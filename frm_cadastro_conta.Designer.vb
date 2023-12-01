<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_conta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_conta))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_parametro = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_pesquisa = New System.Windows.Forms.ToolStripTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.cmb_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_funcionarios = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmb_parametro, Me.ToolStripLabel2, Me.txt_pesquisa})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(661, 28)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(144, 25)
        Me.ToolStripLabel2.Text = "Digite sua pesquisa:"
        Me.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_pesquisa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(241, 28)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(287, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(753, 368)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_confirmar_senha)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_senha)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lbl_id)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.cmb_status)
        Me.TabPage1.Controls.Add(Me.cmb_nasc)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(745, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CADASTRO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(49, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 18)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Confirmar Senha"
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_confirmar_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(53, 299)
        Me.txt_confirmar_senha.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(295, 20)
        Me.txt_confirmar_senha.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(49, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_senha.Location = New System.Drawing.Point(53, 242)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(295, 20)
        Me.txt_senha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(194, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(49, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(194, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(49, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Raleway", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(49, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nome Completo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "ID:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_id.Location = New System.Drawing.Point(85, 22)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 20)
        Me.lbl_id.TabIndex = 40
        Me.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(455, 42)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(174, 226)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_foto.TabIndex = 38
        Me.img_foto.TabStop = False
        '
        'cmb_status
        '
        Me.cmb_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Raleway", 9.0!)
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(198, 42)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(135, 26)
        Me.cmb_status.TabIndex = 6
        '
        'cmb_nasc
        '
        Me.cmb_nasc.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmb_nasc.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_nasc.Font = New System.Drawing.Font("Raleway", 9.0!)
        Me.cmb_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_nasc.Location = New System.Drawing.Point(198, 135)
        Me.cmb_nasc.Name = "cmb_nasc"
        Me.cmb_nasc.Size = New System.Drawing.Size(150, 25)
        Me.cmb_nasc.TabIndex = 2
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_cpf.Location = New System.Drawing.Point(53, 140)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(135, 20)
        Me.txt_cpf.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_email.Location = New System.Drawing.Point(53, 188)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(295, 20)
        Me.txt_email.TabIndex = 3
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Raleway", 10.0!)
        Me.txt_nome.Location = New System.Drawing.Point(53, 93)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(295, 20)
        Me.txt_nome.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Controls.Add(Me.dgv_funcionarios)
        Me.TabPage2.Controls.Add(Me.ToolStripContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(745, 339)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM"
        '
        'dgv_funcionarios
        '
        Me.dgv_funcionarios.AllowUserToAddRows = False
        Me.dgv_funcionarios.AllowUserToDeleteRows = False
        Me.dgv_funcionarios.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Raleway", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_funcionarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_funcionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nome, Me.email, Me.status, Me.Editar, Me.Excluir})
        Me.dgv_funcionarios.Location = New System.Drawing.Point(6, 34)
        Me.dgv_funcionarios.Name = "dgv_funcionarios"
        Me.dgv_funcionarios.ReadOnly = True
        Me.dgv_funcionarios.RowHeadersWidth = 51
        Me.dgv_funcionarios.RowTemplate.Height = 24
        Me.dgv_funcionarios.Size = New System.Drawing.Size(743, 317)
        Me.dgv_funcionarios.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 30
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 170
        '
        'email
        '
        Me.email.HeaderText = "E-mail"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 170
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 50
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Editar.MinimumWidth = 6
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Editar.Width = 50
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Width = 50
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(769, 39)
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(6, 91)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(769, 39)
        Me.ToolStripContainer1.TabIndex = 43
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Excluir"
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(51, 161)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(187, 35)
        Me.btn_voltar.TabIndex = 9
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btn_cadastrar.FlatAppearance.BorderSize = 0
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(51, 73)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(187, 35)
        Me.btn_cadastrar.TabIndex = 7
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(789, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "GESTÃO DE FUNCIONÁRIOS"
        '
        'btn_atualizar
        '
        Me.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_atualizar.FlatAppearance.BorderSize = 0
        Me.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_atualizar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atualizar.ForeColor = System.Drawing.Color.White
        Me.btn_atualizar.Location = New System.Drawing.Point(51, 117)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(187, 35)
        Me.btn_atualizar.TabIndex = 8
        Me.btn_atualizar.Text = "ATUALIZAR"
        Me.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_atualizar.UseVisualStyleBackColor = False
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.BackColor = System.Drawing.Color.White
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(245, 117)
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Editar"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.MinimumWidth = 6
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.Width = 50
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "Excluir"
        Me.DataGridViewImageColumn4.Image = CType(resources.GetObject("DataGridViewImageColumn4.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.MinimumWidth = 6
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Width = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(794, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 399)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'frm_cadastro_conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 453)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_cadastro_conta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CONTA"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmb_parametro As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_pesquisa As ToolStripTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents cmb_nasc As DateTimePicker
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgv_funcionarios As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btn_voltar As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_atualizar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
End Class
