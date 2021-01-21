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
    public partial class DanhSachSuCocs : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachSuCocs()
        {
            InitializeComponent();
        }

        string GetMaBBSC { set; get; }

        private void BindGrid(List<BBSC> lstBBSC)
        {
            dgvBBSC.Rows.Clear();
            int i = 0;
            foreach (var item in lstBBSC)
            {
                using (CNPMEntities db = new CNPMEntities())
                {
                    var getnv = (from hd in db.BBSCs
                                 join nv in db.NhanViens on hd.idNV equals nv.idNV
                                 select nv).ToList();
                    var getkh = (from hd in db.BBSCs
                                 join kh in db.KhachHangs on hd.idKH equals kh.idKH
                                 select kh).ToList();
                    var xe = (from hd in db.BBSCs
                              join x in db.Xes on hd.idXe equals x.idXe
                              select x).ToList();

                    int index = dgvBBSC.Rows.Add();

                    dgvBBSC.Rows[index].Cells[0].Value = item.MaBBSC;
                    dgvBBSC.Rows[index].Cells[1].Value = xe[i].Biensoxe;
                    dgvBBSC.Rows[index].Cells[2].Value = getkh[i].MaKH;
                    dgvBBSC.Rows[index].Cells[3].Value = getnv[i].MaNV;
                    dgvBBSC.Rows[index].Cells[4].Value = item.TenSC;
                    dgvBBSC.Rows[index].Cells[5].Value = item.NgayBBSC;
                    dgvBBSC.Rows[index].Cells[6].Value = item.NoiDungSC;
                    dgvBBSC.Rows[index].Cells[7].Value = item.TienPhat;
                    i++;
                }

            }
        }

        private void DanhSachSuCocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlythueotoDataSet1.SUCO' table. You can move, or remove it, as needed.
            using (CNPMEntities db = new CNPMEntities())
            {
                var getnv = (from nv in db.NhanViens
                             select nv).ToList();
                var getkh = (from kh in db.KhachHangs
                             select kh).ToList();
                var xe = (from x in db.Xes
                          select x).ToList();
                this.cbbMaNV.DataSource = getnv;
                this.cbbMaNV.ValueMember = "idNV";
                this.cbbMaNV.DisplayMember = "MaNV";

                this.cbbMaKH.DataSource = getkh;
                this.cbbMaKH.ValueMember = "idKH";
                this.cbbMaKH.DisplayMember = "MaKH";

                this.cbbSoXe.DataSource = xe;
                this.cbbSoXe.ValueMember = "idXe";
                this.cbbSoXe.DisplayMember = "Biensoxe";

            }
            CNPMEntities context = new CNPMEntities();
            List<BBSC> lstBBSC = context.BBSCs.ToList();
            BindGrid(lstBBSC);
        }

        private void dgvBBSC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSua.Enabled = true;
            btXoa.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBBSC.Rows[e.RowIndex];
                txtSoBBSC.Text = row.Cells[0].Value.ToString();
                cbbSoXe.Text = row.Cells[1].Value.ToString();
                cbbMaNV.Text = row.Cells[2].Value.ToString();
                cbbMaKH.Text = row.Cells[3].Value.ToString();
                txtTenSC.Text = row.Cells[4].Value.ToString();
                msktbNgayBBSC.Text = row.Cells[5].Value.ToString();
                txtNDSC.Text = row.Cells[6].Value.ToString();
                txtTienPhat.Text = row.Cells[7].Value.ToString();
            }
            GetMaBBSC = txtSoBBSC.Text.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BBSC bbsc = new BBSC();
            try
            {

                bbsc.MaBBSC = txtSoBBSC.Text;
                bbsc.idXe = (int)cbbSoXe.SelectedValue;
                bbsc.idKH = (int)cbbMaKH.SelectedValue;
                bbsc.idNV = (int)cbbMaNV.SelectedValue;
                bbsc.TenSC = txtTenSC.Text;
                bbsc.NgayBBSC = DateTime.Parse(msktbNgayBBSC.Text.ToString());
                bbsc.NoiDungSC = txtNDSC.Text;
                bbsc.TienPhat = txtTienPhat.Text;
                if (BBSCController.AddBBSC(bbsc))
                {
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CNPMEntities context = new CNPMEntities();
                List<BBSC> lstBBSC = context.BBSCs.ToList();
                BindGrid(lstBBSC);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin cần nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            using (CNPMEntities db = new CNPMEntities())
            {
                var bbsc = (from bb in db.BBSCs
                            where bb.MaBBSC == GetMaBBSC
                            select bb).FirstOrDefault();
                bbsc.MaBBSC = txtSoBBSC.Text;
                bbsc.idXe = (int)cbbSoXe.SelectedValue;
                bbsc.idNV = (int)cbbMaNV.SelectedValue;
                bbsc.idKH = (int)cbbMaKH.SelectedValue;
                bbsc.TenSC = txtTenSC.Text;
                bbsc.NgayBBSC = DateTime.Parse(msktbNgayBBSC.Text.ToString());
                bbsc.NoiDungSC = txtNDSC.Text;
                bbsc.TienPhat = txtTienPhat.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Edit success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetMaBBSC = null;

            CNPMEntities context = new CNPMEntities();
            List<BBSC> lstBBSC = context.BBSCs.ToList();
            BindGrid(lstBBSC);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }
    }
}