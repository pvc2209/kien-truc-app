using KienTrucApp.Controller;
using KienTrucApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KienTrucApp
{
    public partial class QLKhachHangView : Form
    {
        private QLKhachHangController _controller;
        public QLKhachHangView()
        {
            InitializeComponent();

            _controller = new QLKhachHangController(this);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        
        public void CapNhatDanhSachKhachHang(List<KhachHang> listKhachHang)
        {
            //dgvKhachHang.DataSource = listKhachHang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string soDienThoai = txtSDT.Text;
            _controller.ThemKhachHang(new KhachHang(hoTen, soDienThoai));
        }
    }
}
