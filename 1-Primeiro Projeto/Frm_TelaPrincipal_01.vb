Public Class Frm_TelaPrincipal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        MsgBox("Olá Mundo !!", MsgBoxStyle.Critical, "Mensagem")
    End Sub
End Class
