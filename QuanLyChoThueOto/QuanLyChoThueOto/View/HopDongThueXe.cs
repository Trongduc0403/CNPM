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
            HopDong hopdong = new HopDong();
            hopdong.idHopDong = int.Parse(txtSoDH.Text);
            hopdong.idXe = int.Parse(cbbSoXe.Text);
            hopdong.idKH = int.Parse(txtMaKH.Text);
            //hopdong.Ngày_HĐ = DateTime.Parse(msktbNgayHD.Text);
            hopdong.NoiDungHD = this.txtNoiDungHD.Text.ToString();
            hopdong.TienDat = this.txtTienDat.Text.ToString();
            hopdong.KhuyenMai = this.txtKhuyenMai.Text.ToString();
            hopdong.GiayToGiuLai = this.txtGiayTo.Text.ToString();
            if(HopDongController.AddHopDong(hopdong))
            {
                MessageBox.Show("ok");
            }
            MessageBox.Show("Fail");

        }
    }
}