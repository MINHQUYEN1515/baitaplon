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
    public partial class frmDSTaikhoan : Form
    {
        public frmDSTaikhoan()
        {
            InitializeComponent();
            LoadForm();
            LoadSoNV();
        }
        private void LoadSoNV()
        {
            int count = dgvtaikhoan.RowCount;

            // Trừ đi 1 nếu có ít nhất một dòng
            if (count > 0)
            {
                count--;
            }

            txtSoTK.Text = count.ToString();
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "select ID_USER, TENTK,QUYEN  FROM TAIKHOAN";
                Database.SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvtaikhoan.DataSource = table;
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
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmThemTaikhoan frm = new frmThemTaikhoan();
            frm.Show();
            this.Hide();
        }
        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            var rowsDeleted = 0;
            foreach (DataGridViewRow row in dgvtaikhoan.SelectedRows)
            {
                var taiKhoan = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(taiKhoan))
                {
                    try
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            string deleteQuery = @"DELETE FROM TAIKHOAN WHERE ID_USER = @ID_USER";
                            Database.SqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.Connection = Database.SqlConnection;
                            sqlCommand.CommandText = deleteQuery;
                            sqlCommand.Parameters.AddWithValue("@ID_USER", taiKhoan);
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
                        LoadSoNV();
                    }
                }
            }
            MessageBox.Show("Đã xóa " + rowsDeleted + " nhân viên");
        }
        private void btnRefrehTK_Click(object sender, EventArgs e)
        {
            LoadForm();
            LoadSoNV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
