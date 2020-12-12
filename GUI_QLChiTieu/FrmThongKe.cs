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
        BUS_MucTieu busMucTieu = new BUS_MucTieu();
        
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
            txtThuThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][0]);
            txtChiThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][1]);
            txtSoDuThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][2]);

            int chi;
            int limit;
            DataTable dtTkeMT = busMucTieu.getTkeMucTieu(dtpkThang.Value);
            if (dtTkeMT != null && dtTkeMT.Rows.Count > 0)
            {
                chi = Convert.ToInt32(dtThang.Rows[0][1].ToString());
                limit = Convert.ToInt32(dtTkeMT.Rows[0][3].ToString());
                if (chi > limit)
                {
                    MessageBox.Show("Bạn đã vượt quá giới hạn chi tiêu tháng này", "Phê bình");
                }
                else
                {
                    MessageBox.Show("Bạn đã không vượt quá giới hạn chi tiêu tháng này", "Chúc mừng");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa đặt mục tiêu cho tháng này");
            }
        }

        private void dtpkNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dgvThuNgay.DataSource = busKhoanThu.getKhoanThuNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvThuNgay.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuNgay.Columns[1].Visible = false;
            dgvThuNgay.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuNgay.Columns[3].HeaderText = "Ngày Thu";
            dgvThuNgay.Columns[4].HeaderText = "Số Tiền";
            dgvThuNgay.Columns[5].HeaderText = "Mô Tả";

            dgvChiNgay.DataSource = busKhoanChi.getKhoanChiNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvChiNgay.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiNgay.Columns[1].Visible = false;
            dgvChiNgay.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiNgay.Columns[3].HeaderText = "Ngày Chi";
            dgvChiNgay.Columns[4].HeaderText = "Số Tiền";
            dgvChiNgay.Columns[5].HeaderText = "Mô Tả";

            DataTable dtNgay = busKhoanThu.getdsTkeNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            txtThuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][0]);
            txtChiNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][1]);
            txtSoDuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][2]);
        }

        private void dtpkNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dgvThuNgay.DataSource = busKhoanThu.getKhoanThuNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvThuNgay.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuNgay.Columns[1].Visible = false;
            dgvThuNgay.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuNgay.Columns[3].HeaderText = "Ngày Thu";
            dgvThuNgay.Columns[4].HeaderText = "Số Tiền";
            dgvThuNgay.Columns[5].HeaderText = "Mô Tả";

            dgvChiNgay.DataSource = busKhoanChi.getKhoanChiNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvChiNgay.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiNgay.Columns[1].Visible = false;
            dgvChiNgay.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiNgay.Columns[3].HeaderText = "Ngày Chi";
            dgvChiNgay.Columns[4].HeaderText = "Số Tiền";
            dgvChiNgay.Columns[5].HeaderText = "Mô Tả";

            DataTable dtNgay = busKhoanThu.getdsTkeNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            txtThuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][0]);
            txtChiNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][1]);
            txtSoDuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][2]);
        }
    }
}
