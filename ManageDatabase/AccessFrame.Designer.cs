
namespace ManageDatabase
{
    partial class AccessFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelConnectionName = new System.Windows.Forms.Label();
            this.TextBoxConnectionName = new System.Windows.Forms.TextBox();
            this.TextBoxHostname = new System.Windows.Forms.TextBox();
            this.LabelHostname = new System.Windows.Forms.Label();
            this.TextBoxServiceName = new System.Windows.Forms.TextBox();
            this.LabelServiceName = new System.Windows.Forms.Label();
            this.LabelPortNumber = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonConnectTest = new System.Windows.Forms.Button();
            this.LabelTestResult = new System.Windows.Forms.Label();
            this.NumericPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPort)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelConnectionName
            // 
            this.LabelConnectionName.AutoSize = true;
            this.LabelConnectionName.Location = new System.Drawing.Point(12, 9);
            this.LabelConnectionName.Name = "LabelConnectionName";
            this.LabelConnectionName.Size = new System.Drawing.Size(66, 15);
            this.LabelConnectionName.TabIndex = 0;
            this.LabelConnectionName.Text = "연결 이름 :";
            // 
            // TextBoxConnectionName
            // 
            this.TextBoxConnectionName.Location = new System.Drawing.Point(12, 27);
            this.TextBoxConnectionName.Name = "TextBoxConnectionName";
            this.TextBoxConnectionName.Size = new System.Drawing.Size(395, 23);
            this.TextBoxConnectionName.TabIndex = 1;
            // 
            // TextBoxHostname
            // 
            this.TextBoxHostname.Location = new System.Drawing.Point(12, 71);
            this.TextBoxHostname.Name = "TextBoxHostname";
            this.TextBoxHostname.Size = new System.Drawing.Size(283, 23);
            this.TextBoxHostname.TabIndex = 3;
            this.TextBoxHostname.Text = "192.168.44.10";
            // 
            // LabelHostname
            // 
            this.LabelHostname.AutoSize = true;
            this.LabelHostname.Location = new System.Drawing.Point(12, 53);
            this.LabelHostname.Name = "LabelHostname";
            this.LabelHostname.Size = new System.Drawing.Size(78, 15);
            this.LabelHostname.TabIndex = 2;
            this.LabelHostname.Text = "호스트 이름 :";
            // 
            // TextBoxServiceName
            // 
            this.TextBoxServiceName.Location = new System.Drawing.Point(12, 115);
            this.TextBoxServiceName.Name = "TextBoxServiceName";
            this.TextBoxServiceName.Size = new System.Drawing.Size(395, 23);
            this.TextBoxServiceName.TabIndex = 7;
            this.TextBoxServiceName.Text = "orcl";
            // 
            // LabelServiceName
            // 
            this.LabelServiceName.AutoSize = true;
            this.LabelServiceName.Location = new System.Drawing.Point(12, 97);
            this.LabelServiceName.Name = "LabelServiceName";
            this.LabelServiceName.Size = new System.Drawing.Size(78, 15);
            this.LabelServiceName.TabIndex = 6;
            this.LabelServiceName.Text = "서비스 이름 :";
            // 
            // LabelPortNumber
            // 
            this.LabelPortNumber.AutoSize = true;
            this.LabelPortNumber.Location = new System.Drawing.Point(298, 53);
            this.LabelPortNumber.Name = "LabelPortNumber";
            this.LabelPortNumber.Size = new System.Drawing.Size(38, 15);
            this.LabelPortNumber.TabIndex = 4;
            this.LabelPortNumber.Text = "포트 :";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(12, 159);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(395, 23);
            this.TextBoxUsername.TabIndex = 9;
            this.TextBoxUsername.Text = "scott";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(12, 141);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(78, 15);
            this.LabelUsername.TabIndex = 8;
            this.LabelUsername.Text = "사용자 이름 :";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(12, 203);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(395, 23);
            this.TextBoxPassword.TabIndex = 11;
            this.TextBoxPassword.Text = "tiger";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(12, 185);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(62, 15);
            this.LabelPassword.TabIndex = 10;
            this.LabelPassword.Text = "비밀번호 :";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Enabled = false;
            this.ButtonOk.Location = new System.Drawing.Point(254, 244);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 14;
            this.ButtonOk.Text = "확인";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(335, 244);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 15;
            this.ButtonCancel.Text = "취소";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonConnectTest
            // 
            this.ButtonConnectTest.Location = new System.Drawing.Point(12, 244);
            this.ButtonConnectTest.Name = "ButtonConnectTest";
            this.ButtonConnectTest.Size = new System.Drawing.Size(96, 23);
            this.ButtonConnectTest.TabIndex = 13;
            this.ButtonConnectTest.Text = "연결 테스트(&T)";
            this.ButtonConnectTest.UseVisualStyleBackColor = true;
            this.ButtonConnectTest.Click += new System.EventHandler(this.ButtonConnectTest_Click);
            // 
            // LabelTestResult
            // 
            this.LabelTestResult.AutoSize = true;
            this.LabelTestResult.Location = new System.Drawing.Point(114, 248);
            this.LabelTestResult.Name = "LabelTestResult";
            this.LabelTestResult.Size = new System.Drawing.Size(0, 15);
            this.LabelTestResult.TabIndex = 16;
            // 
            // NumericPort
            // 
            this.NumericPort.Location = new System.Drawing.Point(301, 71);
            this.NumericPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericPort.Name = "NumericPort";
            this.NumericPort.Size = new System.Drawing.Size(106, 23);
            this.NumericPort.TabIndex = 5;
            this.NumericPort.Value = new decimal(new int[] {
            1521,
            0,
            0,
            0});
            // 
            // AccessFrame
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(420, 279);
            this.Controls.Add(this.NumericPort);
            this.Controls.Add(this.LabelTestResult);
            this.Controls.Add(this.ButtonConnectTest);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelPortNumber);
            this.Controls.Add(this.TextBoxServiceName);
            this.Controls.Add(this.LabelServiceName);
            this.Controls.Add(this.TextBoxHostname);
            this.Controls.Add(this.LabelHostname);
            this.Controls.Add(this.TextBoxConnectionName);
            this.Controls.Add(this.LabelConnectionName);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessFrame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "연결";
            ((System.ComponentModel.ISupportInitialize)(this.NumericPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelConnectionName;
        private System.Windows.Forms.TextBox TextBoxConnectionName;
        private System.Windows.Forms.TextBox TextBoxHostname;
        private System.Windows.Forms.Label LabelHostname;
        private System.Windows.Forms.TextBox TextBoxServiceName;
        private System.Windows.Forms.Label LabelServiceName;
        private System.Windows.Forms.Label LabelPortNumber;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonConnectTest;
        private System.Windows.Forms.Label LabelTestResult;
        private System.Windows.Forms.NumericUpDown NumericPort;
    }
}