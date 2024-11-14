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
    public partial class SuaMayBay : Form
    {
        private Database db;
        private int maMB; // Mã máy bay cần sửa

        public SuaMayBay(int maMB)
        {
            InitializeComponent();
            db = new Database();
            this.maMB = maMB;
            LoadMayBayData(); // Tải dữ liệu của máy bay cần sửa khi mở form
        }
        private void LoadMayBayData()
        {
            string query = $"SELECT TenMayBay, NamSX, SoGioBay FROM MayBay WHERE MaMB = {maMB}";
            var dataTable = db.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                // Lấy dữ liệu từ DataTable và gán vào các TextBox
                txtTenMayBay.Text = dataTable.Rows[0]["TenMayBay"].ToString();
                txtNamSX.Text = dataTable.Rows[0]["NamSX"].ToString();
                txtSoGioBay.Text = dataTable.Rows[0]["SoGioBay"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy máy bay để sửa.");
                this.Close(); // Đóng Form nếu không tìm thấy máy bay
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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

            // Tạo câu lệnh SQL để cập nhật máy bay trong cơ sở dữ liệu
            string query = $"UPDATE MayBay SET TenMayBay = '{tenMayBay}', NamSX = {namSX}, SoGioBay = {soGioBay} WHERE MaMB = {maMB}";

            try
            {
                // Thực thi câu lệnh SQL
                db.ExecuteNonQuery(query);
                MessageBox.Show("Cập nhật máy bay thành công!");
                this.Close(); // Đóng form sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật máy bay: " + ex.Message);
            }
        }

        private void btnUpdate_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
