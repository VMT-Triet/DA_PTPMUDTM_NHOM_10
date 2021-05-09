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
    public partial class HoaDonForm : Form
    {
        public HoaDonForm()
        {
            InitializeComponent();
        }

        private void themHDBtn_Click(object sender, EventArgs e)
        {
            SanPhamForm spfrm = new SanPhamForm(false);
            spfrm.ShowDialog();
        }
    }
}
