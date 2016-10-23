
Imports System.Data.SqlClient
Imports quanlybaohiem.MySQLcommand
Public Class themmoisua

   


    Protected Friend Const DE_CONNECT_SQL As String = "data source=hp-pc;initial catalog=qlhdbh;integrated security=true"

    'define CONST for Custom
    'define as
    Protected Friend Const DE_MAKH_AS As String = "IDKhachhang"
    Protected Friend Const DE_HOVATEN_AS As String = "hovaten"
    Protected Friend Const DE_GIOITINH_AS As String = "gioitinh"
    Protected Friend Const DE_TINHTRANG_AS As String = "tinhtrang"
    Protected Friend Const DE_NGAYSINH_AS As String = "ngaysinh"
    Protected Friend Const DE_NOISINH_AS As String = "noisinh"
    Protected Friend Const DE_QUOCTICH_AS As String = "quoctich"
    Protected Friend Const DE_SOCMND_AS As String = "socmnd"
    Protected Friend Const DE_NGAYCAP_AS As String = "ngaycap"
    Protected Friend Const DE_NOICAP_AS As String = "noicap"
    Protected Friend Const DE_DIACHITHUONGTRU_AS As String = "diachithuongtru"
    Protected Friend Const DE_NGHENGHIEP_AS As String = "nghenghiep"
    Protected Friend Const DE_DIENTHOAI_AS As String = "dienthoai"
    Protected Friend Const DE_TENCOQUAN_AS As String = "tencoquan"
    Protected Friend Const DE_DIACHICOQUAN_AS As String = "diachicoquan"
    Protected Friend Const DE_THUNHAPMOTNAM_AS As String = "thunhapmotnam"
    Protected Friend Const DE_SOTK_AS As String = "sotk"



    'define table
    Protected Friend Const TABLE_TINHTRANGQUANHE As String = "tinhtrangquanhe"
    Protected Friend Const TABLE_KHACHHANG As String = "Khachhang"
    Protected Friend Const TABLE_HOPDONG As String = "hopdong"
    Protected Friend Const TABLE_HOADON As String = "hoadon"

    'define column
    Protected Friend Const DE_CUS_IDKHACHHANG As String = "idkhachhang"
    Protected Friend Const DE_CUS_HOVATEN As String = "hovaten"
    Protected Friend Const DE_CUS_GIOITINH As String = "gioitinh"
    Protected Friend Const DE_CUS_TINHTRANG As String = "tinhtrang"
    Protected Friend Const DE_CUS_NGAYSINH As String = "ngaysinh"
    Protected Friend Const DE_CUS_NOISINH As String = "noisinh"
    Protected Friend Const DE_CUS_QUOCTICH As String = "quoctich"
    Protected Friend Const DE_CUS_SOCMND As String = "socmnd"
    Protected Friend Const DE_CUS_NGAYCAP As String = "ngaycap"
    Protected Friend Const DE_CUS_NOICAP As String = "noicap"
    Protected Friend Const DE_CUS_DIACHITHUONGTRU As String = "diachithuongtru"
    Protected Friend Const DE_CUS_NGHENGHIEP As String = "nghenghiep"
    Protected Friend Const DE_CUS_DIENTHOAI As String = "dienthoai"
    Protected Friend Const DE_CUS_TENCOQUAN As String = "tencoquan"
    Protected Friend Const DE_CUS_DIACHICOQUAN As String = "diachicoquan"
    Protected Friend Const DE_CUS_THUNHAPMOTNAM As String = "thunhapmotnam"
    Protected Friend Const DE_CUS_SOTK As String = "sotk"
    'for produce
    Protected Friend Const DE_PRODUCE_INSERT_CUSTOM As String = "insertdataintotableKH"
    Protected Friend Const DE_PRODUCE_INSERT_TINHTRANG As String = "Tinhtrang"


    Public Property stringpass As String

    Private Sub btnthemmoi_Click(sender As Object, e As EventArgs) Handles btnthemmoi.Click
        Dim frm As New Form2
        frm.ShowDialog()

    End Sub
    Dim con As New SqlConnection
    Public Sub taoketnoi()
        Try
            Dim strketnoi As String = DE_CONNECT_SQL
            con.ConnectionString = strketnoi
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub dongketnoi()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Function loaddata() As DataSet
        'Dim myConnect As New MySQLcommand()

        'myConnect.taoketnoi()

        taoketnoi()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select " + DE_CUS_IDKHACHHANG + " as [" + DE_MAKH_AS + "], " + DE_CUS_HOVATEN + " as [" + DE_HOVATEN_AS + "]," + DE_CUS_GIOITINH + " as [" + DE_GIOITINH_AS + "], " + DE_CUS_TINHTRANG + " as [" + DE_TINHTRANG_AS + "]," + DE_CUS_NGAYSINH + " as [" + DE_NGAYSINH_AS + "], " + DE_CUS_NOISINH + " as [" + DE_NOISINH_AS + "], " + DE_CUS_QUOCTICH + " as [" + DE_QUOCTICH_AS + "], " + DE_CUS_SOCMND + " as [" + DE_SOCMND_AS + "], " + DE_CUS_NGAYCAP + " as [" + DE_NGAYCAP_AS + "], " + DE_CUS_NOICAP + " as [" + DE_NOICAP_AS + "], " + DE_CUS_DIACHITHUONGTRU + " as [" + DE_DIACHITHUONGTRU_AS + "], " + DE_CUS_NGHENGHIEP + " as [" + DE_NGHENGHIEP_AS + "], " + DE_CUS_DIENTHOAI + " as [" + DE_DIENTHOAI_AS + "], " + DE_CUS_TENCOQUAN + " as [" + DE_TENCOQUAN_AS + "], " + DE_CUS_DIACHICOQUAN + " as [" + DE_DIACHICOQUAN_AS + "], " + DE_CUS_THUNHAPMOTNAM + " as [" + DE_THUNHAPMOTNAM_AS + "], " + DE_CUS_SOTK + " as [" + DE_SOTK_AS + "]  from " + TABLE_KHACHHANG, con)
        da.Fill(ds)
        'myConnect.dongketnoi()

        dongketnoi()

        Return ds
    End Function
    Private Sub themmoisua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDTGV()

        'Connect to db



    End Sub
    Public Sub LoadDTGV()
        Dim ds As New DataSet
        ds = loaddata()
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btncapnhathoso_Click(sender As Object, e As EventArgs) Handles btncapnhathoso.Click
        Dim makh, HoTen, gioitinh, ngaysinh, noisinh, quoctich, cmnd, ngaycmnd, noicapcmnd, diachi, nghenghiep, sdt, tencoquan, diachicoquan, thunhap, tinhtrang, sotk As String
        
        Dim frm As New Form2
        With Me.DataGridView1
            makh = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_IDKHACHHANG).Value
            HoTen = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_HOVATEN).Value
            gioitinh = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_GIOITINH).Value
            tinhtrang = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_TINHTRANG).Value
            ngaysinh = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_NGAYSINH).Value
            noisinh = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_NOISINH).Value
            quoctich = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_QUOCTICH).Value
            cmnd = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_SOCMND).Value
            ngaycmnd = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_NGAYCAP).Value
            noicapcmnd = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_NOICAP).Value
            diachi = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_DIACHITHUONGTRU).Value
            nghenghiep = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_NGHENGHIEP).Value
            sdt = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_DIENTHOAI).Value
            tencoquan = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_TENCOQUAN).Value
            diachicoquan = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_DIACHICOQUAN).Value
            thunhap = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_THUNHAPMOTNAM).Value
            sotk = .Rows(.CurrentCell.RowIndex).Cells(DE_CUS_SOTK).Value

            

        End With
        frm.Show()
        frm.txtmakh.Text = makh
        frm.txtHoTen.Text = HoTen
        frm.cbgioitinh.Text = gioitinh
        frm.txttinhtrang.Text = tinhtrang
        frm.dtNgaySinh.Text = ngaysinh
        frm.txtNoiSinh.Text = noisinh
        frm.txtQuocTich.Text = quoctich
        frm.txtCMND.Text = cmnd
        frm.dtNgayCMND.Text = ngaycmnd
        frm.txtNoiCapCMND.Text = noicapcmnd
        frm.txtDiaChi.Text = diachi
        frm.txtNgheNghiep.Text = nghenghiep
        frm.txtSDT.Text = sdt
        frm.txtTenCoQuan.Text = tencoquan
        frm.txtDiaChiCoQuan.Text = diachicoquan
        frm.txtThuNhap.Text = thunhap
        frm.txtSoTK.Text = sotk

        

        
     

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = New DataGridViewRow


    End Sub

    Private Sub btnxoahosokhachhang_Click(sender As Object, e As EventArgs) Handles btnxoahosokhachhang.Click
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "deletedatafromtableKH"
        cmd.CommandType = CommandType.StoredProcedure
        Dim makh As String
        With Me.DataGridView1
            makh = .Rows(.CurrentCell.RowIndex).Cells("IDKhachhang").Value
        End With

        cmd.Parameters.AddWithValue(DE_CUS_IDKHACHHANG, makh)
        cmd.ExecuteNonQuery()
        dongketnoi()
        themmoisua_Load(sender, e)
    End Sub
    Private Function TimKiem(sTuKhoa As String) As DataTable
        taoketnoi()
        Dim sTruyVan As String = "select * from Khachhang where IDKhachhang like N'%" + sTuKhoa + "%' or Hovaten like N'%" + sTuKhoa + "%' or Gioitinh like N'%" + sTuKhoa + "%' or Tinhtrang like N'%" + sTuKhoa + "%' or Ngaysinh like N'%" + sTuKhoa + "%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        Dim sTuKhoa As String
        sTuKhoa = txttimkiem.Text
        Dim dt As DataTable = TimKiem(sTuKhoa)
        DataGridView1.DataSource = dt
    End Sub
    Private Function LayBang(truyvan As String, con As SqlConnection) As DataTable
        taoketnoi()
        Dim da As SqlDataAdapter = New SqlDataAdapter(truyvan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function
    Private Sub TruyVanNonQuery(truyvan As String)
        taoketnoi()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandText = truyvan
        cmd.Connection = con
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim makh As String
        Dim frm As New form3
        With Me.DataGridView1
            makh = .Rows(.CurrentCell.RowIndex).Cells("IDKhachhang").Value
        End With
        frm.Show()
        frm.txtmakhachhang.Text = makh
    End Sub
End Class
