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

        private void BindGrid(List<HopDong> listHopDong)
        {
            dgvHD.Rows.Clear();
            foreach (var item in listHopDong)
            {
                int index = dgvHD.Rows.Add();
                dgvHD.Rows[index].Cells[0].Value = item.idHopDong;
                dgvHD.Rows[index].Cells[1].Value = item.idXe;
                dgvHD.Rows[index].Cells[2].Value = item.idNV;
                dgvHD.Rows[index].Cells[3].Value = item.idKH;
                dgvHD.Rows[index].Cells[4].Value = item.NgayHD;
                dgvHD.Rows[index].Cells[5].Value = item.TienDat;
                dgvHD.Rows[index].Cells[6].Value = item.KhuyenMai;
                dgvHD.Rows[index].Cells[7].Value = item.NoiDungHD;
                dgvHD.Rows[index].Cells[8].Value = item.GiayToGiuLai;
            }
        }
        private void FillMaKHCombobox(List<KhachHang> listKhachHang)
        {
            this.cbbMaKH.DataSource = listKhachHang;
            this.cbbMaKH.DisplayMember = "idKH";
        }

        private void FillMaNVCombobox(List<NhanVien> listNHANVIENs)
        {
            this.cbbMaNV.DataSource = listNHANVIENs;
            this.cbbMaNV.DisplayMember = "idNV";
        }

        private void FillSoXeCombobox(List<Xe> listXE)
        {
            this.cbbSoXe.DataSource = listXE;
            this.cbbSoXe.DisplayMember = "idXe";
        }


        private void HopDongThueXe_Load(object sender, EventArgs e)
        {
            CNPMEntities context = new CNPMEntities();
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            List<NhanVien> listNhanVien = context.NhanViens.ToList();
            List<HopDong> listHopDong = context.HopDongs.ToList();
            List<Xe> listXes = context.Xes.ToList();
            FillMaKHCombobox(listKhachHang);
            FillMaNVCombobox(listNhanVien);
            FillSoXeCombobox(listXes);
            BindGrid(listHopDong);
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
            hopdong.idNV = int.Parse(cbbMaNV.Text);
            hopdong.idKH = int.Parse(cbbMaKH.Text);
            hopdong.NgayHD = DateTime.Parse(msktbNgayHD.Text.ToString());
            hopdong.TienDat = txtTienDat.Text;
            hopdong.KhuyenMai = txtKhuyenMai.Text;
            hopdong.NoiDungHD = txtNoiDungHD.Text;
            hopdong.GiayToGiuLai = txtGiayTo.Text;

            dgvHD.Rows.Add(1);
            int index = dgvHD.Rows.Count - 1;
            dgvHD.Rows[index - 1].Cells[0].Value = hopdong.idHopDong;
            dgvHD.Rows[index - 1].Cells[1].Value = hopdong.idXe;
            dgvHD.Rows[index - 1].Cells[2].Value = hopdong.idNV;
            dgvHD.Rows[index - 1].Cells[3].Value = hopdong.idKH;
            dgvHD.Rows[index - 1].Cells[4].Value = hopdong.NgayHD;
            dgvHD.Rows[index - 1].Cells[5].Value = hopdong.TienDat;
            dgvHD.Rows[index - 1].Cells[6].Value = hopdong.KhuyenMai;
            dgvHD.Rows[index - 1].Cells[7].Value = hopdong.NoiDungHD;
            dgvHD.Rows[index - 1].Cells[8].Value = hopdong.GiayToGiuLai;
            if (HopDongController.AddHopDong(hopdong))
            {
                MessageBox.Show("ok");
            }
            else
                MessageBox.Show("Fail");

        }
    }
}