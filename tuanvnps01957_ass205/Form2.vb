Imports System.Data.SqlClient
Public Class Form2

    Private Sub btnDetrinh_Click(sender As Object, e As EventArgs) Handles btnDetrinh.Click
        Dim chuoiketnoi As String = "workstation id=tuanvnps01957.mssql.somee.com;packet size=4096;user id=ps01957;pwd=nhuttuan123;data source=tuanvnps01957.mssql.somee.com;persist security info=False;initial catalog=tuanvnps01957"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqladapter As New SqlDataAdapter("select * from NhanVien where ID =  ' " & txtTendangnhap.Text & "'and MatKhau = '" & TxtMatkhau.Text & " '", ketnoi)
        Dim tb As New DataTable
        Try
            ketnoi.Open()
            sqladapter.Fill(tb)
            If tb.Rows.Count >= 0 Then
                MessageBox.Show("ket noi thanh cong")
                FrmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("sai tai khoan or mat khau")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class