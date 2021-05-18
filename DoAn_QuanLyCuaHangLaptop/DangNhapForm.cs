using System;
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
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
            //this.Hide();
        }

        private void DangNhapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát!", "Xác nhận thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyForm dangky = new DangKyForm();
            dangky.ShowDialog();            
        }

       
    }
}
