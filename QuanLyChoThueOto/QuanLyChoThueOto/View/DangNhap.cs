using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace QuanLyChoThueOto
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            string user = "123";
            string pass = "123";
            if (user.Equals(txtTaiKhoan.Text) && pass.Equals(txtMatKhau.Text))
            {
                ManHinhChinh m = new ManHinhChinh();
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Dark Style";
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            skin();
        }
    }
}