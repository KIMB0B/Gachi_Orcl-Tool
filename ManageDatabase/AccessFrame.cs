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
    public partial class AccessFrame : Form
    {
        public AccessFrame()
        {
            InitializeComponent();
        }

        public OracleConnection Con { get; set; }
        public String ConnectionName { get; set; }
        public String HostName { get; set; }
        public int Port { get; set; }
        public String ServiceName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }


        private bool Connect()
        {
            bool result = false;
            String sysdba = "";

            if (TextBoxUsername.Text.ToLower() == "sys" || TextBoxUsername.Text.ToLower() == "system")
            {
                sysdba = "DBA Privilege = SYSDBA;";
            }

            try
            {
                Con = new OracleConnection();
                Con.ConnectionString = $"Data Source = { TextBoxHostname.Text }:{ NumericPort.Text }/{ TextBoxServiceName.Text };" +
                                       $"USER ID = { TextBoxUsername.Text };" +
                                       $"PASSWORD = { TextBoxPassword.Text }; { sysdba }";
                Con.Open();
                result = true;
            }
            catch (Exception x)
            {
                System.Diagnostics.Debug.WriteLine(x.Message);
            }
            return result;
        }

        //확인 버튼
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Mainframe main = (Mainframe)this.Owner;
            

            if (Connect() == true)
            {
                ConnectionName = TextBoxConnectionName.Text;
                HostName = TextBoxHostname.Text;
                Port = Int32.Parse(NumericPort.Text);
                ServiceName = TextBoxServiceName.Text;
                UserName = TextBoxUsername.Text;
                Password = TextBoxPassword.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("연결에 실패했습니다. 입력 정보를 다시 확인 해 주십시오.");
            }
        }

        //연결 버튼
        private void ButtonConnectTest_Click(object sender, EventArgs e)
        {
            if (Connect() == true)
            {
                LabelTestResult.Text = "연결 성공!";
                ButtonOk.Enabled = true;
            }
            else
            {
                LabelTestResult.Text = "연결 실패..";
                ButtonOk.Enabled = false;
            }
            Con.Close();
        }
    }
}
