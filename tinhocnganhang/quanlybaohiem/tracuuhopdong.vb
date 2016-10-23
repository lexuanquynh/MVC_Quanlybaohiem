Imports System.Data.SqlClient
Imports quanlybaohiem.MySQLcommand
Public Class tracuuhopdong

    Private Sub btnthoat_Click(sender As Object, e As EventArgs)
        Me.Close()
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
    Private Sub btnreset_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsuahopdong_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tracuuhopdong_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub TruyVanNonQuery(truyvan As String)
        taoketnoi()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandText = truyvan
        cmd.Connection = con
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub dtdoanhthutrongngay_ValueChanged(sender As Object, e As EventArgs) Handles dtdoanhthutrongngay.ValueChanged
        Dim tgian As DateTime = dtdoanhthutrongngay.Value
        Dim ngay As Integer = tgian.Day
        Dim thang As Integer = tgian.Month
        Dim nam As Integer = tgian.Year
        Dim ds As DataTable = LoadData(ngay, thang, nam)
        Dim dt As DataTable = LoadData2(ngay, thang)
        Dim sum1, sum2 As Double
        If (ds.Rows.Count > 0) Then
            sum1 = Convert.ToDouble(ds.Compute("SUM(sotien)", String.Empty))
        Else : sum1 = 0
        End If
        If (dt.Rows.Count > 0) Then
            sum2 = Convert.ToDouble(dt.Compute("SUM(phibaohiemdinhky)", String.Empty))
        Else : sum2 = 0
        End If
        DataGridView1.DataSource = ds
        txtthucthu.Text = sum1.ToString()
        txtdoanhthu.Text = sum2.ToString()
    End Sub
   
    Public Function LoadData(ngay As Integer, thang As Integer, nam As Integer) As DataTable
        taoketnoi()
        Dim sTruyVan As String = String.Format("select * from Hoadon where day(ngaythu) ={0} and month(ngaythu) = {1} and year(ngaythu) = {2}", ngay, thang, nam)
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Function LoadData2(ngay As Integer, thang As Integer) As DataTable
        taoketnoi()
        Dim sTruyVan As String = String.Format("select * from Hopdong where day(ngaycohieuluc) = {0} and month(ngaycohieuluc) = {1}", ngay, thang)
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function
End Class