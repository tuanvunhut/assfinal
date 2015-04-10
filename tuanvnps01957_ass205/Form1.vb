Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FrmMain
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=tuanvnps01957.mssql.somee.com;packet size=4096;user id=ps01957;pwd=nhuttuan123;data source=tuanvnps01957.mssql.somee.com;persist security info=False;initial catalog=tuanvnps01957"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value
        TextBox4.Text = DataGridView1.Item(3, index).Value

    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        Dim Connect As New SqlConnection(connectstr)
        Connect.Open()
        Dim AddString As String = "INSERT INTO SanPham VALUES @MaSP, @TenSP, @DonGia, @SoLuong"
        Dim Additional As New SqlCommand(AddString, Connect)
        Try
            Additional.Parameters.AddWithValue("@MaSP", TextBox1.Text)
            Additional.Parameters.AddWithValue("@TenSP", TextBox2.Text)
            Additional.Parameters.AddWithValue("@DonGia", TextBox3.Text)
            Additional.Parameters.AddWithValue("@SoLuong", TextBox4.Text)

            Additional.ExecuteNonQuery()
            Connect.Close()
        Catch ex As Exception
            MessageBox.Show("Thêm Sản Phẩm thành công!")
        End Try
        tb.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        DataGridView1.DataSource = tb


    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "UPDATE SanPham SET TenSP = @TenSP,DonGia = @DonGia,SoLuong= @SoLuong,ngaySX = @ngaySX WHERE MaSP = @MaSP "
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaSP", TextBox1.Text)
            com.Parameters.AddWithValue("@TenSP", TextBox2.Text)
            com.Parameters.AddWithValue("@DonGia", TextBox3.Text)
            com.Parameters.AddWithValue("@SoLuong", TextBox4.Text)

            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try

        tb.Clear()
        DataGridView1.DataSource = tb


    End Sub


    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "DELETE from SanPham WHERE MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", TextBox1.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi không thanh")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb




    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
