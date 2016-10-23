<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HồSơBảoHiểmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuKỳHạnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuHợpĐồngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ HỢP ĐỒNG BẢO HIỂM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HồSơBảoHiểmToolStripMenuItem, Me.TraCứuToolStripMenuItem, Me.TraCứuToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HồSơBảoHiểmToolStripMenuItem
        '
        Me.HồSơBảoHiểmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem})
        Me.HồSơBảoHiểmToolStripMenuItem.Name = "HồSơBảoHiểmToolStripMenuItem"
        Me.HồSơBảoHiểmToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.HồSơBảoHiểmToolStripMenuItem.Text = "Hồ sơ bảo hiểm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Enabled = False
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        Me.KháchHàngToolStripMenuItem.Visible = False
        '
        'TraCứuToolStripMenuItem
        '
        Me.TraCứuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TraCứuKỳHạnToolStripMenuItem, Me.TraCứuHợpĐồngToolStripMenuItem})
        Me.TraCứuToolStripMenuItem.Name = "TraCứuToolStripMenuItem"
        Me.TraCứuToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.TraCứuToolStripMenuItem.Text = "Theo dõi bảo hiểm"
        '
        'TraCứuKỳHạnToolStripMenuItem
        '
        Me.TraCứuKỳHạnToolStripMenuItem.Name = "TraCứuKỳHạnToolStripMenuItem"
        Me.TraCứuKỳHạnToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TraCứuKỳHạnToolStripMenuItem.Text = "Kỳ hạn bảo hiểm"
        '
        'TraCứuHợpĐồngToolStripMenuItem
        '
        Me.TraCứuHợpĐồngToolStripMenuItem.Name = "TraCứuHợpĐồngToolStripMenuItem"
        Me.TraCứuHợpĐồngToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TraCứuHợpĐồngToolStripMenuItem.Text = "Doanh thu bảo hiểm"
        '
        'TraCứuToolStripMenuItem1
        '
        Me.TraCứuToolStripMenuItem1.Name = "TraCứuToolStripMenuItem1"
        Me.TraCứuToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.TraCứuToolStripMenuItem1.Text = "Tra cứu"
        Me.TraCứuToolStripMenuItem1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HồSơBảoHiểmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraCứuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraCứuKỳHạnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraCứuHợpĐồngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraCứuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
