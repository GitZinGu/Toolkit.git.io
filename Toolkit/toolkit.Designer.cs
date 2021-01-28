namespace Toolkit
{
    partial class toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(toolkit));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大小写转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汉子转拼音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.贪吃蛇ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.俄罗斯方块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTAFEtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.HRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ODMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.jSONToolStripMenuItem,
            this.CaseToolStripMenuItem,
            this.SymbolToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.ODMToolStripMenuItem,
            this.InfoToolStripMenuItem1,
            this.ExitToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "条码";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // CaseToolStripMenuItem
            // 
            this.CaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大小写转换ToolStripMenuItem,
            this.汉子转拼音ToolStripMenuItem,
            this.mD5加密ToolStripMenuItem});
            this.CaseToolStripMenuItem.ForeColor = System.Drawing.Color.Fuchsia;
            this.CaseToolStripMenuItem.Name = "CaseToolStripMenuItem";
            this.CaseToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.CaseToolStripMenuItem.Text = "字符转换";
            // 
            // 大小写转换ToolStripMenuItem
            // 
            this.大小写转换ToolStripMenuItem.Name = "大小写转换ToolStripMenuItem";
            this.大小写转换ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.大小写转换ToolStripMenuItem.Text = "大小写转换";
            this.大小写转换ToolStripMenuItem.Click += new System.EventHandler(this.CaseToolStripMenuItem_Click);
            // 
            // 汉子转拼音ToolStripMenuItem
            // 
            this.汉子转拼音ToolStripMenuItem.Name = "汉子转拼音ToolStripMenuItem";
            this.汉子转拼音ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.汉子转拼音ToolStripMenuItem.Text = "汉字转拼音";
            this.汉子转拼音ToolStripMenuItem.Click += new System.EventHandler(this.CaseToolStripMenuItem_Click);
            // 
            // mD5加密ToolStripMenuItem
            // 
            this.mD5加密ToolStripMenuItem.Name = "mD5加密ToolStripMenuItem";
            this.mD5加密ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.mD5加密ToolStripMenuItem.Text = "MD5加密";
            this.mD5加密ToolStripMenuItem.Click += new System.EventHandler(this.CaseToolStripMenuItem_Click);
            // 
            // SymbolToolStripMenuItem
            // 
            this.SymbolToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.SymbolToolStripMenuItem.Name = "SymbolToolStripMenuItem";
            this.SymbolToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.SymbolToolStripMenuItem.Text = "特殊字符";
            this.SymbolToolStripMenuItem.Click += new System.EventHandler(this.SymbolToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.贪吃蛇ToolStripMenuItem,
            this.俄罗斯方块ToolStripMenuItem,
            this.TTAFEtoolStripMenuItem3,
            this.HRDToolStripMenuItem});
            this.gameToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // 贪吃蛇ToolStripMenuItem
            // 
            this.贪吃蛇ToolStripMenuItem.Name = "贪吃蛇ToolStripMenuItem";
            this.贪吃蛇ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.贪吃蛇ToolStripMenuItem.Text = "贪吃蛇";
            this.贪吃蛇ToolStripMenuItem.Click += new System.EventHandler(this.贪吃蛇ToolStripMenuItem_Click);
            // 
            // 俄罗斯方块ToolStripMenuItem
            // 
            this.俄罗斯方块ToolStripMenuItem.Name = "俄罗斯方块ToolStripMenuItem";
            this.俄罗斯方块ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.俄罗斯方块ToolStripMenuItem.Text = "俄罗斯方块";
            this.俄罗斯方块ToolStripMenuItem.Click += new System.EventHandler(this.俄罗斯方块ToolStripMenuItem_Click);
            // 
            // TTAFEtoolStripMenuItem3
            // 
            this.TTAFEtoolStripMenuItem3.Name = "TTAFEtoolStripMenuItem3";
            this.TTAFEtoolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.TTAFEtoolStripMenuItem3.Text = "2048";
            this.TTAFEtoolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // HRDToolStripMenuItem
            // 
            this.HRDToolStripMenuItem.Name = "HRDToolStripMenuItem";
            this.HRDToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.HRDToolStripMenuItem.Text = "华容道";
            this.HRDToolStripMenuItem.Click += new System.EventHandler(this.HRDToolStripMenuItem_Click);
            // 
            // ODMToolStripMenuItem
            // 
            this.ODMToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ODMToolStripMenuItem.Name = "ODMToolStripMenuItem";
            this.ODMToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ODMToolStripMenuItem.Text = "数据库";
            this.ODMToolStripMenuItem.Click += new System.EventHandler(this.ODMToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem1
            // 
            this.InfoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            this.InfoToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.InfoToolStripMenuItem1.Text = "相关信息";
            this.InfoToolStripMenuItem1.Click += new System.EventHandler(this.InfoToolStripMenuItem1_Click);
            // 
            // ExitToolStripMenuItem2
            // 
            this.ExitToolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2";
            this.ExitToolStripMenuItem2.Size = new System.Drawing.Size(68, 21);
            this.ExitToolStripMenuItem2.Text = "退出程序";
            this.ExitToolStripMenuItem2.Click += new System.EventHandler(this.退出ToolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 499);
            this.panel1.TabIndex = 1;
            // 
            // toolkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "toolkit";
            this.Text = "工具箱";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.toolkit_FormClosed);
            this.Load += new System.EventHandler(this.toolkit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SymbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ODMToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 贪吃蛇ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 俄罗斯方块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTAFEtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem HRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大小写转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汉子转拼音ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5加密ToolStripMenuItem;
    }
}

