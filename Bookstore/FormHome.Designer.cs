namespace BookStore
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lbCurrentUserInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnbackAdminPanel = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnShowWhisList = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "magazinePic.jpg");
            this.ımageList1.Images.SetKeyName(1, "music.png");
            this.ımageList1.Images.SetKeyName(2, "Book.png");
            this.ımageList1.Images.SetKeyName(3, "magazine.jpg");
            this.ımageList1.Images.SetKeyName(4, "Books-icon.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "addIcon.ico");
            this.ımageList2.Images.SetKeyName(1, "LogIn.ico");
            this.ımageList2.Images.SetKeyName(2, "LogOut.png");
            this.ımageList2.Images.SetKeyName(3, "cart.png");
            this.ımageList2.Images.SetKeyName(4, "box.ico");
            this.ımageList2.Images.SetKeyName(5, "Control-Panel-icon.png");
            // 
            // lbCurrentUserInfo
            // 
            this.lbCurrentUserInfo.AutoSize = true;
            this.lbCurrentUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurrentUserInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUserInfo.Location = new System.Drawing.Point(3, 0);
            this.lbCurrentUserInfo.Name = "lbCurrentUserInfo";
            this.lbCurrentUserInfo.Size = new System.Drawing.Size(0, 42);
            this.lbCurrentUserInfo.TabIndex = 7;
            this.lbCurrentUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.Controls.Add(this.lbCurrentUserInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogOut, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 76);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.ImageIndex = 2;
            this.btnLogOut.ImageList = this.ımageList2;
            this.btnLogOut.Location = new System.Drawing.Point(3, 45);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 28);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Çıkış";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnMusic);
            this.groupBox2.Controls.Add(this.btnMagazine);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // btnMusic
            // 
            this.btnMusic.FlatAppearance.BorderSize = 4;
            this.btnMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMusic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusic.ImageKey = "music.png";
            this.btnMusic.ImageList = this.ımageList1;
            this.btnMusic.Location = new System.Drawing.Point(398, 18);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(150, 162);
            this.btnMusic.TabIndex = 2;
            this.btnMusic.Text = "MÜZİK";
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMagazine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMagazine.BackgroundImage")));
            this.btnMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMagazine.FlatAppearance.BorderSize = 4;
            this.btnMagazine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMagazine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMagazine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMagazine.ImageKey = "magazine.jpg";
            this.btnMagazine.Location = new System.Drawing.Point(205, 18);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(150, 162);
            this.btnMagazine.TabIndex = 1;
            this.btnMagazine.Text = "DERGİ";
            this.btnMagazine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBook.BackgroundImage")));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.FlatAppearance.BorderSize = 4;
            this.btnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBook.ImageKey = "(none)";
            this.btnBook.ImageList = this.ımageList1;
            this.btnBook.Location = new System.Drawing.Point(12, 18);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(150, 162);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "KİTAP";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxInfo.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxInfo.Location = new System.Drawing.Point(423, 13);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(125, 95);
            this.groupBoxInfo.TabIndex = 12;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "User";
            this.groupBoxInfo.Visible = false;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWelcome.Location = new System.Drawing.Point(199, 130);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(98, 24);
            this.lbWelcome.TabIndex = 13;
            this.lbWelcome.Text = "Hoşgeldin";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbWelcome.Visible = false;
            // 
            // btnbackAdminPanel
            // 
            this.btnbackAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbackAdminPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbackAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbackAdminPanel.ImageKey = "Control-Panel-icon.png";
            this.btnbackAdminPanel.ImageList = this.ımageList2;
            this.btnbackAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.btnbackAdminPanel.Name = "btnbackAdminPanel";
            this.btnbackAdminPanel.Size = new System.Drawing.Size(138, 49);
            this.btnbackAdminPanel.TabIndex = 16;
            this.btnbackAdminPanel.Text = "Admin Paneli";
            this.btnbackAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbackAdminPanel.UseVisualStyleBackColor = false;
            this.btnbackAdminPanel.Visible = false;
            this.btnbackAdminPanel.Click += new System.EventHandler(this.btnbackAdminPanel_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.ImageKey = "box.ico";
            this.btnOrderHistory.ImageList = this.ımageList2;
            this.btnOrderHistory.Location = new System.Drawing.Point(314, 176);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(136, 60);
            this.btnOrderHistory.TabIndex = 15;
            this.btnOrderHistory.Text = "Alışveriş Geçmişim";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Visible = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnShowWhisList
            // 
            this.btnShowWhisList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowWhisList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowWhisList.ImageKey = "cart.png";
            this.btnShowWhisList.ImageList = this.ımageList2;
            this.btnShowWhisList.Location = new System.Drawing.Point(137, 176);
            this.btnShowWhisList.Name = "btnShowWhisList";
            this.btnShowWhisList.Size = new System.Drawing.Size(136, 60);
            this.btnShowWhisList.TabIndex = 14;
            this.btnShowWhisList.Text = "Sepetim";
            this.btnShowWhisList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowWhisList.UseVisualStyleBackColor = true;
            this.btnShowWhisList.Visible = false;
            this.btnShowWhisList.Click += new System.EventHandler(this.btnShowWhisList_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.ImageKey = "LogIn.ico";
            this.btnLogin.ImageList = this.ımageList2;
            this.btnLogin.Location = new System.Drawing.Point(227, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 53);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Üye Girişi";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignup.ImageKey = "addIcon.ico";
            this.btnSignup.ImageList = this.ımageList2;
            this.btnSignup.Location = new System.Drawing.Point(227, 203);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(128, 53);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "         Kayıt Ol";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 449);
            this.Controls.Add(this.btnbackAdminPanel);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnShowWhisList);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "Bookstore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbCurrentUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnShowWhisList;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnbackAdminPanel;
    }
}

