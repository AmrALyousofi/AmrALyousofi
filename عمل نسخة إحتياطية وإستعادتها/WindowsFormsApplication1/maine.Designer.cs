namespace WindowsFormsApplication1
{
    partial class maine
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.النسخالإحياطيللنظامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.النسخالإحياطيللنظامToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.النسخالإحياطيللنظامToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(858, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // النسخالإحياطيللنظامToolStripMenuItem
            // 
            this.النسخالإحياطيللنظامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.النسخالإحياطيللنظامToolStripMenuItem1});
            this.النسخالإحياطيللنظامToolStripMenuItem.Name = "النسخالإحياطيللنظامToolStripMenuItem";
            this.النسخالإحياطيللنظامToolStripMenuItem.Size = new System.Drawing.Size(397, 36);
            this.النسخالإحياطيللنظامToolStripMenuItem.Text = "عمل إستعادة النسخة الإحياطية للنظام";
            // 
            // النسخالإحياطيللنظامToolStripMenuItem1
            // 
            this.النسخالإحياطيللنظامToolStripMenuItem1.Name = "النسخالإحياطيللنظامToolStripMenuItem1";
            this.النسخالإحياطيللنظامToolStripMenuItem1.Size = new System.Drawing.Size(318, 36);
            this.النسخالإحياطيللنظامToolStripMenuItem1.Text = "النسخ الإحياطي للنظام";
            this.النسخالإحياطيللنظامToolStripMenuItem1.Click += new System.EventHandler(this.النسخالإحياطيللنظامToolStripMenuItem1_Click);
            // 
            // maine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 609);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 16F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "maine";
            this.Text = "maine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem النسخالإحياطيللنظامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem النسخالإحياطيللنظامToolStripMenuItem1;
    }
}