Public Class frm_cadastro_conta

    'ABRINDO E FECHANDO O FORMULARIO
    Private Sub frm_cadastro_conta_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_banco()
        carregar_dados()
        carregar_status()
        carregar_tipo()

    End Sub

    Private Sub frm_cadastro_conta_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        fechar_banco()

    End Sub

    '----------------------------------------------------------------------------------------------
    'LIMPEZA
    Sub limpar_campos_cad_func()
        With Me
            .txt_nome.Clear()
            .txt_cpf.Clear()
            .cmb_nasc.Value = Now
            .txt_email.Clear()
            .cmb_status.Text = ""
            .img_foto.Load(Application.StartupPath & "\icones\nova_foto.png")
            .txt_senha.Clear()
            .txt_confirmar_senha.Clear()
            .lbl_id.Text = ""
            .txt_nome.Focus()
        End With
    End Sub

    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick
        limpar_campos_cad_func()
    End Sub

    '----------------------------------------------------------------------------------------------
    'FILTRO E PESQUISA
    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            SQL = "SELECT * from tb_funcionarios WHERE " & cmb_parametro.Text & " like '" & txt_pesquisa.Text & "%'"
            rs = db.Execute(SQL)


            cont = 1
            With dgv_funcionarios
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------
    'AÇÕES DE BOTÕES
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try

            If String.IsNullOrEmpty(txt_nome.Text) Or
                String.IsNullOrEmpty(txt_cpf.Text) Or
                String.IsNullOrEmpty(txt_email.Text) Or
                String.IsNullOrEmpty(cmb_status.Text) Or
                String.IsNullOrEmpty(txt_senha.Text) Or
                String.IsNullOrEmpty(txt_confirmar_senha.Text) Then

                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

                Exit Sub

            Else

                If txt_senha.Text <> txt_confirmar_senha.Text Then

                    MsgBox("As senhas precisam estar iguais", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    txt_senha.Focus()

                    Exit Sub

                End If

                SQL = "select * from tb_funcionarios where ID='" & lbl_id.Text & "'"
                rs = db.Execute(SQL)

                If rs.EOF = True Then

                    cpf = txt_cpf.Text.Replace(",", "").Replace("-", "")

                    SQL = "insert into tb_funcionarios values ('" & cpf & "', " &
                    "'" & txt_nome.Text & "',  " &
                    "'" & txt_email.Text & "',  " &
                    "'" & cmb_nasc.Value.Date & "', " &
                    "'" & cmb_status.Text & "', " &
                    "'" & diretorio & "', " &
                    "'" & txt_senha.Text & "' )"

                    rs = db.Execute(UCase(SQL))

                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    carregar_dados()

                Else

                    MsgBox("Este cadastro já existe!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                    Exit Sub

                End If

                carregar_dados()

            End If

            limpar_campos_cad_func()

        Catch ex As Exception

            MsgBox("Erro ao gravar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click

        Try
            If String.IsNullOrEmpty(txt_nome.Text) Or
                String.IsNullOrEmpty(txt_cpf.Text) Or
                String.IsNullOrEmpty(txt_email.Text) Or
                String.IsNullOrEmpty(cmb_status.Text) Or
                String.IsNullOrEmpty(txt_senha.Text) Or
                String.IsNullOrEmpty(txt_confirmar_senha.Text) Then

                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

                Exit Sub

            Else

                If txt_senha.Text <> txt_confirmar_senha.Text Then

                    MsgBox("As senhas precisam estar iguais", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    txt_senha.Focus()

                    Exit Sub

                End If

                cpf = txt_cpf.Text.Replace(",", "").Replace("-", "")

                SQL = "update tb_funcionarios set nome='" & txt_nome.Text & "', " &
                        "CPF='" & cpf & "', " &
                        "data_nasc='" & cmb_nasc.Value.Date & "', " &
                        "foto='" & img_foto.ImageLocation & "', " &
                        "email = '" & txt_email.Text & "', " &
                        "status = '" & cmb_status.Text & "', " &
                        "senha = '" & txt_senha.Text & "' " &
                        "where ID='" & lbl_id.Text & "'"

                rs = db.Execute(UCase(SQL))

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                limpar_campos_cad_func()
                carregar_dados()

            End If
        Catch ex As Exception

            MsgBox("Erro ao atualizar os dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click

        frm_perfil_adm.Show()
        Me.Close()

    End Sub

    Private Sub dgv_funcionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellContentClick
        Try
            With dgv_funcionarios

                'SE O CLIQUE FOR NO BOTÃO DE EDITAR
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value

                    SQL = "Select * from tb_funcionarios where ID = '" & aux_id & "'"

                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'explorando a primeira aba - dados pessoais
                        lbl_id.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cpf.Text = rs.Fields(1).Value
                        cmb_nasc.Value = rs.Fields(4).Value
                        txt_email.Text = rs.Fields(3).Value
                        cmb_status.Text = rs.Fields(5).Value
                        img_foto.Load(rs.Fields(6).Value)
                        txt_senha.Text = rs.Fields(7).Value
                        txt_confirmar_senha.Text = rs.Fields(7).Value

                    End If

                    'SE O CLIQUE FOR NO BOTÃO DE EXCLUIR
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value

                    SQL = "Select * from tb_funcionarios where ID = '" & aux_id & "'"

                    rs = db.Execute(SQL)

                    If rs.EOF = False Then

                        TabControl1.SelectTab(0) 'explorando a primeira aba - dados pessoais
                        lbl_id.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cpf.Text = rs.Fields(1).Value
                        cmb_nasc.Value = rs.Fields(4).Value
                        txt_email.Text = rs.Fields(3).Value
                        cmb_status.Text = rs.Fields(5).Value
                        img_foto.Load(rs.Fields(6).Value)
                        txt_senha.Text = rs.Fields(7).Value
                        txt_confirmar_senha.Text = rs.Fields(7).Value


                        MsgBox("Para excluir, inative a conta e clique no botão ATUALIZAR", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                        cmb_status.Focus()

                    End If
                Else
                    Exit Sub
                End If

                carregar_dados()

            End With

        Catch ex As Exception

        End Try
    End Sub

    '----------------------------------------------------------------------------------------------
    'CADASTRO INFORMAÇÕES
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------
    'FUNÇÕES
    Private Sub carregar_tipo()
        Try
            With cmb_parametro.Items
                .Clear()
                .Add("ID")
                .Add("Nome")
                .Add("Status")
            End With
            cmb_parametro.SelectedIndex = 1

        Catch ex As Exception
            MsgBox("Erro ao processar a pesquisa por parâmetro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub carregar_status()
        Try
            With cmb_status.Items
                .Clear()
                .Add("ATIVO")
                .Add("INATIVO")
            End With
            cmb_status.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Erro ao processar a pesquisa por parâmetro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub carregar_dados()
        SQL = "select * from tb_funcionarios "
        rs = db.Execute(SQL)

        With dgv_funcionarios
            .Rows.Clear()

            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value)
                rs.MoveNext()

            Loop

        End With
    End Sub

End Class