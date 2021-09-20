namespace BookStore
{
    partial class FormWishList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWishList));
            this.listViewMyCart = new System.Windows.Forms.ListView();
            this.groupBoxInfoP2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCurrentUserInfo = new System.Windows.Forms.Label();
            this.ımageListWish = new System.Windows.Forms.ImageList(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut2 = new System.Windows.Forms.Button();
            this.groupBoxInfoP2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMyCart
            // 
            this.listViewMyCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewMyCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewMyCart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewMyCart.Location = new System.Drawing.Point(0, 108);
            this.listViewMyCart.Name = "listViewMyCart";
            this.listViewMyCart.Size = new System.Drawing.Size(554, 242);
            this.listViewMyCart.TabIndex = 0;
            this.listViewMyCart.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxInfoP2
            // 
            this.groupBoxInfoP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxInfoP2.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxInfoP2.Location = new System.Drawing.Point(402, 12);
            this.groupBoxInfoP2.Name = "groupBoxInfoP2";
            this.groupBoxInfoP2.Size = new System.Drawing.Size(137, 90);
            this.groupBoxInfoP2.TabIndex = 15;
            this.groupBoxInfoP2.TabStop = false;
            this.groupBoxInfoP2.Text = "User";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel2.Controls.Add(this.lbCurrentUserInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogOut2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(131, 71);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lbCurrentUserInfo
            // 
            this.lbCurrentUserInfo.AutoSize = true;
            this.lbCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurrentUserInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCurrentUserInfo.Location = new System.Drawing.Point(3, 0);
            this.lbCurrentUserInfo.Name = "lbCurrentUserInfo";
            this.lbCurrentUserInfo.Size = new System.Drawing.Size(0, 39);
            this.lbCurrentUserInfo.TabIndex = 7;
            this.lbCurrentUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ımageListWish
            // 
            this.ımageListWish.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListWish.ImageStream")));
            this.ımageListWish.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListWish.Images.SetKeyName(0, "home.ico");
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(220, 68);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(87, 25);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "SEPETİM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut2
            // 
            this.btnLogOut2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogOut2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut2.ImageIndex = 0;
            this.btnLogOut2.ImageList = this.ımageListWish;
            this.btnLogOut2.Location = new System.Drawing.Point(3, 42);
            this.btnLogOut2.Name = "btnLogOut2";
            this.btnLogOut2.Size = new System.Drawing.Size(125, 26);
            this.btnLogOut2.TabIndex = 6;
            this.btnLogOut2.Text = "Ana Menü";
            this.btnLogOut2.UseVisualStyleBackColor = true;
            this.btnLogOut2.Click += new System.EventHandler(this.btnLogOut2_Click);
            // 
            // FormWishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(554, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBoxInfoP2);
            this.Controls.Add(this.listViewMyCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWishList";
            this.Text = "Bookstore";
            this.Activated += new System.EventHandler(this.FormWishList_Activated);
            this.Load += new System.EventHandler(this.FormWishList_Load);
            this.groupBoxInfoP2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMyCart;
        private System.Windows.Forms.GroupBox groupBoxInfoP2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbCurrentUserInfo;
        private System.Windows.Forms.Button btnLogOut2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ImageList ımageListWish;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}