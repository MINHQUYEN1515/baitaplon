namespace baitaplon
{
    partial class frmQLHoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dtpngaylap = new DateTimePicker();
            btnxoahd = new Button();
            btnluuhd = new Button();
            btnsuahd = new Button();
            btnthem = new Button();
            cbmanv = new ComboBox();
            cbhoadon = new ComboBox();
            txtkh = new TextBox();
            txtdt = new TextBox();
            txtdiachi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtsoluong = new TextBox();
            txttenhang = new TextBox();
            cbmahang = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnxoahanghoa = new Button();
            btnthemhanghoa = new Button();
            btnluuhanghoa = new Button();
            btnsuahanghoa = new Button();
            dgvctdh = new DataGridView();
            label1 = new Label();
            txttong = new TextBox();
            btnthoat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvctdh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(dtpngaylap);
            panel1.Controls.Add(btnxoahd);
            panel1.Controls.Add(btnluuhd);
            panel1.Controls.Add(btnsuahd);
            panel1.Controls.Add(btnthem);
            panel1.Controls.Add(cbmanv);
            panel1.Controls.Add(cbhoadon);
            panel1.Controls.Add(txtkh);
            panel1.Controls.Add(txtdt);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 25);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 200);
            panel1.TabIndex = 0;
            // 
            // dtpngaylap
            // 
            dtpngaylap.Enabled = false;
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.Location = new Point(113, 147);
            dtpngaylap.Name = "dtpngaylap";
            dtpngaylap.Size = new Size(166, 23);
            dtpngaylap.TabIndex = 19;
            // 
            // btnxoahd
            // 
            btnxoahd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoahd.Location = new Point(293, 142);
            btnxoahd.Margin = new Padding(3, 2, 3, 2);
            btnxoahd.Name = "btnxoahd";
            btnxoahd.Size = new Size(106, 34);
            btnxoahd.TabIndex = 18;
            btnxoahd.Text = "Xóa hóa đơn";
            btnxoahd.UseVisualStyleBackColor = true;
            btnxoahd.Click += btnxoahd_Click;
            // 
            // btnluuhd
            // 
            btnluuhd.Enabled = false;
            btnluuhd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnluuhd.Location = new Point(293, 102);
            btnluuhd.Margin = new Padding(3, 2, 3, 2);
            btnluuhd.Name = "btnluuhd";
            btnluuhd.Size = new Size(106, 34);
            btnluuhd.TabIndex = 17;
            btnluuhd.Text = "Lưu hóa đơn";
            btnluuhd.UseVisualStyleBackColor = true;
            btnluuhd.Click += btnluuhd_Click;
            // 
            // btnsuahd
            // 
            btnsuahd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuahd.Location = new Point(293, 63);
            btnsuahd.Margin = new Padding(3, 2, 3, 2);
            btnsuahd.Name = "btnsuahd";
            btnsuahd.Size = new Size(106, 34);
            btnsuahd.TabIndex = 16;
            btnsuahd.Text = "Sửa hóa đơn";
            btnsuahd.UseVisualStyleBackColor = true;
            btnsuahd.Click += btnsuahd_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.Location = new Point(293, 22);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(106, 34);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm hóa đơn";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // cbmanv
            // 
            cbmanv.Enabled = false;
            cbmanv.FormattingEnabled = true;
            cbmanv.Location = new Point(112, 177);
            cbmanv.Margin = new Padding(3, 2, 3, 2);
            cbmanv.Name = "cbmanv";
            cbmanv.Size = new Size(133, 23);
            cbmanv.TabIndex = 14;
            // 
            // cbhoadon
            // 
            cbhoadon.FormattingEnabled = true;
            cbhoadon.Location = new Point(112, 22);
            cbhoadon.Margin = new Padding(3, 2, 3, 2);
            cbhoadon.Name = "cbhoadon";
            cbhoadon.Size = new Size(133, 23);
            cbhoadon.TabIndex = 13;
            cbhoadon.SelectedIndexChanged += cbhoadon_SelectedIndexChanged;
            // 
            // txtkh
            // 
            txtkh.Enabled = false;
            txtkh.Location = new Point(112, 52);
            txtkh.Margin = new Padding(3, 2, 3, 2);
            txtkh.Name = "txtkh";
            txtkh.Size = new Size(167, 23);
            txtkh.TabIndex = 12;
            // 
            // txtdt
            // 
            txtdt.Enabled = false;
            txtdt.Location = new Point(112, 115);
            txtdt.Margin = new Padding(3, 2, 3, 2);
            txtdt.Name = "txtdt";
            txtdt.Size = new Size(167, 23);
            txtdt.TabIndex = 9;
            // 
            // txtdiachi
            // 
            txtdiachi.Enabled = false;
            txtdiachi.Location = new Point(112, 80);
            txtdiachi.Margin = new Padding(3, 2, 3, 2);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(167, 23);
            txtdiachi.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 179);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 6;
            label8.Text = "Mã nhân viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 148);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 5;
            label7.Text = "Ngày lập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 115);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 4;
            label6.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 86);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 3;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 54);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "Khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 25);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "Số hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 0;
            label2.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Violet;
            panel2.Controls.Add(txtsoluong);
            panel2.Controls.Add(txttenhang);
            panel2.Controls.Add(cbmahang);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnxoahanghoa);
            panel2.Controls.Add(btnthemhanghoa);
            panel2.Controls.Add(btnluuhanghoa);
            panel2.Controls.Add(btnsuahanghoa);
            panel2.Location = new Point(438, 25);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 189);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtsoluong
            // 
            txtsoluong.Enabled = false;
            txtsoluong.Location = new Point(91, 118);
            txtsoluong.Margin = new Padding(3, 2, 3, 2);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(162, 23);
            txtsoluong.TabIndex = 29;
            txtsoluong.TextChanged += textBox5_TextChanged;
            // 
            // txttenhang
            // 
            txttenhang.Enabled = false;
            txttenhang.Location = new Point(91, 80);
            txttenhang.Margin = new Padding(3, 2, 3, 2);
            txttenhang.Name = "txttenhang";
            txttenhang.Size = new Size(162, 23);
            txttenhang.TabIndex = 28;
            txttenhang.TextChanged += textBox2_TextChanged;
            // 
            // cbmahang
            // 
            cbmahang.Enabled = false;
            cbmahang.FormattingEnabled = true;
            cbmahang.Location = new Point(91, 42);
            cbmahang.Margin = new Padding(3, 2, 3, 2);
            cbmahang.Name = "cbmahang";
            cbmahang.Size = new Size(162, 23);
            cbmahang.TabIndex = 27;
            cbmahang.SelectedIndexChanged += cbmahang_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(21, 120);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 26;
            label12.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(21, 82);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 25;
            label11.Text = "Tên hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 42);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 24;
            label10.Text = "Mã hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(33, 4);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 23;
            label9.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // btnxoahanghoa
            // 
            btnxoahanghoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoahanghoa.Location = new Point(294, 135);
            btnxoahanghoa.Margin = new Padding(3, 2, 3, 2);
            btnxoahanghoa.Name = "btnxoahanghoa";
            btnxoahanghoa.Size = new Size(106, 34);
            btnxoahanghoa.TabIndex = 22;
            btnxoahanghoa.Text = "Xóa hàng hóa";
            btnxoahanghoa.UseVisualStyleBackColor = true;
            btnxoahanghoa.Click += btnxoahanghoa_Click;
            // 
            // btnthemhanghoa
            // 
            btnthemhanghoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthemhanghoa.Location = new Point(294, 15);
            btnthemhanghoa.Margin = new Padding(3, 2, 3, 2);
            btnthemhanghoa.Name = "btnthemhanghoa";
            btnthemhanghoa.Size = new Size(106, 34);
            btnthemhanghoa.TabIndex = 19;
            btnthemhanghoa.Text = "Thêm hàng hóa";
            btnthemhanghoa.UseVisualStyleBackColor = true;
            btnthemhanghoa.Click += btnthemhanghoa_Click;
            // 
            // btnluuhanghoa
            // 
            btnluuhanghoa.Enabled = false;
            btnluuhanghoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnluuhanghoa.Location = new Point(294, 94);
            btnluuhanghoa.Margin = new Padding(3, 2, 3, 2);
            btnluuhanghoa.Name = "btnluuhanghoa";
            btnluuhanghoa.Size = new Size(106, 34);
            btnluuhanghoa.TabIndex = 21;
            btnluuhanghoa.Text = "Lưu hàng hóa";
            btnluuhanghoa.UseVisualStyleBackColor = true;
            btnluuhanghoa.Click += btnluuhanghoa_Click;
            // 
            // btnsuahanghoa
            // 
            btnsuahanghoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuahanghoa.Location = new Point(294, 56);
            btnsuahanghoa.Margin = new Padding(3, 2, 3, 2);
            btnsuahanghoa.Name = "btnsuahanghoa";
            btnsuahanghoa.Size = new Size(106, 34);
            btnsuahanghoa.TabIndex = 20;
            btnsuahanghoa.Text = "Sửa hàng hóa";
            btnsuahanghoa.UseVisualStyleBackColor = true;
            btnsuahanghoa.Click += btnsuahanghoa_Click;
            // 
            // dgvctdh
            // 
            dgvctdh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvctdh.Location = new Point(10, 230);
            dgvctdh.Margin = new Padding(3, 2, 3, 2);
            dgvctdh.Name = "dgvctdh";
            dgvctdh.RowHeadersWidth = 51;
            dgvctdh.RowTemplate.Height = 29;
            dgvctdh.Size = new Size(679, 117);
            dgvctdh.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 349);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 3;
            label1.Text = "TỔNG GIÁ TRỊ HÓA ĐƠN";
            // 
            // txttong
            // 
            txttong.Location = new Point(391, 351);
            txttong.Margin = new Padding(3, 2, 3, 2);
            txttong.Name = "txttong";
            txttong.Size = new Size(217, 23);
            txttong.TabIndex = 4;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnthoat.Location = new Point(713, 240);
            btnthoat.Margin = new Padding(3, 2, 3, 2);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(124, 44);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmQLHoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(866, 386);
            Controls.Add(btnthoat);
            Controls.Add(txttong);
            Controls.Add(label1);
            Controls.Add(dgvctdh);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmQLHoadon";
            Text = "QUẢN LÍ HÓA ĐƠN";
            Load += frmQLHoadon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvctdh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvctdh;
        private Label label1;
        private TextBox txttong;
        private Button btnxoahd;
        private Button btnluuhd;
        private Button btnsuahd;
        private Button btnthem;
        private ComboBox cbmanv;
        private ComboBox cbhoadon;
        private TextBox txtkh;
        private TextBox txtdt;
        private TextBox txtdiachi;
        private TextBox txtsoluong;
        private TextBox txttenhang;
        private ComboBox cbmahang;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnxoahanghoa;
        private Button btnthemhanghoa;
        private Button btnluuhanghoa;
        private Button btnsuahanghoa;
        private Button btnthoat;
        private DateTimePicker dtpngaylap;
    }
}