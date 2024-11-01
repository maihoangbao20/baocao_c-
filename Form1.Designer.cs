namespace MainMenu
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiTạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lí nhân viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNhânViênToolStripMenuItem,
            this.quảnLíSinhViênToolStripMenuItem,
            this.quảnLíNhânSựToolStripMenuItem});
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.tậpTinToolStripMenuItem.Text = "Tập tin";
            // 
            // quảnLíNhânViênToolStripMenuItem
            // 
            this.quảnLíNhânViênToolStripMenuItem.Name = "quảnLíNhânViênToolStripMenuItem";
            this.quảnLíNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLíNhânViênToolStripMenuItem.Text = "Quản lí nhân viên";
            this.quảnLíNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhânViênToolStripMenuItem_Click);
            // 
            // quảnLíSinhViênToolStripMenuItem
            // 
            this.quảnLíSinhViênToolStripMenuItem.Name = "quảnLíSinhViênToolStripMenuItem";
            this.quảnLíSinhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLíSinhViênToolStripMenuItem.Text = "Quản lí sinh viên";
            this.quảnLíSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLíSinhViênToolStripMenuItem_Click);
            // 
            // quảnLíNhânSựToolStripMenuItem
            // 
            this.quảnLíNhânSựToolStripMenuItem.Name = "quảnLíNhânSựToolStripMenuItem";
            this.quảnLíNhânSựToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLíNhânSựToolStripMenuItem.Text = "Quản lí nhân sự";
            this.quảnLíNhânSựToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhânSựToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiTạoToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // ngườiTạoToolStripMenuItem
            // 
            this.ngườiTạoToolStripMenuItem.Name = "ngườiTạoToolStripMenuItem";
            this.ngườiTạoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ngườiTạoToolStripMenuItem.Text = "Người tạo";
            this.ngườiTạoToolStripMenuItem.Click += new System.EventHandler(this.ngườiTạoToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 132);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quản lí sinh viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 132);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quản lí nhân sự";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHẦN MỀM QUẢN LÍ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhânViênToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiTạoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhânSựToolStripMenuItem;
    }
}

