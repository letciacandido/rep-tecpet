Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_frente_caixa

    Dim idVendaAtual As Integer = 0

    'ABRINDO E FECHANDO O FORMULARIO

    Private Sub frm_frente_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()

        'COLOCA NOME VENDEDOR QUE ESTÁ LOGADO NA TELA
        lbl_nome_vendedor.Text = nome_func

        'COLOCA DATA DE HOJE NA TELA
        lbl_hoje.Text = Today.Date

        ReinicializarVenda()

        'CARREGANDO DADOS NOS COMBOBOX
        carregar_dados_parcelas()
        carregar_dados_pagamento()
        carregar_dados_parametros()

    End Sub

    Private Sub frm_frente_caixa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fechar_banco()
    End Sub

    '----------------------------------------------------------------------------------------------
    'LIMPAR CAMPOS
    Private Sub ReinicializarVenda()
        'ATUALIZA O LBL_ID_VENDA
        AtualizaIdVenda()

        'LIMPEZA DOS DADOS
        Limpar_campos_item()
        Limpar_campos_pagamento()
        limparDgvItensPagamento()
    End Sub

    Private Sub Limpar_campos_item()
        img_produto.Load(Application.StartupPath & "\icones\imagem-produto.png")
        txt_sku.Clear()
        txt_produto.Clear()
        txt_estoque.Clear()
        txt_qtde.Value = 0
        txt_valoruni.Clear()
        txt_subtotal_cad.Clear()
        lbl_valor_total.Text = "R$0,00"
        cmb_parametro.SelectedIndex = -1
        cmb_pesquisa.SelectedIndex = -1
        cmb_pesquisa.Items.Clear()
        txt_sku.Focus()
    End Sub

    Private Sub Limpar_campos_pagamento()

        cmb_forma_pgto.SelectedIndex = -1
        txt_total_pago.Clear()
        txt_desc_rs.Clear()
        txt_desc_porcent.Clear()
        txt_subtotal_pgto.Clear()
        cmb_parcelas.SelectedIndex = -1
        txt_parcelas.Clear()
        txt_troco.Clear()
        txt_valor_a_pagar.Clear()
        cmb_forma_pgto.Focus()

    End Sub

    Private Sub limparDgvItensPagamento()
        dgv_compra_cadastro.Rows.Clear()
        dgv_compra_pgto.Rows.Clear()
    End Sub

    '----------------------------------------------------------------------------------------------
    'AÇÕES DE BOTÕES
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click

        Me.Hide()

        frm_perfil_caixa.Show()

        Me.Close()

    End Sub

    Private Sub btn_pagamento_Click(sender As Object, e As EventArgs) Handles btn_pagamento.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click

        'VERIFICANDO SE HÁ ALGUM CAMPO VAZIO
        If String.IsNullOrEmpty(txt_sku.Text) Or
           String.IsNullOrEmpty(txt_produto.Text) Or
           String.IsNullOrEmpty(txt_qtde.Text) Or
           String.IsNullOrEmpty(txt_valoruni.Text) Or
           String.IsNullOrEmpty(txt_subtotal_cad.Text) Then

            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub

        ElseIf (txt_qtde.Value <= 0) Then

            MsgBox("A quantidade deve ser maior que 0", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub

        Else
            'PREENCHENDO INFORMACOES NA TB_DESCRICAO_VENDAS

            Dim valorUnitario As Double

            valorUnitario = RemoveMascara(txt_valoruni.Text)

            SQL = "INSERT INTO tb_descricao_vendas
                       VALUES  
                            ('" & idVendaAtual & "', " &
                            "'" & txt_sku.Text & "',  " &
                            valorUnitario.ToString(CultureInfo.InvariantCulture) & ", " &
                            Integer.Parse(txt_qtde.Text) & ", " &
                            CDbl(txt_subtotal_cad.Text).ToString(CultureInfo.InvariantCulture) & ",
                            NULL )"

            rs = db.Execute(UCase(SQL))

            CarregarDadosItemDgv(idVendaAtual)
            CarregarDadosPagamentoDgv(idVendaAtual)

            Limpar_campos_item()
            Limpar_campos_pagamento()
            AtualizaTotal()
            AtualizaPagamento()

        End If
    End Sub

    Private Sub btn_cancelar_venda_Click(sender As Object, e As EventArgs) Handles btn_cancelar_venda.Click
        Dim deveCancelarVenda = MsgBox("Você tem certeza que deseja cancelar essa venda?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ATENÇÃO")
        If deveCancelarVenda = MsgBoxResult.Yes Then
            CancelaVenda(idVendaAtual)
        End If
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If txt_total_pago.Text = "" Then

            MsgBox("Insira o valor recebido", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

        Else

            txt_troco.Text = AdicionaMascara(RemoveMascara(txt_total_pago.Text) - RemoveMascara(txt_valor_a_pagar.Text))

        End If
    End Sub

    Private Sub dgv_compra_cadastro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_compra_cadastro.CellContentClick
        With dgv_compra_cadastro

            'SE O CLIQUE FOR NO BOTÃO DE EXCLUIR
            If .CurrentRow.Cells(3).Selected = True Then

                resp = MsgBox("Deseja realmente excluir o item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                If resp = MsgBoxResult.Yes Then


                    Dim nomeProduto As String
                    Dim SKU As String = ""

                    nomeProduto = .CurrentRow.Cells(1).Value

                    SQL = "SELECT SKU
                       FROM tb_estoque
                       WHERE produto = '" & nomeProduto & "'"

                    rs = db.Execute(SQL)

                    If rs.EOF = False Then

                        SKU = rs.Fields(0).Value

                    End If

                    SQL = "DELETE 
                           FROM tb_descricao_vendas
                           WHERE cod_venda = " & idVendaAtual & " AND SKU ='" & SKU & "'"

                    rs = db.Execute(SQL)

                    CarregarDadosItemDgv(idVendaAtual)
                    CarregarDadosPagamentoDgv(idVendaAtual)

                    Limpar_campos_item()
                    Limpar_campos_pagamento()
                    AtualizaTotal()
                    AtualizaPagamento()

                Else
                    Exit Sub
                End If
            End If

        End With
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

    Private Sub btn_preencher_produto_Click(sender As Object, e As EventArgs) Handles btn_preencher_produto.Click
        SQL = "SELECT * 
               FROM tb_estoque
               WHERE SKU= '" & cmb_pesquisa.Text & "' 
                    OR produto= '" & cmb_pesquisa.Text & "'"

        rs = db.Execute(SQL)

        If rs.EOF = False Then

            txt_sku.Text = rs.Fields(0).Value
            txt_produto.Text = rs.Fields(1).Value
            txt_valoruni.Text = AdicionaMascara(rs.Fields(2).Value)
            txt_estoque.Text = rs.Fields(3).Value
            img_produto.Load(rs.Fields(4).Value)

            txt_qtde.Value = 0
            txt_subtotal_cad.Text = String.Empty

            txt_qtde.Focus()

        End If
    End Sub


    '----------------------------------------------------------------------------------------------
    'ATUALIZAÇÃO DE CAMPOS

    Private Sub cmb_parcelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_parcelas.SelectedIndexChanged
        If cmb_parcelas.Text = "1x" Then
            txt_parcelas.Text = "1x de R$" & Math.Round(CDbl(lbl_valor_total.Text), 2)
        ElseIf cmb_parcelas.Text = "2x" Then
            txt_parcelas.Text = "2x de R$" & Math.Round(CDbl(lbl_valor_total.Text) / 2, 2)
        ElseIf cmb_parcelas.Text = "3x" Then
            txt_parcelas.Text = "3x de R$" & Math.Round(CDbl(lbl_valor_total.Text) / 3, 2)
        Else
            txt_parcelas.Text = ""
        End If
    End Sub

    Private Sub txt_qtde_ValueChanged(sender As Object, e As EventArgs) Handles txt_qtde.ValueChanged

        'CRIA VARIÁVEL PARA ARMAZENAR VALOR DE PRODUTOS EM ESTOQUE
        Dim emEstoque As Integer

        'SE O txt_estoque ESTIVER VAZIO, CONSIDERA ESSE VALOR COMO 0
        If txt_estoque.Text = String.Empty Then
            emEstoque = 0
        Else
            emEstoque = CInt(txt_estoque.Text)
        End If

        'COMPARA SE VALOR EM ESTOQUE É MENOR QUE QUANTIDADE INFORMADA PELO OPERADOR DE CAIXA
        If emEstoque < txt_qtde.Value Then

            MsgBox("Não há produto suficiente em estoque!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            txt_qtde.Value = emEstoque

        Else

            txt_subtotal_cad.Text = AdicionaMascara((CDbl(txt_valoruni.Text)) * txt_qtde.Value)

        End If

    End Sub

    Private Sub PgtoDinheiro()

        txt_total_pago.Clear()
        txt_total_pago.Enabled = True

        btn_confirmar.Enabled = True
        btn_confirmar.BackColor = Color.FromArgb(144, 192, 190)

        cmb_parcelas.SelectedIndex = 0
        cmb_parcelas.Enabled = False
        txt_parcelas.Enabled = False

        'REGRA DE NEGOCIO: SE PAGAMENTO EM DINHEIRO, DESCONTO 5%
        txt_desc_porcent.Text = "5%"
        txt_desc_rs.Text = AdicionaMascara(RemoveMascara(lbl_valor_total.Text) * 0.05)

        AtualizaPagamento()

    End Sub

    Private Sub PgtoCartao()
        txt_total_pago.Clear()
        txt_total_pago.Enabled = False

        btn_confirmar.Enabled = False
        btn_confirmar.BackColor = Color.FromArgb(211, 211, 211)

        cmb_parcelas.Enabled = True
        cmb_parcelas.SelectedIndex = 0
        txt_parcelas.Enabled = True

        txt_troco.Clear()

        'REGRA DE NEGOCIO: SE PAGAMENTO EM CARTÃO, SEM DESCONTO
        txt_desc_porcent.Text = "Sem Desconto"
        txt_desc_rs.Text = AdicionaMascara(0.00)

        AtualizaPagamento()

    End Sub

    Private Sub cmb_forma_pgto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_forma_pgto.SelectedIndexChanged
        If cmb_forma_pgto.Text = "Dinheiro" Then

            PgtoDinheiro()

        ElseIf cmb_forma_pgto.Text = "Cartão" Then

            PgtoCartao()

        End If
    End Sub

    Private Sub txt_total_pago_Leave(sender As Object, e As EventArgs) Handles txt_total_pago.Leave
        txt_total_pago.Text = AdicionaMascara(txt_total_pago.Text)
    End Sub

    Private Sub CarregarDadosItemDgv(cod_venda As Integer)
        'CARREGANDO DADOS NO DATAGRIDVIEW DE FRENTE DE CAIXA ABA CADASTRO
        SQL = "SELECT 
                    dv.quantidade,
                    e.produto,
                    dv.valor_unitario * dv.quantidade AS PrecoTotal
                FROM 
                    tb_descricao_vendas AS dv
                JOIN 
                    tb_estoque AS e ON dv.sku = e.sku
               WHERE cod_venda = " & cod_venda

        rs = db.Execute(SQL)

        With dgv_compra_cadastro

            .Rows.Clear()

            Do While rs.EOF = False

                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()

            Loop

        End With
    End Sub

    Private Sub CarregarDadosPagamentoDgv(cod_venda As Integer)
        'CARREGANDO DADOS NO DATAGRIDVIEW DE FRENTE DE CAIXA ABA PAGAMENTO
        SQL = "SELECT 
                    dv.quantidade,
                    e.produto,
                    dv.valor_unitario * dv.quantidade AS PrecoTotal
                FROM 
                    tb_descricao_vendas AS dv
                JOIN 
                    tb_estoque AS e ON dv.sku = e.sku
               WHERE cod_venda = " & cod_venda

        rs = db.Execute(SQL)

        With dgv_compra_pgto
            .Rows.Clear()

            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If dgv_compra_cadastro.Rows.Count = 0 Then

            MsgBox("Adicione um produto!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

        ElseIf cmb_forma_pgto.SelectedIndex = -1 Then

            MsgBox("Informe os dados do pagamento!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

        Else

            resp = MsgBox("Você está prestes a finalizar uma compra" + vbNewLine &
                           "Confirma esta escolha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")

            If resp = MsgBoxResult.Yes Then

                Dim percentualDesconto As Integer

                If cmb_forma_pgto.SelectedIndex = 0 Then

                    percentualDesconto = 5

                    SQL = "UPDATE tb_descricao_vendas
					   SET valor_pago = valor_total * 0.95
					   WHERE cod_venda = " & idVendaAtual

                    rs = db.Execute(SQL)

                Else

                    percentualDesconto = 0

                    SQL = "UPDATE tb_descricao_vendas
					   SET valor_pago = valor_total
					   WHERE cod_venda = " & idVendaAtual

                    rs = db.Execute(SQL)

                End If

                SQL = "UPDATE tb_vendas 
					   SET valor_total ='" & CDbl(txt_valor_a_pagar.Text).ToString(CultureInfo.InvariantCulture) & "',
					       percentual_desconto = " & percentualDesconto & ",
						   status = 'FINALIZADA'
					   WHERE cod_venda = " & idVendaAtual

                rs = db.Execute(SQL)

                MsgBox("Venda finalizada com sucesso", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")


                AtualizaEstoque()
                ReinicializarVenda()
                TabControl1.SelectedIndex = 0

            End If

        End If
    End Sub

    '----------------------------------------------------------------------------------------------
    'FUNÇÕES
    Private Sub AtualizaIdVenda()


        Dim idVendaIniciada As Integer = ObtemIdVendaIniciada()
        If (idVendaIniciada > 0) Then
            AtualizaIdFuncionarioDataVenda(idVendaIniciada)
            idVendaAtual = idVendaIniciada
            lbl_id_venda.Text = idVendaIniciada
            RemoveProdutosVenda(idVendaIniciada)
            Exit Sub
        End If

        'CRIA NOVA VENDA NA TABELA TB_VENDAS
        CriaNovaVenda()

        'SELECIONA CÓDIGO VENDA DA ÚLTIMA VENDA INICIADA NA TABELA TB_VENDAS
        SQL = "SELECT cod_venda 
               FROM tb_vendas WHERE status = 'INICIADA'"
        rs = db.Execute(SQL)

        'LAÇO PARA OBTER O NÚMERO DA ÚLTIMA VENDA INICIADA
        Do While rs.EOF = False
            idVendaAtual = rs.Fields(0).Value
            rs.MoveNext()
        Loop

        lbl_id_venda.Text = idVendaAtual
    End Sub

    Private Sub CriaNovaVenda()
        'SCRIPT PARA CRIAR NOVA VENDA INICIADA DA TABELA TB_VENDAS
        SQL = "INSERT INTO tb_vendas " &
                    "(id_funcionario,data_venda, status) " &
              "VALUES " &
                    "(" & ID_func & " , '" & DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") & "', 'INICIADA')"
        rs = db.Execute(SQL)
    End Sub

    Private Sub AtualizaIdFuncionarioDataVenda(cod_venda As Integer)

        'SCRIPT PARA ATUALIZAR O ID FUNCIONÁRIO E A DATA DA VENDA INICIADA DA TABELA TB_VENDAS
        SQL = "UPDATE tb_vendas " &
              "SET id_funcionario= " & ID_func & ", data_venda = '" & DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") & "' " &
              "WHERE cod_venda = " & cod_venda
        rs = db.Execute(SQL)

    End Sub

    Private Function ObtemIdVendaIniciada() As Integer

        'SCRIPT PARA SELECIONAR CÓDIGO VENDA INICIADA DA TABELA TB_VENDAS
        SQL = "SELECT cod_venda 
               FROM tb_vendas 
               WHERE status = 'INICIADA'"
        rs = db.Execute(SQL)

        Dim idVenda As Integer = 0

        'OBTÉM O NÚMERO DA PRIMEIRA VENDA INICIADA
        If rs.EOF = False Then
            idVenda = rs.Fields(0).Value
        End If

        Return idVenda
    End Function

    Private Sub RemoveProdutosVenda(cod_venda As Integer)
        'SCRIPT PARA DELETAR TODOS OS PRODUTOS DA TABELA TB_DESCRCAO_VENDAS RELACIONADOS AO CÓDIGO VENDA INFORMADO
        SQL = "DELETE tb_descricao_vendas " &
              "WHERE cod_venda = " & cod_venda
        rs = db.Execute(SQL)
    End Sub

    Private Sub CancelaVenda(cod_venda As Integer)
        'SCRIPT PARA ALTERAR O STATUS DA VENDA INFORMADA POR PARÂMETRO, PARA CANCELADA NA TABELA TB_VENDAS
        SQL = "UPDATE tb_vendas " &
              "SET status = 'CANCELADA'" &
              "WHERE cod_venda = " & cod_venda
        rs = db.Execute(SQL)

        'LIMPA TODOS OS CAMPOS DA ABA ITEM E PAGAMENTO
        ReinicializarVenda()
    End Sub

    Private Sub AtualizaTotal()
        'ATUALIZA O VALOR TOTAL DA VENDA
        lbl_valor_total.Text = AdicionaMascara(SomaTotalDescricaoVenda(idVendaAtual))
    End Sub

    Function SomaTotalDescricaoVenda(cod_venda As Integer) As Double
        Dim total As Double = 0

        'SOMA O PRECOTOTAL DA MESMA CONSULTA DO DATAGRIDVIEW DE PRODUTOS
        SQL = "SELECT SUM(PrecoTotal) total
               FROM(SELECT 
                        dv.quantidade,
                        e.produto,
                        dv.valor_unitario * dv.quantidade AS PrecoTotal
                    FROM tb_descricao_vendas As dv
                    JOIN tb_estoque As e On dv.sku = e.sku
                    WHERE cod_venda = " & cod_venda & ") AS grid"

        rs = db.Execute(SQL)

        If rs.EOF = False Then
            If IsDBNull(rs.Fields(0).Value) Then
                total = 0
            Else
                total = CDbl(rs.Fields(0).Value)
            End If

        End If

        Return total
    End Function

    Private Sub AtualizaPagamento()

        txt_subtotal_pgto.Text = lbl_valor_total.Text
        txt_valor_a_pagar.Text = AdicionaMascara(RemoveMascara(txt_subtotal_pgto.Text) - RemoveMascara(txt_desc_rs.Text))

    End Sub

    Private Sub carregar_dados_parametros()
        'CARREGANDO DADOS NO COMBOBOX DE PARAMETROS ABA CADASTRO EM FRENTE DE CAIXA
        With cmb_parametro
            .Items.Clear()

            .Items.Add("SKU")
            .Items.Add("Produto")

        End With

    End Sub

    Private Sub carregar_dados_parcelas()
        With cmb_parcelas
            .Items.Clear()

            .Items.Add("1x")
            .Items.Add("2x")
            .Items.Add("3x")

        End With
    End Sub

    Private Sub carregar_dados_pagamento()
        With cmb_forma_pgto
            .Items.Clear()

            .Items.Add("Dinheiro")
            .Items.Add("Cartão")

        End With
    End Sub

    Private Sub AtualizaEstoque()
        SQL = "UPDATE tb_estoque
               SET qtd_estoque = qtd_estoque - tb_descricao_vendas.quantidade
               FROM tb_estoque
               INNER JOIN tb_descricao_vendas ON tb_estoque.SKU = tb_descricao_vendas.SKU
               WHERE tb_descricao_vendas.cod_venda = " & idVendaAtual

        rs = db.Execute(SQL)


    End Sub
End Class