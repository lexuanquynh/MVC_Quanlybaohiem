<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tracuukyhan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btntim = New System.Windows.Forms.Button()
        Me.dtthoigian = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtngaythu = New System.Windows.Forms.DateTimePicker()
        Me.txtmatimkiemhoadon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncapnhathoadon = New System.Windows.Forms.Button()
        Me.btnluuhoadon = New System.Windows.Forms.Button()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsotien = New System.Windows.Forms.TextBox()
        Me.txtcachthuc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmahopdong = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HÓA ĐƠN THU PHÍ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btntim)
        Me.GroupBox1.Controls.Add(Me.dtthoigian)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 166)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DANH SÁCH NỘP PHÍ"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(7, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(566, 104)
        Me.DataGridView1.TabIndex = 3
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(280, 21)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 2
        Me.btntim.Text = "&Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'dtthoigian
        '
        Me.dtthoigian.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtthoigian.Location = New System.Drawing.Point(73, 21)
        Me.dtthoigian.Name = "dtthoigian"
        Me.dtthoigian.Size = New System.Drawing.Size(200, 22)
        Me.dtthoigian.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Thời gian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtngaythu)
        Me.GroupBox2.Controls.Add(Me.txtmatimkiemhoadon)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btncapnhathoadon)
        Me.GroupBox2.Controls.Add(Me.btnluuhoadon)
        Me.GroupBox2.Controls.Add(Me.txtmahoadon)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtsotien)
        Me.GroupBox2.Controls.Add(Me.txtcachthuc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtmahopdong)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 340)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hóa đơn đã thu"
        '
        'dtngaythu
        '
        Me.dtngaythu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtngaythu.Location = New System.Drawing.Point(328, 82)
        Me.dtngaythu.Name = "dtngaythu"
        Me.dtngaythu.Size = New System.Drawing.Size(175, 22)
        Me.dtngaythu.TabIndex = 4
        '
        'txtmatimkiemhoadon
        '
        Me.txtmatimkiemhoadon.Location = New System.Drawing.Point(67, 185)
        Me.txtmatimkiemhoadon.Name = "txtmatimkiemhoadon"
        Me.txtmatimkiemhoadon.Size = New System.Drawing.Size(100, 22)
        Me.txtmatimkiemhoadon.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tìm kiếm"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(498, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Xóa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncapnhathoadon
        '
        Me.btncapnhathoadon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapnhathoadon.Location = New System.Drawing.Point(412, 189)
        Me.btncapnhathoadon.Name = "btncapnhathoadon"
        Me.btncapnhathoadon.Size = New System.Drawing.Size(75, 23)
        Me.btncapnhathoadon.TabIndex = 5
        Me.btncapnhathoadon.Text = "&Cập nhật"
        Me.btncapnhathoadon.UseVisualStyleBackColor = True
        '
        'btnluuhoadon
        '
        Me.btnluuhoadon.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnluuhoadon.Location = New System.Drawing.Point(309, 189)
        Me.btnluuhoadon.Name = "btnluuhoadon"
        Me.btnluuhoadon.Size = New System.Drawing.Size(89, 23)
        Me.btnluuhoadon.TabIndex = 6
        Me.btnluuhoadon.Text = "&Lưu hóa đơn"
        Me.btnluuhoadon.UseVisualStyleBackColor = True
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Enabled = False
        Me.txtmahoadon.Location = New System.Drawing.Point(98, 19)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(175, 22)
        Me.txtmahoadon.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Mã hóa đơn"
        '
        'txtsotien
        '
        Me.txtsotien.Location = New System.Drawing.Point(328, 157)
        Me.txtsotien.Name = "txtsotien"
        Me.txtsotien.Size = New System.Drawing.Size(175, 22)
        Me.txtsotien.TabIndex = 8
        '
        'txtcachthuc
        '
        Me.txtcachthuc.Location = New System.Drawing.Point(328, 123)
        Me.txtcachthuc.Name = "txtcachthuc"
        Me.txtcachthuc.Size = New System.Drawing.Size(175, 22)
        Me.txtcachthuc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(214, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Số tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cách thức"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày thu"
        '
        'txtmahopdong
        '
        Me.txtmahopdong.Location = New System.Drawing.Point(328, 49)
        Me.txtmahopdong.Name = "txtmahopdong"
        Me.txtmahopdong.Size = New System.Drawing.Size(175, 22)
        Me.txtmahopdong.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(214, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã hợp đồng"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(20, 407)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(566, 104)
        Me.DataGridView2.TabIndex = 4
        '
        'tracuukyhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 548)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "tracuukyhan"
        Me.Text = "kyhanbaohiem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents dtthoigian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsotien As System.Windows.Forms.TextBox
    Friend WithEvents txtcachthuc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmahopdong As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btncapnhathoadon As System.Windows.Forms.Button
    Friend WithEvents btnluuhoadon As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmatimkiemhoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtngaythu As System.Windows.Forms.DateTimePicker
End Class
