namespace DemoQuanLyThuVien
{
    partial class fRentBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvRentBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDmsVH = new System.Windows.Forms.Button();
            this.btDmsManga = new System.Windows.Forms.Button();
            this.btDmsCNTT = new System.Windows.Forms.Button();
            this.btDmsDoujin = new System.Windows.Forms.Button();
            this.btDMSLN = new System.Windows.Forms.Button();
            this.btDMSAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvChecked = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbfebMSSV = new System.Windows.Forms.Label();
            this.lbfrbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirmRent = new System.Windows.Forms.Button();
            this.btfRBDeselect = new System.Windows.Forms.Button();
            this.btThanThanh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnReturnfRentBook = new System.Windows.Forms.ToolStripMenuItem();
            this.discountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtgvRentBook);
            this.panel1.Location = new System.Drawing.Point(244, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 250);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 0);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(724, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvRentBook
            // 
            this.dtgvRentBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRentBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.releaseYear,
            this.nameAuthor,
            this.nameNXB,
            this.price});
            this.dtgvRentBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvRentBook.Location = new System.Drawing.Point(0, 41);
            this.dtgvRentBook.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRentBook.Name = "dtgvRentBook";
            this.dtgvRentBook.Size = new System.Drawing.Size(724, 209);
            this.dtgvRentBook.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.Width = 25;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Mã sách";
            this.idCategory.Name = "idCategory";
            this.idCategory.Width = 50;
            // 
            // releaseYear
            // 
            this.releaseYear.DataPropertyName = "releaseYear";
            this.releaseYear.HeaderText = "Năm sản xuất";
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Width = 45;
            // 
            // nameAuthor
            // 
            this.nameAuthor.DataPropertyName = "nameAuthor";
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.Width = 70;
            // 
            // nameNXB
            // 
            this.nameNXB.DataPropertyName = "nameNXB";
            this.nameNXB.HeaderText = "Nhà xuất bản";
            this.nameNXB.Name = "nameNXB";
            this.nameNXB.Width = 55;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.Width = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDmsVH);
            this.panel2.Controls.Add(this.btDmsManga);
            this.panel2.Controls.Add(this.btDmsCNTT);
            this.panel2.Controls.Add(this.btDmsDoujin);
            this.panel2.Controls.Add(this.btDMSLN);
            this.panel2.Controls.Add(this.btDMSAll);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 241);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 288);
            this.panel2.TabIndex = 0;
            // 
            // btDmsVH
            // 
            this.btDmsVH.BackColor = System.Drawing.Color.White;
            this.btDmsVH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsVH.Location = new System.Drawing.Point(4, 249);
            this.btDmsVH.Margin = new System.Windows.Forms.Padding(4);
            this.btDmsVH.Name = "btDmsVH";
            this.btDmsVH.Size = new System.Drawing.Size(212, 34);
            this.btDmsVH.TabIndex = 1;
            this.btDmsVH.Text = "Văn học";
            this.btDmsVH.UseVisualStyleBackColor = false;
            this.btDmsVH.Click += new System.EventHandler(this.btDmsVH_Click);
            // 
            // btDmsManga
            // 
            this.btDmsManga.BackColor = System.Drawing.Color.White;
            this.btDmsManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsManga.Location = new System.Drawing.Point(4, 207);
            this.btDmsManga.Margin = new System.Windows.Forms.Padding(4);
            this.btDmsManga.Name = "btDmsManga";
            this.btDmsManga.Size = new System.Drawing.Size(212, 34);
            this.btDmsManga.TabIndex = 1;
            this.btDmsManga.Text = "manga";
            this.btDmsManga.UseVisualStyleBackColor = false;
            this.btDmsManga.Click += new System.EventHandler(this.btDmsManga_Click);
            // 
            // btDmsCNTT
            // 
            this.btDmsCNTT.BackColor = System.Drawing.Color.White;
            this.btDmsCNTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsCNTT.Location = new System.Drawing.Point(4, 165);
            this.btDmsCNTT.Margin = new System.Windows.Forms.Padding(4);
            this.btDmsCNTT.Name = "btDmsCNTT";
            this.btDmsCNTT.Size = new System.Drawing.Size(212, 34);
            this.btDmsCNTT.TabIndex = 1;
            this.btDmsCNTT.Text = "Công nghệ thông tin";
            this.btDmsCNTT.UseVisualStyleBackColor = false;
            this.btDmsCNTT.Click += new System.EventHandler(this.btDmsCNTT_Click);
            // 
            // btDmsDoujin
            // 
            this.btDmsDoujin.BackColor = System.Drawing.Color.White;
            this.btDmsDoujin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDmsDoujin.Location = new System.Drawing.Point(4, 123);
            this.btDmsDoujin.Margin = new System.Windows.Forms.Padding(4);
            this.btDmsDoujin.Name = "btDmsDoujin";
            this.btDmsDoujin.Size = new System.Drawing.Size(212, 34);
            this.btDmsDoujin.TabIndex = 1;
            this.btDmsDoujin.Text = "doujinshi";
            this.btDmsDoujin.UseVisualStyleBackColor = false;
            this.btDmsDoujin.Click += new System.EventHandler(this.btDmsDoujin_Click);
            // 
            // btDMSLN
            // 
            this.btDMSLN.BackColor = System.Drawing.Color.White;
            this.btDMSLN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDMSLN.Location = new System.Drawing.Point(4, 81);
            this.btDMSLN.Margin = new System.Windows.Forms.Padding(4);
            this.btDMSLN.Name = "btDMSLN";
            this.btDMSLN.Size = new System.Drawing.Size(212, 34);
            this.btDMSLN.TabIndex = 1;
            this.btDMSLN.Text = "light novel";
            this.btDMSLN.UseVisualStyleBackColor = false;
            this.btDMSLN.Click += new System.EventHandler(this.btDMSLN_Click);
            // 
            // btDMSAll
            // 
            this.btDMSAll.BackColor = System.Drawing.Color.White;
            this.btDMSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDMSAll.Location = new System.Drawing.Point(4, 39);
            this.btDMSAll.Margin = new System.Windows.Forms.Padding(4);
            this.btDMSAll.Name = "btDMSAll";
            this.btDMSAll.Size = new System.Drawing.Size(212, 34);
            this.btDMSAll.TabIndex = 1;
            this.btDMSAll.Text = "All";
            this.btDMSAll.UseVisualStyleBackColor = false;
            this.btDMSAll.Click += new System.EventHandler(this.btDMSAll_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvChecked);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(487, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 164);
            this.panel3.TabIndex = 0;
            // 
            // lsvChecked
            // 
            this.lsvChecked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvChecked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvChecked.Location = new System.Drawing.Point(0, 32);
            this.lsvChecked.Name = "lsvChecked";
            this.lsvChecked.Size = new System.Drawing.Size(481, 132);
            this.lsvChecked.TabIndex = 1;
            this.lsvChecked.UseCompatibleStateImageBehavior = false;
            this.lsvChecked.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sách đã chọn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbfebMSSV);
            this.panel4.Controls.Add(this.lbfrbName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(16, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 199);
            this.panel4.TabIndex = 0;
            // 
            // lbfebMSSV
            // 
            this.lbfebMSSV.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbfebMSSV.Location = new System.Drawing.Point(143, 85);
            this.lbfebMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfebMSSV.Name = "lbfebMSSV";
            this.lbfebMSSV.Size = new System.Drawing.Size(267, 25);
            this.lbfebMSSV.TabIndex = 3;
            // 
            // lbfrbName
            // 
            this.lbfrbName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbfrbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbfrbName.Location = new System.Drawing.Point(143, 41);
            this.lbfrbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfrbName.Name = "lbfrbName";
            this.lbfrbName.Size = new System.Drawing.Size(267, 27);
            this.lbfrbName.TabIndex = 3;
            this.lbfrbName.Click += new System.EventHandler(this.lbfrbName_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(143, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 130);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "MSSV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin của bạn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btConfirmRent
            // 
            this.btConfirmRent.Location = new System.Drawing.Point(531, 207);
            this.btConfirmRent.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirmRent.Name = "btConfirmRent";
            this.btConfirmRent.Size = new System.Drawing.Size(128, 31);
            this.btConfirmRent.TabIndex = 0;
            this.btConfirmRent.Text = "Hoàn tất mượn";
            this.btConfirmRent.UseVisualStyleBackColor = true;
            this.btConfirmRent.Click += new System.EventHandler(this.btConfirmRent_Click);
            // 
            // btfRBDeselect
            // 
            this.btfRBDeselect.Location = new System.Drawing.Point(728, 207);
            this.btfRBDeselect.Margin = new System.Windows.Forms.Padding(4);
            this.btfRBDeselect.Name = "btfRBDeselect";
            this.btfRBDeselect.Size = new System.Drawing.Size(128, 31);
            this.btfRBDeselect.TabIndex = 0;
            this.btfRBDeselect.Text = "Bỏ chọn";
            this.btfRBDeselect.UseVisualStyleBackColor = true;
            // 
            // btThanThanh
            // 
            this.btThanThanh.Location = new System.Drawing.Point(728, 498);
            this.btThanThanh.Margin = new System.Windows.Forms.Padding(4);
            this.btThanThanh.Name = "btThanThanh";
            this.btThanThanh.Size = new System.Drawing.Size(128, 31);
            this.btThanThanh.TabIndex = 0;
            this.btThanThanh.Text = "Thêm";
            this.btThanThanh.UseVisualStyleBackColor = true;
            this.btThanThanh.Click += new System.EventHandler(this.btThanThanh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReturnfRentBook,
            this.discountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1239, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnReturnfRentBook
            // 
            this.mnReturnfRentBook.Name = "mnReturnfRentBook";
            this.mnReturnfRentBook.Size = new System.Drawing.Size(62, 24);
            this.mnReturnfRentBook.Text = "Home";
            this.mnReturnfRentBook.Click += new System.EventHandler(this.mnReturnfRentBook_Click);
            // 
            // discountToolStripMenuItem
            // 
            this.discountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpMãToolStripMenuItem});
            this.discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            this.discountToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.discountToolStripMenuItem.Text = "Discount";
            // 
            // nhậpMãToolStripMenuItem
            // 
            this.nhậpMãToolStripMenuItem.Name = "nhậpMãToolStripMenuItem";
            this.nhậpMãToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.nhậpMãToolStripMenuItem.Text = "Nhập mã";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(976, 282);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 247);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(976, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            // 
            // fRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btThanThanh);
            this.Controls.Add(this.btfRBDeselect);
            this.Controls.Add(this.btConfirmRent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fRentBook";
            this.Text = "fRentBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRentBook_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btConfirmRent;
        private System.Windows.Forms.Button btfRBDeselect;
        private System.Windows.Forms.Button btThanThanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvRentBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnReturnfRentBook;
        private System.Windows.Forms.ToolStripMenuItem discountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMãToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbfebMSSV;
        private System.Windows.Forms.Label lbfrbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btDmsVH;
        private System.Windows.Forms.Button btDmsManga;
        private System.Windows.Forms.Button btDmsCNTT;
        private System.Windows.Forms.Button btDmsDoujin;
        private System.Windows.Forms.Button btDMSLN;
        private System.Windows.Forms.Button btDMSAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lsvChecked;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}