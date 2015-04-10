<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDetrinh = New System.Windows.Forms.Button()
        Me.gbpDangnhaphethong = New System.Windows.Forms.GroupBox()
        Me.TxtMatkhau = New System.Windows.Forms.TextBox()
        Me.txtTendangnhap = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTendangnhap = New System.Windows.Forms.Label()
        Me.gbpDangnhaphethong.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblThongbao
        '
        Me.lblThongbao.AutoSize = True
        Me.lblThongbao.Location = New System.Drawing.Point(107, 201)
        Me.lblThongbao.Name = "lblThongbao"
        Me.lblThongbao.Size = New System.Drawing.Size(0, 13)
        Me.lblThongbao.TabIndex = 7
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(200, 151)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(84, 29)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDetrinh
        '
        Me.btnDetrinh.Location = New System.Drawing.Point(83, 151)
        Me.btnDetrinh.Name = "btnDetrinh"
        Me.btnDetrinh.Size = New System.Drawing.Size(84, 29)
        Me.btnDetrinh.TabIndex = 5
        Me.btnDetrinh.Text = "Đệ Trình"
        Me.btnDetrinh.UseVisualStyleBackColor = True
        '
        'gbpDangnhaphethong
        '
        Me.gbpDangnhaphethong.Controls.Add(Me.TxtMatkhau)
        Me.gbpDangnhaphethong.Controls.Add(Me.txtTendangnhap)
        Me.gbpDangnhaphethong.Controls.Add(Me.Label1)
        Me.gbpDangnhaphethong.Controls.Add(Me.lblTendangnhap)
        Me.gbpDangnhaphethong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpDangnhaphethong.Location = New System.Drawing.Point(43, 38)
        Me.gbpDangnhaphethong.Name = "gbpDangnhaphethong"
        Me.gbpDangnhaphethong.Size = New System.Drawing.Size(328, 107)
        Me.gbpDangnhaphethong.TabIndex = 4
        Me.gbpDangnhaphethong.TabStop = False
        Me.gbpDangnhaphethong.Text = "Đăng Nhập Hệ Thống"
        '
        'TxtMatkhau
        '
        Me.TxtMatkhau.Location = New System.Drawing.Point(124, 72)
        Me.TxtMatkhau.Name = "TxtMatkhau"
        Me.TxtMatkhau.Size = New System.Drawing.Size(179, 22)
        Me.TxtMatkhau.TabIndex = 3
        '
        'txtTendangnhap
        '
        Me.txtTendangnhap.Location = New System.Drawing.Point(124, 33)
        Me.txtTendangnhap.Name = "txtTendangnhap"
        Me.txtTendangnhap.Size = New System.Drawing.Size(179, 22)
        Me.txtTendangnhap.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "mật khẩu"
        '
        'lblTendangnhap
        '
        Me.lblTendangnhap.AutoSize = True
        Me.lblTendangnhap.Location = New System.Drawing.Point(6, 33)
        Me.lblTendangnhap.Name = "lblTendangnhap"
        Me.lblTendangnhap.Size = New System.Drawing.Size(112, 16)
        Me.lblTendangnhap.TabIndex = 0
        Me.lblTendangnhap.Text = "Tên đăng nhập"
        '
        'Form2
        '
        Me.AcceptButton = Me.btnDetrinh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 201)
        Me.Controls.Add(Me.lblThongbao)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDetrinh)
        Me.Controls.Add(Me.gbpDangnhaphethong)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbpDangnhaphethong.ResumeLayout(False)
        Me.gbpDangnhaphethong.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblThongbao As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDetrinh As System.Windows.Forms.Button
    Friend WithEvents gbpDangnhaphethong As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTendangnhap As System.Windows.Forms.Label
End Class
