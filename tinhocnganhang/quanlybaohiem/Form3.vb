Imports System.Data.SqlClient
Imports quanlybaohiem.MySQLcommand
Public Class form3



    'Connect cmd
    Protected Friend Const DE_CONNECT_SQL As String = "data source=hp-pc;initial catalog=qlhdbh;integrated security=true"

    Protected Friend Const DE_MAHD_AS As String = "mã hợp đồng"
    Protected Friend Const DE_IDKH_AS As String = "ID Khách Hàng"
    Protected Friend Const DE_SPBAOHIEM_AS As String = "Sản phẩm bảo hiểm"
    Protected Friend Const DE_SOTIENBAOHIEM_AS As String = "Số tiền bảo hiểm"
    Protected Friend Const DE_KYHANBAOHIEM_AS As String = "Kỳ hạn bảo hiểm"
    Protected Friend Const DE_DINHKYBAOHIEM_AS As String = "Định kỳ bảo hiểm"
    Protected Friend Const DE_PHI_AS As String = "Phí bảo hiểm định kỳ"
    Protected Friend Const DE_SOTIENDAOHAN_AS As String = "Số tiền đáo hạn"
    Protected Friend Const DE_NGAYHD_AS As String = "Ngày có hiệu lực"
    Protected Friend Const DE_BOSUNG_AS As String = "Sản phẩm bảo hiểm bổ sung"
    Protected Friend Const DE_PHUONGTHUC_AS As String = "Phương thức trả"
    Protected Friend Const DE_NGUONGOCBAOHIEM_AS As String = "Nguồn gôc phí bảo hiểm"
    Protected Friend Const DE_BENHVIENCHITRA_AS As String = "Bệnh viện được chi trả"

    Protected Friend Const de_hop_mahd As String = "maHD"
    Protected Friend Const de_hop_makhachhang As String = "IDKhachHang"
    Protected Friend Const de_hop_sanphambaohiem As String = "spbaohiem"
    Protected Friend Const de_hop_sotienbaohiem As String = "sotienbaohiem"
    Protected Friend Const de_hop_kyhanbaohiem As String = "kyhanbaohiem"
    Protected Friend Const de_hop_dinhkydongbaohiem As String = "dinhkybaohiem"
    Protected Friend Const de_hop_phi As String = "phibaohiemdinhky"
    Protected Friend Const de_hop_sotiendaohan As String = "sotiendaohan"
    Protected Friend Const de_hop_ngayhd As String = "ngaycohieuluc"
    Protected Friend Const de_hop_bosung As String = "sanphambaohiembosung"
    Protected Friend Const de_hop_phuongthuc As String = "phuongthuctra"
    Protected Friend Const de_hop_nguongoc As String = "nguongocphibaohiem"
    Protected Friend Const de_hop_benhvien As String = "benhvienduocchitra"

    Protected Friend Const TABLE_TINHTRANGHONNHAN As String = "tinhtranghonnhan"
    Protected Friend Const TABLE_KHACHHANG As String = "Khachhang"
    Protected Friend Const TABLE_HOPDONG As String = "hopdong"
    Protected Friend Const TABLE_HOADON As String = "hoadon"

    Protected Friend Const DE_PRODUCE_INSERT_HOPDONG As String = "insertdataintotableHD"

    
    Private Function LayBang(truyvan As String, con As SqlConnection) As DataTable
        taoketnoi()
        Dim da As SqlDataAdapter = New SqlDataAdapter(truyvan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function
    Private Sub TruyVanNonQuery(truyvan As String, con As SqlConnection)
        taoketnoi()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandText = truyvan
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        dongketnoi()
    End Sub

    Private Sub btnluuhopdong_click(sender As Object, e As EventArgs) Handles btnluuhopdong.Click
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = DE_PRODUCE_INSERT_HOPDONG
        cmd.CommandType = CommandType.StoredProcedure
        Dim IDKH As Integer
        Int32.TryParse(txtmakhachhang.Text, IDKH)

        Dim sotienbaohiem As Double
        If Double.TryParse(txtSoTienBaoHiem.Text, sotienbaohiem) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        Dim phi As Double
        If Double.TryParse(txtPhi.Text, phi) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        Dim sotiendaohan As Double
        If Double.TryParse(txtSoTienDaoHan.Text, sotiendaohan) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        cmd.Parameters.AddWithValue(de_hop_makhachhang, IDKH)
        cmd.Parameters.AddWithValue(de_hop_sanphambaohiem, txtSanPhamBaoHiem.Text)
        cmd.Parameters.AddWithValue(de_hop_sotienbaohiem, sotienbaohiem)
        cmd.Parameters.AddWithValue(de_hop_kyhanbaohiem, txtKyHanBaoHiem.Text)
        cmd.Parameters.AddWithValue(de_hop_dinhkydongbaohiem, txtdinhkydongbaohiem.Text)
        cmd.Parameters.AddWithValue(de_hop_phi, phi)
        cmd.Parameters.AddWithValue(de_hop_sotiendaohan, sotiendaohan)
        cmd.Parameters.AddWithValue(de_hop_ngayhd, dtNgayHD.Text)
        cmd.Parameters.AddWithValue(de_hop_bosung, txtBoSung.Text)
        cmd.Parameters.AddWithValue(de_hop_phuongthuc, txtPhuongThuc.Text)
        cmd.Parameters.AddWithValue(de_hop_nguongoc, txtNguonGoc.Text)
        cmd.Parameters.AddWithValue(de_hop_benhvien, txtBenhVien.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        form3_load(sender, e)
    End Sub
    Public Sub deleteText()
        txtMaHD.Text = ""
        txtmakhachhang.Text = ""
        txtSanPhamBaoHiem.Text = ""
        txtSoTienBaoHiem.Text = ""
        txtKyHanBaoHiem.Text = ""
        txtdinhkydongbaohiem.Text = ""
        txtPhi.Text = ""
        txtSoTienDaoHan.Text = ""
        dtNgayHD.Text = ""
        txtBoSung.Text = ""
        txtPhuongThuc.Text = ""
        txtNguonGoc.Text = ""
        txtBenhVien.Text = ""
        txtmakhachhang.Focus()
    End Sub
    Private Sub form3_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        'connect to db
        ds = loaddata()
        datagitHopdong.DataSource = ds.Tables(0)

        'clear old data
        txtMaHD.DataBindings.Clear()
        txtmakhachhang.DataBindings.Clear()
        txtSanPhamBaoHiem.DataBindings.Clear()
        txtSoTienBaoHiem.DataBindings.Clear()
        txtKyHanBaoHiem.DataBindings.Clear()
        txtdinhkydongbaohiem.DataBindings.Clear()
        txtPhi.DataBindings.Clear()
        dtNgayHD.DataBindings.Clear()
        txtBoSung.DataBindings.Clear()
        txtPhuongThuc.DataBindings.Clear()
        txtNguonGoc.DataBindings.Clear()
        txtBenhVien.DataBindings.Clear()
        txtSoTienDaoHan.DataBindings.Clear()

        txtMaHD.DataBindings.Add("text", ds.Tables(0), DE_MAHD_AS)
        txtmakhachhang.DataBindings.Add("text", ds.Tables(0), DE_IDKH_AS)
        txtSanPhamBaoHiem.DataBindings.Add("text", ds.Tables(0), DE_SPBAOHIEM_AS)
        txtSoTienBaoHiem.DataBindings.Add("text", ds.Tables(0), DE_SOTIENBAOHIEM_AS)
        txtKyHanBaoHiem.DataBindings.Add("text", ds.Tables(0), DE_KYHANBAOHIEM_AS)
        txtdinhkydongbaohiem.DataBindings.Add("text", ds.Tables(0), DE_DINHKYBAOHIEM_AS)
        txtPhi.DataBindings.Add("text", ds.Tables(0), DE_PHI_AS)
        txtSoTienDaoHan.DataBindings.Add("text", ds.Tables(0), DE_SOTIENDAOHAN_AS)
        dtNgayHD.DataBindings.Add("text", ds.Tables(0), DE_NGAYHD_AS)
        txtBoSung.DataBindings.Add("text", ds.Tables(0), DE_BOSUNG_AS)
        txtPhuongThuc.DataBindings.Add("text", ds.Tables(0), DE_PHUONGTHUC_AS)
        txtNguonGoc.DataBindings.Add("text", ds.Tables(0), DE_NGUONGOCBAOHIEM_AS)
        txtBenhVien.DataBindings.Add("text", ds.Tables(0), DE_BENHVIENCHITRA_AS)
        deletetext()

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
        'Dim myconnect As New MySQLcommand()

        'myconnect.taoketnoi()

        taoketnoi()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select " + de_hop_mahd + " as [" + DE_MAHD_AS + "], " + de_hop_makhachhang + " as [" + DE_IDKH_AS + "], " + de_hop_sanphambaohiem + " as [" + DE_SPBAOHIEM_AS + "], " + de_hop_sotienbaohiem + " as [" + DE_SOTIENBAOHIEM_AS + "], " + de_hop_kyhanbaohiem + " as [" + DE_KYHANBAOHIEM_AS + "], " + de_hop_dinhkydongbaohiem + " as [" + DE_DINHKYBAOHIEM_AS + "], " + de_hop_phi + " as [" + DE_PHI_AS + "], " + de_hop_sotiendaohan + " as [" + DE_SOTIENDAOHAN_AS + "], " + de_hop_ngayhd + " as [" + DE_NGAYHD_AS + "], " + de_hop_bosung + " as [" + DE_BOSUNG_AS + "], " + de_hop_phuongthuc + " as [" + DE_PHUONGTHUC_AS + "]," + de_hop_nguongoc + " as [" + DE_NGUONGOCBAOHIEM_AS + "], " + de_hop_benhvien + " as [" + DE_BENHVIENCHITRA_AS + "]  from " + TABLE_HOPDONG, con)
        da.Fill(ds)
        'myconnect.dongketnoi()
        dongketnoi()


        Return ds
    End Function

    Private Sub btnxoahopdong_Click(sender As Object, e As EventArgs) Handles btnxoahopdong.Click
        Dim mahd As String
        With Me.datagitHopdong
            mahd = .Rows(.CurrentCell.RowIndex).Cells("mã hợp đồng").Value
        End With
        Dim truyvan As String = String.Format("delete from Hopdong where maHD = {0}", mahd)
        TruyVanNonQuery(truyvan, con)
        form3_load(sender, e)
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Dim mahd, idkhachhang, spbaohiem, sotienBH, kyhanbaohiem, dinhkybaohiem, phibaohiemdinhky, sotienDH, ngaycohieuluc, sanphambaohiembosung, phuongthuctra, nguongocphibaohiem, benhvienduocchitra As String
        With Me.datagitHopdong
            mahd = .Rows(.CurrentCell.RowIndex).Cells(DE_MAHD_AS).Value
            idkhachhang = .Rows(.CurrentCell.RowIndex).Cells(DE_IDKH_AS).Value
            spbaohiem = .Rows(.CurrentCell.RowIndex).Cells(DE_SPBAOHIEM_AS).Value
            sotienBH = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENBAOHIEM_AS).Value
            kyhanbaohiem = .Rows(.CurrentCell.RowIndex).Cells(DE_KYHANBAOHIEM_AS).Value
            dinhkybaohiem = .Rows(.CurrentCell.RowIndex).Cells(DE_DINHKYBAOHIEM_AS).Value
            phibaohiemdinhky = .Rows(.CurrentCell.RowIndex).Cells(DE_PHI_AS).Value
            sotienDH = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENDAOHAN_AS).Value
            ngaycohieuluc = .Rows(.CurrentCell.RowIndex).Cells(DE_NGAYHD_AS).Value
            sanphambaohiembosung = .Rows(.CurrentCell.RowIndex).Cells(DE_BOSUNG_AS).Value
            phuongthuctra = .Rows(.CurrentCell.RowIndex).Cells(DE_PHUONGTHUC_AS).Value
            nguongocphibaohiem = .Rows(.CurrentCell.RowIndex).Cells(DE_NGUONGOCBAOHIEM_AS).Value
            benhvienduocchitra = .Rows(.CurrentCell.RowIndex).Cells(DE_BENHVIENCHITRA_AS).Value

        End With

        txtMaHD.Text = mahd
        txtmakhachhang.Text = idkhachhang
        txtSanPhamBaoHiem.Text = spbaohiem
        txtSoTienBaoHiem.Text = sotienBH
        txtKyHanBaoHiem.Text = kyhanbaohiem
        txtdinhkydongbaohiem.Text = dinhkybaohiem
        txtPhi.Text = phibaohiemdinhky
        txtSoTienDaoHan.Text = sotienDH
        dtNgayHD.Text = ngaycohieuluc
        txtBoSung.Text = sanphambaohiembosung
        txtPhuongThuc.Text = phuongthuctra
        txtNguonGoc.Text = nguongocphibaohiem
        txtBenhVien.Text = benhvienduocchitra
        taoketnoi()
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "updatedatainsidetableHD"
        cmd.CommandType = CommandType.StoredProcedure
        Dim IDKH As Integer
        Int32.TryParse(txtmakhachhang.Text, IDKH)

        Dim sotienbaohiem As Double
        If Double.TryParse(txtSoTienBaoHiem.Text, sotienbaohiem) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        Dim phi As Double
        If Double.TryParse(txtPhi.Text, phi) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        Dim sotiendaohan As Double
        If Double.TryParse(txtSoTienDaoHan.Text, sotiendaohan) Then
            ' text is convertible to Double, and value contains the Double value now
        Else
            ' Cannot convert text to Double
        End If

        cmd.Parameters.AddWithValue(de_hop_mahd, txtMaHD.Text)
        cmd.Parameters.AddWithValue(de_hop_makhachhang, IDKH)
        cmd.Parameters.AddWithValue(de_hop_sanphambaohiem, txtSanPhamBaoHiem.Text)
        cmd.Parameters.AddWithValue(de_hop_sotienbaohiem, sotienbaohiem)
        cmd.Parameters.AddWithValue(de_hop_kyhanbaohiem, txtKyHanBaoHiem.Text)
        cmd.Parameters.AddWithValue(de_hop_dinhkydongbaohiem, txtdinhkydongbaohiem.Text)
        cmd.Parameters.AddWithValue(de_hop_phi, phi)
        cmd.Parameters.AddWithValue(de_hop_sotiendaohan, sotiendaohan)
        cmd.Parameters.AddWithValue(de_hop_ngayhd, dtNgayHD.Text)
        cmd.Parameters.AddWithValue(de_hop_bosung, txtBoSung.Text)
        cmd.Parameters.AddWithValue(de_hop_phuongthuc, txtPhuongThuc.Text)
        cmd.Parameters.AddWithValue(de_hop_nguongoc, txtNguonGoc.Text)
        cmd.Parameters.AddWithValue(de_hop_benhvien, txtBenhVien.Text)
        cmd.ExecuteNonQuery()
        dongketnoi()
        form3_load(sender, e)


    End Sub
    Private Function TimKiem(sTuKhoa As String) As DataTable
        taoketnoi()
        Dim sTruyVan As String = "select * from Hopdong where IDKhachHang like N'%" + sTuKhoa + "%' or maHD like N'%" + sTuKhoa + "%' or spbaohiem like N'%" + sTuKhoa + "%' or sotienbaohiem like N'%" + sTuKhoa + "%' or kyhanbaohiem like N'%" + sTuKhoa + "%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(sTruyVan, con)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

    Private Sub txtmakhachhang_TextChanged(sender As Object, e As EventArgs) Handles txtmakhachhang.TextChanged

    End Sub

    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        Dim sTuKhoa As String
        sTuKhoa = txttimkiem.Text
        Dim dt As DataTable = TimKiem(sTuKhoa)
        datagitHopdong.DataSource = dt
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    With datagitHopdong

    '        txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_MAHD_AS).Value
    '        txtmakhachhang.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_IDKH_AS).Value
    '        txtSanPhamBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SPBAOHIEM_AS).Value
    '        txtSoTienBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENBAOHIEM_AS).Value
    '        txtKyHanBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_KYHANBAOHIEM_AS).Value
    '        txtdinhkydongbaohiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_DINHKYBAOHIEM_AS).Value
    '        txtPhi.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_PHI_AS).Value
    '        txtSoTienDaoHan.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENDAOHAN_AS).Value
    '        dtNgayHD.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_NGAYHD_AS).Value
    '        txtBoSung.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_BOSUNG_AS).Value
    '        txtPhuongThuc.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_PHUONGTHUC_AS).Value
    '        txtNguonGoc.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_NGUONGOCBAOHIEM_AS).Value
    '        txtBenhVien.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_BENHVIENCHITRA_AS).Value

    '    End With
    'End Sub

    Private Sub dtgHopdong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        With datagitHopdong

            txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_MAHD_AS).Value
            txtmakhachhang.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_IDKH_AS).Value
            txtSanPhamBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SPBAOHIEM_AS).Value
            txtSoTienBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENBAOHIEM_AS).Value
            txtKyHanBaoHiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_KYHANBAOHIEM_AS).Value
            txtdinhkydongbaohiem.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_DINHKYBAOHIEM_AS).Value
            txtPhi.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_PHI_AS).Value
            txtSoTienDaoHan.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_SOTIENDAOHAN_AS).Value
            dtNgayHD.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_NGAYHD_AS).Value
            txtBoSung.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_BOSUNG_AS).Value
            txtPhuongThuc.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_PHUONGTHUC_AS).Value
            txtNguonGoc.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_NGUONGOCBAOHIEM_AS).Value
            txtBenhVien.Text = .Rows(.CurrentCell.RowIndex).Cells(DE_BENHVIENCHITRA_AS).Value

        End With
    End Sub

End Class