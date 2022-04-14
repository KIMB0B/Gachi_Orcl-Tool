using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ManageDatabase
{
    public partial class Mainframe : Form
    {
        private TreeNodeMouseClickEventArgs nodeClick;
        private Dictionary<string, OracleConnection> connectionDict = new Dictionary<string, OracleConnection>();

        public Mainframe()
        {
            InitializeComponent();
        }

        //Menu - 새 연결
        private void FileMenuConnect_Click(object sender, EventArgs e)
        {
            int tableCnt = 0;

            OracleCommand cmd;
            OracleCommand cmd2;
            OracleDataReader dr;
            OracleDataReader dr2;

            DataRow row;

            TreeNode node;
            ImageList nodeImageList;

            AccessFrame accessFrame = new AccessFrame();
            accessFrame.Owner = this;

            if (accessFrame.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    connectionDict.Add(accessFrame.ConnectionName, accessFrame.Con);

                    row = this.ConnectionTable.NewRow();
                    row[this.ConnectionTableConnectionName] = accessFrame.ConnectionName;
                    row[this.ConnectionTableHostName]       = accessFrame.HostName;
                    row[this.ConnectionTablePort]           = accessFrame.Port;
                    row[this.ConnectionTableServiceName]    = accessFrame.ServiceName;
                    row[this.ConnectionTableUserName]       = accessFrame.UserName;
                    row[this.ConnectionTablePassword]       = accessFrame.Password;
                    this.ConnectionTable.Rows.Add(row);

                    nodeImageList = new ImageList();
                    nodeImageList.Images.Add(Properties.Resources.connect);
                    nodeImageList.Images.Add(Properties.Resources.user);
                    nodeImageList.Images.Add(Properties.Resources.table);
                    MainTreeView.ImageList = nodeImageList;

                    node = new TreeNode(accessFrame.ConnectionName, 0, 0);

                    if (accessFrame.UserName.ToLower() == "sys" || accessFrame.UserName.ToLower() == "system")
                    {
                        cmd = accessFrame.Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select username from dba_users where account_status = 'OPEN' order by username";

                        dr = cmd.ExecuteReader();

                        while (dr.Read() == true)
                        {
                            node.Nodes.Add(dr["username"].ToString(), dr["username"].ToString(), 1, 1);
                            cmd2 = accessFrame.Con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "select table_name from all_tables where owner = '" + dr["username"].ToString() + "' order by table_name";
                            dr2 = cmd2.ExecuteReader();
                            while (dr2.Read() == true)
                            {
                                node.Nodes[tableCnt].Nodes.Add(dr2["table_name"].ToString(), dr2["table_name"].ToString(), 2, 2);
                            }
                            tableCnt++;
                        }
                    }
                    else
                    {
                        node.Nodes.Add(accessFrame.UserName.ToUpper(), accessFrame.UserName.ToUpper(), 1, 1);

                        cmd = accessFrame.Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select table_name from user_tables order by table_name";

                        dr = cmd.ExecuteReader();

                        while (dr.Read() == true)
                        {
                            node.Nodes[accessFrame.UserName].Nodes.Add(dr["table_name"].ToString(), dr["table_name"].ToString(), 2, 2);
                        }
                    }
                    MainTreeView.Nodes.Add(node);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        //TableFrame 열기
        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeClick = e;
            TableFrame table;
            Form frm = null;
            bool isFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if(form.Text == MainTreeView.SelectedNode.FullPath)
                {
                    frm = form;
                    isFound = true;
                    break;
                }
            }

            if (isFound == false)
            {
                if (MainTreeView.SelectedNode.Level == 2)
                {
                    try
                    {
                        table = new TableFrame
                        {
                            MdiParent = this,
                            Text = MainTreeView.SelectedNode.FullPath,
                            Con = connectionDict[MainTreeView.SelectedNode.Parent.Parent.Text],
                            TableName = MainTreeView.SelectedNode.Text,
                            UserName = MainTreeView.SelectedNode.Parent.Text
                        };
                        table.Show();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                }
            }
            else
            {
                frm.Activate();
            }
        }

        private void MainTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MainTreeView_NodeMouseDoubleClick(sender, nodeClick);
            }
        }

        private void TreeContextMenuAddConnection_Click(object sender, EventArgs e)
        {
            this.FileMenuConnect.PerformClick();
        }
    }
}
