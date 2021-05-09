﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class ChiTietSP : Form
    {
        public ChiTietSP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public ChiTietSP(bool isEdit)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (isEdit)
            {
                this.panelHoaDon.Visible = false;
            }
            else
            {
                this.panelChinhSua.Visible = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}