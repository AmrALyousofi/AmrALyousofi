namespace WindowsFormsApplication1
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
            this.my_Button2 = new WindowsFormsApplication1.my_Button();
            this.my_Button1 = new WindowsFormsApplication1.my_Button();
            this.SuspendLayout();
            // 
            // my_Button2
            // 
            this.my_Button2.BackColor = System.Drawing.Color.Yellow;
            this.my_Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.my_Button2.Location = new System.Drawing.Point(41, 110);
            this.my_Button2.Name = "my_Button2";
            this.my_Button2.Size = new System.Drawing.Size(293, 134);
            this.my_Button2.TabIndex = 2;
            this.my_Button2.Text = "BAckup_DB_Rester";
            this.my_Button2.UseVisualStyleBackColor = false;
            this.my_Button2.Click += new System.EventHandler(this.my_Button2_Click);
            // 
            // my_Button1
            // 
            this.my_Button1.BackColor = System.Drawing.Color.Yellow;
            this.my_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.my_Button1.Location = new System.Drawing.Point(430, 93);
            this.my_Button1.Name = "my_Button1";
            this.my_Button1.Size = new System.Drawing.Size(266, 151);
            this.my_Button1.TabIndex = 1;
            this.my_Button1.Text = "BAckup_DB";
            this.my_Button1.UseVisualStyleBackColor = false;
            this.my_Button1.Click += new System.EventHandler(this.my_Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(733, 403);
            this.Controls.Add(this.my_Button2);
            this.Controls.Add(this.my_Button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private my_Button my_Button1;
        private my_Button my_Button2;
    }
}

