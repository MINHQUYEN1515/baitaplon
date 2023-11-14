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
    public partial class frmQLHoadon : Form
    {
        public frmQLHoadon()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmQLHoadon_Load(object sender, EventArgs e)
        {
            LoadDL_SoHD();
            LoadDL_MANV();

            LOADHD();
            Load_DataGridView();
            LoadDL_MaHang();
            LoadTenHang();
            SumThanhtien();
        }
        private void Load_DataGridView()
        {
            string sql = @"select CTHoadon.Mahang, tenhang, soluong, dongia, (dongia*soluong) as thanhtien
                            from cthoadon INNER JOIN hanghoa on cthoadon.mahang = hanghoa.mahang
                              INNER JOIN hoadon on cthoadon.sohd = hoadon.sohd where cthoadon.sohd = '" + cbhoadon.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable adt = new DataTable();
            ad.Fill(adt);
            dgvctdh.DataSource = adt;
            dgvctdh.Columns[0].HeaderText = "Mã hàng";
            dgvctdh.Columns[1].HeaderText = "Tên hàng";
            dgvctdh.Columns[2].HeaderText = "Số lượng";
            dgvctdh.Columns[3].HeaderText = "Đơn giá";
            dgvctdh.Columns[4].HeaderText = "Thành tiền";
            dgvctdh.AllowUserToAddRows = false;
            dgvctdh.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvctdh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvctdh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDL_SoHD()
        {
            string sql = "select sohd from hoadon";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbhoadon.DataSource = dt;
            cbhoadon.DisplayMember = "sohd";
            cbhoadon.ValueMember = "sohd";

        }
        private void LoadDL_MaHang()
        {
            string sql = "select mahang from hanghoa";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbmahang.DataSource = dt;
            cbmahang.DisplayMember = "mahang";
            cbmahang.ValueMember = "mahang";

        }
        private void LoadDL_MANV()
        {
            string sql = "select MANV from NHANVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbmanv.DataSource = dt;
            cbmanv.DisplayMember = "MANV";
            cbmanv.ValueMember = "MANV";

        }
        private void LOADHD()
        {
            if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
            Database.SqlConnection.Open();
            String render = "select * from HOADON where sohd= '" + cbhoadon.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(render, Database.SqlConnection);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {

                txtkh.Text = Reader.GetString(1).ToString();
                txtdiachi.Text = Reader.GetString(2).ToString();
                txtdt.Text = Reader.GetString(3).ToString();
                dtpngaylap.Value = Reader.GetDateTime(4);
                cbmanv.Text = Reader.GetString(5).ToString();
            }

            Database.SqlConnection.Close();
        }

        private void cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTenHang();
        }

        private void LoadTenHang()
        {
            if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
            Database.SqlConnection.Open();
            String render = "select tenhang from hanghoa where mahang= '" + cbmahang.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(render, Database.SqlConnection);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {

                txttenhang.Text = Reader.GetString(0).ToString();

            }

            Database.SqlConnection.Close();
        }
        private void cbhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select CTHoadon.Mahang, tenhang, soluong, dongia, (dongia*soluong) as thanhtien
                            from cthoadon INNER JOIN hanghoa on cthoadon.mahang = hanghoa.mahang
                              INNER JOIN hoadon on cthoadon.sohd = hoadon.sohd
                             where cthoadon.sohd = '" + cbhoadon.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dtt = new DataTable();
            ad.Fill(dtt);
            dgvctdh.DataSource = dtt;
            LOADHD();
            SumThanhtien();
        }
        private void SumThanhtien()
        {
            int tong = 0;
            for (int i = 0; i < dgvctdh.Rows.Count; i++)
            {
                tong += Convert.ToInt32(dgvctdh.Rows[i].Cells[4].Value);
            }
            txttong.Text = tong.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluuhd.Enabled = true;
            cbhoadon.ResetText();
            txtkh.Enabled = true;
            txtdt.Enabled = true;
            txtdiachi.Enabled = true;
            cbmanv.Enabled = true;
            txtkh.Clear();
            txtdiachi.Clear();
            txtdt.Clear();
            dtpngaylap.ResetText();



        }

        private void btnthemhanghoa_Click(object sender, EventArgs e)
        {
            cbmahang.Enabled = true;
            txtsoluong.Enabled = true;
            btnluuhanghoa.Enabled = true;
            btnxoahanghoa.Enabled = false;

        }

        private void btnluuhanghoa_Click(object sender, EventArgs e)
        {


            try
            {
                if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
                Database.SqlConnection.Open();
                if (capnhat == true)
                {
                    string sql = "Update cthoadon set soluong = @soluong where ( mahang= '" + cbmahang.SelectedValue.ToString() + "') and (sohd = '" + cbhoadon.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@soluong", SqlDbType.Int).Value = txtsoluong.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Update.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    capnhat = false;
                }
                else
                {
                    string sql = "Insert into cthoadon values(@sohd,@mahang,@soluong)";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@sohd", SqlDbType.VarChar).Value = cbhoadon.Text;
                    cmd.Parameters.AddWithValue("@mahang", SqlDbType.VarChar).Value = cbmahang.Text;
                    cmd.Parameters.AddWithValue("@soluong", SqlDbType.Int).Value = txtsoluong.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Insert.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
                Load_DataGridView();
                SumThanhtien();
                cbmahang.Enabled = false;
                txtsoluong.Enabled = false;
                btnluuhanghoa.Enabled = false;
                btnxoahanghoa.Enabled = true;
            }

        }
        bool capnhat = false;
        private void btnsuahanghoa_Click(object sender, EventArgs e)
        {
            capnhat = true;
            cbmahang.Enabled = true;
            txtsoluong.Enabled = true;
            btnluuhanghoa.Enabled = true;
        }

        private void btnxoahanghoa_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow selectedRow in this.dgvctdh.SelectedRows)
                {
                    if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
                    Database.SqlConnection.Open();
                    string mahh = selectedRow.Cells["mahang"].Value.ToString();
                    SqlCommand cmd = new SqlCommand("DELETE FROM cthoadon WHERE (mahang =@mahh)", Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@mahh", mahh);
                    cmd.ExecuteNonQuery();
                    Database.SqlConnection.Close();
                    MessageBox.Show("Successful Delete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
                Load_DataGridView();
                SumThanhtien();

            }

        }

        private void btnluuhd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
                Database.SqlConnection.Open();
                if (capnhat == true)
                {
                    string sql = "Update hoadon set khachhang = @khachhang,diachi=@diachi,ngaylap=@ngaylap,dienthoai=@dienthoai,manv=@manv where  (sohd = '" + cbhoadon.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@khachhang", txtkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@dienthoai", txtdt.Text);
                    cmd.Parameters.AddWithValue("@manv", cbmanv.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", dtpngaylap.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Update.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    capnhat = false;
                }
                else
                {
                    string sql = "Insert into hoadon values(@sohd,@khachhang,@diachi,@dienthoai,@ngaylap,@manv)";
                    SqlCommand cmd = new SqlCommand(sql, Database.SqlConnection);
                    cmd.Parameters.AddWithValue("@sohd", cbhoadon.Text);
                    cmd.Parameters.AddWithValue("@khachhang", txtkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@dienthoai", txtdt.Text);
                    cmd.Parameters.AddWithValue("@manv", cbmanv.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", dtpngaylap.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Insert.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
                LoadDL_SoHD();
                LOADHD();
                Load_DataGridView();
                SumThanhtien();
                cbmanv.Enabled = false;
                txtkh.Enabled = false;
                btnluuhd.Enabled = false;
                txtdiachi.Enabled = false;
                txtdt.Enabled = false;
                dtpngaylap.Enabled = false;
            }

        }

        private void btnsuahd_Click(object sender, EventArgs e)
        {
            capnhat = true;
            btnluuhd.Enabled = true;
            txtkh.Enabled = true;
            txtdt.Enabled = true;
            txtdiachi.Enabled = true;
            cbmanv.Enabled = true;

        }

        private void btnxoahd_Click(object sender, EventArgs e)
        {
            try
            {

                if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
                Database.SqlConnection.Open();
                string mahd = cbhoadon.Text;
                SqlCommand cmd = new SqlCommand("DELETE FROM hoadon WHERE (Sohd =@sohd)", Database.SqlConnection);
                cmd.Parameters.AddWithValue("@sohd", mahd);
                cmd.ExecuteNonQuery();
                Database.SqlConnection.Close();
                MessageBox.Show("Successful Delete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SqlConnection.Close();
                LoadDL_SoHD();
                LOADHD();
                Load_DataGridView();
                SumThanhtien();

            }
        }
    }
}
