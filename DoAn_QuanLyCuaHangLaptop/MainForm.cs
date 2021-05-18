using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoAn_QuanLyCuaHangLaptop
{
    public partial class MainForm : Form
    {
        
        IconButton currentButton = null;
        Panel leftBorder = null;
        Form currentForm = null;

        public MainForm()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorder);
        }
        struct myColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        void activeButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = sender as IconButton;
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.ForeColor = color;
                currentButton.IconColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentButton.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();

            }
        }
        
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = panelMenu.BackColor;
                currentButton.IconColor = Color.White;
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        void reset()
        {
            DisableButton();

            leftBorder.Visible = false;

        }
        private void openForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = form;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
        private void sanPhamBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color1);
            openForm(new SanPhamForm(true));
        }

        private void hoaDonBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color2);
            openForm(new HoaDonForm());
        }

        private void nhaSanXuatBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color3);
            openForm(new NhaSanXuatForm());
        }
        
        private void nhanVienBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color4);
            openForm(new NhanVienForm());
            
        }

        private void quanLySanPhamBtn_Click(object sender, EventArgs e)
        {
            activeButton(sender, myColors.color5);
            openForm(new QLSanPhamForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát!","Xác nhận thoát?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;              
            }
            
            //DangNhapForm dangnhap = new DangNhapForm();
            //dangnhap.Show();
        }
    }
}
