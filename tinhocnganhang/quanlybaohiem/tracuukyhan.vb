Imports System.Data.SqlClient
Imports quanlybaohiem.MySQLcommand

Public Class tracuukyhan
    Protected Friend Const DE_CONNECT_SQL As String = "data source=hp-pc;initial catalog=qlhdbh;integrated security=true"

    Protected Friend Const DE_MAHOADON_AS As String = "Mã hóa đơn"
    Protected Friend Const DE_MAHOPDONG_AS As String = "Mã hợp đồng"
    Protected Friend Const DE_NGAYTHU_AS As String = "ngày thu"
    Protected Friend Const DE_CACHTHUC_AS As String = "cách thức"
    Protected Friend Const DE_SOTIEN_AS As String = "số tiền"

    Protected Friend Const TABLE_TINHTRANGHONNHAN As String = "tinhtranghonnhan"
    Protected Friend Const TABLE_KHACHHANG As String = "Khachhang"
    Protected Friend Const TABLE_HOPDONG As String = "hopdong"
    Protected Friend Const TABLE_HOADON As String = "hoadon"

    Protected Friend Const DE_HD_SOHOADON As String = "soHoadon"
    Protected Friend Const DE_HD_MAHOPDONG As String = "maHD"
    Protected Friend Const DE_HD_NGAYTHU As String = "ngaythu"
    Protected Friend Const DE_HD_CACHTHUC As String = "cachthuc"
    Protected Friend Const DE_HD_SOTIEN As String = "sotien"

    Private Sub btnluuhoadon_Click(sender As Object, e As EventArgs) Handles btnluuhoadon.Click
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "insertdataintotableHoadon"
        cmd.CommandType = CommandType.StoredProcedure
        Dim Mahopdong As Integer
        Int32.TryParse(txtmahopdong.Text, Mahopdong)

        Dim sotien As Double
        If Double.TryParse(txtsotien.Text, sotien) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        cmd.Parameters.AddWithValue(DE_HD_MAHOPDONG, Mahopdong)
        cmd.Parameters.AddWithValue(DE_HD_NGAYTHU, dtngaythu.Text)
        cmd.Parameters.AddWithValue(DE_HD_CACHTHUC, txtcachthuc.Text)
        cmd.Parameters.AddWithValue(DE_HD_SOTIEN, sotien)
        cmd.ExecuteNonQuery()
        dongketnoi()
        tracuukyhan_Load(sender, e)
    End Sub
    Public Sub deleteText()
        txtmahoadon.Text = ""
        txtmahopdong.Text = ""
        dtngaythu.Text = ""
        txtcachthuc.Text = ""
        txtsotien.Text = ""
        txtmahoadon.Focus()
    End Sub


    Private Sub tracuukyhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        'Connect to db
        ds = loaddata()
        DataGridView2.DataSource = ds.Tables(0)

        'clear old data
        txtmahoadon.DataBindings.Clear()
        txtmahopdong.DataBindings.Clear()
        dtngaythu.DataBindings.Clear()
        txtcachthuc.DataBindings.Clear()
        txtsotien.DataBindings.Clear()
       

        '    Dim _dateString As String = "22-2009-11"
        'Dim _date As DateTime =  DateTime.ParseExact(_dateString,"dd-yyyy-MM",CultureInfo.InvariantCulture);
        'parse data from ds to dtgrid



        txtmahoadon.DataBindings.Add("text", ds.Tables(0), DE_MAHOADON_AS)
        txtmahopdong.DataBindings.Add("text", ds.Tables(0), DE_MAHOPDONG_AS)
        dtngaythu.DataBindings.Add("text", ds.Tables(0), DE_NGAYTHU_AS)
        txtcachthuc.DataBindings.Add("text", ds.Tables(0), DE_CACHTHUC_AS)
        txtsotien.DataBindings.Add("text", ds.Tables(0), DE_SOTIEN_AS)
        deleteText()
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
        Dim da As New SqlDataAdapter("select " + DE_HD_SOHOADON + " as [" + DE_MAHOADON_AS + "], " + DE_HD_MAHOPDONG + " as [" + DE_MAHOPDONG_AS + "]," + DE_HD_NGAYTHU + " as [" + DE_NGAYTHU_AS + "], " + DE_HD_CACHTHUC + " as [" + DE_CACHTHUC_AS + "]," + DE_HD_SOTIEN + " as [" + DE_SOTIEN_AS + "]  from " + TABLE_HOADON, con)
        da.Fill(ds)
        'myConnect.dongketnoi()

        dongketnoi()

        Return ds
    End Function
   
    Private Sub btncapnhathoadon_Click(sender As Object, e As EventArgs) Handles btncapnhathoadon.Click
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "UpdateDataInsideTableHoadon"
        cmd.CommandType = CommandType.StoredProcedure
       
       
        cmd.Parameters.AddWithValue(DE_HD_SOHOADON, txtmahoadon.Text)
        cmd.Parameters.AddWithValue(DE_HD_MAHOPDONG, txtmahopdong.Text)
        cmd.Parameters.AddWithValue(DE_HD_NGAYTHU, dtngaythu.Text)
        cmd.Parameters.AddWithValue(DE_HD_CACHTHUC, txtcachthuc.Text)
        cmd.Parameters.AddWithValue(DE_HD_SOTIEN, txtsotien.Text)
        
        cmd.ExecuteNonQuery()
        dongketnoi()
        tracuukyhan_Load(sender, e)
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "DeleteDataFromTableHoadon"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue(DE_HD_SOHOADON, txtmahoadon.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        tracuukyhan_Load(sender, e)
    End Sub


    Private Function TimKiem(ngay As Integer, thang As Integer) As DataTable
        taoketnoi()
        Dim sTruyVan As String = String.Format("select * from Hopdong where day(ngaycohieuluc) = {0} and month(ngaycohieuluc) = {1}", ngay, thang)
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

  

    Private Sub txtmatimkiemhoadon_TextChanged(sender As Object, e As EventArgs) Handles txtmatimkiemhoadon.TextChanged
        
    End Sub



    
    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim tgian As DateTime = dtthoigian.Value
        Dim ngay As Integer = tgian.Day
        Dim thang As Integer = tgian.Month
        Dim nam As Integer = tgian.Year

    End Sub

    Private Sub dtthoigian_ValueChanged(sender As Object, e As EventArgs) Handles dtthoigian.ValueChanged
        Dim ngay, thang, nam As Integer
        Dim tgian As DateTime = dtthoigian.Value
        ngay = tgian.Day
        thang = tgian.Month
        nam = tgian.Year
        Dim dt As DataTable = TimKiem(ngay, thang)
        DataGridView1.DataSource = dt
    End Sub
    Private Function TimKiem1(sTuKhoa As String) As DataTable
        taoketnoi()
        Dim sTruyVan As String = "select " + DE_HD_SOHOADON + " as [" + DE_MAHOADON_AS + "], " + DE_HD_MAHOPDONG + " as [" + DE_MAHOPDONG_AS + "]," + DE_HD_NGAYTHU + " as [" + DE_NGAYTHU_AS + "], " + DE_HD_CACHTHUC + " as [" + DE_CACHTHUC_AS + "]," + DE_HD_SOTIEN + " as [" + DE_SOTIEN_AS + "] from Hoadon where soHoadon like N'%" + sTuKhoa + "%' or maHD like N'%" + sTuKhoa + "%' or ngaythu like N'%" + sTuKhoa + "%' or cachthuc like N'%" + sTuKhoa + "%' or sotien like N'%" + sTuKhoa + "%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

    

    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txtmatimkiemhoadon.TextChanged
        Dim sTuKhoa As String
        sTuKhoa = txtmatimkiemhoadon.Text
        Dim dt As DataTable = TimKiem1(sTuKhoa)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

   
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        With DataGridView2
            txtmahoadon.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_MAHOADON_AS).Value
            txtmahopdong.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_MAHOPDONG_AS).Value
            dtngaythu.Value = .Rows(.CurrentCell.RowIndex).Cells(DE_NGAYTHU_AS).Value
            txtcachthuc.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_CACHTHUC_AS).Value
            txtsotien.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIEN_AS).Value



        End With
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class