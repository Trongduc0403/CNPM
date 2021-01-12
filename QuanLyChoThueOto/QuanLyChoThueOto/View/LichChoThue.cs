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

namespace QuanLyChoThueOto
{
    public partial class LichChoThue : DevExpress.XtraEditors.XtraForm
    {
        public LichChoThue()
        {
            InitializeComponent();
        }

        private void LichChoThue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlythueotoDataSet4.LICHCHOTHUE' table. You can move, or remove it, as needed.

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DangKyThueXe f = new DangKyThueXe();
            f.Show();
        }
    }
}