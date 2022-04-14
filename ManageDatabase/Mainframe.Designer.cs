
namespace ManageDatabase
{
    partial class Mainframe
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainframe));
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.ContextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuTreeAddConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTreeDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuTreeAddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTreeRenameTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTreeDropTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitterTreeData = new System.Windows.Forms.Splitter();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ImageListTree = new System.Windows.Forms.ImageList(this.components);
            this.ConnectionDataSet = new System.Data.DataSet();
            this.ConnectionTable = new System.Data.DataTable();
            this.ConnectionTableConnectionName = new System.Data.DataColumn();
            this.ConnectionTableHostName = new System.Data.DataColumn();
            this.ConnectionTablePort = new System.Data.DataColumn();
            this.ConnectionTableServiceName = new System.Data.DataColumn();
            this.ConnectionTableUserName = new System.Data.DataColumn();
            this.ConnectionTablePassword = new System.Data.DataColumn();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBarConnection = new System.Windows.Forms.ToolStripButton();
            this.ToolBarDisconnect = new System.Windows.Forms.ToolStripButton();
            this.ContextMenuTree.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTable)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTreeView
            // 
            this.MainTreeView.ContextMenuStrip = this.ContextMenuTree;
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainTreeView.Location = new System.Drawing.Point(0, 49);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.PathSeparator = "/";
            this.MainTreeView.Size = new System.Drawing.Size(211, 610);
            this.MainTreeView.TabIndex = 2;
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            this.MainTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainTreeView_KeyDown);
            // 
            // ContextMenuTree
            // 
            this.ContextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuTreeAddConnection,
            this.ContextMenuTreeDisconnect,
            this.TreeContextMenuSeparator,
            this.ContextMenuTreeAddTable,
            this.ContextMenuTreeRenameTable,
            this.ContextMenuTreeDropTable});
            this.ContextMenuTree.Name = "TreeContextMenu";
            this.ContextMenuTree.Size = new System.Drawing.Size(167, 120);
            // 
            // ContextMenuTreeAddConnection
            // 
            this.ContextMenuTreeAddConnection.Name = "ContextMenuTreeAddConnection";
            this.ContextMenuTreeAddConnection.Size = new System.Drawing.Size(166, 22);
            this.ContextMenuTreeAddConnection.Text = "새 연결";
            this.ContextMenuTreeAddConnection.Click += new System.EventHandler(this.TreeContextMenuAddConnection_Click);
            // 
            // ContextMenuTreeDisconnect
            // 
            this.ContextMenuTreeDisconnect.Name = "ContextMenuTreeDisconnect";
            this.ContextMenuTreeDisconnect.Size = new System.Drawing.Size(166, 22);
            this.ContextMenuTreeDisconnect.Text = "연결 종료";
            // 
            // TreeContextMenuSeparator
            // 
            this.TreeContextMenuSeparator.Name = "TreeContextMenuSeparator";
            this.TreeContextMenuSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // ContextMenuTreeAddTable
            // 
            this.ContextMenuTreeAddTable.Name = "ContextMenuTreeAddTable";
            this.ContextMenuTreeAddTable.Size = new System.Drawing.Size(166, 22);
            this.ContextMenuTreeAddTable.Text = "테이블 추가";
            // 
            // ContextMenuTreeRenameTable
            // 
            this.ContextMenuTreeRenameTable.Name = "ContextMenuTreeRenameTable";
            this.ContextMenuTreeRenameTable.Size = new System.Drawing.Size(166, 22);
            this.ContextMenuTreeRenameTable.Text = "테이블 이름 수정";
            // 
            // ContextMenuTreeDropTable
            // 
            this.ContextMenuTreeDropTable.Name = "ContextMenuTreeDropTable";
            this.ContextMenuTreeDropTable.Size = new System.Drawing.Size(166, 22);
            this.ContextMenuTreeDropTable.Text = "테이블 삭제";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ViewMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuConnect});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(57, 20);
            this.FileMenu.Text = "파일(&F)";
            // 
            // FileMenuConnect
            // 
            this.FileMenuConnect.Name = "FileMenuConnect";
            this.FileMenuConnect.Size = new System.Drawing.Size(180, 22);
            this.FileMenuConnect.Text = "새 연결(&N)";
            this.FileMenuConnect.Click += new System.EventHandler(this.FileMenuConnect_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(57, 20);
            this.EditMenu.Text = "편집(&E)";
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMenuRefresh});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(59, 20);
            this.ViewMenu.Text = "보기(&V)";
            // 
            // ViewMenuRefresh
            // 
            this.ViewMenuRefresh.Name = "ViewMenuRefresh";
            this.ViewMenuRefresh.Size = new System.Drawing.Size(180, 22);
            this.ViewMenuRefresh.Text = "새로 고침(&R)";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuInformation});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(72, 20);
            this.HelpMenu.Text = "도움말(&H)";
            // 
            // HelpMenuInformation
            // 
            this.HelpMenuInformation.Name = "HelpMenuInformation";
            this.HelpMenuInformation.Size = new System.Drawing.Size(231, 22);
            this.HelpMenuInformation.Text = "데이터베이스 매니저 정보(&H)";
            // 
            // SplitterTreeData
            // 
            this.SplitterTreeData.Location = new System.Drawing.Point(211, 49);
            this.SplitterTreeData.Name = "SplitterTreeData";
            this.SplitterTreeData.Size = new System.Drawing.Size(3, 610);
            this.SplitterTreeData.TabIndex = 1;
            this.SplitterTreeData.TabStop = false;
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 659);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1264, 22);
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "statusStrip1";
            // 
            // ImageListTree
            // 
            this.ImageListTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageListTree.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListTree.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ConnectionDataSet
            // 
            this.ConnectionDataSet.DataSetName = "ConnectionDataSet";
            this.ConnectionDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.ConnectionTable});
            // 
            // ConnectionTable
            // 
            this.ConnectionTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.ConnectionTableConnectionName,
            this.ConnectionTableHostName,
            this.ConnectionTablePort,
            this.ConnectionTableServiceName,
            this.ConnectionTableUserName,
            this.ConnectionTablePassword});
            this.ConnectionTable.TableName = "Connection";
            // 
            // ConnectionTableConnectionName
            // 
            this.ConnectionTableConnectionName.ColumnName = "ConnectionName";
            // 
            // ConnectionTableHostName
            // 
            this.ConnectionTableHostName.ColumnName = "HostName";
            // 
            // ConnectionTablePort
            // 
            this.ConnectionTablePort.ColumnName = "Port";
            this.ConnectionTablePort.DataType = typeof(int);
            // 
            // ConnectionTableServiceName
            // 
            this.ConnectionTableServiceName.ColumnName = "ServiceName";
            // 
            // ConnectionTableUserName
            // 
            this.ConnectionTableUserName.ColumnName = "UserName";
            // 
            // ConnectionTablePassword
            // 
            this.ConnectionTablePassword.ColumnName = "Password";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarConnection,
            this.ToolBarDisconnect});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1264, 25);
            this.ToolBar.TabIndex = 6;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ToolBarConnection
            // 
            this.ToolBarConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarConnection.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarConnection.Image")));
            this.ToolBarConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarConnection.Name = "ToolBarConnection";
            this.ToolBarConnection.Size = new System.Drawing.Size(23, 22);
            this.ToolBarConnection.Text = "toolStripButton1";
            // 
            // ToolBarDisconnect
            // 
            this.ToolBarDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarDisconnect.Image")));
            this.ToolBarDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarDisconnect.Name = "ToolBarDisconnect";
            this.ToolBarDisconnect.Size = new System.Drawing.Size(23, 22);
            this.ToolBarDisconnect.Text = "toolStripButton1";
            // 
            // Mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SplitterTreeData);
            this.Controls.Add(this.MainTreeView);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainframe";
            this.Text = "데이터베이스 매니저";
            this.ContextMenuTree.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionTable)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuConnect;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuInformation;
        private System.Windows.Forms.Splitter SplitterTreeData;
        private System.Windows.Forms.StatusStrip StatusBar;
        public System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.ImageList ImageListTree;
        private System.Data.DataSet ConnectionDataSet;
        private System.Data.DataTable ConnectionTable;
        private System.Data.DataColumn ConnectionTableConnectionName;
        private System.Data.DataColumn ConnectionTableHostName;
        private System.Data.DataColumn ConnectionTablePort;
        private System.Data.DataColumn ConnectionTableServiceName;
        private System.Data.DataColumn ConnectionTableUserName;
        private System.Data.DataColumn ConnectionTablePassword;
        private System.Windows.Forms.ContextMenuStrip ContextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTreeAddConnection;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTreeDisconnect;
        private System.Windows.Forms.ToolStripSeparator TreeContextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTreeAddTable;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTreeRenameTable;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTreeDropTable;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolBarConnection;
        private System.Windows.Forms.ToolStripButton ToolBarDisconnect;
    }
}

