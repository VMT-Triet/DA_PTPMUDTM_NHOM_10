namespace DoAn_QuanLyCuaHangLaptop
{
    partial class ChiTietSP
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.txtOCung = new System.Windows.Forms.TextBox();
            this.txtHeDieuHanh = new System.Windows.Forms.TextBox();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.txtThoiDiemRaMat = new System.Windows.Forms.TextBox();
            this.txtCardManHinh = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChinhSua = new System.Windows.Forms.Panel();
            this.huyBtn = new FontAwesome.Sharp.IconButton();
            this.luuBtn = new FontAwesome.Sharp.IconButton();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dongFormBtn = new FontAwesome.Sharp.IconButton();
            this.themVaoHDBtn = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChinhSua.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.panelTop.Controls.Add(this.exitBtn);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(700, 50);
            this.panelTop.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitBtn.IconColor = System.Drawing.Color.White;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 32;
            this.exitBtn.Location = new System.Drawing.Point(650, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(50, 50);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(276, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sản phẩm";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.comboBox2);
            this.panelMain.Controls.Add(this.comboBox1);
            this.panelMain.Controls.Add(this.txtSoLuongTon);
            this.panelMain.Controls.Add(this.txtGia);
            this.panelMain.Controls.Add(this.txtCPU);
            this.panelMain.Controls.Add(this.txtRAM);
            this.panelMain.Controls.Add(this.txtManHinh);
            this.panelMain.Controls.Add(this.txtOCung);
            this.panelMain.Controls.Add(this.txtHeDieuHanh);
            this.panelMain.Controls.Add(this.txtKichThuoc);
            this.panelMain.Controls.Add(this.txtCanNang);
            this.panelMain.Controls.Add(this.txtThoiDiemRaMat);
            this.panelMain.Controls.Add(this.txtCardManHinh);
            this.panelMain.Controls.Add(this.label14);
            this.panelMain.Controls.Add(this.label13);
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.textBox1);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 750);
            this.panelMain.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 540);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 28);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(339, 642);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(350, 26);
            this.txtSoLuongTon.TabIndex = 29;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(15, 642);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(296, 26);
            this.txtGia.TabIndex = 28;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(425, 38);
            this.txtCPU.Multiline = true;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(268, 47);
            this.txtCPU.TabIndex = 25;
            this.txtCPU.Text = "Intel Core i5 Tiger Lake, 1135G7, 2.40 GHz";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(420, 116);
            this.txtRAM.Multiline = true;
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(268, 47);
            this.txtRAM.TabIndex = 24;
            this.txtRAM.Text = "8 GB, DDR3Intel Core i5 Tiger Lake, 1135G7, 2.40 GHzL(On board), 1600 MHz";
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(420, 350);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(268, 26);
            this.txtManHinh.TabIndex = 23;
            this.txtManHinh.Text = "15.6\", Full HD (1920 x 1080)";
            // 
            // txtOCung
            // 
            this.txtOCung.Location = new System.Drawing.Point(420, 194);
            this.txtOCung.Multiline = true;
            this.txtOCung.Name = "txtOCung";
            this.txtOCung.Size = new System.Drawing.Size(268, 47);
            this.txtOCung.TabIndex = 22;
            this.txtOCung.Text = "SSD 256GB NVMe PCIeIntel Core i5 Tiger Lake, 1135G7, 2.40 GHz";
            // 
            // txtHeDieuHanh
            // 
            this.txtHeDieuHanh.Location = new System.Drawing.Point(448, 398);
            this.txtHeDieuHanh.Name = "txtHeDieuHanh";
            this.txtHeDieuHanh.Size = new System.Drawing.Size(240, 26);
            this.txtHeDieuHanh.TabIndex = 21;
            this.txtHeDieuHanh.Text = "Windows 10 Home SL";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(420, 446);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(268, 26);
            this.txtKichThuoc.TabIndex = 20;
            this.txtKichThuoc.Text = "Dày 22.9 mm";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(420, 494);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(268, 26);
            this.txtCanNang.TabIndex = 19;
            this.txtCanNang.Text = "2.1kg";
            // 
            // txtThoiDiemRaMat
            // 
            this.txtThoiDiemRaMat.Location = new System.Drawing.Point(468, 542);
            this.txtThoiDiemRaMat.Name = "txtThoiDiemRaMat";
            this.txtThoiDiemRaMat.Size = new System.Drawing.Size(220, 26);
            this.txtThoiDiemRaMat.TabIndex = 18;
            this.txtThoiDiemRaMat.Text = "2020";
            // 
            // txtCardManHinh
            // 
            this.txtCardManHinh.Location = new System.Drawing.Point(446, 272);
            this.txtCardManHinh.Multiline = true;
            this.txtCardManHinh.Name = "txtCardManHinh";
            this.txtCardManHinh.Size = new System.Drawing.Size(240, 47);
            this.txtCardManHinh.TabIndex = 17;
            this.txtCardManHinh.Text = "Card đồ họa rời, NVIDIA GeForce GTX 1650 4GB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Cấu hình chi tiết";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(335, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Số lượng tồn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thời điểm ra mắt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cân nặng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kích thước:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hệ điều hành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Card màn hình:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Màn hình:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ổ cứng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hãng sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại Laptop";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 312);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 64);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Đặc điểm nổi bật của Acer Aspire 7 A715 42G R4ST R5 5500U/8GB/256GB/4GB GTX1650/W" +
    "in10 (NH.QAYSV.004)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChinhSua
            // 
            this.panelChinhSua.Controls.Add(this.huyBtn);
            this.panelChinhSua.Controls.Add(this.luuBtn);
            this.panelChinhSua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChinhSua.Location = new System.Drawing.Point(0, 740);
            this.panelChinhSua.Name = "panelChinhSua";
            this.panelChinhSua.Size = new System.Drawing.Size(700, 60);
            this.panelChinhSua.TabIndex = 5;
            // 
            // huyBtn
            // 
            this.huyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.huyBtn.FlatAppearance.BorderSize = 0;
            this.huyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huyBtn.ForeColor = System.Drawing.Color.White;
            this.huyBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.huyBtn.IconColor = System.Drawing.Color.Red;
            this.huyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.huyBtn.IconSize = 30;
            this.huyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.huyBtn.Location = new System.Drawing.Point(341, 11);
            this.huyBtn.Name = "huyBtn";
            this.huyBtn.Size = new System.Drawing.Size(101, 37);
            this.huyBtn.TabIndex = 1;
            this.huyBtn.Text = "Đóng";
            this.huyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.huyBtn.UseVisualStyleBackColor = false;
            this.huyBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.luuBtn.FlatAppearance.BorderSize = 0;
            this.luuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuBtn.ForeColor = System.Drawing.Color.White;
            this.luuBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.luuBtn.IconColor = System.Drawing.Color.White;
            this.luuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.luuBtn.IconSize = 30;
            this.luuBtn.Location = new System.Drawing.Point(205, 11);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(101, 37);
            this.luuBtn.TabIndex = 0;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luuBtn.UseVisualStyleBackColor = false;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dongFormBtn);
            this.panelHoaDon.Controls.Add(this.themVaoHDBtn);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 680);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(700, 60);
            this.panelHoaDon.TabIndex = 6;
            // 
            // dongFormBtn
            // 
            this.dongFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.dongFormBtn.FlatAppearance.BorderSize = 0;
            this.dongFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dongFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongFormBtn.ForeColor = System.Drawing.Color.White;
            this.dongFormBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.dongFormBtn.IconColor = System.Drawing.Color.Red;
            this.dongFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dongFormBtn.IconSize = 30;
            this.dongFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dongFormBtn.Location = new System.Drawing.Point(341, 11);
            this.dongFormBtn.Name = "dongFormBtn";
            this.dongFormBtn.Size = new System.Drawing.Size(101, 37);
            this.dongFormBtn.TabIndex = 1;
            this.dongFormBtn.Text = "Đóng";
            this.dongFormBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dongFormBtn.UseVisualStyleBackColor = false;
            this.dongFormBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // themVaoHDBtn
            // 
            this.themVaoHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(52)))), ((int)(((byte)(163)))));
            this.themVaoHDBtn.FlatAppearance.BorderSize = 0;
            this.themVaoHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themVaoHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themVaoHDBtn.ForeColor = System.Drawing.Color.White;
            this.themVaoHDBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.themVaoHDBtn.IconColor = System.Drawing.Color.Lime;
            this.themVaoHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themVaoHDBtn.IconSize = 30;
            this.themVaoHDBtn.Location = new System.Drawing.Point(102, 11);
            this.themVaoHDBtn.Name = "themVaoHDBtn";
            this.themVaoHDBtn.Size = new System.Drawing.Size(204, 37);
            this.themVaoHDBtn.TabIndex = 0;
            this.themVaoHDBtn.Text = "Thêm vào hóa đơn";
            this.themVaoHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themVaoHDBtn.UseVisualStyleBackColor = false;
            // 
            // ChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.panelChinhSua);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietSP";
            this.Text = "ChiTietSP";
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChinhSua.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelChinhSua;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.TextBox txtOCung;
        private System.Windows.Forms.TextBox txtHeDieuHanh;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.TextBox txtThoiDiemRaMat;
        private System.Windows.Forms.TextBox txtCardManHinh;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private FontAwesome.Sharp.IconButton huyBtn;
        private FontAwesome.Sharp.IconButton luuBtn;
        private System.Windows.Forms.Panel panelHoaDon;
        private FontAwesome.Sharp.IconButton dongFormBtn;
        private FontAwesome.Sharp.IconButton themVaoHDBtn;

    }
}