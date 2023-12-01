<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_frente_caixa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_frente_caixa))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_estoque = New System.Windows.Forms.TextBox()
        Me.txt_qtde = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_id_venda = New System.Windows.Forms.Label()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.btn_pagamento = New System.Windows.Forms.Button()
        Me.lbl_valor_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_compra_cadastro = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_subtotal_cad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_valoruni = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.txt_sku = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_parcelas = New System.Windows.Forms.ComboBox()
        Me.txt_parcelas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_valor_a_pagar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_troco = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subtotal_pgto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_desc_porcent = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_desc_rs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_total_pago = New System.Windows.Forms.TextBox()
        Me.cmb_forma_pgto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_compra_pgto = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_a = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisa = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_preencher_produto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.lbl_nome_vendedor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.btn_cancelar_venda = New System.Windows.Forms.Button()
        Me.lbl_hoje = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.txt_qtde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_compra_cadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_compra_pgto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_a.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(215, 69)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1029, 368)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.txt_estoque)
        Me.TabPage1.Controls.Add(Me.txt_qtde)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.lbl_id_venda)
        Me.TabPage1.Controls.Add(Me.btn_adicionar)
        Me.TabPage1.Controls.Add(Me.btn_pagamento)
        Me.TabPage1.Controls.Add(Me.lbl_valor_total)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dgv_compra_cadastro)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_produto)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_subtotal_cad)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_valoruni)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.img_produto)
        Me.TabPage1.Controls.Add(Me.txt_sku)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1021, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ITEM VENDA"
        '
        'txt_estoque
        '
        Me.txt_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_estoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_estoque.Location = New System.Drawing.Point(143, 150)
        Me.txt_estoque.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_estoque.Name = "txt_estoque"
        Me.txt_estoque.ReadOnly = True
        Me.txt_estoque.Size = New System.Drawing.Size(147, 19)
        Me.txt_estoque.TabIndex = 2
        '
        'txt_qtde
        '
        Me.txt_qtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_qtde.Location = New System.Drawing.Point(297, 143)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_qtde.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(140, 26)
        Me.txt_qtde.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Quantidade"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "ID Venda"
        '
        'lbl_id_venda
        '
        Me.lbl_id_venda.AutoSize = True
        Me.lbl_id_venda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_venda.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_id_venda.Location = New System.Drawing.Point(15, 174)
        Me.lbl_id_venda.Name = "lbl_id_venda"
        Me.lbl_id_venda.Size = New System.Drawing.Size(0, 20)
        Me.lbl_id_venda.TabIndex = 57
        Me.lbl_id_venda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btn_adicionar.FlatAppearance.BorderSize = 0
        Me.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_adicionar.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar.Location = New System.Drawing.Point(141, 299)
        Me.btn_adicionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(199, 31)
        Me.btn_adicionar.TabIndex = 6
        Me.btn_adicionar.Text = "ADICIONAR PRODUTO"
        Me.btn_adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'btn_pagamento
        '
        Me.btn_pagamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btn_pagamento.FlatAppearance.BorderSize = 0
        Me.btn_pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_pagamento.ForeColor = System.Drawing.Color.White
        Me.btn_pagamento.Location = New System.Drawing.Point(460, 299)
        Me.btn_pagamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_pagamento.Name = "btn_pagamento"
        Me.btn_pagamento.Size = New System.Drawing.Size(199, 31)
        Me.btn_pagamento.TabIndex = 7
        Me.btn_pagamento.Text = "PAGAMENTO"
        Me.btn_pagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pagamento.UseVisualStyleBackColor = False
        '
        'lbl_valor_total
        '
        Me.lbl_valor_total.AutoSize = True
        Me.lbl_valor_total.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_valor_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_valor_total.ForeColor = System.Drawing.Color.White
        Me.lbl_valor_total.Location = New System.Drawing.Point(460, 251)
        Me.lbl_valor_total.Name = "lbl_valor_total"
        Me.lbl_valor_total.Size = New System.Drawing.Size(0, 39)
        Me.lbl_valor_total.TabIndex = 55
        Me.lbl_valor_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(460, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "VALOR TOTAL:"
        '
        'dgv_compra_cadastro
        '
        Me.dgv_compra_cadastro.AllowUserToAddRows = False
        Me.dgv_compra_cadastro.AllowUserToDeleteRows = False
        Me.dgv_compra_cadastro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_compra_cadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_compra_cadastro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_compra_cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compra_cadastro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewImageColumn2})
        Me.dgv_compra_cadastro.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_compra_cadastro.Location = New System.Drawing.Point(456, 46)
        Me.dgv_compra_cadastro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_compra_cadastro.Name = "dgv_compra_cadastro"
        Me.dgv_compra_cadastro.ReadOnly = True
        Me.dgv_compra_cadastro.RowHeadersWidth = 51
        Me.dgv_compra_cadastro.RowTemplate.Height = 24
        Me.dgv_compra_cadastro.Size = New System.Drawing.Size(547, 180)
        Me.dgv_compra_cadastro.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qtd."
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 12
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Preço"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Excluir"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Produto"
        '
        'txt_produto
        '
        Me.txt_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_produto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_produto.Location = New System.Drawing.Point(141, 95)
        Me.txt_produto.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.ReadOnly = True
        Me.txt_produto.Size = New System.Drawing.Size(295, 19)
        Me.txt_produto.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Subtotal"
        '
        'txt_subtotal_cad
        '
        Me.txt_subtotal_cad.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_subtotal_cad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subtotal_cad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_subtotal_cad.Location = New System.Drawing.Point(141, 263)
        Me.txt_subtotal_cad.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_subtotal_cad.Name = "txt_subtotal_cad"
        Me.txt_subtotal_cad.ReadOnly = True
        Me.txt_subtotal_cad.Size = New System.Drawing.Size(295, 19)
        Me.txt_subtotal_cad.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(139, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Valor Unitário"
        '
        'txt_valoruni
        '
        Me.txt_valoruni.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_valoruni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valoruni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_valoruni.Location = New System.Drawing.Point(141, 213)
        Me.txt_valoruni.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_valoruni.Name = "txt_valoruni"
        Me.txt_valoruni.ReadOnly = True
        Me.txt_valoruni.Size = New System.Drawing.Size(293, 19)
        Me.txt_valoruni.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Qtd. Em Estoque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "SKU"
        '
        'img_produto
        '
        Me.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(19, 21)
        Me.img_produto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(103, 118)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_produto.TabIndex = 38
        Me.img_produto.TabStop = False
        '
        'txt_sku
        '
        Me.txt_sku.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_sku.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sku.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_sku.Location = New System.Drawing.Point(141, 43)
        Me.txt_sku.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_sku.Name = "txt_sku"
        Me.txt_sku.ReadOnly = True
        Me.txt_sku.Size = New System.Drawing.Size(295, 19)
        Me.txt_sku.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1021, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PAGAMENTO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_parcelas)
        Me.GroupBox4.Controls.Add(Me.txt_parcelas)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txt_valor_a_pagar)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txt_troco)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txt_subtotal_pgto)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.PictureBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(721, 18)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(292, 315)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumo da compra"
        '
        'cmb_parcelas
        '
        Me.cmb_parcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_parcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmb_parcelas.FormattingEnabled = True
        Me.cmb_parcelas.Location = New System.Drawing.Point(13, 115)
        Me.cmb_parcelas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_parcelas.Name = "cmb_parcelas"
        Me.cmb_parcelas.Size = New System.Drawing.Size(75, 28)
        Me.cmb_parcelas.TabIndex = 14
        '
        'txt_parcelas
        '
        Me.txt_parcelas.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_parcelas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_parcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_parcelas.Location = New System.Drawing.Point(96, 119)
        Me.txt_parcelas.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_parcelas.Name = "txt_parcelas"
        Me.txt_parcelas.ReadOnly = True
        Me.txt_parcelas.Size = New System.Drawing.Size(185, 19)
        Me.txt_parcelas.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label17.Location = New System.Drawing.Point(11, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 18)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Parcelas"
        '
        'txt_valor_a_pagar
        '
        Me.txt_valor_a_pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_valor_a_pagar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valor_a_pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_valor_a_pagar.Location = New System.Drawing.Point(11, 218)
        Me.txt_valor_a_pagar.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_valor_a_pagar.Name = "txt_valor_a_pagar"
        Me.txt_valor_a_pagar.ReadOnly = True
        Me.txt_valor_a_pagar.Size = New System.Drawing.Size(271, 19)
        Me.txt_valor_a_pagar.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label16.Location = New System.Drawing.Point(11, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 18)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Total a pagar"
        '
        'txt_troco
        '
        Me.txt_troco.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_troco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_troco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_troco.Location = New System.Drawing.Point(11, 168)
        Me.txt_troco.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_troco.Name = "txt_troco"
        Me.txt_troco.ReadOnly = True
        Me.txt_troco.Size = New System.Drawing.Size(271, 19)
        Me.txt_troco.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.Location = New System.Drawing.Point(11, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Troco"
        '
        'txt_subtotal_pgto
        '
        Me.txt_subtotal_pgto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_subtotal_pgto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subtotal_pgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_subtotal_pgto.Location = New System.Drawing.Point(11, 75)
        Me.txt_subtotal_pgto.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_subtotal_pgto.Name = "txt_subtotal_pgto"
        Me.txt_subtotal_pgto.ReadOnly = True
        Me.txt_subtotal_pgto.Size = New System.Drawing.Size(271, 19)
        Me.txt_subtotal_pgto.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(11, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Subtotal"
        '
        'PictureBox5
        '
        Me.PictureBox5.ErrorImage = CType(resources.GetObject("PictureBox5.ErrorImage"), System.Drawing.Image)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(251, 12)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_desc_porcent)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_desc_rs)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(423, 177)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(292, 156)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descontos"
        '
        'txt_desc_porcent
        '
        Me.txt_desc_porcent.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_desc_porcent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc_porcent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_desc_porcent.Location = New System.Drawing.Point(11, 114)
        Me.txt_desc_porcent.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_desc_porcent.Name = "txt_desc_porcent"
        Me.txt_desc_porcent.ReadOnly = True
        Me.txt_desc_porcent.Size = New System.Drawing.Size(153, 19)
        Me.txt_desc_porcent.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Location = New System.Drawing.Point(8, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 18)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "%"
        '
        'txt_desc_rs
        '
        Me.txt_desc_rs.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_desc_rs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc_rs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txt_desc_rs.Location = New System.Drawing.Point(11, 57)
        Me.txt_desc_rs.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_desc_rs.Name = "txt_desc_rs"
        Me.txt_desc_rs.ReadOnly = True
        Me.txt_desc_rs.Size = New System.Drawing.Size(153, 19)
        Me.txt_desc_rs.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Location = New System.Drawing.Point(8, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "R$"
        '
        'PictureBox4
        '
        Me.PictureBox4.ErrorImage = CType(resources.GetObject("PictureBox4.ErrorImage"), System.Drawing.Image)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(251, 12)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 44
        Me.PictureBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_confirmar)
        Me.GroupBox2.Controls.Add(Me.txt_total_pago)
        Me.GroupBox2.Controls.Add(Me.cmb_forma_pgto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(423, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(292, 156)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de pagamento"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btn_confirmar.FlatAppearance.BorderSize = 0
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Location = New System.Drawing.Point(165, 98)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(112, 27)
        Me.btn_confirmar.TabIndex = 10
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'txt_total_pago
        '
        Me.txt_total_pago.BackColor = System.Drawing.SystemColors.Window
        Me.txt_total_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_pago.Location = New System.Drawing.Point(11, 98)
        Me.txt_total_pago.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_total_pago.Name = "txt_total_pago"
        Me.txt_total_pago.Size = New System.Drawing.Size(153, 27)
        Me.txt_total_pago.TabIndex = 9
        '
        'cmb_forma_pgto
        '
        Me.cmb_forma_pgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_forma_pgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmb_forma_pgto.FormattingEnabled = True
        Me.cmb_forma_pgto.Location = New System.Drawing.Point(8, 37)
        Me.cmb_forma_pgto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_forma_pgto.Name = "cmb_forma_pgto"
        Me.cmb_forma_pgto.Size = New System.Drawing.Size(217, 26)
        Me.cmb_forma_pgto.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(8, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 18)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Total recebido"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(251, 12)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_compra_pgto)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(403, 315)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Itens da compra"
        '
        'dgv_compra_pgto
        '
        Me.dgv_compra_pgto.AllowUserToAddRows = False
        Me.dgv_compra_pgto.AllowUserToDeleteRows = False
        Me.dgv_compra_pgto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_compra_pgto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_compra_pgto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_compra_pgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compra_pgto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgv_compra_pgto.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_compra_pgto.Location = New System.Drawing.Point(8, 47)
        Me.dgv_compra_pgto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_compra_pgto.Name = "dgv_compra_pgto"
        Me.dgv_compra_pgto.ReadOnly = True
        Me.dgv_compra_pgto.RowHeadersWidth = 51
        Me.dgv_compra_pgto.RowTemplate.Height = 24
        Me.dgv_compra_pgto.Size = New System.Drawing.Size(387, 260)
        Me.dgv_compra_pgto.TabIndex = 54
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qtd."
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 12
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 30
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 170
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Preço"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(361, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'btn_a
        '
        Me.btn_a.BackColor = System.Drawing.Color.White
        Me.btn_a.Dock = System.Windows.Forms.DockStyle.None
        Me.btn_a.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.btn_a.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.btn_a.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_parametro, Me.ToolStripLabel2, Me.cmb_pesquisa, Me.btn_preencher_produto})
        Me.btn_a.Location = New System.Drawing.Point(0, 7)
        Me.btn_a.Name = "btn_a"
        Me.btn_a.Size = New System.Drawing.Size(638, 31)
        Me.btn_a.TabIndex = 19
        Me.btn_a.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(162, 28)
        Me.ToolStripLabel1.Text = "Selecione o parâmetro:"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_parametro
        '
        Me.cmb_parametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmb_parametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_parametro.DropDownWidth = 60
        Me.cmb_parametro.Name = "cmb_parametro"
        Me.cmb_parametro.Size = New System.Drawing.Size(100, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(140, 28)
        Me.ToolStripLabel2.Text = "Digite sua pesquisa:"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_pesquisa
        '
        Me.cmb_pesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_pesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pesquisa.DropDownWidth = 200
        Me.cmb_pesquisa.Name = "cmb_pesquisa"
        Me.cmb_pesquisa.Size = New System.Drawing.Size(200, 31)
        '
        'btn_preencher_produto
        '
        Me.btn_preencher_produto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_preencher_produto.Image = CType(resources.GetObject("btn_preencher_produto.Image"), System.Drawing.Image)
        Me.btn_preencher_produto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_preencher_produto.Name = "btn_preencher_produto"
        Me.btn_preencher_produto.Size = New System.Drawing.Size(29, 28)
        Me.btn_preencher_produto.Text = "ToolStripButton1"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.btn_a)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(769, 39)
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(221, 25)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(769, 39)
        Me.ToolStripContainer1.TabIndex = 43
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(12, 396)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(187, 34)
        Me.btn_voltar.TabIndex = 20
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'lbl_nome_vendedor
        '
        Me.lbl_nome_vendedor.AutoSize = True
        Me.lbl_nome_vendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.lbl_nome_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lbl_nome_vendedor.ForeColor = System.Drawing.Color.White
        Me.lbl_nome_vendedor.Location = New System.Drawing.Point(37, 132)
        Me.lbl_nome_vendedor.MaximumSize = New System.Drawing.Size(149, 0)
        Me.lbl_nome_vendedor.Name = "lbl_nome_vendedor"
        Me.lbl_nome_vendedor.Size = New System.Drawing.Size(143, 32)
        Me.lbl_nome_vendedor.TabIndex = 45
        Me.lbl_nome_vendedor.Text = "XXXXXXXXXXXXXXXXXXX"
        Me.lbl_nome_vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1012, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "VENDA DE PRODUTOS"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btn_finalizar.FlatAppearance.BorderSize = 0
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_finalizar.ForeColor = System.Drawing.Color.White
        Me.btn_finalizar.Location = New System.Drawing.Point(12, 319)
        Me.btn_finalizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(187, 34)
        Me.btn_finalizar.TabIndex = 18
        Me.btn_finalizar.Text = "FINALIZAR VENDA"
        Me.btn_finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_finalizar.UseVisualStyleBackColor = False
        '
        'btn_cancelar_venda
        '
        Me.btn_cancelar_venda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btn_cancelar_venda.FlatAppearance.BorderSize = 0
        Me.btn_cancelar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar_venda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar_venda.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar_venda.Location = New System.Drawing.Point(12, 357)
        Me.btn_cancelar_venda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancelar_venda.Name = "btn_cancelar_venda"
        Me.btn_cancelar_venda.Size = New System.Drawing.Size(187, 34)
        Me.btn_cancelar_venda.TabIndex = 19
        Me.btn_cancelar_venda.Text = "CANCELAR VENDA"
        Me.btn_cancelar_venda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelar_venda.UseVisualStyleBackColor = False
        '
        'lbl_hoje
        '
        Me.lbl_hoje.AutoSize = True
        Me.lbl_hoje.Location = New System.Drawing.Point(9, 7)
        Me.lbl_hoje.Name = "lbl_hoje"
        Me.lbl_hoje.Size = New System.Drawing.Size(0, 16)
        Me.lbl_hoje.TabIndex = 52
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Excluir"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(992, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(12, 69)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 127)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Vendedor:"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_frente_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 453)
        Me.Controls.Add(Me.lbl_hoje)
        Me.Controls.Add(Me.btn_cancelar_venda)
        Me.Controls.Add(Me.btn_finalizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_nome_vendedor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_frente_caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAIXA"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.txt_qtde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_compra_cadastro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_compra_pgto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_a.ResumeLayout(False)
        Me.btn_a.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_subtotal_cad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_valoruni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents txt_sku As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_a As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents dgv_compra_cadastro As DataGridView
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_nome_vendedor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_valor_total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_pagamento As Button
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents cmb_pesquisa As ToolStripComboBox
    Friend WithEvents btn_preencher_produto As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_id_venda As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_total_pago As TextBox
    Friend WithEvents cmb_forma_pgto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_valor_a_pagar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_troco As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subtotal_pgto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_desc_porcent As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_desc_rs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents dgv_compra_pgto As DataGridView
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents btn_cancelar_venda As Button
    Friend WithEvents cmb_parcelas As ComboBox
    Friend WithEvents txt_parcelas As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_hoje As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents txt_estoque As TextBox
    Friend WithEvents txt_qtde As NumericUpDown
    Friend WithEvents Label5 As Label
End Class
