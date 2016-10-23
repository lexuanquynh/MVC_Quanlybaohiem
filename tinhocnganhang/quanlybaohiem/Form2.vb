Imports System.Data.SqlClient
Imports quanlybaohiem.MySQLcommand


Public Class Form2

    Private Sub btnhuybo_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Connect cmd
    Protected Friend Const DE_CONNECT_SQL As String = "data source=hp-pc;initial catalog=qlhdbh;integrated security=true"

    'define CONST for Custom
    'define as
    Protected Friend Const DE_MAKH_AS As String = "Mã khách hàng"
    Protected Friend Const DE_HOVATEN_AS As String = "họ và tên"
    Protected Friend Const DE_GIOITINH_AS As String = "giới tính (NAM)"
    Protected Friend Const DE_TINHTRANG_AS As String = "tình trạng"
    Protected Friend Const DE_NGAYSINH_AS As String = "ngày sinh"
    Protected Friend Const DE_NOISINH_AS As String = "nơi sinh"
    Protected Friend Const DE_QUOCTICH_AS As String = "quốc tịch"
    Protected Friend Const DE_SOCMND_AS As String = "số cmnd"
    Protected Friend Const DE_NGAYCAP_AS As String = "ngày cấp cmnd"
    Protected Friend Const DE_NOICAP_AS As String = "nơi cấp cmnd"
    Protected Friend Const DE_DIACHITHUONGTRU_AS As String = "địa chỉ thường trú"
    Protected Friend Const DE_NGHENGHIEP_AS As String = "nghề nghiệp"
    Protected Friend Const DE_DIENTHOAI_AS As String = "điện thoại"
    Protected Friend Const DE_TENCOQUAN_AS As String = "tên cơ quan"
    Protected Friend Const DE_DIACHICOQUAN_AS As String = "địa chỉ cơ quan"
    Protected Friend Const DE_THUNHAPMOTNAM_AS As String = "thu nhập một năm"
    Protected Friend Const DE_SOTK_AS As String = "số tk"



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

    Private Sub btnluu_click(sender As Object, e As EventArgs) Handles btnluu.Click
        If isNull() Then
            If ThemMoi() Then
                MessageBox.Show("Thêm thành công")
            Else
                MessageBox.Show("Thêm thất bại")
            End If
        Else
            If Sua() Then
                MessageBox.Show("Sửa thành công")
            Else
                MessageBox.Show("Sửa thất bại")
            End If
        End If

        themmoisua.LoadDTGV()
        Me.Close()
    End Sub
    Private Function ThemMoi() As Boolean
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con


        cmd.CommandText = DE_PRODUCE_INSERT_CUSTOM
        cmd.CommandType = CommandType.StoredProcedure
        Dim gioitinh As Integer
        gioitinh = cbgioitinh.SelectedIndex
        'Dim tinhtrang As Integer


        '   Dim gioitinh As Short
        ' gioitinh = Convert.ToInt16(txtgioitinh.Text, 16)
        ''Long gioitinh = Convert.ToInt16(txtgioitinh.Text)

        'Dim text As String = txtThuNhap.Text
        Dim thunhap As Double
        If Double.TryParse(txtThuNhap.Text, thunhap) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If
        Try
            cmd.Parameters.AddWithValue(DE_CUS_HOVATEN, txtHoTen.Text)
            cmd.Parameters.AddWithValue(DE_CUS_GIOITINH, gioitinh)
            cmd.Parameters.AddWithValue(DE_CUS_TINHTRANG, txttinhtrang.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGAYSINH, dtNgaySinh.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NOISINH, txtNoiSinh.Text)
            cmd.Parameters.AddWithValue(DE_CUS_QUOCTICH, txtQuocTich.Text)
            cmd.Parameters.AddWithValue(DE_CUS_SOCMND, txtCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGAYCAP, dtNgayCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NOICAP, txtNoiCapCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIACHITHUONGTRU, txtDiaChi.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGHENGHIEP, txtNgheNghiep.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIENTHOAI, txtSDT.Text)
            cmd.Parameters.AddWithValue(DE_CUS_TENCOQUAN, txtTenCoQuan.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIACHICOQUAN, txtDiaChiCoQuan.Text)
            cmd.Parameters.AddWithValue(DE_CUS_THUNHAPMOTNAM, thunhap)
            cmd.Parameters.AddWithValue(DE_CUS_SOTK, txtSoTK.Text)
            cmd.ExecuteNonQuery()
            dongketnoi()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
    Private Function Sua() As Boolean
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "updatedatainsidetableKH"
        cmd.CommandType = CommandType.StoredProcedure
        Dim gioitinh As Integer
        gioitinh = cbgioitinh.SelectedIndex
        'Dim tinhtrang As Integer
        'tinhtrang = cbTinhTrang.SelectedIndex + 1

        '   Dim gioitinh As Short
        ' gioitinh = Convert.ToInt16(txtgioitinh.Text, 16)
        ''Long gioitinh = Convert.ToInt16(txtgioitinh.Text)

        'Dim text As String = txtThuNhap.Text
        Dim thunhap As Double
        If Double.TryParse(txtThuNhap.Text, thunhap) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If
        Try
            cmd.Parameters.AddWithValue(DE_CUS_IDKHACHHANG, txtmakh.Text)
            cmd.Parameters.AddWithValue(DE_CUS_HOVATEN, txtHoTen.Text)
            cmd.Parameters.AddWithValue(DE_CUS_GIOITINH, gioitinh)
            cmd.Parameters.AddWithValue(DE_CUS_TINHTRANG, txttinhtrang.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGAYSINH, dtNgaySinh.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NOISINH, txtNoiSinh.Text)
            cmd.Parameters.AddWithValue(DE_CUS_QUOCTICH, txtQuocTich.Text)
            cmd.Parameters.AddWithValue(DE_CUS_SOCMND, txtCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGAYCAP, dtNgayCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NOICAP, txtNoiCapCMND.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIACHITHUONGTRU, txtDiaChi.Text)
            cmd.Parameters.AddWithValue(DE_CUS_NGHENGHIEP, txtNgheNghiep.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIENTHOAI, txtSDT.Text)
            cmd.Parameters.AddWithValue(DE_CUS_TENCOQUAN, txtTenCoQuan.Text)
            cmd.Parameters.AddWithValue(DE_CUS_DIACHICOQUAN, txtDiaChiCoQuan.Text)
            cmd.Parameters.AddWithValue(DE_CUS_THUNHAPMOTNAM, thunhap)
            cmd.Parameters.AddWithValue(DE_CUS_SOTK, txtSoTK.Text)
            cmd.ExecuteNonQuery()
            dongketnoi()
            Return True
        Catch ex As Exception
            Return False
        End Try
        

    End Function
    Private Function isNull() As Boolean
        If txtmakh.Text = "" Then
            Return True
        Else : Return False
        End If
    End Function
    'Viết một sub xóa text khi lưu thành công và đặt name là con trỏ (focus)
    Public Sub deleteText()
        txtmakh.Text = ""
        txtHoTen.Text = ""
        cbgioitinh.Text = ""
        txttinhtrang.Text = ""
        dtNgaySinh.Text = ""
        txtNoiSinh.Text = ""
        txtCMND.Text = ""
        txtQuocTich.Text = ""
        dtNgayCMND.Text = ""
        txtNoiCapCMND.Text = ""
        txtDiaChi.Text = ""
        txtNgheNghiep.Text = ""
        txtSDT.Text = ""
        txtTenCoQuan.Text = ""
        txtDiaChiCoQuan.Text = ""
        txtThuNhap.Text = ""
        txtSoTK.Text = ""
        txtHoTen.Focus()
    End Sub


    Private Sub form2_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        cbgioitinh.SelectedIndex = 1
        'Connect to db
      

        'clear old data
        txtmakh.databindings.clear()
        txthoten.databindings.clear()
        cbgioitinh.DataBindings.Clear()
        txttinhtrang.DataBindings.Clear()
        dtngaysinh.databindings.clear()
        txtnoisinh.databindings.clear()
        txtquoctich.databindings.clear()
        txtcmnd.databindings.clear()
        dtngaycmnd.databindings.clear()
        txtNoiCapCMND.DataBindings.Clear()
        txtdiachi.databindings.clear()
        txtnghenghiep.databindings.clear()
        txtsdt.databindings.clear()
        txttencoquan.databindings.clear()
        txtdiachicoquan.databindings.clear()
        txtthunhap.databindings.clear()
        txtsotk.databindings.clear()

        '    Dim _dateString As String = "22-2009-11"
        'Dim _date As DateTime =  DateTime.ParseExact(_dateString,"dd-yyyy-MM",CultureInfo.InvariantCulture);
        'parse data from ds to dtgrid

        txttinhtrang.DataBindings.Clear()



        'Connect to db
        ds = loaddata()


        txtmakh.DataBindings.Add("text", ds.Tables(0), DE_MAKH_AS)
        txtHoTen.DataBindings.Add("text", ds.Tables(0), DE_HOVATEN_AS)
        cbgioitinh.DataBindings.Add("text", ds.Tables(0), DE_GIOITINH_AS)
        txttinhtrang.DataBindings.Add("text", ds.Tables(0), DE_TINHTRANG_AS)
        txtNoiSinh.DataBindings.Add("text", ds.Tables(0), DE_NOISINH_AS)
        txtQuocTich.DataBindings.Add("text", ds.Tables(0), DE_QUOCTICH_AS)
        txtCMND.DataBindings.Add("text", ds.Tables(0), DE_SOCMND_AS)
        dtNgayCMND.DataBindings.Add("text", ds.Tables(0), DE_NGAYCAP_AS)
        txtNoiCapCMND.DataBindings.Add("text", ds.Tables(0), DE_NOICAP_AS)
        txtDiaChi.DataBindings.Add("text", ds.Tables(0), DE_DIACHITHUONGTRU_AS)
        txtNgheNghiep.DataBindings.Add("text", ds.Tables(0), DE_NGHENGHIEP_AS)
        txtSDT.DataBindings.Add("text", ds.Tables(0), DE_DIENTHOAI_AS)
        txtTenCoQuan.DataBindings.Add("text", ds.Tables(0), DE_TENCOQUAN_AS)
        txtDiaChiCoQuan.DataBindings.Add("text", ds.Tables(0), DE_DIACHICOQUAN_AS)
        txtThuNhap.DataBindings.Add("text", ds.Tables(0), DE_THUNHAPMOTNAM_AS)
        txtSoTK.DataBindings.Add("text", ds.Tables(0), DE_SOTK_AS)
        deleteText()
        ', ngaycap as [ngày cấp cmnd], noicap as [nơi cấp cmnd], diachithuongtru as [địa chỉ thường trú], nghenghiep as [nghề nghiệp], dienthoai as [điện thoại], tencoquan as [tên cơ quan], diachicoquan as [địa chỉ cơ quan], thunhapmotnam as [thu nhập một năm], sotk as [số tk]  from custom", con)


    End Sub
    'Public Sub FilterData(valueToSearch As String)
    '    taoketnoi()
    '    Dim cmd As New SqlCommand
    '    cmd.Connection = con

    '    cmd.CommandType = CommandType.StoredProcedure
    '    'SELECT * From TABLE_KHACHHANG WHERE CONCAT(Mã khách hàng,họ và tên, giới tính (NAM),tình trạng,ngày sinh, nơi sinh, quốc tịch, số cmnd, ngày cấp cmnd, nơi cấp cmnd, địa chỉ thường trú, nghề nghiệp, điện thoại, tên cơ quan, địa chỉ cơ quan,thu nhập một năm, số tk) like '%F%'
    '    Dim searchQuery As String = "SELECT * From Users WHERE (idkhachhang,hovaten , gioitinh,idtinhtrang,ngaysinh,noisinh,quoctich,socmnd,ngaycap,noicap,diachithuongtru,nghenghiep,dienthoai,tencoquan,diachicoquan,thunhapmotnam,sotk) like '%" & valueToSearch & "%'"

    '    Dim command As New SqlCommand(searchQuery, con)
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim table As New DataTable()

    '    adapter.Fill(table)

    '    DataGridView1.DataSource = table

    'End Sub

    'Private Sub txttimkiem_textchanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
    '    FilterData(txttimkiem.Text)
    'End Sub

    'Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
    '    FilterData(txttimkiem.Text)
    'End Sub
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





    Private Sub btnTaohopdong_Click(sender As Object, e As EventArgs) Handles btnTaohopdong.Click
        form3.Show()
    End Sub



    Private Sub btncapnhathoso_Click(sender As Object, e As EventArgs)
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "updatedatainsidetableKH"
        cmd.CommandType = CommandType.StoredProcedure
        Dim gioitinh As Integer
        gioitinh = cbgioitinh.SelectedIndex
        'Dim tinhtrang As Integer
        'tinhtrang = cbTinhTrang.SelectedIndex + 1

        '   Dim gioitinh As Short
        ' gioitinh = Convert.ToInt16(txtgioitinh.Text, 16)
        ''Long gioitinh = Convert.ToInt16(txtgioitinh.Text)

        'Dim text As String = txtThuNhap.Text
        Dim thunhap As Double
        If Double.TryParse(txtThuNhap.Text, thunhap) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If
        cmd.Parameters.AddWithValue(DE_CUS_IDKHACHHANG, txtmakh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_HOVATEN, txtHoTen.Text)
        cmd.Parameters.AddWithValue(DE_CUS_GIOITINH, gioitinh)
        cmd.Parameters.AddWithValue(DE_CUS_TINHTRANG, txttinhtrang.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGAYSINH, dtNgaySinh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NOISINH, txtNoiSinh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_QUOCTICH, txtQuocTich.Text)
        cmd.Parameters.AddWithValue(DE_CUS_SOCMND, txtCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGAYCAP, dtNgayCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NOICAP, txtNoiCapCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIACHITHUONGTRU, txtDiaChi.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGHENGHIEP, txtNgheNghiep.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIENTHOAI, txtSDT.Text)
        cmd.Parameters.AddWithValue(DE_CUS_TENCOQUAN, txtTenCoQuan.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIACHICOQUAN, txtDiaChiCoQuan.Text)
        cmd.Parameters.AddWithValue(DE_CUS_THUNHAPMOTNAM, thunhap)
        cmd.Parameters.AddWithValue(DE_CUS_SOTK, txtSoTK.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        form2_load(sender, e)
    End Sub

  
    Private Sub btnxoahosokhachhang_Click(sender As Object, e As EventArgs)
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "deletedatafromtableKH"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue(DE_CUS_IDKHACHHANG, txtmakh.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        form2_load(sender, e)
    End Sub

  
   
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs)
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "updatedatainsidetableKH"
        cmd.CommandType = CommandType.StoredProcedure
        Dim gioitinh As Integer
        gioitinh = cbgioitinh.SelectedIndex
        'Dim tinhtrang As Integer
        'tinhtrang = cbTinhTrang.SelectedIndex + 1

        '   Dim gioitinh As Short
        ' gioitinh = Convert.ToInt16(txtgioitinh.Text, 16)
        ''Long gioitinh = Convert.ToInt16(txtgioitinh.Text)

        'Dim text As String = txtThuNhap.Text
        Dim thunhap As Double
        If Double.TryParse(txtThuNhap.Text, thunhap) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If
        cmd.Parameters.AddWithValue(DE_CUS_IDKHACHHANG, txtmakh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_HOVATEN, txtHoTen.Text)
        cmd.Parameters.AddWithValue(DE_CUS_GIOITINH, gioitinh)
        cmd.Parameters.AddWithValue(DE_CUS_TINHTRANG, txttinhtrang.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGAYSINH, dtNgaySinh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NOISINH, txtNoiSinh.Text)
        cmd.Parameters.AddWithValue(DE_CUS_QUOCTICH, txtQuocTich.Text)
        cmd.Parameters.AddWithValue(DE_CUS_SOCMND, txtCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGAYCAP, dtNgayCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NOICAP, txtNoiCapCMND.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIACHITHUONGTRU, txtDiaChi.Text)
        cmd.Parameters.AddWithValue(DE_CUS_NGHENGHIEP, txtNgheNghiep.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIENTHOAI, txtSDT.Text)
        cmd.Parameters.AddWithValue(DE_CUS_TENCOQUAN, txtTenCoQuan.Text)
        cmd.Parameters.AddWithValue(DE_CUS_DIACHICOQUAN, txtDiaChiCoQuan.Text)
        cmd.Parameters.AddWithValue(DE_CUS_THUNHAPMOTNAM, thunhap)
        cmd.Parameters.AddWithValue(DE_CUS_SOTK, txtSoTK.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        form2_load(sender, e)
        themmoisua.LoadDTGV()
    End Sub
End Class