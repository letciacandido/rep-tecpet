Imports System.Globalization

Public Class frm_estoque

    'ABRINDO E FECHANDO O FORMULARIO
    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()
        carregar_dados()
        carregar_dados_parametros()

    End Sub

    Private Sub frm_estoque_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fechar_banco()
    End Sub

    '----------------------------------------------------------------------------------------------
    'CADASTRO INFORMAÇÕES

    Private Sub img_produto_Click(sender As Object, e As EventArgs) Handles img_produto.Click

        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\img-produtos"
                .ShowDialog()
                diretorio = .FileName
                img_produto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub


    '----------------------------------------------------------------------------------------------
    'AÇÕES DE BOTÕES
    Public Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click

        'VERIFICANDO SE HÁ ALGUM CAMPO VAZIO
        If String.IsNullOrEmpty(txt_sku.Text) Or
           String.IsNullOrEmpty(txt_produto.Text) Or
           String.IsNullOrEmpty(txt_valoruni.Text) Or
           String.IsNullOrEmpty(txt_qtde.Text) Then

            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub

        Else
            'VERIFICANDO SE JÁ HÁ CADASTRADO ALGUM PRODUTO COM MESMO SKU
            SQL = "SELECT * FROM tb_estoque WHERE SKU='" & txt_sku.Text & "'"
            rs = db.Execute(SQL)

            'RESPOSTA CASO NÃO HAJA PRODUTO CADASTRADO
            If rs.EOF = True Then

                Dim valorUnitario As Double

                valorUnitario = RemoveMascara(txt_valoruni.Text)


                SQL = "INSERT INTO tb_estoque 
                       VALUES  
                            ('" & txt_sku.Text & "', " &
                            "'" & txt_produto.Text & "',  " &
                            valorUnitario.ToString(CultureInfo.InvariantCulture) & ", " &
                            "'" & txt_qtde.Text & "', " &
                            "'" & diretorio & "')"

                rs = db.Execute(UCase(SQL))

                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                carregar_dados()

                'RESPOSTA CASO HAJA PRODUTO CADASTRADO
            Else

                MsgBox("Este produto já existe!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

            End If

        End If

        limpar_campos()

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click

        Me.Hide()
        frm_perfil_adm.Show()
        Me.Close()

    End Sub

    Private Sub btn_atualizar_Click(sender As Object, e As EventArgs) Handles btn_atualizar.Click

        'VERIFICANDO SE HÁ ALGUM CAMPO VAZIO
        If String.IsNullOrEmpty(txt_sku.Text) Or
           String.IsNullOrEmpty(txt_produto.Text) Or
           String.IsNullOrEmpty(txt_valoruni.Text) Or
           String.IsNullOrEmpty(txt_qtde.Text) Then

            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub

        Else
            'VERIFICANDO SE JÁ HÁ CADASTRADO ALGUM PRODUTO COM MESMO SKU
            SQL = "SELECT * FROM tb_estoque WHERE SKU='" & txt_sku.Text & "'"
            rs = db.Execute(SQL)

            'RESPOSTA CASO HAJA PRODUTO CADASTRADO
            If rs.EOF = False Then

                Dim valorUnitario As Double

                valorUnitario = RemoveMascara(txt_valoruni.Text)

                SQL = "UPDATE tb_estoque
                        SET SKU= '" & txt_sku.Text & "' ," &
                            "produto= '" & txt_produto.Text & "', " &
                            "valor_unitario= '" & valorUnitario.ToString(CultureInfo.InvariantCulture) & "', " &
                            "qtd_estoque= '" & txt_qtde.Text & "', " &
                            "img_produto= '" & img_produto.ImageLocation & "'" &
                       "WHERE SKU= '" & txt_sku.Text & "'"
                rs = db.Execute(SQL)

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                carregar_dados()

                'RESPOSTA CASO NÃO HAJA PRODUTO CADASTRADO
            Else

                MsgBox("Este SKU não possui cadastro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If

        End If

        limpar_campos()

    End Sub

    Private Sub dgv_estoque_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estoque.CellContentClick
        Try
            With dgv_estoque

                'SE O CLIQUE FOR NO BOTÃO DE EDITAR
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value

                    SQL = "SELECT * 
                            FROM tb_estoque
                            WHERE SKU = '" & aux_id & "'"

                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'explorando a primeira aba - dados pessoais
                        txt_sku.Text = rs.Fields(0).Value
                        txt_produto.Text = rs.Fields(1).Value
                        txt_valoruni.Text = AdicionaMascara(rs.Fields(2).Value)
                        txt_qtde.Text = rs.Fields(3).Value
                        img_produto.Load(rs.Fields(4).Value)

                    End If

                    'SE O CLIQUE FOR NO BOTÃO DE EXCLUIR
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value

                    resp = MsgBox("Tem certeza que deseja excluir o registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                    If resp = MsgBoxResult.Yes Then
                        SQL = "DELETE 
                            FROM tb_estoque
                            WHERE SKU = '" & aux_id & "'"

                        rs = db.Execute(SQL)

                        MsgBox("Registro excluído com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        carregar_dados()
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
    'FILTRO E PESQUISA

    Private Sub cmb_parametro_Leave(sender As Object, e As EventArgs) Handles cmb_parametro.Leave
        Try
            cmb_pesquisa.Text = ""

            'PREENCHER O COMBOBOX DE PESQUISA COM OS ITENS DO PARAMETRO ESCOLHIDO
            'VERIFICA SE O VALOR NO PARAMETRO É SKU
            If cmb_parametro.Text = "SKU" Then

                SQL = "SELECT SKU
                        FROM tb_estoque"

                rs = db.Execute(SQL)

                With cmb_pesquisa

                    .Items.Clear()

                    'PREENCHE O COMBOBOX COM O VALOR DE TODOS OS SKU EXISTENTES
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(0).Value)
                        rs.MoveNext()
                    Loop

                End With

                'VERIFICA SE O VALOR NO PARAMETRO É PRODUTO
            ElseIf cmb_parametro.Text = "Produto" Then

                SQL = "SELECT produto
                        FROM tb_estoque"

                rs = db.Execute(SQL)

                With cmb_pesquisa

                    .Items.Clear()

                    'PREENCHE O COMBOBOX COM O VALOR DE TODOS OS PRODUTOS EXISTENTES
                    Do While rs.EOF = False
                        .Items.Add(rs.Fields(0).Value)
                        rs.MoveNext()
                    Loop

                End With

            End If

        Catch ex As Exception
            MsgBox("Erro no carregamento dos parâmetros", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        SQL = "SELECT * 
                FROM tb_estoque
                WHERE SKU= '" & cmb_pesquisa.Text & "' OR
                        produto= '" & cmb_pesquisa.Text & "'"

        rs = db.Execute(SQL)

        If rs.EOF = False Then

            txt_sku.Text = rs.Fields(0).Value
            txt_produto.Text = rs.Fields(1).Value
            txt_valoruni.Text = AdicionaMascara(rs.Fields(2).Value)
            txt_qtde.Text = rs.Fields(3).Value
            img_produto.Load(rs.Fields(4).Value)
            txt_sku.Focus()

        End If

    End Sub

    '----------------------------------------------------------------------------------------------
    'LIMPAR CAMPOS
    Private Sub SafeClearItems(comboBox As ToolStripComboBox)

        'LIMPA OS ITEMS DA LISTA DO COMBOBOX REMOVENDO CADA ITEM COM INDICE 0
        For index As Integer = 0 To comboBox.Items.Count - 1
            comboBox.Items.RemoveAt(0)

        Next index

    End Sub

    Private Sub txt_sku_DoubleClick(sender As Object, e As EventArgs) Handles txt_sku.DoubleClick
        limpar_campos()
    End Sub

    '----------------------------------------------------------------------------------------------
    'MASCARAS
    Private Sub txt_valoruni_LostFocus(sender As Object, e As EventArgs) Handles txt_valoruni.LostFocus
        txt_valoruni.Text = AdicionaMascara(txt_valoruni.Text)
    End Sub

    Private Sub carregar_dados()

        'CARREGANDO DADOS NO DATAGRIDVIEW DE ESTOQUE
        SQL = "SELECT * 
               FROM tb_estoque"

        rs = db.Execute(SQL)

        With dgv_estoque

            .Rows.Clear()

            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()

            Loop

        End With

    End Sub

    Private Sub limpar_campos()
        txt_sku.Clear()
        txt_produto.Clear()
        txt_valoruni.Clear()
        txt_qtde.Clear()
        txt_sku.Focus()
        img_produto.Load(Application.StartupPath & "\icones\imagem-produto.png")
    End Sub

    Private Sub carregar_dados_parametros()
        'CARREGANDO DADOS NO COMBOBOX DE PARAMETROS ABA CADASTRO EM ESTOQUE
        With cmb_parametro
            .Items.Clear()

            .Items.Add("SKU")
            .Items.Add("Produto")

        End With
    End Sub

End Class