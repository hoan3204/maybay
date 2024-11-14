using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbbb
{
    public partial class ThemMayBay : Form
    {
        private Database db;
        public ThemMayBay()
        {
            InitializeComponent();
            db = new Database();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenMayBay = txtTenMayBay.Text;
            int namSX;
            int soGioBay;

            // Kiểm tra dữ liệu đầu vào hợp lệ
            if (string.IsNullOrEmpty(tenMayBay))
            {
                MessageBox.Show("Vui lòng nhập tên máy bay.");
                return;
            }
            if (!int.TryParse(txtNamSX.Text, out namSX) || namSX <= 0)
            {
                MessageBox.Show("Vui lòng nhập năm sản xuất hợp lệ.");
                return;
            }
            if (!int.TryParse(txtSoGioBay.Text, out soGioBay) || soGioBay < 0)
            {
                MessageBox.Show("Vui lòng nhập số giờ bay hợp lệ.");
                return;
            }

            // Tạo câu lệnh SQL để thêm máy bay vào cơ sở dữ liệu
            string query = $"INSERT INTO MayBay (TenMayBay, NamSX, SoGioBay) VALUES ('{tenMayBay}', {namSX}, {soGioBay})";

            try
            {
                // Thực thi câu lệnh SQL
                db.ExecuteNonQuery(query);
                MessageBox.Show("Thêm máy bay thành công!");
                this.Close(); // Đóng form sau khi thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm máy bay: " + ex.Message);
            }
        }
    }
}
