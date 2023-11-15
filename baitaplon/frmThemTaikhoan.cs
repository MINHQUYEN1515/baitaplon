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
    public partial class frmThemTaikhoan : Form
    {
        public frmThemTaikhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var id = txtID_User.Text;
            var tentk = txtTentk.Text;
            var matKhau = txtPass.Text;
            var quyen = txtQuyen.Text;
            try
            {
                Database.SqlConnection.Open();
                string sql = "select count(*) from TAIKHOAN where ID_USER = '" + txtID_User.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Đã có mã nhân viên này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID_User.Focus();
                }
                else
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = Database.SqlConnection;
                    string queryString = @"INSERT INTO TAIKHOAN
                            VALUES (@ID_USER, @TENTK ,@MATKHAU, @QUYEN)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@ID_USER", id);
                    sqlCommand.Parameters.AddWithValue("@TENTK", tentk);
                    sqlCommand.Parameters.AddWithValue("@MATKHAU", matKhau);
                    sqlCommand.Parameters.AddWithValue("@QUYEN", quyen);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm nhân viên " + tentk, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID_User.Text = txtTentk.Text = txtPass.Text = txtQuyen.Text = string.Empty;
                    txtID_User.Focus();
                }
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSTaikhoan frm = new frmDSTaikhoan();
            frm.Show();
        }
    }
}
