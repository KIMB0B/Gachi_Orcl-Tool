
namespace ManageDatabase
{
    partial class TableFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableFrame));
            this.DataList = new System.Windows.Forms.DataGridView();
            this.TableDataSet = new System.Data.DataSet();
            this.MainTable = new System.Data.DataTable();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TopPannel = new System.Windows.Forms.Panel();
            this.BotButtonRenewal = new System.Windows.Forms.Button();
            this.ContextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuTableReload = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTableDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBarSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.ToolBarSearchTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.ToolBarSearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarCommitButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarRollbackButton = new System.Windows.Forms.ToolStripButton();
            this.ToolBarDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.TopPannel.SuspendLayout();
            this.ContextMenuTable.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataList
            // 
            this.DataList.ColumnHeadersHeight = 36;
            this.DataList.ContextMenuStrip = this.ContextMenuTable;
            this.DataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataList.Location = new System.Drawing.Point(0, 63);
            this.DataList.Name = "DataList";
            this.DataList.RowTemplate.Height = 23;
            this.DataList.Size = new System.Drawing.Size(599, 273);
            this.DataList.TabIndex = 1;
            this.DataList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataList_CellValueChanged);
            this.DataList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataList_DataError);
            // 
            // TableDataSet
            // 
            this.TableDataSet.DataSetName = "TableDataSet";
            this.TableDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.MainTable});
            // 
            // MainTable
            // 
            this.MainTable.TableName = "Main";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelSearch.Location = new System.Drawing.Point(7, 7);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LabelSearch.Size = new System.Drawing.Size(66, 18);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "검색 조건 :";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSearch.Location = new System.Drawing.Point(73, 7);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(369, 23);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TextBoxSearch_PreviewKeyDown);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSearch.Location = new System.Drawing.Point(442, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 24);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "검색";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TopPannel
            // 
            this.TopPannel.Controls.Add(this.TextBoxSearch);
            this.TopPannel.Controls.Add(this.ButtonSearch);
            this.TopPannel.Controls.Add(this.BotButtonRenewal);
            this.TopPannel.Controls.Add(this.LabelSearch);
            this.TopPannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Padding = new System.Windows.Forms.Padding(7);
            this.TopPannel.Size = new System.Drawing.Size(599, 38);
            this.TopPannel.TabIndex = 0;
            // 
            // BotButtonRenewal
            // 
            this.BotButtonRenewal.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotButtonRenewal.Location = new System.Drawing.Point(517, 7);
            this.BotButtonRenewal.Name = "BotButtonRenewal";
            this.BotButtonRenewal.Size = new System.Drawing.Size(75, 24);
            this.BotButtonRenewal.TabIndex = 1;
            this.BotButtonRenewal.Text = "갱신";
            this.BotButtonRenewal.UseVisualStyleBackColor = true;
            this.BotButtonRenewal.Click += new System.EventHandler(this.BottomButtonRenewal_Click);
            // 
            // ContextMenuTable
            // 
            this.ContextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuTableReload,
            this.ContextMenuTableDelete});
            this.ContextMenuTable.Name = "ContextMenuTable";
            this.ContextMenuTable.Size = new System.Drawing.Size(143, 48);
            // 
            // ContextMenuTableReload
            // 
            this.ContextMenuTableReload.Name = "ContextMenuTableReload";
            this.ContextMenuTableReload.Size = new System.Drawing.Size(142, 22);
            this.ContextMenuTableReload.Text = "갱신";
            this.ContextMenuTableReload.Click += new System.EventHandler(this.ContextMenuTableReload_Click);
            // 
            // ContextMenuTableDelete
            // 
            this.ContextMenuTableDelete.Name = "ContextMenuTableDelete";
            this.ContextMenuTableDelete.Size = new System.Drawing.Size(142, 22);
            this.ContextMenuTableDelete.Text = "선택 행 삭제";
            this.ContextMenuTableDelete.Click += new System.EventHandler(this.ContextMenuTableDelete_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarSearchLabel,
            this.ToolBarSearchTextbox,
            this.ToolBarSearchButton,
            this.toolStripSeparator1,
            this.ToolBarDeleteButton,
            this.toolStripSeparator2,
            this.ToolBarRollbackButton,
            this.ToolBarCommitButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 38);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(599, 25);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ToolBarSearchLabel
            // 
            this.ToolBarSearchLabel.Name = "ToolBarSearchLabel";
            this.ToolBarSearchLabel.Size = new System.Drawing.Size(70, 22);
            this.ToolBarSearchLabel.Text = "검색 조건 : ";
            // 
            // ToolBarSearchTextbox
            // 
            this.ToolBarSearchTextbox.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ToolBarSearchTextbox.Name = "ToolBarSearchTextbox";
            this.ToolBarSearchTextbox.Size = new System.Drawing.Size(200, 25);
            // 
            // ToolBarSearchButton
            // 
            this.ToolBarSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarSearchButton.Image")));
            this.ToolBarSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarSearchButton.Name = "ToolBarSearchButton";
            this.ToolBarSearchButton.Size = new System.Drawing.Size(23, 22);
            this.ToolBarSearchButton.Click += new System.EventHandler(this.ToolBarSearchButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolBarCommitButton
            // 
            this.ToolBarCommitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarCommitButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarCommitButton.Image")));
            this.ToolBarCommitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarCommitButton.Name = "ToolBarCommitButton";
            this.ToolBarCommitButton.Size = new System.Drawing.Size(23, 22);
            this.ToolBarCommitButton.Text = "toolStripButton2";
            this.ToolBarCommitButton.Click += new System.EventHandler(this.ToolBarCommitButton_Click);
            // 
            // ToolBarRollbackButton
            // 
            this.ToolBarRollbackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarRollbackButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarRollbackButton.Image")));
            this.ToolBarRollbackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarRollbackButton.Name = "ToolBarRollbackButton";
            this.ToolBarRollbackButton.Size = new System.Drawing.Size(23, 22);
            this.ToolBarRollbackButton.Text = "toolStripButton3";
            this.ToolBarRollbackButton.Click += new System.EventHandler(this.ToolBarRollbackButton_Click);
            // 
            // ToolBarDeleteButton
            // 
            this.ToolBarDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarDeleteButton.Image")));
            this.ToolBarDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarDeleteButton.Name = "ToolBarDeleteButton";
            this.ToolBarDeleteButton.Size = new System.Drawing.Size(23, 22);
            this.ToolBarDeleteButton.Text = "toolStripButton4";
            this.ToolBarDeleteButton.Click += new System.EventHandler(this.ToolBarDeleteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TableFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.TopPannel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableFrame";
            this.Text = "TableFrame";
            this.Load += new System.EventHandler(this.TableFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            this.ContextMenuTable.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet TableDataSet;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.DataGridView DataList;
        private System.Data.DataTable MainTable;
        private System.Windows.Forms.Button BotButtonRenewal;
        private System.Windows.Forms.ContextMenuStrip ContextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTableReload;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTableDelete;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripLabel ToolBarSearchLabel;
        private System.Windows.Forms.ToolStripTextBox ToolBarSearchTextbox;
        private System.Windows.Forms.ToolStripButton ToolBarSearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolBarDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolBarRollbackButton;
        private System.Windows.Forms.ToolStripButton ToolBarCommitButton;
    }
}