﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLapPhieuThuePhong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNgayTraPhong = New System.Windows.Forms.DateTimePicker()
        Me.lblNgayTraPhong = New System.Windows.Forms.Label()
        Me.lblNgayBatDauThue = New System.Windows.Forms.Label()
        Me.dtpNgayBatDauThue = New System.Windows.Forms.DateTimePicker()
        Me.cboMaPhong = New System.Windows.Forms.ComboBox()
        Me.txtDonGiaThue = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.txtMaPhieuThue = New System.Windows.Forms.TextBox()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.lblDonGiaThue = New System.Windows.Forms.Label()
        Me.lblMaPhieuThue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachKhachThue = New System.Windows.Forms.DataGridView()
        Me.TenKhachHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboDgvLoaiKhach = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CMND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvTrangThaiPhong = New System.Windows.Forms.DataGridView()
        Me.cboTenKhuyenMai = New System.Windows.Forms.ComboBox()
        Me.lblKhuyenMai = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoiDungKM = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoiDungKM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTenKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.lblKhuyenMai)
        Me.GroupBox1.Controls.Add(Me.dtpNgayTraPhong)
        Me.GroupBox1.Controls.Add(Me.lblNgayTraPhong)
        Me.GroupBox1.Controls.Add(Me.lblNgayBatDauThue)
        Me.GroupBox1.Controls.Add(Me.dtpNgayBatDauThue)
        Me.GroupBox1.Controls.Add(Me.cboMaPhong)
        Me.GroupBox1.Controls.Add(Me.txtDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.txtTenPhong)
        Me.GroupBox1.Controls.Add(Me.txtMaPhieuThue)
        Me.GroupBox1.Controls.Add(Me.lblTenPhong)
        Me.GroupBox1.Controls.Add(Me.lblMaPhong)
        Me.GroupBox1.Controls.Add(Me.lblDonGiaThue)
        Me.GroupBox1.Controls.Add(Me.lblMaPhieuThue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LẬP PHIẾU THUÊ PHÒNG"
        '
        'dtpNgayTraPhong
        '
        Me.dtpNgayTraPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayTraPhong.Location = New System.Drawing.Point(392, 104)
        Me.dtpNgayTraPhong.Name = "dtpNgayTraPhong"
        Me.dtpNgayTraPhong.Size = New System.Drawing.Size(140, 20)
        Me.dtpNgayTraPhong.TabIndex = 14
        '
        'lblNgayTraPhong
        '
        Me.lblNgayTraPhong.AutoSize = True
        Me.lblNgayTraPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayTraPhong.Location = New System.Drawing.Point(303, 107)
        Me.lblNgayTraPhong.Name = "lblNgayTraPhong"
        Me.lblNgayTraPhong.Size = New System.Drawing.Size(83, 13)
        Me.lblNgayTraPhong.TabIndex = 13
        Me.lblNgayTraPhong.Text = "Ngày trả phòng:"
        '
        'lblNgayBatDauThue
        '
        Me.lblNgayBatDauThue.AutoSize = True
        Me.lblNgayBatDauThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNgayBatDauThue.Location = New System.Drawing.Point(51, 107)
        Me.lblNgayBatDauThue.Name = "lblNgayBatDauThue"
        Me.lblNgayBatDauThue.Size = New System.Drawing.Size(75, 13)
        Me.lblNgayBatDauThue.TabIndex = 12
        Me.lblNgayBatDauThue.Text = "Ngày bắt đầu:"
        '
        'dtpNgayBatDauThue
        '
        Me.dtpNgayBatDauThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayBatDauThue.Location = New System.Drawing.Point(143, 104)
        Me.dtpNgayBatDauThue.Name = "dtpNgayBatDauThue"
        Me.dtpNgayBatDauThue.Size = New System.Drawing.Size(140, 20)
        Me.dtpNgayBatDauThue.TabIndex = 11
        '
        'cboMaPhong
        '
        Me.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboMaPhong.FormattingEnabled = True
        Me.cboMaPhong.Location = New System.Drawing.Point(143, 68)
        Me.cboMaPhong.Name = "cboMaPhong"
        Me.cboMaPhong.Size = New System.Drawing.Size(140, 21)
        Me.cboMaPhong.TabIndex = 10
        '
        'txtDonGiaThue
        '
        Me.txtDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDonGiaThue.Location = New System.Drawing.Point(392, 31)
        Me.txtDonGiaThue.Name = "txtDonGiaThue"
        Me.txtDonGiaThue.ReadOnly = True
        Me.txtDonGiaThue.Size = New System.Drawing.Size(140, 20)
        Me.txtDonGiaThue.TabIndex = 9
        '
        'txtTenPhong
        '
        Me.txtTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenPhong.Location = New System.Drawing.Point(392, 68)
        Me.txtTenPhong.Name = "txtTenPhong"
        Me.txtTenPhong.Size = New System.Drawing.Size(140, 20)
        Me.txtTenPhong.TabIndex = 8
        '
        'txtMaPhieuThue
        '
        Me.txtMaPhieuThue.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtMaPhieuThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhieuThue.Location = New System.Drawing.Point(143, 34)
        Me.txtMaPhieuThue.Name = "txtMaPhieuThue"
        Me.txtMaPhieuThue.ReadOnly = True
        Me.txtMaPhieuThue.Size = New System.Drawing.Size(140, 20)
        Me.txtMaPhieuThue.TabIndex = 0
        '
        'lblTenPhong
        '
        Me.lblTenPhong.AutoSize = True
        Me.lblTenPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenPhong.Location = New System.Drawing.Point(324, 71)
        Me.lblTenPhong.Name = "lblTenPhong"
        Me.lblTenPhong.Size = New System.Drawing.Size(62, 13)
        Me.lblTenPhong.TabIndex = 4
        Me.lblTenPhong.Text = "Tên phòng:"
        '
        'lblMaPhong
        '
        Me.lblMaPhong.AutoSize = True
        Me.lblMaPhong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhong.Location = New System.Drawing.Point(68, 71)
        Me.lblMaPhong.Name = "lblMaPhong"
        Me.lblMaPhong.Size = New System.Drawing.Size(58, 13)
        Me.lblMaPhong.TabIndex = 3
        Me.lblMaPhong.Text = "Mã phòng:"
        '
        'lblDonGiaThue
        '
        Me.lblDonGiaThue.AutoSize = True
        Me.lblDonGiaThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDonGiaThue.Location = New System.Drawing.Point(317, 34)
        Me.lblDonGiaThue.Name = "lblDonGiaThue"
        Me.lblDonGiaThue.Size = New System.Drawing.Size(71, 13)
        Me.lblDonGiaThue.TabIndex = 1
        Me.lblDonGiaThue.Text = "Đơn giá thuê:"
        '
        'lblMaPhieuThue
        '
        Me.lblMaPhieuThue.AutoSize = True
        Me.lblMaPhieuThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaPhieuThue.Location = New System.Drawing.Point(48, 37)
        Me.lblMaPhieuThue.Name = "lblMaPhieuThue"
        Me.lblMaPhieuThue.Size = New System.Drawing.Size(78, 13)
        Me.lblMaPhieuThue.TabIndex = 0
        Me.lblMaPhieuThue.Text = "Mã phiếu thuê:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(408, 15)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(90, 23)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(102, 15)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(90, 23)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachKhachThue)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 110)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách khách thuê phòng"
        '
        'dgvDanhSachKhachThue
        '
        Me.dgvDanhSachKhachThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachKhachThue.AllowUserToResizeRows = False
        Me.dgvDanhSachKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachKhachThue.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvDanhSachKhachThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachKhachThue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDanhSachKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenKhachHang, Me.cboDgvLoaiKhach, Me.CMND, Me.DiaChi})
        Me.dgvDanhSachKhachThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachKhachThue.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachKhachThue.MultiSelect = False
        Me.dgvDanhSachKhachThue.Name = "dgvDanhSachKhachThue"
        Me.dgvDanhSachKhachThue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDanhSachKhachThue.RowHeadersWidth = 25
        Me.dgvDanhSachKhachThue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDanhSachKhachThue.Size = New System.Drawing.Size(599, 89)
        Me.dgvDanhSachKhachThue.TabIndex = 0
        '
        'TenKhachHang
        '
        Me.TenKhachHang.DataPropertyName = "TenKhachHang"
        Me.TenKhachHang.HeaderText = "Tên Khách Hàng"
        Me.TenKhachHang.Name = "TenKhachHang"
        '
        'cboDgvLoaiKhach
        '
        Me.cboDgvLoaiKhach.DataPropertyName = "TenLoaiKhachHang"
        Me.cboDgvLoaiKhach.HeaderText = "Loại Khách"
        Me.cboDgvLoaiKhach.Name = "cboDgvLoaiKhach"
        Me.cboDgvLoaiKhach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboDgvLoaiKhach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CMND
        '
        Me.CMND.DataPropertyName = "CMND"
        Me.CMND.HeaderText = "CMND"
        Me.CMND.Name = "CMND"
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvTrangThaiPhong)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 161)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Trạng thái phòng theo ngày bắt đầu và ngày trả phòng"
        '
        'dgvTrangThaiPhong
        '
        Me.dgvTrangThaiPhong.AllowUserToAddRows = False
        Me.dgvTrangThaiPhong.AllowUserToDeleteRows = False
        Me.dgvTrangThaiPhong.AllowUserToResizeColumns = False
        Me.dgvTrangThaiPhong.AllowUserToResizeRows = False
        Me.dgvTrangThaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrangThaiPhong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTrangThaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrangThaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrangThaiPhong.Location = New System.Drawing.Point(4, 17)
        Me.dgvTrangThaiPhong.Name = "dgvTrangThaiPhong"
        Me.dgvTrangThaiPhong.ReadOnly = True
        Me.dgvTrangThaiPhong.RowHeadersVisible = False
        Me.dgvTrangThaiPhong.Size = New System.Drawing.Size(599, 140)
        Me.dgvTrangThaiPhong.TabIndex = 0
        '
        'cboTenKhuyenMai
        '
        Me.cboTenKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTenKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cboTenKhuyenMai.FormattingEnabled = True
        Me.cboTenKhuyenMai.Location = New System.Drawing.Point(143, 137)
        Me.cboTenKhuyenMai.Name = "cboTenKhuyenMai"
        Me.cboTenKhuyenMai.Size = New System.Drawing.Size(140, 21)
        Me.cboTenKhuyenMai.TabIndex = 20
        '
        'lblKhuyenMai
        '
        Me.lblKhuyenMai.AutoSize = True
        Me.lblKhuyenMai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblKhuyenMai.Location = New System.Drawing.Point(68, 138)
        Me.lblKhuyenMai.Name = "lblKhuyenMai"
        Me.lblKhuyenMai.Size = New System.Drawing.Size(59, 13)
        Me.lblKhuyenMai.TabIndex = 19
        Me.lblKhuyenMai.Text = "Khyến mãi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nội dung KM:"
        '
        'lblNoiDungKM
        '
        Me.lblNoiDungKM.AutoSize = True
        Me.lblNoiDungKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblNoiDungKM.Location = New System.Drawing.Point(392, 140)
        Me.lblNoiDungKM.Name = "lblNoiDungKM"
        Me.lblNoiDungKM.Size = New System.Drawing.Size(13, 13)
        Me.lblNoiDungKM.TabIndex = 22
        Me.lblNoiDungKM.Text = "0"
        '
        'frmLapPhieuThuePhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 526)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLapPhieuThuePhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lập Phiếu Thuê Phòng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMaPhong As System.Windows.Forms.ComboBox
    Friend WithEvents txtDonGiaThue As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPhieuThue As System.Windows.Forms.TextBox
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents lblDonGiaThue As System.Windows.Forms.Label
    Friend WithEvents lblMaPhieuThue As System.Windows.Forms.Label
    Friend WithEvents dtpNgayTraPhong As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNgayTraPhong As System.Windows.Forms.Label
    Friend WithEvents lblNgayBatDauThue As System.Windows.Forms.Label
    Friend WithEvents dtpNgayBatDauThue As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDanhSachKhachThue As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTrangThaiPhong As System.Windows.Forms.DataGridView
    Friend WithEvents TenKhachHang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboDgvLoaiKhach As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CMND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTenKhuyenMai As ComboBox
    Friend WithEvents lblKhuyenMai As Label
    Friend WithEvents lblNoiDungKM As Label
    Friend WithEvents Label1 As Label
End Class
