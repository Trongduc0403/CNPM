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
using QuanLyChoThueOto.Controller;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto
{
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //NHANVIEN NhanVien= new NHANVIEN();
            //NhanVien.MaNV = txtMaNV.Text;
            //NhanVien.TenNV = txtTenNV.Text;
            //NhanVien.VaiTro = txtVaiTro.Text;
            //NhanVien.sdtNV = txtSDT.Text;
            //NhanVien.cmtNV = txtCMT.Text;
            
            //dgvNV.Rows.Add(1);
            //int index = dgvNV.Rows.Count - 1;
            //dgvNV.Rows[index - 1].Cells[0].Value = NhanVien.MaNV;
            //dgvNV.Rows[index - 1].Cells[1].Value = NhanVien.TenNV;
            //dgvNV.Rows[index - 1].Cells[2].Value = NhanVien.VaiTro;
            //dgvNV.Rows[index - 1].Cells[3].Value = NhanVien.sdtNV;
            //dgvNV.Rows[index - 1].Cells[4].Value = NhanVien.cmtNV;


            //if (NhanVienController.AddNhanVien(NhanVien))
            //{
            //    XtraMessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //    XtraMessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BindGrid(List<NhanVien> listNhanVien)
        {
            //dgvNV.Rows.Clear();
            //foreach (var item in listNhanVien)
            //{
            //    int index = dgvNV.Rows.Add();
            //    dgvNV.Rows[index].Cells[0].Value = item.MaNV;
            //    dgvNV.Rows[index].Cells[1].Value = item.TenNV;
            //    dgvNV.Rows[index].Cells[2].Value = item.VaiTro;
            //    dgvNV.Rows[index].Cells[3].Value = item.sdtNV;
            //    dgvNV.Rows[index].Cells[4].Value = item.cmtNV;
            //}
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            //CNPMEntities context = new CNPMEntities();
            //List<NHANVIEN> listNhanVien = context.NHANVIENs.ToList();
            //BindGrid(listNhanVien);
        }
    }
}