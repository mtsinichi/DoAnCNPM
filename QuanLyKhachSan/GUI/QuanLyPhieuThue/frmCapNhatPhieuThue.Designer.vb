﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapNhatPhieuThue
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpNgayTraPhong = New System.Windows.Forms.DateTimePicker()
        Me.lblNgayTraPhong = New System.Windows.Forms.Label()
        Me.lblNgayBatDauThue = New System.Windows.Forms.Label()
        Me.dtpNgayBatDauThue = New System.Windows.Forms.DateTimePicker()
        Me.txtDonGiaThue = New System.Windows.Forms.TextBox()
        Me.txtTenPhong = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvTrangThaiPhong = New System.Windows.Forms.DataGridView()
        Me.txtMaPhieuThue = New System.Windows.Forms.TextBox()
        Me.lblTenPhong = New System.Windows.Forms.Label()
        Me.lblMaPhong = New System.Windows.Forms.Label()
        Me.lblDonGiaThue = New System.Windows.Forms.Label()
        Me.lblMaPhieuThue = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDanhSachKhachThue = New System.Windows.Forms.DataGridView()
        Me.TenKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMaPhong = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvTrangThaiPhong)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(607, 161)
        Me.GroupBox4.TabIndex = 9
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrangThaiPhong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTrangThaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrangThaiPhong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrangThaiPhong.Location = New System.Drawing.Point(4, 17)
        Me.dgvTrangThaiPhong.Name = "dgvTrangThaiPhong"
        Me.dgvTrangThaiPhong.ReadOnly = True
        Me.dgvTrangThaiPhong.RowHeadersVisible = False
        Me.dgvTrangThaiPhong.Size = New System.Drawing.Size(599, 140)
        Me.dgvTrangThaiPhong.TabIndex = 0
        '
        'txtMaPhieuThue
        '
        Me.txtMaPhieuThue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaPhieuThue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaPhieuThue.Location = New System.Drawing.Point(143, 34)
        Me.txtMaPhieuThue.Name = "txtMaPhieuThue"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDanhSachKhachThue)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(607, 110)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Danh sách khách thuê phòng"
        '
        'dgvDanhSachKhachThue
        '
        Me.dgvDanhSachKhachThue.AllowUserToAddRows = False
        Me.dgvDanhSachKhachThue.AllowUserToDeleteRows = False
        Me.dgvDanhSachKhachThue.AllowUserToResizeColumns = False
        Me.dgvDanhSachKhachThue.AllowUserToResizeRows = False
        Me.dgvDanhSachKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachKhachThue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenKhach, Me.LoaiKhach, Me.CMND, Me.DiaChi})
        Me.dgvDanhSachKhachThue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSachKhachThue.Location = New System.Drawing.Point(4, 17)
        Me.dgvDanhSachKhachThue.Name = "dgvDanhSachKhachThue"
        Me.dgvDanhSachKhachThue.RowHeadersVisible = False
        Me.dgvDanhSachKhachThue.Size = New System.Drawing.Size(599, 89)
        Me.dgvDanhSachKhachThue.TabIndex = 0
        '
        'TenKhach
        '
        Me.TenKhach.DataPropertyName = "TenKhachHang"
        Me.TenKhach.HeaderText = "Tên Khách"
        Me.TenKhach.Name = "TenKhach"
        '
        'LoaiKhach
        '
        Me.LoaiKhach.DataPropertyName = "TenLoaiKhachHang"
        Me.LoaiKhach.HeaderText = "Loại Khách"
        Me.LoaiKhach.Name = "LoaiKhach"
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
        Me.btnLuu.Enabled = False
        Me.btnLuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(102, 15)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(90, 23)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Size = New System.Drawing.Size(607, 147)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CẬP NHẬT PHIẾU THUÊ PHÒNG"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHuy)
        Me.GroupBox2.Controls.Add(Me.btnLuu)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'frmCapNhatPhieuThue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 509)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCapNhatPhieuThue"
        Me.Text = "Cập Nhật Phiếu Thuê"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvTrangThaiPhong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDanhSachKhachThue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpNgayTraPhong As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNgayTraPhong As System.Windows.Forms.Label
    Friend WithEvents lblNgayBatDauThue As System.Windows.Forms.Label
    Friend WithEvents dtpNgayBatDauThue As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDonGiaThue As System.Windows.Forms.TextBox
    Friend WithEvents txtTenPhong As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTrangThaiPhong As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaPhieuThue As System.Windows.Forms.TextBox
    Friend WithEvents lblTenPhong As System.Windows.Forms.Label
    Friend WithEvents lblMaPhong As System.Windows.Forms.Label
    Friend WithEvents lblDonGiaThue As System.Windows.Forms.Label
    Friend WithEvents lblMaPhieuThue As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMaPhong As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDanhSachKhachThue As System.Windows.Forms.DataGridView
    Friend WithEvents TenKhach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiKhach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class