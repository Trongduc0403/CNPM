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
using QuanLyChoThueOto.Models;
using QuanLyChoThueOto.Controller;

namespace QuanLyChoThueOto
{
    public partial class HopDongThueXe : DevExpress.XtraEditors.XtraForm
    {
        public HopDongThueXe()
        {
            InitializeComponent();
        }

        private void HopDongThueXe_Load(object sender, EventArgs e)
        {

        }





        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HOPDONG hopdong = new HOPDONG();
            hopdong.Số_HĐ = txtSoDH.Text.ToString();
            hopdong.Số_xe = cbbSoXe.Text.ToString();
            hopdong.Mã_KH = txtMaKH.Text.ToString();
            //hopdong.Ngày_HĐ = DateTime.Parse(msktbNgayHD.Text);
            hopdong.Nội_dung_HĐ = this.txtNoiDungHD.Text.ToString();
            hopdong.Tiền_đặt = this.txtTienDat.Text.ToString();
            hopdong.Khuyến_mãi = this.txtKhuyenMai.Text.ToString();
            hopdong.Giấy_tờ_giữ_lại = this.txtGiayTo.Text.ToString();
            if(HopDongController.AddHopDong(hopdong))
            {
                MessageBox.Show("ok");
            }
            MessageBox.Show("Fail");

        }
    }
}