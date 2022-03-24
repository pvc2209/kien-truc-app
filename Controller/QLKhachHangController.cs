using KienTrucApp.Dal;
using KienTrucApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KienTrucApp.Controller
{
    public class QLKhachHangController
    {
        private KhachHangDAO khachHangDAO = new KhachHangDAO();

        private QLKhachHangView _view;
        public QLKhachHangController(QLKhachHangView view)
        {
            _view = view;
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            if (CheckValid(khachHang) == true)
            {
                int ketQua = khachHangDAO.Them(khachHang);

                // delete from khachhang where hoTen = 'Ngoc'
                // ketQua là số bản ghi bị tác động
                // ví dụ có 2 người tên là Ngọc thì ketQua = 2
                // => nếu kq = 0 thì ko xóa đc

                if (ketQua > 0)
                {
                    List<KhachHang> listKhachHang = khachHangDAO.LayDanhSachKhachHang();
                    _view.CapNhatDanhSachKhachHang(listKhachHang);

                    _view.ShowMessage("Thêm thành công");
                }
                else
                {
                    _view.ShowMessage("Thêm không thành công");
                }
            } 
            else
            {
                _view.ShowMessage("Số điện thoại không hợp lệ");
            }
        }
        
        private bool CheckValid(KhachHang khachHang)
        {
            if (khachHang.SoDienThoai.Length != 10)
            {
                return false;
            }
            
            return true;
        }
    }
}
