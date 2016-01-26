namespace NagInstaller
{
    partial class Frm_Install
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
            this.txt_Usr = new System.Windows.Forms.TextBox();
            this.lbl_Usr = new System.Windows.Forms.Label();
            this.Btn_Install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Usr
            // 
            this.txt_Usr.Location = new System.Drawing.Point(73, 6);
            this.txt_Usr.Name = "txt_Usr";
            this.txt_Usr.Size = new System.Drawing.Size(100, 20);
            this.txt_Usr.TabIndex = 0;
            // 
            // lbl_Usr
            // 
            this.lbl_Usr.AutoSize = true;
            this.lbl_Usr.Location = new System.Drawing.Point(12, 9);
            this.lbl_Usr.Name = "lbl_Usr";
            this.lbl_Usr.Size = new System.Drawing.Size(55, 13);
            this.lbl_Usr.TabIndex = 1;
            this.lbl_Usr.Text = "Username";
            // 
            // Btn_Install
            // 
            this.Btn_Install.Location = new System.Drawing.Point(179, 6);
            this.Btn_Install.Name = "Btn_Install";
            this.Btn_Install.Size = new System.Drawing.Size(75, 23);
            this.Btn_Install.TabIndex = 2;
            this.Btn_Install.Text = "Install";
            this.Btn_Install.UseVisualStyleBackColor = true;
            this.Btn_Install.Click += new System.EventHandler(this.Btn_Install_Click);
            // 
            // Frm_Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 36);
            this.Controls.Add(this.Btn_Install);
            this.Controls.Add(this.lbl_Usr);
            this.Controls.Add(this.txt_Usr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Install";
            this.Text = "Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usr;
        private System.Windows.Forms.Label lbl_Usr;
        private System.Windows.Forms.Button Btn_Install;
    }
}

