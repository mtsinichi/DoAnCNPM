﻿Imports BUS.BUS
Imports GUI.XuLy
Imports DTO.DTO

Public Class frmThemLoaiPhong

    Private fatherForm As frmHeThong

    Private Sub btntThoat_Click(sender As Object, e As EventArgs) Handles btntThoat.Click
        Me.Close()
    End Sub


    Private Sub frmThemLoaiPhong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDanhSachLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Using New CenteredMessageBox(Me)
            If ((XuLyGUI.laChuoiHopLe(txtTenLoaiPhong.Text) = False)) Then
                MessageBox.Show("Vui lòng nhập tên loại phòng hợp lệ.")
                Return
            End If

            If (XuLyGUI.laChuoiHopLe(txtDonGiaThue.Text) = False) Then
                MessageBox.Show("Vui lòng nhập đơn giá thuê hợp lệ.")
                Return
            End If

            'If (IsNumeric(Double.Parse(txtDonGiaThue.Text)) = False) Then
            '    MessageBox.Show("Nhập đơn giá thuê hợp lệ.")
            '    Return
            'End If

            Dim loaiPhong As New LoaiPhongDTO
            loaiPhong.TenLoaiPhong = txtTenLoaiPhong.Text
            loaiPhong.DonGiaThue = txtDonGiaThue.Text

            If (LoaiPhongBUS.themLoaiPhong(loaiPhong) = True) Then
                MessageBox.Show("Thêm loại phòng thành công.")

                dgvDanhSachLoaiPhong.DataSource = LoaiPhongBUS.selectLoaiPhongAll()

                txtDonGiaThue.Text = ""
                txtTenLoaiPhong.Text = ""
            End If
        End Using
    End Sub

    Sub New(formFather As frmHeThong)

        InitializeComponent()
        fatherForm = formFather

    End Sub

    Private Sub frmThemLoaiPhong_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fatherForm.CapNhat()
    End Sub
End Class