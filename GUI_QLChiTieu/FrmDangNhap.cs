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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void ckboxShowHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxShowHidePass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }
    }
}
