using BUS_QLChiTieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChiTieu
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        BUS_KhoanThu busKhoanThu = new BUS_KhoanThu();
        BUS_KhoanChi busKhoanChi = new BUS_KhoanChi();

        private void dtpkNgay_ValueChanged(object sender, EventArgs e)
        {
            dgvThuNgay.DataSource = busKhoanThu.getKhoanThuNgay(dtpkNgay.Value);
            dgvThuNgay.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuNgay.Columns[1].Visible = false;
            dgvThuNgay.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuNgay.Columns[3].HeaderText = "Ngày Thu";
            dgvThuNgay.Columns[4].HeaderText = "Số Tiền";
            dgvThuNgay.Columns[5].HeaderText = "Mô Tả";

            dgvChiNgay.DataSource = busKhoanChi.getKhoanChiNgay(dtpkNgay.Value);
            dgvChiNgay.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiNgay.Columns[1].Visible = false;
            dgvChiNgay.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiNgay.Columns[3].HeaderText = "Ngày Chi";
            dgvChiNgay.Columns[4].HeaderText = "Số Tiền";
            dgvChiNgay.Columns[5].HeaderText = "Mô Tả";

            DataTable dtNgay = busKhoanThu.getdsTkeNgay(dtpkNgay.Value);
            txtThuNgay.Text = dtNgay.Rows[0][0].ToString();
            txtChiNgay.Text = dtNgay.Rows[0][1].ToString();
            txtSoDuNgay.Text = dtNgay.Rows[0][2].ToString();
        }

        private void dtpkThang_ValueChanged(object sender, EventArgs e)
        {
            dgvThuThang.DataSource = busKhoanThu.getKhoanThuThang(dtpkThang.Value);
            dgvThuThang.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuThang.Columns[1].Visible = false;
            dgvThuThang.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuThang.Columns[3].HeaderText = "Ngày Thu";
            dgvThuThang.Columns[4].HeaderText = "Số Tiền";
            dgvThuThang.Columns[5].HeaderText = "Mô Tả";

            dgvChiThang.DataSource = busKhoanChi.getKhoanChiThang(dtpkThang.Value);
            dgvChiThang.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiThang.Columns[1].Visible = false;
            dgvChiThang.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiThang.Columns[3].HeaderText = "Ngày Chi";
            dgvChiThang.Columns[4].HeaderText = "Số Tiền";
            dgvChiThang.Columns[5].HeaderText = "Mô Tả";

            DataTable dtThang = busKhoanThu.getdsTkeThang(dtpkThang.Value);
            txtThuThang.Text = dtThang.Rows[0][0].ToString();
            txtChiThang.Text = dtThang.Rows[0][1].ToString();
            txtSoDuThang.Text = dtThang.Rows[0][2].ToString();
        }
    }
}
