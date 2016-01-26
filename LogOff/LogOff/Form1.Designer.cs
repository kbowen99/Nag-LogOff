namespace LogOff
{
    partial class Frm_Nag
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pic_Minder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minder)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 292);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(471, 49);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Remove Reminder";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pic_Minder
            // 
            this.pic_Minder.Image = global::LogOff.Properties.Resources.logOut;
            this.pic_Minder.Location = new System.Drawing.Point(12, 12);
            this.pic_Minder.Name = "pic_Minder";
            this.pic_Minder.Size = new System.Drawing.Size(471, 274);
            this.pic_Minder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Minder.TabIndex = 1;
            this.pic_Minder.TabStop = false;
            // 
            // Frm_Nag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.pic_Minder);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Nag";
            this.Text = "Log Off ";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.PictureBox pic_Minder;
    }
}

