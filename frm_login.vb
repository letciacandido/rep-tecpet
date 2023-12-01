Public Class frm_login

    'ABRINDO E FECHANDO O FORMULARIO
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()

    End Sub
    Private Sub frm_login_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        fechar_banco()

    End Sub

    '----------------------------------------------------------------------------------------------
    'AÇÕES DE BOTÕES

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Try

            If txt_usuario.Text = "" Or
               txt_senha.Text = "" Then

                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

                Exit Sub

                'VERIFICAÇÃO SE SÃO DADOS PARA LOGIN DO ADMINISTRADOR
            ElseIf (txt_usuario.Text = "000,000,000-00" And txt_senha.Text = "admin") Then

                frm_perfil_adm.Show()
                Me.Close()

            Else
                'VERIFICAÇÃO SE LOGIN E SENHA DO FUNCIONÁRIO EXISTE

                Dim cpfLimpo = removeMascaraCPF(txt_usuario.Text)

                SQL = "SELECT * FROM tb_funcionarios where CPF= '" & cpfLimpo & "' and senha= '" & txt_senha.Text & "'"

                rs = db.Execute(SQL)

                If rs.EOF = False Then

                    If rs.Fields(5).Value <> "INATIVO" Then

                        Me.Hide()

                        frm_perfil_caixa.Show()

                        'ARMAZENA ID DO FUNCIONÁRIO LOGADO EM VARIÁVEL PARA QUE SEJA UTILIZADO NA CRIAÇÃO DA VENDA NA TELA DE FRENTE DE CAIXA
                        'ARMAZENA NOME DO FUNCIONÁRIO LOGADO EM VARIÁVEL PARA MOSTRAR NA TELA DE FRENTE DE CAIXA
                        SQL = "SELECT * FROM tb_funcionarios WHERE CPF= '" & cpfLimpo & "'"

                        rs = db.Execute(SQL)

                        If rs.EOF = False Then
                            ID_func = rs.Fields(0).Value
                            nome_func = rs.Fields(2).Value
                            frm_perfil_caixa.lbl_nome_func.Text = nome_func

                        Else
                            nome_func = "SEM IDENTIFICAÇÃO"
                        End If

                        Me.Close()
                    Else

                        MsgBox("Usuário está inativo" + vbNewLine + "Entre em contato com o Gerente.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

                    End If
                Else

                    MsgBox("Usuário ou senha inválidos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

                End If

            End If

        Catch ex As Exception

            MsgBox("Erro ao chamar o formulário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

    End Sub

    Private Sub ckb_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_visualizar.CheckedChanged

        If ckb_visualizar.Checked Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If

    End Sub

    '----------------------------------------------------------------------------------------------
    'LIMPAR CAMPOS

    Private Sub txt_usuario_DoubleClick(sender As Object, e As EventArgs) Handles txt_usuario.DoubleClick

        limpar_campos()

    End Sub

    '----------------------------------------------------------------------------------------------
    'FUNÇÕES
    Private Function removeMascaraCPF(cpf As String) As String
        Dim cpfLimpo = cpf.Replace(".", "").Replace(",", "").Replace("-", "")
        Return cpfLimpo
    End Function

    Private Sub limpar_campos()
        txt_usuario.Clear()
        txt_senha.Clear()
        txt_usuario.Focus()
    End Sub

End Class