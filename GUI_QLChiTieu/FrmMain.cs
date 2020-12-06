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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static string mail;

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();

            FrmKhoanThu khoanThu = new FrmKhoanThu();
            khoanThu.TopLevel = false;

            this.panelMain.Controls.Add(khoanThu);
            khoanThu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            khoanThu.Dock = DockStyle.Fill;
            khoanThu.Show();
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();

            FrmKhoanChi khoanChi = new FrmKhoanChi();
            khoanChi.TopLevel = false;

            this.panelMain.Controls.Add(khoanChi);
            khoanChi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            khoanChi.Dock = DockStyle.Fill;
            khoanChi.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();

            FrmThongKe thongKe = new FrmThongKe();
            thongKe.TopLevel = false;

            this.panelMain.Controls.Add(thongKe);
            thongKe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            thongKe.Dock = DockStyle.Fill;
            thongKe.Show();
        }

        private void btnMucTieu_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();

            FrmMucTieu mucTieu = new FrmMucTieu();
            mucTieu.TopLevel = false;

            this.panelMain.Controls.Add(mucTieu);
            mucTieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mucTieu.Dock = DockStyle.Fill;
            mucTieu.Show();
        }
    }
}
