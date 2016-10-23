<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class themmoisua
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnthemmoi = New System.Windows.Forms.Button()
        Me.btncapnhathoso = New System.Windows.Forms.Button()
        Me.btnxoahosokhachhang = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Từ khóa"
        '
        'txttimkiem
        '
        Me.txttimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimkiem.Location = New System.Drawing.Point(73, 20)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(253, 22)
        Me.txttimkiem.TabIndex = 42
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(575, 292)
        Me.DataGridView1.TabIndex = 46
        '
        'btnthemmoi
        '
        Me.btnthemmoi.Location = New System.Drawing.Point(594, 69)
        Me.btnthemmoi.Name = "btnthemmoi"
        Me.btnthemmoi.Size = New System.Drawing.Size(106, 23)
        Me.btnthemmoi.TabIndex = 47
        Me.btnthemmoi.Text = "&Thêm mới"
        Me.btnthemmoi.UseVisualStyleBackColor = True
        '
        'btncapnhathoso
        '
        Me.btncapnhathoso.Location = New System.Drawing.Point(597, 110)
        Me.btncapnhathoso.Name = "btncapnhathoso"
        Me.btncapnhathoso.Size = New System.Drawing.Size(106, 23)
        Me.btncapnhathoso.TabIndex = 48
        Me.btncapnhathoso.Text = "&Cập nhật "
        Me.btncapnhathoso.UseVisualStyleBackColor = True
        '
        'btnxoahosokhachhang
        '
        Me.btnxoahosokhachhang.Location = New System.Drawing.Point(597, 153)
        Me.btnxoahosokhachhang.Name = "btnxoahosokhachhang"
        Me.btnxoahosokhachhang.Size = New System.Drawing.Size(106, 23)
        Me.btnxoahosokhachhang.TabIndex = 49
        Me.btnxoahosokhachhang.Text = "&Xóa hồ sơ "
        Me.btnxoahosokhachhang.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "&Thêm hợp đồng"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'themmoisua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 364)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnxoahosokhachhang)
        Me.Controls.Add(Me.btncapnhathoso)
        Me.Controls.Add(Me.btnthemmoi)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.Label16)
        Me.Name = "themmoisua"
        Me.Text = "themmoisua"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthemmoi As System.Windows.Forms.Button
    Friend WithEvents btncapnhathoso As System.Windows.Forms.Button
    Friend WithEvents btnxoahosokhachhang As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
