namespace show_produre
{
    partial class f_show_proc
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldatasource = new System.Windows.Forms.Label();
            this.lblloginname = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.txtdatasource = new System.Windows.Forms.TextBox();
            this.txtloginname = new System.Windows.Forms.TextBox();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.treeviewdata = new System.Windows.Forms.TreeView();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.cboxdb = new System.Windows.Forms.ComboBox();
            this.lbldb = new System.Windows.Forms.Label();
            this.cbox_datasource = new System.Windows.Forms.ComboBox();
            this.lblinstance = new System.Windows.Forms.Label();
            this.txtdbname = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbldatasource
            // 
            this.lbldatasource.AutoSize = true;
            this.lbldatasource.Location = new System.Drawing.Point(2, 9);
            this.lbldatasource.Name = "lbldatasource";
            this.lbldatasource.Size = new System.Drawing.Size(53, 12);
            this.lbldatasource.TabIndex = 0;
            this.lbldatasource.Text = "数据源：";
            // 
            // lblloginname
            // 
            this.lblloginname.AutoSize = true;
            this.lblloginname.Location = new System.Drawing.Point(187, 8);
            this.lblloginname.Name = "lblloginname";
            this.lblloginname.Size = new System.Drawing.Size(53, 12);
            this.lblloginname.TabIndex = 1;
            this.lblloginname.Text = "用户名：";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(1088, 5);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(57, 23);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "连接";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdatasource
            // 
            this.txtdatasource.Location = new System.Drawing.Point(61, 6);
            this.txtdatasource.Name = "txtdatasource";
            this.txtdatasource.Size = new System.Drawing.Size(109, 21);
            this.txtdatasource.TabIndex = 3;
            // 
            // txtloginname
            // 
            this.txtloginname.Location = new System.Drawing.Point(246, 6);
            this.txtloginname.Name = "txtloginname";
            this.txtloginname.Size = new System.Drawing.Size(100, 21);
            this.txtloginname.TabIndex = 4;
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(352, 11);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(41, 12);
            this.lblpwd.TabIndex = 5;
            this.lblpwd.Text = "密码：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(399, 7);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(100, 21);
            this.txtpwd.TabIndex = 6;
            // 
            // treeviewdata
            // 
            this.treeviewdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeviewdata.Location = new System.Drawing.Point(4, 33);
            this.treeviewdata.Name = "treeviewdata";
            this.treeviewdata.Size = new System.Drawing.Size(193, 694);
            this.treeviewdata.TabIndex = 7;
            this.treeviewdata.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeviewdata_NodeMouseDoubleClick);
            // 
            // txtshow
            // 
            this.txtshow.AcceptsReturn = true;
            this.txtshow.AllowDrop = true;
            this.txtshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtshow.Location = new System.Drawing.Point(203, 34);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtshow.Size = new System.Drawing.Size(1033, 693);
            this.txtshow.TabIndex = 8;
            this.txtshow.Tag = "双击复制到剪贴板";
            this.txtshow.DoubleClick += new System.EventHandler(this.txtshow_DoubleClick);
            this.txtshow.MouseEnter += new System.EventHandler(this.txtshow_MouseEnter);
            
            // 
            // cboxdb
            // 
            this.cboxdb.FormattingEnabled = true;
            this.cboxdb.Location = new System.Drawing.Point(915, 7);
            this.cboxdb.Name = "cboxdb";
            this.cboxdb.Size = new System.Drawing.Size(124, 20);
            this.cboxdb.TabIndex = 9;
            this.cboxdb.SelectionChangeCommitted += new System.EventHandler(this.cboxdb_SelectionChangeCommitted);
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Location = new System.Drawing.Point(505, 10);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(71, 12);
            this.lbldb.TabIndex = 10;
            this.lbldb.Text = " 数据库名：";
            // 
            // cbox_datasource
            // 
            this.cbox_datasource.FormattingEnabled = true;
            this.cbox_datasource.Location = new System.Drawing.Point(779, 8);
            this.cbox_datasource.Name = "cbox_datasource";
            this.cbox_datasource.Size = new System.Drawing.Size(121, 20);
            this.cbox_datasource.TabIndex = 11;
            // 
            // lblinstance
            // 
            this.lblinstance.AutoSize = true;
            this.lblinstance.Location = new System.Drawing.Point(711, 11);
            this.lblinstance.Name = "lblinstance";
            this.lblinstance.Size = new System.Drawing.Size(47, 12);
            this.lblinstance.TabIndex = 12;
            this.lblinstance.Text = "实例名:";
            // 
            // txtdbname
            // 
            this.txtdbname.Location = new System.Drawing.Point(582, 7);
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.Size = new System.Drawing.Size(109, 21);
            this.txtdbname.TabIndex = 13;
            // 
            // f_show_proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1236, 730);
            this.Controls.Add(this.txtdbname);
            this.Controls.Add(this.lblinstance);
            this.Controls.Add(this.cbox_datasource);
            this.Controls.Add(this.lbldb);
            this.Controls.Add(this.cboxdb);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.treeviewdata);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.txtloginname);
            this.Controls.Add(this.txtdatasource);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.lblloginname);
            this.Controls.Add(this.lbldatasource);
            this.Name = "f_show_proc";
            this.Text = "SQL解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatasource;
        private System.Windows.Forms.Label lblloginname;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.TextBox txtdatasource;
        private System.Windows.Forms.TextBox txtloginname;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TreeView treeviewdata;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.ComboBox cboxdb;
        private System.Windows.Forms.Label lbldb;
        private System.Windows.Forms.ComboBox cbox_datasource;
        private System.Windows.Forms.Label lblinstance;
        private System.Windows.Forms.TextBox txtdbname;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

