using System.Data;

namespace mbbb
{
    public partial class Form1 : Form
    {
        private Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
        }
        private void MayBayForm_Load(object sender, EventArgs e)
        {
            LoadMayBay();
        }

        private void LoadMayBay()
        {
            string query = "SELECT * FROM MayBay ORDER BY TenMayBay ASC";
            DataTable dataTable = db.ExecuteQuery(query);
            dataGridViewMayBay.DataSource = dataTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMayBay();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form ThemMayBay
            ThemMayBay themMayBayForm = new ThemMayBay();

            // Mở form ThemMayBay dưới dạng hộp thoại (modal)
            themMayBayForm.ShowDialog();

            // Sau khi form ThemMayBay đóng lại, làm mới danh sách máy bay
            LoadMayBay(); // Gọi phương thức LoadMayBay để làm mới danh sách trong DataGridView
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMayBay.SelectedRows.Count > 0) // Kiểm tra nếu có hàng nào được chọn
            {
                int maMB = Convert.ToInt32(dataGridViewMayBay.SelectedRows[0].Cells["MaMB"].Value); // Lấy MaMB của máy bay
                SuaMayBay suaMayBayForm = new SuaMayBay(maMB); // Truyền MaMB vào Form SuaMayBay
                suaMayBayForm.ShowDialog(); // Mở Form SuaMayBay
                LoadMayBay(); // Làm mới danh sách sau khi sửa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn máy bay để sửa.");
            }
        }

    }
}
