using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLChiTieu
{
    public class BUS_KhoanThu
    {
        BUS_KhoanThu dalKhoanThu = new BUS_KhoanThu();

        public bool InsertKhoanThu(DTO_KhoanThu kt)
        {
            return dalKhoanThu.InsertKhoanThu(kt);
        }

        public bool UpdateKhoanThu(DTO_KhoanThu kt)
        {
            return dalKhoanThu.UpdateKhoanThu(kt);
        }

        public bool DeleteKhoanThu(string maKT)
        {
            return dalKhoanThu.DeleteKhoanThu(maKT);
        }

        public DataTable getKhoanThu()
        {
            return dalKhoanThu.getKhoanThu();
        }
    }
}
