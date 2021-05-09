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
    public partial class SanPhamForm : Form
    {
        bool isEdit;
        public SanPhamForm()
        {
            InitializeComponent();
        }
        public SanPhamForm(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            if(isEdit){
                this.panelHoaDon.Visible = false;
            }
            else
            {
                this.panelSanPham.Visible = false;
            }
        }

        private void xemchitietBtn_Click(object sender, EventArgs e)
        {
            ChiTietSP ctspfrm = new ChiTietSP(isEdit);
            ctspfrm.ShowDialog();
        }
    }
}
