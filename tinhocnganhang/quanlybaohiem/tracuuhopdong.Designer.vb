<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tracuuhopdong
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
        Me.txtthucthu = New System.Windows.Forms.TextBox()
        Me.btnbaocao = New System.Windows.Forms.Button()
        Me.dtdoanhthutrongngay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdoanhthu = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doanh thu trong ngày"
        '
        'txtthucthu
        '
        Me.txtthucthu.Enabled = False
        Me.txtthucthu.Location = New System.Drawing.Point(129, 64)
        Me.txtthucthu.Name = "txtthucthu"
        Me.txtthucthu.Size = New System.Drawing.Size(191, 20)
        Me.txtthucthu.TabIndex = 1
        '
        'btnbaocao
        '
        Me.btnbaocao.Location = New System.Drawing.Point(135, 147)
        Me.btnbaocao.Name = "btnbaocao"
        Me.btnbaocao.Size = New System.Drawing.Size(111, 23)
        Me.btnbaocao.TabIndex = 2
        Me.btnbaocao.Text = "&Xuất báo cáo"
        Me.btnbaocao.UseVisualStyleBackColor = True
        '
        'dtdoanhthutrongngay
        '
        Me.dtdoanhthutrongngay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdoanhthutrongngay.Location = New System.Drawing.Point(129, 24)
        Me.dtdoanhthutrongngay.Name = "dtdoanhthutrongngay"
        Me.dtdoanhthutrongngay.Size = New System.Drawing.Size(191, 20)
        Me.dtdoanhthutrongngay.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Thực thu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Doanh thu "
        '
        'txtdoanhthu
        '
        Me.txtdoanhthu.Enabled = False
        Me.txtdoanhthu.Location = New System.Drawing.Point(129, 104)
        Me.txtdoanhthu.Name = "txtdoanhthu"
        Me.txtdoanhthu.Size = New System.Drawing.Size(191, 20)
        Me.txtdoanhthu.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(348, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(182, 70)
        Me.DataGridView1.TabIndex = 7
        '
        'tracuuhopdong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 182)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdoanhthu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtdoanhthutrongngay)
        Me.Controls.Add(Me.btnbaocao)
        Me.Controls.Add(Me.txtthucthu)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "tracuuhopdong"
        Me.Text = "baocaodoanhthu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtthucthu As System.Windows.Forms.TextBox
    Friend WithEvents btnbaocao As System.Windows.Forms.Button
    Friend WithEvents dtdoanhthutrongngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdoanhthu As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
