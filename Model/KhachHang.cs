using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KienTrucApp.Model
{
    public class KhachHang
    {
        public KhachHang(string hoTen, string sdt)
        {
            this.HoTen = hoTen;
            this.SoDienThoai = sdt;
        }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
    }
}
