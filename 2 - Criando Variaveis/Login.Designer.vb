<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoginL = New System.Windows.Forms.TextBox()
        Me.txtSenhaL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'txtLoginL
        '
        Me.txtLoginL.Location = New System.Drawing.Point(161, 152)
        Me.txtLoginL.Name = "txtLoginL"
        Me.txtLoginL.Size = New System.Drawing.Size(154, 23)
        Me.txtLoginL.TabIndex = 1
        '
        'txtSenhaL
        '
        Me.txtSenhaL.Location = New System.Drawing.Point(161, 192)
        Me.txtSenhaL.Name = "txtSenhaL"
        Me.txtSenhaL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaL.Size = New System.Drawing.Size(154, 23)
        Me.txtSenhaL.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Senha"
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(191, 252)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 349)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenhaL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLoginL)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoginL As TextBox
    Friend WithEvents txtSenhaL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntrar As Button
End Class
