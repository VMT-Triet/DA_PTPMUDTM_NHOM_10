namespace DoAn_QuanLyCuaHangLaptop
{
    partial class SanPhamForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.xoaBtn = new FontAwesome.Sharp.IconButton();
            this.xemchitietBtn = new FontAwesome.Sharp.IconButton();
            this.themBtn = new FontAwesome.Sharp.IconButton();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.dongFormBtn = new FontAwesome.Sharp.IconButton();
            this.themVaoHDBtn = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xemchitietBtn1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panelSanPham.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 60);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(865, 26);
            this.textBox1.TabIndex = 0;
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.xemchitietBtn1);
            this.panelSanPham.Controls.Add(this.xoaBtn);
            this.panelSanPham.Controls.Add(this.themBtn);
            this.panelSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSanPham.Location = new System.Drawing.Point(0, 639);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(1178, 60);
            this.panelSanPham.TabIndex = 3;
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.xoaBtn.FlatAppearance.BorderSize = 0;
            this.xoaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.ForeColor = System.Drawing.Color.White;
            this.xoaBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.xoaBtn.IconColor = System.Drawing.Color.Red;
            this.xoaBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoaBtn.IconSize = 36;
            this.xoaBtn.Location = new System.Drawing.Point(359, 8);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(111, 45);
            this.xoaBtn.TabIndex = 2;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoaBtn.UseVisualStyleBackColor = false;
            // 
            // xemchitietBtn
            // 
            this.xemchitietBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.xemchitietBtn.FlatAppearance.BorderSize = 0;
            this.xemchitietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xemchitietBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemchitietBtn.ForeColor = System.Drawing.Color.White;
            this.xemchitietBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.xemchitietBtn.IconColor = System.Drawing.Color.Orange;
            this.xemchitietBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xemchitietBtn.IconSize = 36;
            this.xemchitietBtn.Location = new System.Drawing.Point(267, 9);
            this.xemchitietBtn.Name = "xemchitietBtn";
            this.xemchitietBtn.Size = new System.Drawing.Size(165, 45);
            this.xemchitietBtn.TabIndex = 1;
            this.xemchitietBtn.Text = "Xem chi tiết";
            this.xemchitietBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xemchitietBtn.UseVisualStyleBackColor = false;
            this.xemchitietBtn.Click += new System.EventHandler(this.xemchitietBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.themBtn.FlatAppearance.BorderSize = 0;
            this.themBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.ForeColor = System.Drawing.Color.White;
            this.themBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.themBtn.IconColor = System.Drawing.Color.Green;
            this.themBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themBtn.IconSize = 36;
            this.themBtn.Location = new System.Drawing.Point(61, 8);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(111, 45);
            this.themBtn.TabIndex = 0;
            this.themBtn.Text = "Thêm";
            this.themBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themBtn.UseVisualStyleBackColor = false;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.dongFormBtn);
            this.panelHoaDon.Controls.Add(this.xemchitietBtn);
            this.panelHoaDon.Controls.Add(this.themVaoHDBtn);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 579);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(1178, 60);
            this.panelHoaDon.TabIndex = 4;
            // 
            // dongFormBtn
            // 
            this.dongFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.dongFormBtn.FlatAppearance.BorderSize = 0;
            this.dongFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dongFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongFormBtn.ForeColor = System.Drawing.Color.White;
            this.dongFormBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.dongFormBtn.IconColor = System.Drawing.Color.Red;
            this.dongFormBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dongFormBtn.IconSize = 36;
            this.dongFormBtn.Location = new System.Drawing.Point(438, 9);
            this.dongFormBtn.Name = "dongFormBtn";
            this.dongFormBtn.Size = new System.Drawing.Size(111, 45);
            this.dongFormBtn.TabIndex = 2;
            this.dongFormBtn.Text = "Đóng";
            this.dongFormBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dongFormBtn.UseVisualStyleBackColor = false;
            // 
            // themVaoHDBtn
            // 
            this.themVaoHDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.themVaoHDBtn.FlatAppearance.BorderSize = 0;
            this.themVaoHDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themVaoHDBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themVaoHDBtn.ForeColor = System.Drawing.Color.White;
            this.themVaoHDBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.themVaoHDBtn.IconColor = System.Drawing.Color.Green;
            this.themVaoHDBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.themVaoHDBtn.IconSize = 36;
            this.themVaoHDBtn.Location = new System.Drawing.Point(61, 8);
            this.themVaoHDBtn.Name = "themVaoHDBtn";
            this.themVaoHDBtn.Size = new System.Drawing.Size(200, 45);
            this.themVaoHDBtn.TabIndex = 0;
            this.themVaoHDBtn.Text = "Thêm vào hóa đơn";
            this.themVaoHDBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.themVaoHDBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 519);
            this.dataGridView1.TabIndex = 5;
            // 
            // xemchitietBtn1
            // 
            this.xemchitietBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(14)))), ((int)(((byte)(84)))));
            this.xemchitietBtn1.FlatAppearance.BorderSize = 0;
            this.xemchitietBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xemchitietBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemchitietBtn1.ForeColor = System.Drawing.Color.White;
            this.xemchitietBtn1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.xemchitietBtn1.IconColor = System.Drawing.Color.Orange;
            this.xemchitietBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xemchitietBtn1.IconSize = 36;
            this.xemchitietBtn1.Location = new System.Drawing.Point(188, 8);
            this.xemchitietBtn1.Name = "xemchitietBtn1";
            this.xemchitietBtn1.Size = new System.Drawing.Size(165, 45);
            this.xemchitietBtn1.TabIndex = 3;
            this.xemchitietBtn1.Text = "Xem chi tiết";
            this.xemchitietBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xemchitietBtn1.UseVisualStyleBackColor = false;
            this.xemchitietBtn1.Click += new System.EventHandler(this.xemchitietBtn_Click);
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 699);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.panelSanPham);
            this.Controls.Add(this.panel2);
            this.Name = "SanPhamForm";
            this.Text = "SanPhamForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSanPham.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelSanPham;
        private FontAwesome.Sharp.IconButton xoaBtn;
        private FontAwesome.Sharp.IconButton xemchitietBtn;
        private FontAwesome.Sharp.IconButton themBtn;
        private System.Windows.Forms.Panel panelHoaDon;
        private FontAwesome.Sharp.IconButton dongFormBtn;
        private FontAwesome.Sharp.IconButton themVaoHDBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton xemchitietBtn1;

    }
}