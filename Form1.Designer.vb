<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_pesquisa = New System.Windows.Forms.ToolStripComboBox()
        Me.btn_pesquisar = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_excluir_p = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(215, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 368)
        Me.TabControl1.TabIndex = 63
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_parametro, Me.ToolStripLabel2, Me.cmb_pesquisa, Me.btn_pesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(219, 35)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(649, 28)
        Me.ToolStrip1.TabIndex = 62
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(975, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(971, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "FORMULARIOS"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(12, 400)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(187, 35)
        Me.btn_voltar.TabIndex = 61
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_voltar.UseVisualStyleBackColor = False
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
        'Column1
        '
        Me.Column1.HeaderText = "Estoque"
        Me.Column1.MinimumWidth = 80
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor unitário"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 270
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "SKU"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 90
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_voltar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FORMULARIOS"
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_pesquisa As ToolStripComboBox
    Friend WithEvents btn_pesquisar As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_excluir_p As DataGridViewImageColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
