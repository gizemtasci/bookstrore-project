namespace BookStore
{
    partial class FormAdminLogin
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbladminuser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(119, 45);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 0;
            // 
            // lbladminuser
            // 
            this.lbladminuser.AutoSize = true;
            this.lbladminuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladminuser.Location = new System.Drawing.Point(30, 46);
            this.lbladminuser.Name = "lbladminuser";
            this.lbladminuser.Size = new System.Drawing.Size(83, 17);
            this.lbladminuser.TabIndex = 2;
            this.lbladminuser.Text = "User Name:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpassword.Location = new System.Drawing.Point(40, 112);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(73, 17);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password:";
            // 
            // btnadminlogin
            // 
            this.btnadminlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadminlogin.Location = new System.Drawing.Point(100, 162);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(75, 36);
            this.btnadminlogin.TabIndex = 4;
            this.btnadminlogin.Text = "Login";
            this.btnadminlogin.UseVisualStyleBackColor = true;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(119, 109);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 5;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(301, 275);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btnadminlogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbladminuser);
            this.Controls.Add(this.txt_username);
            this.Name = "FormAdminLogin";
            this.Text = "FormAdminLogin";
            this.Load += new System.EventHandler(this.FormAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbladminuser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnadminlogin;
        private System.Windows.Forms.TextBox txt_password;
    }
}