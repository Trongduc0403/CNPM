﻿using DevExpress.XtraEditors;
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
    public partial class ManHinhChinh : DevExpress.XtraEditors.XtraForm
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }



        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "DevExpress Style";
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlythueotoDataSet5.XE' table. You can move, or remove it, as needed.
            skin();

        }

        private void btDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }


        private void btXeDaThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btDangKyThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LichChoThue f = new LichChoThue();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HopDongThueXe f = new HopDongThueXe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btBBGiaoNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BBGN f = new BBGN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btXeRanh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}