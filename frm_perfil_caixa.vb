Public Class frm_perfil_caixa

    'AÇÕES DE BOTÕES
    Private Sub btn_nova_venda_Click(sender As Object, e As EventArgs) Handles btn_nova_venda.Click

        Me.Hide()

        frm_frente_caixa.Show()

        Me.Close()

    End Sub

    Private Sub btn_alterar_senha_Click(sender As Object, e As EventArgs) Handles btn_alterar_senha.Click

        resp = MsgBox("Deseja realmente alterar sua senha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

        If resp = MsgBoxResult.Yes Then

            Dim novaSenha As String

            novaSenha = InputBox("Digite sua nova senha", "NOVA SENHA")

            If novaSenha <> "" Then

                conectar_banco()

                SQL = "UPDATE tb_funcionarios
                       SET senha = '" & novaSenha & "'
                       WHERE id = '" & ID_func & "'"

                rs = db.Execute(SQL)

                MsgBox("Senha atualizada com sucesso!", MsgBoxStyle.Exclamation, "ATUALIZADA!")

                fechar_banco()

            Else

                MsgBox("Nenhuma senha foi inserida", MsgBoxStyle.Exclamation, "ATENÇÃO!")

            End If

        End If

    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click

        Me.Hide()

        frm_login.Show()

        Me.Close()

    End Sub

End Class