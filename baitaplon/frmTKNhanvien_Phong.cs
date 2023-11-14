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
    public partial class frmTKNhanvien_Phong : Form
    {
        public frmTKNhanvien_Phong()
        {
            InitializeComponent();
        }

        private void frmTKNhanvien_Phong_Load(object sender, EventArgs e)
        {
            LoadDL_MaPhong();
            Load_DataGridView();
            LoadSoNV();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select MANV, HOTEN,(CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, NGAYSINH,HSLUONG,HSCHUCVU,(HSLUONG * 1300000 + HSCHUCVU * 1390000) AS TIENLUONG
                            from NHANVIEN INNER JOIN PHONGBAN ON NHANVIEN.MAPHONG = PHONGBAN.MAPHONG where PHONGBAN.MAPHONG = '" + cbbmaphong.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dtgvphongban.DataSource = dt;
            txttenphong.Text = TenPhongBan(cbbmaphong.SelectedValue.ToString());
            txtdienthoai.Text = SoDienThoai(cbbmaphong.SelectedValue.ToString());
            LoadSoNV();
        }
        public string TenPhongBan(string maPhong)
        {
            if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
            Database.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TENPHONG FROM PHONGBAN WHERE MAPHONG = @MAPHONG", Database.SqlConnection);
            cmd.Parameters.AddWithValue("@MAPHONG", maPhong);
            object result = cmd.ExecuteScalar();
            Database.SqlConnection.Close();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return "Không tìm thấy dữ liệu";
            }
        }
        public string SoDienThoai(string maPhong)
        {
            if (Database.SqlConnection.State == ConnectionState.Open) Database.SqlConnection.Close();
            Database.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT DIENTHOAI FROM PHONGBAN WHERE MAPHONG = @MAPHONG", Database.SqlConnection);
            cmd.Parameters.AddWithValue("@MAPHONG", maPhong);
            object result = cmd.ExecuteScalar();
            Database.SqlConnection.Close();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return "Không tìm thấy dữ liệu";
            }
        }
        private void LoadSoNV()
        {
            int count = dtgvphongban.RowCount;
            txttongsonhanvien.Text = count.ToString();

            double tongLuong = 0.0;
            for (int i = 0; i < dtgvphongban.Rows.Count; i++)
            {
                double luongNhanVien = Convert.ToDouble(dtgvphongban.Rows[i].Cells["TIENLUONG"].Value);
                tongLuong += luongNhanVien;
            }

            txttongluong.Text = tongLuong.ToString();
        }
        private void Load_DataGridView()
        {
            string sql = @"select MANV, HOTEN,(CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, NGAYSINH,HSLUONG,HSCHUCVU,(HSLUONG * 1300000 + HSCHUCVU) AS TIENLUONG
                            from NHANVIEN INNER JOIN PHONGBAN ON NHANVIEN.MAPHONG = PHONGBAN.MAPHONG";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SqlConnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dtgvphongban.DataSource = dt;
            dtgvphongban.Columns[0].HeaderText = "Mã nhân viên";
            dtgvphongban.Columns[1].HeaderText = "Họ tên";
            dtgvphongban.Columns[2].HeaderText = "Phái";
            dtgvphongban.Columns[3].HeaderText = "Ngày sinh";
            dtgvphongban.Columns[4].HeaderText = "Hệ số lương";
            dtgvphongban.Columns[5].HeaderText = "Hệ số chức vụ";
            dtgvphongban.Columns[6].HeaderText = "Tiền lương";
            dtgvphongban.AllowUserToAddRows = false;
            dtgvphongban.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
