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
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BindGrid(List<KhachHang> listKhachHang)
        {
            //dgvKH.Rows.Clear();
            //foreach (var item in listKhachHang)
            //{
            //    int index = dgvKH.Rows.Add();
            //    dgvKH.Rows[index].Cells[0].Value = item.MaKH;
            //    dgvKH.Rows[index].Cells[1].Value = item.TenKH;
            //    dgvKH.Rows[index].Cells[2].Value = item.DiaChi;
            //    dgvKH.Rows[index].Cells[3].Value = item.sdtKH;
            //    dgvKH.Rows[index].Cells[4].Value = item.cmtKH;
            //    dgvKH.Rows[index].Cells[5].Value = item.GPLX;
            //}
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            //QuanlythueotoEntities1 context = new QuanlythueotoEntities1();
            //List<KHACHHANG> listKhachHang = context.KHACHHANGs.ToList();
            //BindGrid(listKhachHang);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //KHACHHANG KhachHang = new KHACHHANG();
            //KhachHang.MaKH = txtMaKH.Text;
            //KhachHang.TenKH = txtTenKH.Text;
            //KhachHang.DiaChi = txtDiaChi.Text;
            //KhachHang.sdtKH = txtSDT.Text;
            //KhachHang.cmtKH = txtCMT.Text;
            //KhachHang.GPLX = txtGPLX.Text;
            //dgvKH.Rows.Add(1);
            //int index = dgvKH.Rows.Count - 1;
            //dgvKH.Rows[index - 1].Cells[0].Value = KhachHang.MaKH;
            //dgvKH.Rows[index - 1].Cells[1].Value = KhachHang.TenKH;
            //dgvKH.Rows[index - 1].Cells[2].Value = KhachHang.DiaChi;
            //dgvKH.Rows[index - 1].Cells[3].Value = KhachHang.sdtKH;
            //dgvKH.Rows[index - 1].Cells[4].Value = KhachHang.cmtKH;
            //dgvKH.Rows[index - 1].Cells[5].Value = KhachHang.GPLX;


            //if (KhachHangController.AddKhachHang(KhachHang))
            //{
            //    XtraMessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}    
            //else
            //    XtraMessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}