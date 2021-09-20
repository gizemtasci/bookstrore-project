namespace BookStore
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.tabControlItems = new System.Windows.Forms.TabControl();
            this.tabPBook = new System.Windows.Forms.TabPage();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.UpDownBook = new System.Windows.Forms.NumericUpDown();
            this.txtBookPage = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookNum = new System.Windows.Forms.Label();
            this.lblBookPage = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.tabPMagazine = new System.Windows.Forms.TabPage();
            this.btnMagazineEdit = new System.Windows.Forms.Button();
            this.btnCancelMagazine = new System.Windows.Forms.Button();
            this.btnAddMagazine = new System.Windows.Forms.Button();
            this.comBMagazineType = new System.Windows.Forms.ComboBox();
            this.UpDownMagazine = new System.Windows.Forms.NumericUpDown();
            this.txtMagazineIssue = new System.Windows.Forms.TextBox();
            this.txtMagazinePrice = new System.Windows.Forms.TextBox();
            this.txtMagazineName = new System.Windows.Forms.TextBox();
            this.lblMagazineNum = new System.Windows.Forms.Label();
            this.lblMagazineType = new System.Windows.Forms.Label();
            this.lblMagazineIssue = new System.Windows.Forms.Label();
            this.lblMagazinePrice = new System.Windows.Forms.Label();
            this.lblMagazineName = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.tabPMusicCD = new System.Windows.Forms.TabPage();
            this.btnMusicEdit = new System.Windows.Forms.Button();
            this.btnCancelMusic = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.comBMusicType = new System.Windows.Forms.ComboBox();
            this.UpDownMusic = new System.Windows.Forms.NumericUpDown();
            this.txtMusicSinger = new System.Windows.Forms.TextBox();
            this.txtMusicPrice = new System.Windows.Forms.TextBox();
            this.txtMusicName = new System.Windows.Forms.TextBox();
            this.lblMusicNum = new System.Windows.Forms.Label();
            this.lblMusicType = new System.Windows.Forms.Label();
            this.lblMusicSinger = new System.Windows.Forms.Label();
            this.lblMusicPrice = new System.Windows.Forms.Label();
            this.lblMusicName = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.tabPMain = new System.Windows.Forms.TabPage();
            this.btnUserPage = new System.Windows.Forms.Button();
            this.imageListAdmin = new System.Windows.Forms.ImageList(this.components);
            this.btnLogFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMainPageInfo = new System.Windows.Forms.Label();
            this.radioBtnMagazine = new System.Windows.Forms.RadioButton();
            this.radioBtnMusicCD = new System.Windows.Forms.RadioButton();
            this.radioBtnBook = new System.Windows.Forms.RadioButton();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.tabPUser = new System.Windows.Forms.TabPage();
            this.btnBackAdminPanel = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblUserTabInfo = new System.Windows.Forms.Label();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlItems.SuspendLayout();
            this.tabPBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBook)).BeginInit();
            this.tabPMagazine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMagazine)).BeginInit();
            this.tabPMusicCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMusic)).BeginInit();
            this.tabPMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlItems
            // 
            this.tabControlItems.Controls.Add(this.tabPBook);
            this.tabControlItems.Controls.Add(this.tabPMagazine);
            this.tabControlItems.Controls.Add(this.tabPMusicCD);
            this.tabControlItems.Controls.Add(this.tabPMain);
            this.tabControlItems.Controls.Add(this.tabPUser);
            this.tabControlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlItems.Location = new System.Drawing.Point(0, 0);
            this.tabControlItems.Name = "tabControlItems";
            this.tabControlItems.SelectedIndex = 0;
            this.tabControlItems.Size = new System.Drawing.Size(864, 473);
            this.tabControlItems.TabIndex = 3;
            // 
            // tabPBook
            // 
            this.tabPBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPBook.Controls.Add(this.btnBookEdit);
            this.tabPBook.Controls.Add(this.btnCancelBook);
            this.tabPBook.Controls.Add(this.btnAddBook);
            this.tabPBook.Controls.Add(this.UpDownBook);
            this.tabPBook.Controls.Add(this.txtBookPage);
            this.tabPBook.Controls.Add(this.txtBookPublisher);
            this.tabPBook.Controls.Add(this.txtBookAuthor);
            this.tabPBook.Controls.Add(this.txtBookISBN);
            this.tabPBook.Controls.Add(this.txtBookPrice);
            this.tabPBook.Controls.Add(this.txtBookName);
            this.tabPBook.Controls.Add(this.lblBookNum);
            this.tabPBook.Controls.Add(this.lblBookPage);
            this.tabPBook.Controls.Add(this.lblBookPublisher);
            this.tabPBook.Controls.Add(this.lblBookAuthor);
            this.tabPBook.Controls.Add(this.lblBookISBN);
            this.tabPBook.Controls.Add(this.lblBookPrice);
            this.tabPBook.Controls.Add(this.lblBookName);
            this.tabPBook.Controls.Add(this.lblInfo1);
            this.tabPBook.Location = new System.Drawing.Point(4, 22);
            this.tabPBook.Name = "tabPBook";
            this.tabPBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBook.Size = new System.Drawing.Size(856, 447);
            this.tabPBook.TabIndex = 0;
            this.tabPBook.Text = "Kitap";
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.BackColor = System.Drawing.Color.Blue;
            this.btnBookEdit.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookEdit.Location = new System.Drawing.Point(463, 320);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(132, 61);
            this.btnBookEdit.TabIndex = 23;
            this.btnBookEdit.Text = "Güncelle";
            this.btnBookEdit.UseVisualStyleBackColor = false;
            this.btnBookEdit.Visible = false;
            this.btnBookEdit.Click += new System.EventHandler(this.btnBookEdit_Click);
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelBook.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelBook.Location = new System.Drawing.Point(265, 320);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(132, 61);
            this.btnCancelBook.TabIndex = 22;
            this.btnCancelBook.Text = "<< Geri";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBook.Location = new System.Drawing.Point(463, 320);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(132, 61);
            this.btnAddBook.TabIndex = 21;
            this.btnAddBook.Text = "Ürünü Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // UpDownBook
            // 
            this.UpDownBook.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpDownBook.Location = new System.Drawing.Point(370, 259);
            this.UpDownBook.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UpDownBook.Name = "UpDownBook";
            this.UpDownBook.Size = new System.Drawing.Size(43, 26);
            this.UpDownBook.TabIndex = 20;
            this.UpDownBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownBook.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBookPage
            // 
            this.txtBookPage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookPage.Location = new System.Drawing.Point(370, 227);
            this.txtBookPage.Name = "txtBookPage";
            this.txtBookPage.Size = new System.Drawing.Size(169, 26);
            this.txtBookPage.TabIndex = 19;
            this.txtBookPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPage_KeyPress);
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookPublisher.Location = new System.Drawing.Point(370, 195);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(169, 26);
            this.txtBookPublisher.TabIndex = 18;
            this.txtBookPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookPublisher_KeyDown);
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookAuthor.Location = new System.Drawing.Point(370, 163);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(169, 26);
            this.txtBookAuthor.TabIndex = 17;
            this.txtBookAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookAuthor_KeyDown);
            this.txtBookAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookAuthor_KeyPress);
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookISBN.Location = new System.Drawing.Point(370, 131);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(169, 26);
            this.txtBookISBN.TabIndex = 16;
            this.txtBookISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookISBN_KeyDown);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookPrice.Location = new System.Drawing.Point(370, 99);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(169, 26);
            this.txtBookPrice.TabIndex = 15;
            this.txtBookPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookPrice_KeyPress);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(370, 67);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(169, 26);
            this.txtBookName.TabIndex = 14;
            this.txtBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyDown);
            // 
            // lblBookNum
            // 
            this.lblBookNum.AutoSize = true;
            this.lblBookNum.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookNum.Location = new System.Drawing.Point(310, 259);
            this.lblBookNum.Name = "lblBookNum";
            this.lblBookNum.Size = new System.Drawing.Size(54, 23);
            this.lblBookNum.TabIndex = 13;
            this.lblBookNum.Text = "Adet :";
            // 
            // lblBookPage
            // 
            this.lblBookPage.AutoSize = true;
            this.lblBookPage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookPage.Location = new System.Drawing.Point(255, 227);
            this.lblBookPage.Name = "lblBookPage";
            this.lblBookPage.Size = new System.Drawing.Size(110, 23);
            this.lblBookPage.TabIndex = 12;
            this.lblBookPage.Text = "Sayfa Sayısı :";
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookPublisher.Location = new System.Drawing.Point(286, 198);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(78, 23);
            this.lblBookPublisher.TabIndex = 11;
            this.lblBookPublisher.Text = "Yayımcı :";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAuthor.Location = new System.Drawing.Point(299, 166);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(65, 23);
            this.lblBookAuthor.TabIndex = 10;
            this.lblBookAuthor.Text = "Yazarı :";
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookISBN.Location = new System.Drawing.Point(309, 134);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(55, 23);
            this.lblBookISBN.TabIndex = 9;
            this.lblBookISBN.Text = "ISBN :";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookPrice.Location = new System.Drawing.Point(261, 102);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(103, 23);
            this.lblBookPrice.TabIndex = 8;
            this.lblBookPrice.Text = "Kitap Fiyatı :";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(277, 70);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(87, 23);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "Kitap Adı :";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.Location = new System.Drawing.Point(255, 17);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(396, 23);
            this.lblInfo1.TabIndex = 6;
            this.lblInfo1.Text = "Lütfen Eklemek İstedğiniz Ürünün Bilgilerini Giriniz!";
            // 
            // tabPMagazine
            // 
            this.tabPMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(179)))));
            this.tabPMagazine.Controls.Add(this.btnMagazineEdit);
            this.tabPMagazine.Controls.Add(this.btnCancelMagazine);
            this.tabPMagazine.Controls.Add(this.btnAddMagazine);
            this.tabPMagazine.Controls.Add(this.comBMagazineType);
            this.tabPMagazine.Controls.Add(this.UpDownMagazine);
            this.tabPMagazine.Controls.Add(this.txtMagazineIssue);
            this.tabPMagazine.Controls.Add(this.txtMagazinePrice);
            this.tabPMagazine.Controls.Add(this.txtMagazineName);
            this.tabPMagazine.Controls.Add(this.lblMagazineNum);
            this.tabPMagazine.Controls.Add(this.lblMagazineType);
            this.tabPMagazine.Controls.Add(this.lblMagazineIssue);
            this.tabPMagazine.Controls.Add(this.lblMagazinePrice);
            this.tabPMagazine.Controls.Add(this.lblMagazineName);
            this.tabPMagazine.Controls.Add(this.lblInfo2);
            this.tabPMagazine.Location = new System.Drawing.Point(4, 22);
            this.tabPMagazine.Name = "tabPMagazine";
            this.tabPMagazine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMagazine.Size = new System.Drawing.Size(856, 447);
            this.tabPMagazine.TabIndex = 1;
            this.tabPMagazine.Text = "Dergi";
            // 
            // btnMagazineEdit
            // 
            this.btnMagazineEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMagazineEdit.Location = new System.Drawing.Point(503, 285);
            this.btnMagazineEdit.Name = "btnMagazineEdit";
            this.btnMagazineEdit.Size = new System.Drawing.Size(132, 61);
            this.btnMagazineEdit.TabIndex = 39;
            this.btnMagazineEdit.Text = "Güncelle";
            this.btnMagazineEdit.UseVisualStyleBackColor = true;
            this.btnMagazineEdit.Visible = false;
            this.btnMagazineEdit.Click += new System.EventHandler(this.btnMagazineEdit_Click);
            // 
            // btnCancelMagazine
            // 
            this.btnCancelMagazine.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelMagazine.Location = new System.Drawing.Point(289, 285);
            this.btnCancelMagazine.Name = "btnCancelMagazine";
            this.btnCancelMagazine.Size = new System.Drawing.Size(132, 61);
            this.btnCancelMagazine.TabIndex = 38;
            this.btnCancelMagazine.Text = "Geri";
            this.btnCancelMagazine.UseVisualStyleBackColor = true;
            this.btnCancelMagazine.Click += new System.EventHandler(this.btnCancelMagazine_Click);
            // 
            // btnAddMagazine
            // 
            this.btnAddMagazine.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMagazine.Location = new System.Drawing.Point(503, 285);
            this.btnAddMagazine.Name = "btnAddMagazine";
            this.btnAddMagazine.Size = new System.Drawing.Size(132, 61);
            this.btnAddMagazine.TabIndex = 37;
            this.btnAddMagazine.Text = "Ürünü Ekle";
            this.btnAddMagazine.UseVisualStyleBackColor = true;
            this.btnAddMagazine.Click += new System.EventHandler(this.btnAddMagazine_Click);
            // 
            // comBMagazineType
            // 
            this.comBMagazineType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBMagazineType.FormattingEnabled = true;
            this.comBMagazineType.Items.AddRange(new object[] {
            "Business",
            "Sport",
            "Computer",
            "Technology",
            "Humor",
            "Science",
            "Fashion"});
            this.comBMagazineType.Location = new System.Drawing.Point(398, 183);
            this.comBMagazineType.Name = "comBMagazineType";
            this.comBMagazineType.Size = new System.Drawing.Size(121, 28);
            this.comBMagazineType.TabIndex = 36;
            // 
            // UpDownMagazine
            // 
            this.UpDownMagazine.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpDownMagazine.Location = new System.Drawing.Point(398, 217);
            this.UpDownMagazine.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UpDownMagazine.Name = "UpDownMagazine";
            this.UpDownMagazine.Size = new System.Drawing.Size(43, 26);
            this.UpDownMagazine.TabIndex = 35;
            this.UpDownMagazine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownMagazine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMagazineIssue
            // 
            this.txtMagazineIssue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineIssue.Location = new System.Drawing.Point(398, 151);
            this.txtMagazineIssue.Name = "txtMagazineIssue";
            this.txtMagazineIssue.Size = new System.Drawing.Size(169, 26);
            this.txtMagazineIssue.TabIndex = 31;
            this.txtMagazineIssue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMagazineIssue_KeyDown);
            // 
            // txtMagazinePrice
            // 
            this.txtMagazinePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazinePrice.Location = new System.Drawing.Point(398, 121);
            this.txtMagazinePrice.Name = "txtMagazinePrice";
            this.txtMagazinePrice.Size = new System.Drawing.Size(169, 26);
            this.txtMagazinePrice.TabIndex = 30;
            this.txtMagazinePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMagazinePrice_KeyPress);
            // 
            // txtMagazineName
            // 
            this.txtMagazineName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMagazineName.Location = new System.Drawing.Point(398, 89);
            this.txtMagazineName.Name = "txtMagazineName";
            this.txtMagazineName.Size = new System.Drawing.Size(169, 26);
            this.txtMagazineName.TabIndex = 29;
            this.txtMagazineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMagazineName_KeyDown);
            // 
            // lblMagazineNum
            // 
            this.lblMagazineNum.AutoSize = true;
            this.lblMagazineNum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineNum.Location = new System.Drawing.Point(341, 219);
            this.lblMagazineNum.Name = "lblMagazineNum";
            this.lblMagazineNum.Size = new System.Drawing.Size(45, 20);
            this.lblMagazineNum.TabIndex = 28;
            this.lblMagazineNum.Text = "Adet :";
            // 
            // lblMagazineType
            // 
            this.lblMagazineType.AutoSize = true;
            this.lblMagazineType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineType.Location = new System.Drawing.Point(340, 186);
            this.lblMagazineType.Name = "lblMagazineType";
            this.lblMagazineType.Size = new System.Drawing.Size(46, 20);
            this.lblMagazineType.TabIndex = 25;
            this.lblMagazineType.Text = "Türü :";
            // 
            // lblMagazineIssue
            // 
            this.lblMagazineIssue.AutoSize = true;
            this.lblMagazineIssue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineIssue.Location = new System.Drawing.Point(330, 154);
            this.lblMagazineIssue.Name = "lblMagazineIssue";
            this.lblMagazineIssue.Size = new System.Drawing.Size(56, 20);
            this.lblMagazineIssue.TabIndex = 24;
            this.lblMagazineIssue.Text = "Basım :";
            // 
            // lblMagazinePrice
            // 
            this.lblMagazinePrice.AutoSize = true;
            this.lblMagazinePrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazinePrice.Location = new System.Drawing.Point(298, 124);
            this.lblMagazinePrice.Name = "lblMagazinePrice";
            this.lblMagazinePrice.Size = new System.Drawing.Size(88, 20);
            this.lblMagazinePrice.TabIndex = 23;
            this.lblMagazinePrice.Text = "Dergi Fiyatı :";
            // 
            // lblMagazineName
            // 
            this.lblMagazineName.AutoSize = true;
            this.lblMagazineName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMagazineName.Location = new System.Drawing.Point(311, 92);
            this.lblMagazineName.Name = "lblMagazineName";
            this.lblMagazineName.Size = new System.Drawing.Size(75, 20);
            this.lblMagazineName.TabIndex = 22;
            this.lblMagazineName.Text = "Dergi Adı :";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo2.Location = new System.Drawing.Point(239, 21);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(396, 23);
            this.lblInfo2.TabIndex = 21;
            this.lblInfo2.Text = "Lütfen Eklemek İstedğiniz Ürünün Bilgilerini Giriniz!";
            // 
            // tabPMusicCD
            // 
            this.tabPMusicCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(179)))));
            this.tabPMusicCD.Controls.Add(this.btnMusicEdit);
            this.tabPMusicCD.Controls.Add(this.btnCancelMusic);
            this.tabPMusicCD.Controls.Add(this.btnAddMusic);
            this.tabPMusicCD.Controls.Add(this.comBMusicType);
            this.tabPMusicCD.Controls.Add(this.UpDownMusic);
            this.tabPMusicCD.Controls.Add(this.txtMusicSinger);
            this.tabPMusicCD.Controls.Add(this.txtMusicPrice);
            this.tabPMusicCD.Controls.Add(this.txtMusicName);
            this.tabPMusicCD.Controls.Add(this.lblMusicNum);
            this.tabPMusicCD.Controls.Add(this.lblMusicType);
            this.tabPMusicCD.Controls.Add(this.lblMusicSinger);
            this.tabPMusicCD.Controls.Add(this.lblMusicPrice);
            this.tabPMusicCD.Controls.Add(this.lblMusicName);
            this.tabPMusicCD.Controls.Add(this.lblInfo3);
            this.tabPMusicCD.Location = new System.Drawing.Point(4, 22);
            this.tabPMusicCD.Name = "tabPMusicCD";
            this.tabPMusicCD.Size = new System.Drawing.Size(856, 447);
            this.tabPMusicCD.TabIndex = 2;
            this.tabPMusicCD.Text = "Müzik";
            // 
            // btnMusicEdit
            // 
            this.btnMusicEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusicEdit.Location = new System.Drawing.Point(501, 282);
            this.btnMusicEdit.Name = "btnMusicEdit";
            this.btnMusicEdit.Size = new System.Drawing.Size(132, 61);
            this.btnMusicEdit.TabIndex = 50;
            this.btnMusicEdit.Text = "Güncelle";
            this.btnMusicEdit.UseVisualStyleBackColor = true;
            this.btnMusicEdit.Visible = false;
            this.btnMusicEdit.Click += new System.EventHandler(this.btnMusicEdit_Click);
            // 
            // btnCancelMusic
            // 
            this.btnCancelMusic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelMusic.Location = new System.Drawing.Point(237, 282);
            this.btnCancelMusic.Name = "btnCancelMusic";
            this.btnCancelMusic.Size = new System.Drawing.Size(132, 61);
            this.btnCancelMusic.TabIndex = 49;
            this.btnCancelMusic.Text = "Geri";
            this.btnCancelMusic.UseVisualStyleBackColor = true;
            this.btnCancelMusic.Click += new System.EventHandler(this.btnCancelMusic_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMusic.Location = new System.Drawing.Point(501, 282);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(132, 61);
            this.btnAddMusic.TabIndex = 48;
            this.btnAddMusic.Text = "Ürünü Ekle";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // comBMusicType
            // 
            this.comBMusicType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBMusicType.FormattingEnabled = true;
            this.comBMusicType.Items.AddRange(new object[] {
            "Rock",
            "Country",
            "Hip Hop",
            "Classic",
            "ProgressiveRock",
            "Pop",
            "Folk"});
            this.comBMusicType.Location = new System.Drawing.Point(385, 190);
            this.comBMusicType.Name = "comBMusicType";
            this.comBMusicType.Size = new System.Drawing.Size(121, 28);
            this.comBMusicType.TabIndex = 47;
            // 
            // UpDownMusic
            // 
            this.UpDownMusic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpDownMusic.Location = new System.Drawing.Point(385, 224);
            this.UpDownMusic.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UpDownMusic.Name = "UpDownMusic";
            this.UpDownMusic.Size = new System.Drawing.Size(43, 26);
            this.UpDownMusic.TabIndex = 46;
            this.UpDownMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownMusic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMusicSinger
            // 
            this.txtMusicSinger.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicSinger.Location = new System.Drawing.Point(385, 158);
            this.txtMusicSinger.Name = "txtMusicSinger";
            this.txtMusicSinger.Size = new System.Drawing.Size(169, 26);
            this.txtMusicSinger.TabIndex = 45;
            this.txtMusicSinger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMusicSinger_KeyDown);
            // 
            // txtMusicPrice
            // 
            this.txtMusicPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicPrice.Location = new System.Drawing.Point(385, 126);
            this.txtMusicPrice.Name = "txtMusicPrice";
            this.txtMusicPrice.Size = new System.Drawing.Size(169, 26);
            this.txtMusicPrice.TabIndex = 44;
            this.txtMusicPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusicPrice_KeyPress);
            // 
            // txtMusicName
            // 
            this.txtMusicName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusicName.Location = new System.Drawing.Point(385, 94);
            this.txtMusicName.Name = "txtMusicName";
            this.txtMusicName.Size = new System.Drawing.Size(169, 26);
            this.txtMusicName.TabIndex = 43;
            this.txtMusicName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMusicName_KeyDown);
            // 
            // lblMusicNum
            // 
            this.lblMusicNum.AutoSize = true;
            this.lblMusicNum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicNum.Location = new System.Drawing.Point(324, 226);
            this.lblMusicNum.Name = "lblMusicNum";
            this.lblMusicNum.Size = new System.Drawing.Size(45, 20);
            this.lblMusicNum.TabIndex = 42;
            this.lblMusicNum.Text = "Adet :";
            // 
            // lblMusicType
            // 
            this.lblMusicType.AutoSize = true;
            this.lblMusicType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicType.Location = new System.Drawing.Point(323, 193);
            this.lblMusicType.Name = "lblMusicType";
            this.lblMusicType.Size = new System.Drawing.Size(46, 20);
            this.lblMusicType.TabIndex = 41;
            this.lblMusicType.Text = "Türü :";
            // 
            // lblMusicSinger
            // 
            this.lblMusicSinger.AutoSize = true;
            this.lblMusicSinger.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicSinger.Location = new System.Drawing.Point(306, 161);
            this.lblMusicSinger.Name = "lblMusicSinger";
            this.lblMusicSinger.Size = new System.Drawing.Size(63, 20);
            this.lblMusicSinger.TabIndex = 40;
            this.lblMusicSinger.Text = "Sanatçı :";
            // 
            // lblMusicPrice
            // 
            this.lblMusicPrice.AutoSize = true;
            this.lblMusicPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicPrice.Location = new System.Drawing.Point(256, 129);
            this.lblMusicPrice.Name = "lblMusicPrice";
            this.lblMusicPrice.Size = new System.Drawing.Size(113, 20);
            this.lblMusicPrice.TabIndex = 39;
            this.lblMusicPrice.Text = "Müzik CD Fiyatı :";
            // 
            // lblMusicName
            // 
            this.lblMusicName.AutoSize = true;
            this.lblMusicName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusicName.Location = new System.Drawing.Point(269, 97);
            this.lblMusicName.Name = "lblMusicName";
            this.lblMusicName.Size = new System.Drawing.Size(100, 20);
            this.lblMusicName.TabIndex = 38;
            this.lblMusicName.Text = "Müzik CD Adı :";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo3.Location = new System.Drawing.Point(253, 25);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(396, 23);
            this.lblInfo3.TabIndex = 37;
            this.lblInfo3.Text = "Lütfen Eklemek İstedğiniz Ürünün Bilgilerini Giriniz!";
            // 
            // tabPMain
            // 
            this.tabPMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(179)))));
            this.tabPMain.Controls.Add(this.btnUserPage);
            this.tabPMain.Controls.Add(this.btnLogFile);
            this.tabPMain.Controls.Add(this.tableLayoutPanel1);
            this.tabPMain.Controls.Add(this.groupBox1);
            this.tabPMain.Controls.Add(this.listViewItems);
            this.tabPMain.Location = new System.Drawing.Point(4, 22);
            this.tabPMain.Name = "tabPMain";
            this.tabPMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMain.Size = new System.Drawing.Size(856, 447);
            this.tabPMain.TabIndex = 3;
            this.tabPMain.Text = "Ürün Listesi";
            // 
            // btnUserPage
            // 
            this.btnUserPage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserPage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserPage.ImageKey = "Users.png";
            this.btnUserPage.ImageList = this.imageListAdmin;
            this.btnUserPage.Location = new System.Drawing.Point(551, 97);
            this.btnUserPage.Name = "btnUserPage";
            this.btnUserPage.Size = new System.Drawing.Size(154, 60);
            this.btnUserPage.TabIndex = 9;
            this.btnUserPage.Text = "Üyeleri Görüntüle";
            this.btnUserPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserPage.UseVisualStyleBackColor = true;
            this.btnUserPage.Click += new System.EventHandler(this.btnUserPage_Click);
            // 
            // imageListAdmin
            // 
            this.imageListAdmin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAdmin.ImageStream")));
            this.imageListAdmin.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAdmin.Images.SetKeyName(0, "Add.ico");
            this.imageListAdmin.Images.SetKeyName(1, "Awicons-Vista-Artistic-Delete.ico");
            this.imageListAdmin.Images.SetKeyName(2, "update.png");
            this.imageListAdmin.Images.SetKeyName(3, "home1.png");
            this.imageListAdmin.Images.SetKeyName(4, "Spy-icon.png");
            this.imageListAdmin.Images.SetKeyName(5, "Users.png");
            // 
            // btnLogFile
            // 
            this.btnLogFile.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogFile.ImageKey = "Spy-icon.png";
            this.btnLogFile.ImageList = this.imageListAdmin;
            this.btnLogFile.Location = new System.Drawing.Point(551, 31);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(154, 60);
            this.btnLogFile.TabIndex = 8;
            this.btnLogFile.Text = "Kullanıcı Hareketleri";
            this.btnLogFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnItemAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnItemUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBackMain, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnItemRemove, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(316, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 132);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemAdd.ImageIndex = 0;
            this.btnItemAdd.ImageList = this.imageListAdmin;
            this.btnItemAdd.Location = new System.Drawing.Point(3, 3);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(108, 60);
            this.btnItemAdd.TabIndex = 0;
            this.btnItemAdd.Text = "Ekle";
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemUpdate.ImageIndex = 2;
            this.btnItemUpdate.ImageList = this.imageListAdmin;
            this.btnItemUpdate.Location = new System.Drawing.Point(3, 69);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(108, 60);
            this.btnItemUpdate.TabIndex = 2;
            this.btnItemUpdate.Text = "Güncelle";
            this.btnItemUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemUpdate.UseVisualStyleBackColor = true;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnBackMain
            // 
            this.btnBackMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMain.ImageIndex = 3;
            this.btnBackMain.ImageList = this.imageListAdmin;
            this.btnBackMain.Location = new System.Drawing.Point(117, 69);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(109, 60);
            this.btnBackMain.TabIndex = 4;
            this.btnBackMain.Text = "Ana Menü";
            this.btnBackMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemRemove.ImageIndex = 1;
            this.btnItemRemove.ImageList = this.imageListAdmin;
            this.btnItemRemove.Location = new System.Drawing.Point(117, 3);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(109, 60);
            this.btnItemRemove.TabIndex = 5;
            this.btnItemRemove.Text = "Çıkar";
            this.btnItemRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemRemove.UseVisualStyleBackColor = true;
            this.btnItemRemove.Click += new System.EventHandler(this.btnItemRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lblMainPageInfo);
            this.groupBox1.Controls.Add(this.radioBtnMagazine);
            this.groupBox1.Controls.Add(this.radioBtnMusicCD);
            this.groupBox1.Controls.Add(this.radioBtnBook);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // lblMainPageInfo
            // 
            this.lblMainPageInfo.AutoSize = true;
            this.lblMainPageInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMainPageInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblMainPageInfo.Location = new System.Drawing.Point(23, 27);
            this.lblMainPageInfo.Name = "lblMainPageInfo";
            this.lblMainPageInfo.Size = new System.Drawing.Size(245, 20);
            this.lblMainPageInfo.TabIndex = 1;
            this.lblMainPageInfo.Text = "İşlem yapmak istediğiniz ürünü seçiniz";
            // 
            // radioBtnMagazine
            // 
            this.radioBtnMagazine.AutoSize = true;
            this.radioBtnMagazine.Location = new System.Drawing.Point(111, 73);
            this.radioBtnMagazine.Name = "radioBtnMagazine";
            this.radioBtnMagazine.Size = new System.Drawing.Size(60, 24);
            this.radioBtnMagazine.TabIndex = 2;
            this.radioBtnMagazine.Text = "Dergi";
            this.radioBtnMagazine.UseVisualStyleBackColor = true;
            this.radioBtnMagazine.CheckedChanged += new System.EventHandler(this.radioBtnMagazine_CheckedChanged);
            // 
            // radioBtnMusicCD
            // 
            this.radioBtnMusicCD.AutoSize = true;
            this.radioBtnMusicCD.Location = new System.Drawing.Point(111, 96);
            this.radioBtnMusicCD.Name = "radioBtnMusicCD";
            this.radioBtnMusicCD.Size = new System.Drawing.Size(63, 24);
            this.radioBtnMusicCD.TabIndex = 1;
            this.radioBtnMusicCD.Text = "Müzik";
            this.radioBtnMusicCD.UseVisualStyleBackColor = true;
            this.radioBtnMusicCD.CheckedChanged += new System.EventHandler(this.radioBtnMusicCD_CheckedChanged);
            // 
            // radioBtnBook
            // 
            this.radioBtnBook.AutoSize = true;
            this.radioBtnBook.Checked = true;
            this.radioBtnBook.Location = new System.Drawing.Point(111, 50);
            this.radioBtnBook.Name = "radioBtnBook";
            this.radioBtnBook.Size = new System.Drawing.Size(59, 24);
            this.radioBtnBook.TabIndex = 0;
            this.radioBtnBook.TabStop = true;
            this.radioBtnBook.Text = "Kitap";
            this.radioBtnBook.UseVisualStyleBackColor = true;
            this.radioBtnBook.CheckedChanged += new System.EventHandler(this.radioBtnBook_CheckedChanged);
            // 
            // listViewItems
            // 
            this.listViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewItems.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.Location = new System.Drawing.Point(8, 190);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(839, 249);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // tabPUser
            // 
            this.tabPUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(204)))), ((int)(((byte)(179)))));
            this.tabPUser.Controls.Add(this.btnBackAdminPanel);
            this.tabPUser.Controls.Add(this.btnDeleteUser);
            this.tabPUser.Controls.Add(this.lblUserTabInfo);
            this.tabPUser.Controls.Add(this.listViewUsers);
            this.tabPUser.Location = new System.Drawing.Point(4, 22);
            this.tabPUser.Name = "tabPUser";
            this.tabPUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPUser.Size = new System.Drawing.Size(856, 447);
            this.tabPUser.TabIndex = 4;
            this.tabPUser.Text = "Kullanıcılar";
            // 
            // btnBackAdminPanel
            // 
            this.btnBackAdminPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackAdminPanel.Location = new System.Drawing.Point(166, 355);
            this.btnBackAdminPanel.Name = "btnBackAdminPanel";
            this.btnBackAdminPanel.Size = new System.Drawing.Size(142, 66);
            this.btnBackAdminPanel.TabIndex = 3;
            this.btnBackAdminPanel.Text = "Geri";
            this.btnBackAdminPanel.UseVisualStyleBackColor = true;
            this.btnBackAdminPanel.Click += new System.EventHandler(this.btnBackAdminPanel_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.btnDeleteUser.ImageList = this.imageListAdmin;
            this.btnDeleteUser.Location = new System.Drawing.Point(521, 355);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(148, 66);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Kullanıcıyı Sil";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblUserTabInfo
            // 
            this.lblUserTabInfo.AutoSize = true;
            this.lblUserTabInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserTabInfo.Location = new System.Drawing.Point(369, 20);
            this.lblUserTabInfo.Name = "lblUserTabInfo";
            this.lblUserTabInfo.Size = new System.Drawing.Size(144, 23);
            this.lblUserTabInfo.TabIndex = 1;
            this.lblUserTabInfo.Text = "Kayıtlı Kullanıcılar";
            // 
            // listViewUsers
            // 
            this.listViewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewUsers.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewUsers.Location = new System.Drawing.Point(13, 46);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(840, 303);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 25);
            this.panel1.TabIndex = 4;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControlItems.ResumeLayout(false);
            this.tabPBook.ResumeLayout(false);
            this.tabPBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBook)).EndInit();
            this.tabPMagazine.ResumeLayout(false);
            this.tabPMagazine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMagazine)).EndInit();
            this.tabPMusicCD.ResumeLayout(false);
            this.tabPMusicCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMusic)).EndInit();
            this.tabPMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPUser.ResumeLayout(false);
            this.tabPUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlItems;
        private System.Windows.Forms.TabPage tabPBook;
        private System.Windows.Forms.TabPage tabPMagazine;
        private System.Windows.Forms.TabPage tabPMusicCD;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.NumericUpDown UpDownBook;
        private System.Windows.Forms.TextBox txtBookPage;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookNum;
        private System.Windows.Forms.Label lblBookPage;
        private System.Windows.Forms.ComboBox comBMagazineType;
        private System.Windows.Forms.NumericUpDown UpDownMagazine;
        private System.Windows.Forms.TextBox txtMagazineIssue;
        private System.Windows.Forms.TextBox txtMagazinePrice;
        private System.Windows.Forms.TextBox txtMagazineName;
        private System.Windows.Forms.Label lblMagazineNum;
        private System.Windows.Forms.Label lblMagazineType;
        private System.Windows.Forms.Label lblMagazineIssue;
        private System.Windows.Forms.Label lblMagazinePrice;
        private System.Windows.Forms.Label lblMagazineName;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.ComboBox comBMusicType;
        private System.Windows.Forms.NumericUpDown UpDownMusic;
        private System.Windows.Forms.TextBox txtMusicSinger;
        private System.Windows.Forms.TextBox txtMusicPrice;
        private System.Windows.Forms.TextBox txtMusicName;
        private System.Windows.Forms.Label lblMusicNum;
        private System.Windows.Forms.Label lblMusicType;
        private System.Windows.Forms.Label lblMusicSinger;
        private System.Windows.Forms.Label lblMusicPrice;
        private System.Windows.Forms.Label lblMusicName;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancelMagazine;
        private System.Windows.Forms.Button btnAddMagazine;
        private System.Windows.Forms.Button btnCancelMusic;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.TabPage tabPMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMainPageInfo;
        private System.Windows.Forms.RadioButton radioBtnMagazine;
        private System.Windows.Forms.RadioButton radioBtnMusicCD;
        private System.Windows.Forms.RadioButton radioBtnBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnItemRemove;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.Button btnMagazineEdit;
        private System.Windows.Forms.Button btnMusicEdit;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.ImageList imageListAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserPage;
        private System.Windows.Forms.TabPage tabPUser;
        private System.Windows.Forms.Button btnBackAdminPanel;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblUserTabInfo;
        private System.Windows.Forms.ListView listViewUsers;
    }
}