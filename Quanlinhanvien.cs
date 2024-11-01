using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MainMenu
{
    public partial class Quanlinhanvien : Form
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        private string connectionString = "Server=HOANGBAO-APTOP-\\SQLMHB;Database=QuanLiNhanVien;User Id=sa;Password=sa;";

        public Quanlinhanvien()
        {
            InitializeComponent();
            LoadData(); // Tải dữ liệu khi khởi động form
        }

        private void LoadData()
        {
            danhSachNhanVien.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNV = reader["MaNV"].ToString(),
                        TenNV = reader["TenNV"].ToString(),
                        Tuoi = Convert.ToInt32(reader["Tuoi"]),
                        GioiTinh = reader["GioiTinh"].ToString()
                    };
                    danhSachNhanVien.Add(nv);
                }
            }
            CapNhatDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string maNV = txtMa.Text;

            // Kiểm tra xem Mã NV đã tồn tại chưa
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV", connection);
                checkCommand.Parameters.AddWithValue("@MaNV", maNV);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Nhân viên với mã " + txtMa.Text + " đã tồn tại!");
                    return;
                }
            }

            string gioiTinh = checkBoxGioiTinh.Checked ? "Nam" : "Nữ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO NhanVien (MaNV, TenNV, Tuoi, GioiTinh) VALUES (@MaNV, @TenNV, @Tuoi, @GioiTinh)", connection);
                command.Parameters.AddWithValue("@MaNV", maNV);
                command.Parameters.AddWithValue("@TenNV", txtTen.Text);
                command.Parameters.AddWithValue("@Tuoi", int.Parse(txtTuoi.Text));
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.ExecuteNonQuery();
            }

            LoadData();
            ResetInputFields();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string maNV = row.Cells[0].Value.ToString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM NhanVien WHERE MaNV = @MaNV", connection);
                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                string maNV = row.Cells[0].Value.ToString();
                string gioiTinh = checkBoxGioiTinh.Checked ? "Nam" : "Nữ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE NhanVien SET TenNV = @TenNV, Tuoi = @Tuoi, GioiTinh = @GioiTinh WHERE MaNV = @MaNV", connection);
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    command.Parameters.AddWithValue("@TenNV", txtTen.Text);
                    command.Parameters.AddWithValue("@Tuoi", int.TryParse(txtTuoi.Text, out int tuoi) ? tuoi : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.ExecuteNonQuery();
                }

                LoadData();
                ResetInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
        }

        private void CapNhatDanhSach()
        {
            dataGridView1.Rows.Clear();
            foreach (var nv in danhSachNhanVien)
            {
                dataGridView1.Rows.Add(nv.MaNV, nv.TenNV, nv.Tuoi, nv.GioiTinh == "Nam", nv.GioiTinh == "Nữ");
            }
        }

        private void ResetInputFields()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTuoi.Clear();
            checkBoxGioiTinh.Checked = false;
            checkBox2.Checked = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (!int.TryParse(txtTuoi.Text, out _))
            {
                MessageBox.Show("Tuổi không hợp lệ!");
                return false;
            }

            return true;
        }

        private void checkBoxGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGioiTinh.Checked)
            {
                checkBox2.Checked = false; // Bỏ chọn "Nữ" nếu chọn "Nam"
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBoxGioiTinh.Checked = false; // Bỏ chọn "Nam" nếu chọn "Nữ"
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtTuoi.Text = row.Cells[2].Value.ToString();
                checkBoxGioiTinh.Checked = row.Cells[3].Value != null && (bool)row.Cells[3].Value;
                checkBox2.Checked = row.Cells[4].Value != null && (bool)row.Cells[4].Value;
            }
            else
            {
                ResetInputFields();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Để xử lý sự kiện khi form được tải
        }
    }

    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
    }
}
