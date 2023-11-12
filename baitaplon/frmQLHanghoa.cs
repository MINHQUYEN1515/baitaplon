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
        }

        private void frmQLHanghoa_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            setfalse();
            btnLuu.Enabled = false;
        }
        private void Load_DataGridView()
        {
            if (Database.SqlConnection.State == ConnectionState.Closed)
            {
                Database.SqlConnection.Open();
                string sql = @"select * from HANGHOA ";
                SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SqlConnection);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dtgvhanghoa.DataSource = dt;
                dtgvhanghoa.Columns[0].HeaderText = "Mã hàng";
                dtgvhanghoa.Columns[1].HeaderText = "Tên hàng";
                dtgvhanghoa.Columns[2].HeaderText = "Ngày sản xuất";
                dtgvhanghoa.Columns[3].HeaderText = "Đơn giá";
                dtgvhanghoa.AllowUserToAddRows = false;
                dtgvhanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
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
        string themmoi = "";
        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            settrue();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            themmoi = "themmoi";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Database.SqlConnection.State == ConnectionState.Closed)
            {
                Database.SqlConnection.Open();
                if (themmoi == "themmoi")
                {
                    string sql = @"INSERT INTO HANGHOA (MAHANG, TENHANG, NGAYSX, DONGIA)
                           VALUES (@MAHANG, @TENHANG, @NGAYSX, @DONGIA)";

                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@MAHANG", txtmahang.Text);
                    cmd.Parameters.AddWithValue("@TENHANG", txttenhang.Text);
                    cmd.Parameters.Add("@NGAYSX", SqlDbType.DateTime).Value = dtpngaysanxuat.Value;
                    cmd.Parameters.AddWithValue("@DONGIA", txtdongia.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (themmoi == "sua")
                {
                    string sqlupdate = @"UPDATE HANGHOA SET TENHANG = @TENHANG, NGAYSX = @NGAYSX, DONGIA = @DONGIA WHERE MAHANG = @MAHANG";

                    using (SqlCommand cmd = new SqlCommand(sqlupdate, Database.SqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@TENHANG", txttenhang.Text);
                        cmd.Parameters.Add("@NGAYSX", SqlDbType.DateTime).Value = dtpngaysanxuat.Value;
                        cmd.Parameters.AddWithValue("@DONGIA", txtdongia.Text);
                        cmd.Parameters.AddWithValue("@MAHANG", txtmahang.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Load_DataGridView();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                clear();
            }
            Database.SqlConnection.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = "sua";
            settrue();
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Database.SqlConnection.State == ConnectionState.Closed)
            {
                Database.SqlConnection.Open();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    string sql = "delete from HANGHOA Where MAHANG = N'" + txtmahang.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.ExecuteNonQuery();
                    Refresh();
                    Load_DataGridView();
                    Database.SqlConnection.Close();
                    clear();
                }
                else MessageBox.Show("Chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Database.SqlConnection.Close();
        }
    }
}
