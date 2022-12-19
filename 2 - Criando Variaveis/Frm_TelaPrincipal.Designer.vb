<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TelaPrincipal))
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtMSG = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSmtp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.checkSSLL = New System.Windows.Forms.CheckBox()
        Me.lbel2 = New System.Windows.Forms.Label()
        Me.txtEmailRem = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtassunto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(161, 287)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Enviar"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtMSG
        '
        Me.txtMSG.Location = New System.Drawing.Point(84, 115)
        Me.txtMSG.Multiline = True
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.Size = New System.Drawing.Size(212, 150)
        Me.txtMSG.TabIndex = 1
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(12, 127)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(66, 15)
        Me.lblMsg.TabIndex = 2
        Me.lblMsg.Text = "Mensagem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SMTP"
        '
        'txtSmtp
        '
        Me.txtSmtp.Location = New System.Drawing.Point(394, 32)
        Me.txtSmtp.Name = "txtSmtp"
        Me.txtSmtp.Size = New System.Drawing.Size(219, 23)
        Me.txtSmtp.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Porta"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(396, 73)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(51, 23)
        Me.txtPort.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 9
        '
        'checkSSLL
        '
        Me.checkSSLL.AutoSize = True
        Me.checkSSLL.Location = New System.Drawing.Point(462, 74)
        Me.checkSSLL.Name = "checkSSLL"
        Me.checkSSLL.Size = New System.Drawing.Size(44, 19)
        Me.checkSSLL.TabIndex = 10
        Me.checkSSLL.Text = "SSL"
        Me.checkSSLL.UseVisualStyleBackColor = True
        '
        'lbel2
        '
        Me.lbel2.AutoSize = True
        Me.lbel2.Location = New System.Drawing.Point(7, 34)
        Me.lbel2.Name = "lbel2"
        Me.lbel2.Size = New System.Drawing.Size(84, 15)
        Me.lbel2.TabIndex = 11
        Me.lbel2.Text = "E-mail Destino"
        '
        'txtEmailRem
        '
        Me.txtEmailRem.Location = New System.Drawing.Point(92, 32)
        Me.txtEmailRem.Name = "txtEmailRem"
        Me.txtEmailRem.Size = New System.Drawing.Size(196, 23)
        Me.txtEmailRem.TabIndex = 12
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(396, 102)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(217, 23)
        Me.txtUser.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Usuario"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(396, 147)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(217, 23)
        Me.txtSenha.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Senha"
        '
        'txtassunto
        '
        Me.txtassunto.Location = New System.Drawing.Point(89, 75)
        Me.txtassunto.Name = "txtassunto"
        Me.txtassunto.Size = New System.Drawing.Size(196, 23)
        Me.txtassunto.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Assunto"
        '
        'Frm_TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 332)
        Me.Controls.Add(Me.txtassunto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmailRem)
        Me.Controls.Add(Me.lbel2)
        Me.Controls.Add(Me.checkSSLL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSmtp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtMSG)
        Me.Controls.Add(Me.btn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validador SMTP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txtMSG As TextBox
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSmtp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents checkSSLL As CheckBox
    Friend WithEvents lbel2 As Label
    Friend WithEvents txtEmailRem As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtassunto As TextBox
    Friend WithEvents Label7 As Label
End Class
