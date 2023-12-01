Public Class frm_perfil_adm

    'AÇÕES DE BOTÕES
    Private Sub btn_gerenciar_func_Click(sender As Object, e As EventArgs) Handles btn_gerenciar_func.Click
        frm_cadastro_conta.Show()
        Me.Close()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        Me.Hide()

        frm_estoque.Show()

        Me.Close()
    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        frm_login.Show()
        Me.Close()
    End Sub

End Class