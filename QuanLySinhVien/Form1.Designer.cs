namespace QuanLySinhVien
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtQueQuan = new System.Windows.Forms.RichTextBox();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.radNu = new System.Windows.Forms.RadioButton();
			this.radNam = new System.Windows.Forms.RadioButton();
			this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pHinh = new System.Windows.Forms.PictureBox();
			this.btnChonHinh = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dgvDSSV = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pHinh)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(248, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ SINH VIÊN";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtQueQuan);
			this.groupBox1.Controls.Add(this.cboLop);
			this.groupBox1.Controls.Add(this.radNu);
			this.groupBox1.Controls.Add(this.radNam);
			this.groupBox1.Controls.Add(this.dateNgaySinh);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.txtMaSV);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(21, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(767, 242);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Sinh Viên";
			// 
			// txtQueQuan
			// 
			this.txtQueQuan.Location = new System.Drawing.Point(493, 124);
			this.txtQueQuan.Name = "txtQueQuan";
			this.txtQueQuan.Size = new System.Drawing.Size(236, 96);
			this.txtQueQuan.TabIndex = 5;
			this.txtQueQuan.Text = "";
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Location = new System.Drawing.Point(493, 88);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(121, 24);
			this.cboLop.TabIndex = 4;
			// 
			// radNu
			// 
			this.radNu.AutoSize = true;
			this.radNu.Location = new System.Drawing.Point(630, 43);
			this.radNu.Name = "radNu";
			this.radNu.Size = new System.Drawing.Size(47, 21);
			this.radNu.TabIndex = 3;
			this.radNu.TabStop = true;
			this.radNu.Text = "Nữ";
			this.radNu.UseVisualStyleBackColor = true;
			// 
			// radNam
			// 
			this.radNam.AutoSize = true;
			this.radNam.Location = new System.Drawing.Point(493, 45);
			this.radNam.Name = "radNam";
			this.radNam.Size = new System.Drawing.Size(58, 21);
			this.radNam.TabIndex = 3;
			this.radNam.TabStop = true;
			this.radNam.Text = "Nam";
			this.radNam.UseVisualStyleBackColor = true;
			// 
			// dateNgaySinh
			// 
			this.dateNgaySinh.Location = new System.Drawing.Point(173, 132);
			this.dateNgaySinh.Name = "dateNgaySinh";
			this.dateNgaySinh.Size = new System.Drawing.Size(200, 22);
			this.dateNgaySinh.TabIndex = 2;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(173, 83);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(100, 22);
			this.txtHoTen.TabIndex = 1;
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(173, 40);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(100, 22);
			this.txtMaSV.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(404, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Địa chỉ :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(404, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Lớp :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(404, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Giới Tính :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày Sinh :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Họ Tên :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã SV :";
			// 
			// pHinh
			// 
			this.pHinh.Location = new System.Drawing.Point(861, 94);
			this.pHinh.Name = "pHinh";
			this.pHinh.Size = new System.Drawing.Size(170, 231);
			this.pHinh.TabIndex = 2;
			this.pHinh.TabStop = false;
			// 
			// btnChonHinh
			// 
			this.btnChonHinh.Location = new System.Drawing.Point(861, 359);
			this.btnChonHinh.Name = "btnChonHinh";
			this.btnChonHinh.Size = new System.Drawing.Size(170, 30);
			this.btnChonHinh.TabIndex = 3;
			this.btnChonHinh.Text = "Chọn Hình";
			this.btnChonHinh.UseVisualStyleBackColor = true;
			this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTimKiem);
			this.groupBox2.Controls.Add(this.btnTimKiem);
			this.groupBox2.Location = new System.Drawing.Point(21, 345);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(767, 53);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tìm kiếm";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(7, 22);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(470, 22);
			this.txtTimKiem.TabIndex = 0;
			this.txtTimKiem.Text = "Nhập vào tên sinh viên cần tìm...";
			this.txtTimKiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseDown);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(528, 22);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 3;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// dgvDSSV
			// 
			this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSSV.Location = new System.Drawing.Point(21, 417);
			this.dgvDSSV.Name = "dgvDSSV";
			this.dgvDSSV.RowTemplate.Height = 24;
			this.dgvDSSV.Size = new System.Drawing.Size(767, 114);
			this.dgvDSSV.TabIndex = 5;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(861, 417);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 6;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(956, 417);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 6;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(861, 460);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(956, 460);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 6;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(861, 505);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 6;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(956, 505);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1072, 540);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvDSSV);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnChonHinh);
			this.Controls.Add(this.pHinh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "QUẢN LÝ SINH VIÊN";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pHinh)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox txtQueQuan;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.RadioButton radNu;
		private System.Windows.Forms.RadioButton radNam;
		private System.Windows.Forms.DateTimePicker dateNgaySinh;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtMaSV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pHinh;
		private System.Windows.Forms.Button btnChonHinh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.DataGridView dgvDSSV;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

