namespace BookStore
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.imageListLoginF = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üyelik Girişi";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(29, 127);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(215, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(29, 193);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(215, 25);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre";
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxSignIn.Controls.Add(this.btnLogCancel);
            this.groupBoxSignIn.Controls.Add(this.btnUserLogin);
            this.groupBoxSignIn.Controls.Add(this.label1);
            this.groupBoxSignIn.Controls.Add(this.txtUsername);
            this.groupBoxSignIn.Controls.Add(this.label3);
            this.groupBoxSignIn.Controls.Add(this.txtPassword);
            this.groupBoxSignIn.Controls.Add(this.label2);
            this.groupBoxSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSignIn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSignIn.Size = new System.Drawing.Size(281, 322);
            this.groupBoxSignIn.TabIndex = 5;
            this.groupBoxSignIn.TabStop = false;
            // 
            // btnLogCancel
            // 
            this.btnLogCancel.BackColor = System.Drawing.Color.Red;
            this.btnLogCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogCancel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogCancel.Location = new System.Drawing.Point(29, 238);
            this.btnLogCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(107, 42);
            this.btnLogCancel.TabIndex = 23;
            this.btnLogCancel.Text = "İptal";
            this.btnLogCancel.UseVisualStyleBackColor = false;
            this.btnLogCancel.Click += new System.EventHandler(this.btnLogCancel_Click);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUserLogin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUserLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserLogin.ImageIndex = 0;
            this.btnUserLogin.ImageList = this.imageListLoginF;
            this.btnUserLogin.Location = new System.Drawing.Point(144, 238);
            this.btnUserLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(107, 42);
            this.btnUserLogin.TabIndex = 22;
            this.btnUserLogin.Text = "Giriş";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // imageListLoginF
            // 
            this.imageListLoginF.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLoginF.ImageStream")));
            this.imageListLoginF.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLoginF.Images.SetKeyName(0, "SignIn.png");
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnUserLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CancelButton = this.btnLogCancel;
            this.ClientSize = new System.Drawing.Size(281, 322);
            this.Controls.Add(this.groupBoxSignIn);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Text = "Bookstore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.ImageList imageListLoginF;
    }
}