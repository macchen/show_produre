namespace show_produre
{
    partial class testform
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
            this.dgv_showdata = new System.Windows.Forms.DataGridView();
            this.btntest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_showdata
            // 
            this.dgv_showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showdata.Location = new System.Drawing.Point(12, 2);
            this.dgv_showdata.Name = "dgv_showdata";
            this.dgv_showdata.RowTemplate.Height = 23;
            this.dgv_showdata.Size = new System.Drawing.Size(537, 288);
            this.dgv_showdata.TabIndex = 0;
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(246, 296);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(75, 23);
            this.btntest.TabIndex = 1;
            this.btntest.Text = "测试";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 335);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.dgv_showdata);
            this.Name = "testform";
            this.Text = "testform";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_showdata;
        private System.Windows.Forms.Button btntest;
    }
}