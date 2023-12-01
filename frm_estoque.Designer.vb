<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estoque))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_valoruni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.txt_sku = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_estoque = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_excluir_p = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisa = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_pesquisar = New System.Windows.Forms.ToolStripButton()
        Me.lbl_hoje = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(219, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 368)
        Me.TabControl1.TabIndex = 54
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.txt_valoruni)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_produto)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.img_produto)
        Me.TabPage1.Controls.Add(Me.txt_qtde)
        Me.TabPage1.Controls.Add(Me.txt_sku)
        Me.TabPage1.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1022, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO"
        '
        'txt_valoruni
        '
        Me.txt_valoruni.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_valoruni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valoruni.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_valoruni.Location = New System.Drawing.Point(43, 187)
        Me.txt_valoruni.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_valoruni.Name = "txt_valoruni"
        Me.txt_valoruni.Size = New System.Drawing.Size(295, 20)
        Me.txt_valoruni.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Produto"
        '
        'txt_produto
        '
        Me.txt_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_produto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_produto.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_produto.Location = New System.Drawing.Point(43, 137)
        Me.txt_produto.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(295, 20)
        Me.txt_produto.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Valor Unitário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Quantidade em estoque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "SKU"
        '
        'img_produto
        '
        Me.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(373, 67)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(164, 194)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_produto.TabIndex = 38
        Me.img_produto.TabStop = False
        '
        'txt_qtde
        '
        Me.txt_qtde.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_qtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtde.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_qtde.Location = New System.Drawing.Point(43, 241)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(295, 20)
        Me.txt_qtde.TabIndex = 3
        '
        'txt_sku
        '
        Me.txt_sku.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_sku.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sku.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_sku.Location = New System.Drawing.Point(43, 85)
        Me.txt_sku.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_sku.Name = "txt_sku"
        Me.txt_sku.Size = New System.Drawing.Size(295, 20)
        Me.txt_sku.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.dgv_estoque)
        Me.TabPage2.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM"
        '
        'dgv_estoque
        '
        Me.dgv_estoque.AllowUserToAddRows = False
        Me.dgv_estoque.AllowUserToDeleteRows = False
        Me.dgv_estoque.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_estoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Column1, Me.btn_editar, Me.btn_excluir_p})
        Me.dgv_estoque.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgv_estoque.Location = New System.Drawing.Point(6, 6)
        Me.dgv_estoque.Name = "dgv_estoque"
        Me.dgv_estoque.ReadOnly = True
        Me.dgv_estoque.RowHeadersWidth = 51
        Me.dgv_estoque.RowTemplate.Height = 24
        Me.dgv_estoque.Size = New System.Drawing.Size(1010, 327)
        Me.dgv_estoque.TabIndex = 54
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "SKU"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 90
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 270
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor unitário"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Estoque"
        Me.Column1.MinimumWidth = 80
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'btn_editar
        '
        Me.btn_editar.HeaderText = "Editar"
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btn_editar.MinimumWidth = 50
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.ReadOnly = True
        Me.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn_editar.Width = 50
        '
        'btn_excluir_p
        '
        Me.btn_excluir_p.HeaderText = "Excluir"
        Me.btn_excluir_p.Image = CType(resources.GetObject("btn_excluir_p.Image"), System.Drawing.Image)
        Me.btn_excluir_p.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btn_excluir_p.MinimumWidth = 50
        Me.btn_excluir_p.Name = "btn_excluir_p"
        Me.btn_excluir_p.ReadOnly = True
        Me.btn_excluir_p.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn_excluir_p.Width = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_parametro, Me.ToolStripLabel2, Me.cmb_pesquisa, Me.btn_pesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(223, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(649, 28)
        Me.ToolStrip1.TabIndex = 53
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Raleway", 8.999999!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(169, 25)
        Me.ToolStripLabel1.Text = "Selecione o parâmetro:"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_parametro
        '
        Me.cmb_parametro.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmb_parametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_parametro.DropDownWidth = 60
        Me.cmb_parametro.Name = "cmb_parametro"
        Me.cmb_parametro.Size = New System.Drawing.Size(100, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Raleway", 8.999999!)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(144, 25)
        Me.ToolStripLabel2.Text = "Digite sua pesquisa:"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_pesquisa
        '
        Me.cmb_pesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_pesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pesquisa.DropDownWidth = 200
        Me.cmb_pesquisa.Name = "cmb_pesquisa"
        Me.cmb_pesquisa.Size = New System.Drawing.Size(200, 28)
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_pesquisar.Image = CType(resources.GetObject("btn_pesquisar.Image"), System.Drawing.Image)
        Me.btn_pesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(29, 25)
        Me.btn_pesquisar.Text = "ToolStripButton1"
        '
        'lbl_hoje
        '
        Me.lbl_hoje.AutoSize = True
        Me.lbl_hoje.Location = New System.Drawing.Point(13, 12)
        Me.lbl_hoje.Name = "lbl_hoje"
        Me.lbl_hoje.Size = New System.Drawing.Size(0, 16)
        Me.lbl_hoje.TabIndex = 62
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btn_cadastrar.FlatAppearance.BorderSize = 0
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(16, 310)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(187, 35)
        Me.btn_cadastrar.TabIndex = 4
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_atualizar
        '
        Me.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btn_atualizar.FlatAppearance.BorderSize = 0
        Me.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atualizar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_atualizar.ForeColor = System.Drawing.Color.White
        Me.btn_atualizar.Location = New System.Drawing.Point(16, 355)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(187, 35)
        Me.btn_atualizar.TabIndex = 5
        Me.btn_atualizar.Text = "ATUALIZAR"
        Me.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_atualizar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(979, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(975, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "CONTROLE DE ESTOQUE"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(16, 400)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(187, 35)
        Me.btn_voltar.TabIndex = 6
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_hoje)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_voltar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTOQUE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents txt_sku As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_estoque As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_pesquisa As ToolStripComboBox
    Friend WithEvents btn_pesquisar As ToolStripButton
    Friend WithEvents lbl_hoje As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_valoruni As TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir_p As DataGridViewImageColumn
End Class
