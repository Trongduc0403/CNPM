
namespace QuanLyChoThueOto
{
    partial class DanhSachSuCocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSuCocs));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBBSC = new System.Windows.Forms.DataGridView();
            this.msktbNgayBBSC = new System.Windows.Forms.MaskedTextBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.cbbSoXe = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenSC = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.txtNDSC = new System.Windows.Forms.TextBox();
            this.txtSoBBSC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenSC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.clSBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBSC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(304, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách sự cố";
            // 
            // dgvBBSC
            // 
            this.dgvBBSC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBBSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBBSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSBB,
            this.clSoXe,
            this.clMaKH,
            this.clMaNV,
            this.clTenSC,
            this.clNgayBB,
            this.clND,
            this.clTienPhat});
            this.dgvBBSC.Location = new System.Drawing.Point(307, 40);
            this.dgvBBSC.Name = "dgvBBSC";
            this.dgvBBSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBBSC.Size = new System.Drawing.Size(735, 430);
            this.dgvBBSC.TabIndex = 18;
            this.dgvBBSC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBBSC_CellMouseClick);
            // 
            // msktbNgayBBSC
            // 
            this.msktbNgayBBSC.Font = new System.Drawing.Font("Tahoma", 14F);
            this.msktbNgayBBSC.Location = new System.Drawing.Point(120, 310);
            this.msktbNgayBBSC.Mask = "00/00/0000";
            this.msktbNgayBBSC.Name = "msktbNgayBBSC";
            this.msktbNgayBBSC.Size = new System.Drawing.Size(181, 30);
            this.msktbNgayBBSC.TabIndex = 6;
            this.msktbNgayBBSC.ValidatingType = typeof(System.DateTime);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKH.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(119, 186);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(181, 30);
            this.cbbMaKH.TabIndex = 3;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(120, 233);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(181, 30);
            this.cbbMaNV.TabIndex = 4;
            // 
            // cbbSoXe
            // 
            this.cbbSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoXe.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.cbbSoXe.FormattingEnabled = true;
            this.cbbSoXe.Location = new System.Drawing.Point(120, 145);
            this.cbbSoXe.Name = "cbbSoXe";
            this.cbbSoXe.Size = new System.Drawing.Size(181, 30);
            this.cbbSoXe.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.Fuchsia;
            this.label15.Location = new System.Drawing.Point(180, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 119;
            this.label15.Text = "(Ngày/Tháng/Năm)";
            // 
            // txtTenSC
            // 
            this.txtTenSC.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTenSC.Location = new System.Drawing.Point(120, 274);
            this.txtTenSC.Multiline = true;
            this.txtTenSC.Name = "txtTenSC";
            this.txtTenSC.Size = new System.Drawing.Size(181, 30);
            this.txtTenSC.TabIndex = 5;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtTienPhat.Location = new System.Drawing.Point(120, 409);
            this.txtTienPhat.Multiline = true;
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(181, 30);
            this.txtTienPhat.TabIndex = 8;
            // 
            // txtNDSC
            // 
            this.txtNDSC.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtNDSC.Location = new System.Drawing.Point(120, 362);
            this.txtNDSC.Multiline = true;
            this.txtNDSC.Name = "txtNDSC";
            this.txtNDSC.Size = new System.Drawing.Size(181, 30);
            this.txtNDSC.TabIndex = 7;
            // 
            // txtSoBBSC
            // 
            this.txtSoBBSC.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.txtSoBBSC.Location = new System.Drawing.Point(120, 107);
            this.txtSoBBSC.Multiline = true;
            this.txtSoBBSC.Name = "txtSoBBSC";
            this.txtSoBBSC.Size = new System.Drawing.Size(181, 30);
            this.txtSoBBSC.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(9, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 111;
            this.label7.Text = "Tiền phạt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(10, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Nội dung sự cố";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(9, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Mã KH";
            // 
            // lblTenSC
            // 
            this.lblTenSC.AutoSize = true;
            this.lblTenSC.BackColor = System.Drawing.Color.Cornsilk;
            this.lblTenSC.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTenSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTenSC.Location = new System.Drawing.Point(7, 279);
            this.lblTenSC.Name = "lblTenSC";
            this.lblTenSC.Size = new System.Drawing.Size(69, 17);
            this.lblTenSC.TabIndex = 115;
            this.lblTenSC.Text = "Tên sự cố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Số xe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Cornsilk;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(9, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 117;
            this.label11.Text = "Mã NV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Cornsilk;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(10, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 118;
            this.label9.Text = "Ngày BBSC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 116;
            this.label2.Text = "Số BBSC";
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.Image")));
            this.btThem.Location = new System.Drawing.Point(350, 476);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 37);
            this.btThem.TabIndex = 120;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Enabled = false;
            this.btSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSua.ImageOptions.Image")));
            this.btSua.Location = new System.Drawing.Point(444, 476);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 37);
            this.btSua.TabIndex = 121;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Enabled = false;
            this.btXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.ImageOptions.Image")));
            this.btXoa.Location = new System.Drawing.Point(538, 476);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 37);
            this.btXoa.TabIndex = 122;
            this.btXoa.Text = "Xóa";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.ImageOptions.Image")));
            this.btThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btThoat.Location = new System.Drawing.Point(632, 476);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 37);
            this.btThoat.TabIndex = 123;
            this.btThoat.Text = "Đóng";
            // 
            // clSBB
            // 
            this.clSBB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSBB.HeaderText = "Số biên bản";
            this.clSBB.Name = "clSBB";
            // 
            // clSoXe
            // 
            this.clSoXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoXe.HeaderText = "Số xe";
            this.clSoXe.Name = "clSoXe";
            // 
            // clMaKH
            // 
            this.clMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaKH.HeaderText = "Mã khách hàng";
            this.clMaKH.Name = "clMaKH";
            // 
            // clMaNV
            // 
            this.clMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaNV.HeaderText = "Mã nhân viên";
            this.clMaNV.Name = "clMaNV";
            // 
            // clTenSC
            // 
            this.clTenSC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenSC.HeaderText = "Tên sự cố";
            this.clTenSC.Name = "clTenSC";
            // 
            // clNgayBB
            // 
            this.clNgayBB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayBB.HeaderText = "Ngày biên bản ";
            this.clNgayBB.Name = "clNgayBB";
            // 
            // clND
            // 
            this.clND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clND.HeaderText = "Nội dung";
            this.clND.Name = "clND";
            // 
            // clTienPhat
            // 
            this.clTienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTienPhat.HeaderText = "Tiền phạt";
            this.clTienPhat.Name = "clTienPhat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 27);
            this.label10.TabIndex = 124;
            this.label10.Text = "Biên bản sự cố";
            // 
            // DanhSachSuCocs
            // 
            this.AcceptButton = this.btThem;
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(1044, 525);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.msktbNgayBBSC);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.cbbSoXe);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTenSC);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.txtNDSC);
            this.Controls.Add(this.txtSoBBSC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenSC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBBSC);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachSuCocs";
            this.Text = "DanhSachSuCocs";
            this.Load += new System.EventHandler(this.DanhSachSuCocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBBSC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBBSC;
        private System.Windows.Forms.MaskedTextBox msktbNgayBBSC;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.ComboBox cbbSoXe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenSC;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.TextBox txtNDSC;
        private System.Windows.Forms.TextBox txtSoBBSC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenSC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clND;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTienPhat;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private System.Windows.Forms.Label label10;
    }
}