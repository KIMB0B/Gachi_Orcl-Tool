using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ManageDatabase
{
    public partial class TableFrame : Form
    {
        public string UserName { get; set; }
        public string TableName { get; set; }
        public OracleConnection Con { get; set; }

        public TableFrame()
        {
            InitializeComponent();
        }

        // sql에 맞는 테이블로 MainTable 열 설정 후 행 추가
        public bool LoadTable(String WhereQuerry)
        {
            List<String> pk = new List<string>();

            OracleCommand cmd;
            OracleDataReader dr;
            DataRow row;
            Type colType;
            String sql;
            bool result = false;

            // mainTable 열 재설정
            MainTable.Clear();
            MainTable.Columns.Clear();

            try
            {
                cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select column_name, data_type " +
                                  "from all_tab_columns " +
                                  "where owner = '" + UserName + "' and table_name = '" + TableName + "' " +
                                  "order by column_id";
                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read() == true)
                    {
                        if (dr["data_type"].ToString().StartsWith("CHAR") || 
                            dr["data_type"].ToString().StartsWith("VARCHAR") || 
                            dr["data_type"].ToString().StartsWith("VARCHAR2") || 
                            dr["data_type"].ToString().StartsWith("NCHAR") || 
                            dr["data_type"].ToString().StartsWith("NVARCHAR") || 
                            dr["data_type"].ToString().StartsWith("LONG") || 
                            dr["data_type"].ToString().StartsWith("CLOB") || 
                            dr["data_type"].ToString().StartsWith("NCLOB"))
                        {
                            colType = typeof(String);
                        }
                        else if (dr["data_type"].ToString().StartsWith("NUMBER") || 
                                 dr["data_type"].ToString().StartsWith("FLOAT") || 
                                 dr["data_type"].ToString().StartsWith("BINARY_FLOAT"))
                        {
                            colType = typeof(Int64);
                        }
                        else if (dr["data_type"].ToString().StartsWith("DATE") || 
                                 dr["data_type"].ToString().StartsWith("TIMESTAMP"))
                        {
                            colType = Type.GetType("System.DateTime");
                        }
                        else
                        {
                            colType = typeof(String);
                        }

                        MainTable.Columns.Add(dr["column_name"].ToString() + "\n(" + dr["data_type"].ToString() + ")", colType);
                    }
                }

                sql = "select column_name " +
                      "from all_constraints a, " +
                           "all_cons_columns b " +
                      "where a.table_name      = '" + TableName  + "' " +
                        "and a.constraint_type = 'P' " +
                        "and a.owner           = b.owner " +
                        "and a.constraint_name = b.constraint_name " +
                      "order by b.position";
                cmd.CommandText = sql;
                using (dr = cmd.ExecuteReader())
                {
                    while(dr.Read() == true)
                    {
                        pk.Add(dr["column_name"].ToString());
                    }
                }

                // MainTable 행 재설정
                sql = "select * from " + UserName + "." + TableName;
                if (WhereQuerry.Trim().Length !=0)
                {
                    sql += " where " + WhereQuerry;
                }
                if(pk.Count == 0)
                {
                    sql += " order by rowid";
                }
                else
                {
                    sql += " order by ";
                    for (int i = 0; i < pk.Count; i++)
                    {
                        sql += pk[i];
                        if(i != pk.Count - 1)
                        {
                            sql += ", ";
                        }
                    }
                }
                cmd.CommandText = sql;
                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read() == true)
                    {
                        row = MainTable.NewRow();
                        for (int i = 0; i < MainTable.Columns.Count; i++)
                        {
                            row[i] = dr[i];
                        }
                        MainTable.Rows.Add(row);
                    }
                }

                DataList.DataSource = TableDataSet;
                DataList.DataMember = "Main";
                result = true;
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(x.Message);
            }

            return result;
        }

        public bool ReloadTable()
        {
            OracleCommand cmd = Con.CreateCommand();
            OracleTransaction trans;
            bool result = false;

            trans = Con.BeginTransaction(IsolationLevel.ReadCommitted);
            cmd.Transaction = trans;
            try
            {
                cmd.CommandText = "delete from " + TableName;
                cmd.ExecuteNonQuery();
                for (int r = 0; r < MainTable.Rows.Count; r++)
                {
                    cmd.CommandText = "insert into " + UserName + "." + TableName + " values (";
                    for (int c = 0; c < MainTable.Columns.Count; c++)
                    {
                        if(c != 0)
                        {
                            cmd.CommandText = cmd.CommandText + ", ";
                        }
                        if(MainTable.Rows[r].ItemArray[c].GetType() == Type.GetType("System.DateTime"))
                        {
                            cmd.CommandText = cmd.CommandText + "to_date('" + MainTable.Rows[r].ItemArray[c].ToString() + "', 'yyyy-mm-dd AM HH:MI:SS')";
                        }
                        else
                        {
                            cmd.CommandText = cmd.CommandText + "'" + MainTable.Rows[r].ItemArray[c].ToString() + "'";
                        }
                    }
                    cmd.CommandText = cmd.CommandText + ")";
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                LoadTable(ToolBarSearchTextbox.Text);
                result = true;
            }
            catch (OracleException x)
            {
                trans.Rollback();
                MessageBox.Show(x.Number + x.Message);
                System.Diagnostics.Debug.WriteLine(x.Message);
            }
            return result;
        }

        //검색
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            LoadTable(ToolBarSearchTextbox.Text);
        }

        private void TextBoxSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ButtonSearch.PerformClick();
            }
        }

        private void TableFrame_Load(object sender, EventArgs e)
        {
            this.ButtonSearch.PerformClick();
        }

        private void BottomButtonRenewal_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void DataList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.PaleGreen;
        }

        private void DataList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("형식이 맞지 않습니다. 형식에 맞춰 값을 입력해 주세요.");
        }

        private void ContextMenuTableDelete_Click(object sender, EventArgs e)
        {
            String a = "";
            for (int r = 0; r < DataList.SelectedCells.Count; r++)
            {
                for (int c = 0; c < DataList.Columns.Count; c++)
                {
                    a += DataList.Rows[DataList.SelectedCells[r].RowIndex].Cells[c].Value + "/";
                }
                a += "\n";
            }

            DialogResult askDialog = MessageBox.Show(a, "선택 행 삭제", MessageBoxButtons.OKCancel);

            if (askDialog == DialogResult.OK)
            {
                for (int r = 0; r < DataList.Rows.Count; r++)
                {
                    for (int c = 0; c < DataList.Columns.Count; c++)
                    {
                        if (DataList.Rows[r].Cells[c].Selected == true)
                        {
                            DataList.Rows.Remove(DataList.Rows[r]);
                        }
                    }
                }
            }
        }

        private void ContextMenuTableReload_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarSearchButton_Click(object sender, EventArgs e)
        {
            LoadTable(ToolBarSearchTextbox.Text);
        }

        private void ToolBarDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ToolBarRollbackButton_Click(object sender, EventArgs e)
        {
            LoadTable("");
        }

        private void ToolBarCommitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
