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
    public partial class fmQuanlinhanvien : Form
    {
        public fmQuanlinhanvien()
        {
            InitializeComponent();
            LoadForm();
        }
        private void fmQuanlinhanvien_Load(object sender, EventArgs e)
        {
            LoadDL_MaPhong();
            setfalse();
            btnLuu.Enabled = false;
        }
        private void LoadDL_MaPhong()
        {
            string sql = "select MAPHONG from PHONGBAN";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbmaphong.DataSource = dt;
            cbbmaphong.DisplayMember = "MAPHONG";
            cbbmaphong.ValueMember = "MAPHONG";
        }
        private void setfalse()
        {
            cbbmaphong.Enabled = dtpngaysinh.Enabled = txtManv.Enabled = txtHotennv.Enabled = txtHesoluong.Enabled = txtHesochucvu.Enabled = txtPhai.Enabled = txtTienluong.Enabled = false;
        }
        private void settrue()
        {
            cbbmaphong.Enabled = dtpngaysinh.Enabled = txtManv.Enabled = txtHotennv.Enabled = txtHesoluong.Enabled = txtHesochucvu.Enabled = txtPhai.Enabled = true;
        }
        private void clear()
        {
            txtManv.Text = txtHotennv.Text = txtHesoluong.Text = txtHesochucvu.Text = txtPhai.Text = txtTienluong.Text = string.Empty;
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "select MANV, HOTEN,(CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, NGAYSINH,HSLUONG,HSCHUCVU,(HSLUONG * 1300000 + HSCHUCVU) AS TIENLUONG, MAPHONG FROM NHANVIEN";
                Database.SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvquanlynhanvien.DataSource = table;
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
        private void dgvquanlynhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvquanlynhanvien.Rows[e.RowIndex];

                txtManv.Text = selectedRow.Cells["MANV"].Value.ToString();
                txtHotennv.Text = selectedRow.Cells["HOTEN"].Value.ToString();
                dtpngaysinh.Value = (DateTime)selectedRow.Cells["NGAYSINH"].Value;
                txtPhai.Text = selectedRow.Cells["PHAI"].Value.ToString();
                txtHesoluong.Text = selectedRow.Cells["HSLUONG"].Value.ToString();
                txtHesochucvu.Text = selectedRow.Cells["HSCHUCVU"].Value.ToString();
                txtTienluong.Text = selectedRow.Cells["TIENLUONG"].Value.ToString();
                cbbmaphong.Text = selectedRow.Cells["MAPHONG"].Value.ToString();
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
            txtManv.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var maNhanVien = txtManv.Text;
            var tenNhanVien = txtHotennv.Text;
            var gioiTinh = (txtPhai.Text.ToUpper() == "NAM") ? 1 : 0;
            var ngaySinh = dtpngaysinh.Value;
            var hsl = txtHesoluong.Text;
            var hscv = txtHesochucvu.Text;
            var maPhong = cbbmaphong.Text;
            try
            {
                Database.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SqlConnection;
                if (themmoi == false)
                {
                    string queryString = @"UPDATE NHANVIEN
                                        SET HOTEN = @HOTEN,
                                        PHAI = @PHAI,
                                        NGAYSINH = @NGAYSINH,
                                        HSLUONG = @HSLUONG,
                                        HSCHUCVU = @HSCHUCVU,
                                        MAPHONG = @MAPHONG
                                        WHERE MANV = @MANV";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", maNhanVien);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", tenNhanVien);
                    sqlCommand.Parameters.AddWithValue("@PHAI", gioiTinh);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", hsl);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", hscv);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", maPhong);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật Hàng Hóa " + maNhanVien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    setfalse();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                }
                else
                {
                    string queryString = @"INSERT INTO NHANVIEN
                                        VALUES (@MANV, @HOTEN ,@PHAI, @NGAYSINH, @HSLUONG, @HSCHUCVU, @MAPHONG)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", maNhanVien);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", tenNhanVien);
                    sqlCommand.Parameters.AddWithValue("@PHAI", gioiTinh);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", hsl);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", hscv);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", maPhong);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm nhân viên " + maNhanVien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    setfalse();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
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
            foreach (DataGridViewRow row in dgvquanlynhanvien.SelectedRows)
            {
                var maNhanVien = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(maNhanVien))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM NHANVIEN WHERE MANV = @MANV";
                        Database.SqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SqlConnection;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@MANV", maNhanVien);
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
            MessageBox.Show("Đã xóa " + rowsDeleted + " nhân viên");
        }

       
    }
}
