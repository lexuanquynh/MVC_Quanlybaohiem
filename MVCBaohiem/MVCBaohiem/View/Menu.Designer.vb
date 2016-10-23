<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageHoSo = New System.Windows.Forms.TabPage()
        Me.TabPageTheodoi = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageHoSo)
        Me.TabControl1.Controls.Add(Me.TabPageTheodoi)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(977, 534)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageHoSo
        '
        Me.TabPageHoSo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageHoSo.Name = "TabPageHoSo"
        Me.TabPageHoSo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageHoSo.Size = New System.Drawing.Size(969, 508)
        Me.TabPageHoSo.TabIndex = 0
        Me.TabPageHoSo.Text = "Ho so bao hiem"
        Me.TabPageHoSo.UseVisualStyleBackColor = True
        '
        'TabPageTheodoi
        '
        Me.TabPageTheodoi.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTheodoi.Name = "TabPageTheodoi"
        Me.TabPageTheodoi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTheodoi.Size = New System.Drawing.Size(969, 508)
        Me.TabPageTheodoi.TabIndex = 1
        Me.TabPageTheodoi.Text = "Theo doi bao hiem"
        Me.TabPageTheodoi.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Menu"
        Me.Text = "Phan mem quan ly bao hiem"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageHoSo As System.Windows.Forms.TabPage
    Friend WithEvents TabPageTheodoi As System.Windows.Forms.TabPage

End Class
