using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class fmQLPhongban : Form
    {
        public fmQLPhongban()
        {
            InitializeComponent();
        }
        private void fmQLPhongban_Load(object sender, EventArgs e)
        {
            LoadForm();
            setfalse();
            btnLuu.Enabled = false;
        }
        private void setfalse()
        {
            txtMaphong.Enabled = txtTenphong.Enabled = txtSdt.Enabled = false;
        }
        private void settrue()
        {
            txtMaphong.Enabled = txtTenphong.Enabled = txtSdt.Enabled = true;
        }
        private void clear()
        {
            txtMaphong.Text = txtTenphong.Text = txtSdt.Text = string.Empty;
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "select MAPHONG, TENPHONG,DIENTHOAI FROM PHONGBAN";
                Database.SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvThongtinphongban.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
            }
        }

        private void dgvThongtinphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvThongtinphongban.Rows[e.RowIndex];

                txtMaphong.Text = selectedRow.Cells["MAPHONG"].Value.ToString();
                txtTenphong.Text = selectedRow.Cells["TENPHONG"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool themmoi = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            settrue();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            settrue();
            txtMaphong.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var maPhong = txtMaphong.Text;
            var tenPhong = txtTenphong.Text;
            var dienThoai = txtSdt.Text;
            try
            {
                Database.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SqlConnection;
                if (themmoi == false)
                {
                    string queryString = @"UPDATE PHONGBAN
                                        SET TENPHONG = @TENPHONG,
                                        DIENTHOAI = @DIENTHOAI
                                        WHERE MAPHONG = @MAPHONG";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", maPhong);
                    sqlCommand.Parameters.AddWithValue("@TENPHONG", tenPhong);
                    sqlCommand.Parameters.AddWithValue("@DIENTHOAI", dienThoai);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật Hàng Hóa " + maPhong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    setfalse();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }
                else
                {
                    string sql = "select count(*) from PHONGBAN where MAPHONG = '" + txtMaphong.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã có mã phòng ban này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaphong.Focus();
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnLuu.Enabled = false;
                        clear();
                    }
                    else
                    {
                        string queryString = @"INSERT INTO PHONGBAN
                                        VALUES (@MAPHONG, @TENPHONG ,@DIENTHOAI)";
                        sqlCommand.CommandText = queryString;
                        sqlCommand.Parameters.AddWithValue("@MAPHONG", maPhong);
                        sqlCommand.Parameters.AddWithValue("@TENPHONG", tenPhong);
                        sqlCommand.Parameters.AddWithValue("@DIENTHOAI", dienThoai);

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã thêm phòng ban " + maPhong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        setfalse();
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnLuu.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
                LoadForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowsDeleted = 0;
            foreach (DataGridViewRow row in dgvThongtinphongban.SelectedRows)
            {
                var maPhong = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(maPhong))
                {
                    try
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialog == DialogResult.Yes)
                        {
                            string deleteQuery = @"DELETE FROM PHONGBAN WHERE MAPHONG = @MAPHONG";
                            Database.SqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = Database.SqlConnection;
                            sqlCommand.CommandText = deleteQuery;
                            sqlCommand.Parameters.AddWithValue("@MAPHONG", maPhong);
                            sqlCommand.ExecuteNonQuery();
                            rowsDeleted++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Database.SqlConnection.Close();
                        LoadForm();
                    }
                }
            }
            MessageBox.Show("Đã xóa " + rowsDeleted + " phòng ban");
        }
    }
}
