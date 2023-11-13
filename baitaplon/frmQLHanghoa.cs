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
    public partial class frmQLHanghoa : Form
    {
        public frmQLHanghoa()
        {
            InitializeComponent();
            LoadForm();
        }

        private void frmQLHanghoa_Load(object sender, EventArgs e)
        {
            setfalse();
            btnLuu.Enabled = false;
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "SELECT * FROM HANGHOA";
                Database.SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dtgvhanghoa.DataSource = table;
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
        private void dtgvhanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvhanghoa.Rows[e.RowIndex];

                txtmahang.Text = selectedRow.Cells["MAHANG"].Value.ToString();
                txttenhang.Text = selectedRow.Cells["TENHANG"].Value.ToString();
                dtpngaysanxuat.Value = (DateTime)selectedRow.Cells["NGAYSX"].Value;
                txtdongia.Text = selectedRow.Cells["DONGIA"].Value.ToString();
            }
        }
        private void setfalse()
        {
            txtmahang.Enabled = txttenhang.Enabled = dtpngaysanxuat.Enabled = txtdongia.Enabled = false;
        }
        private void settrue()
        {
            txtmahang.Enabled = txttenhang.Enabled = dtpngaysanxuat.Enabled = txtdongia.Enabled = true;
        }
        private void clear()
        {
            txtmahang.Text = txttenhang.Text = dtpngaysanxuat.Text = txtdongia.Text = string.Empty;
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
            themmoi = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var maHang = txtmahang.Text;
            var tenHang = txttenhang.Text;
            var ngaysx = dtpngaysanxuat.Value;
            var donGia = txtdongia.Text;
            try
            {
                Database.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SqlConnection;
                if (themmoi == false)
                {
                    string queryString = @"UPDATE HANGHOA
                                        SET TENHANG = @TENHANG,
                                        NGAYSX = @NGAYSX,
                                        DONGIA = @DONGIA
                                        WHERE MAHANG = @MAHANG";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MAHANG", maHang);
                    sqlCommand.Parameters.AddWithValue("@TENHANG", tenHang);
                    sqlCommand.Parameters.AddWithValue("@NGAYSX", ngaysx);
                    sqlCommand.Parameters.AddWithValue("@DONGIA", donGia);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật Hàng Hóa " + maHang);
                    clear();
                    setfalse();
                    btnThem.Enabled = true;
                }
                else
                {
                    string queryString = @"INSERT INTO HANGHOA
                                        VALUES (@MAHANG, @TENHANG,@NGAYSX, @DONGIA)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MAHANG", maHang);
                    sqlCommand.Parameters.AddWithValue("@TENHANG", tenHang);
                    sqlCommand.Parameters.AddWithValue("@NGAYSX", ngaysx);
                    sqlCommand.Parameters.AddWithValue("@DONGIA", donGia);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu mới hàng hóa " + maHang);
                    clear();
                    setfalse();
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            settrue();
            txtmahang.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowsDeleted = 0;
            foreach (DataGridViewRow row in dtgvhanghoa.SelectedRows)
            {
                var maHang = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(maHang))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM HANGHOA WHERE MAHANG = @MAHANG";
                        Database.SqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SqlConnection;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@MAHANG", maHang);
                        sqlCommand.ExecuteNonQuery();
                        rowsDeleted++;
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
            MessageBox.Show("Đã xóa " + rowsDeleted + " hàng hóa");
        }
    }
}