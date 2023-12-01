<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_perfil_caixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perfil_caixa))
        Me.btn_nova_venda = New System.Windows.Forms.Button()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.btn_alterar_senha = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome_func = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_nova_venda
        '
        Me.btn_nova_venda.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btn_nova_venda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_nova_venda.FlatAppearance.BorderSize = 0
        Me.btn_nova_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nova_venda.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_nova_venda.ForeColor = System.Drawing.Color.White
        Me.btn_nova_venda.Location = New System.Drawing.Point(423, 300)
        Me.btn_nova_venda.Name = "btn_nova_venda"
        Me.btn_nova_venda.Size = New System.Drawing.Size(368, 39)
        Me.btn_nova_venda.TabIndex = 0
        Me.btn_nova_venda.Text = "NOVA VENDA"
        Me.btn_nova_venda.UseVisualStyleBackColor = False
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btn_deslogar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_deslogar.FlatAppearance.BorderSize = 0
        Me.btn_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deslogar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_deslogar.ForeColor = System.Drawing.Color.White
        Me.btn_deslogar.Location = New System.Drawing.Point(423, 400)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(368, 39)
        Me.btn_deslogar.TabIndex = 2
        Me.btn_deslogar.Text = "DESLOGAR"
        Me.btn_deslogar.UseVisualStyleBackColor = False
        '
        'btn_alterar_senha
        '
        Me.btn_alterar_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btn_alterar_senha.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_alterar_senha.FlatAppearance.BorderSize = 0
        Me.btn_alterar_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterar_senha.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_alterar_senha.ForeColor = System.Drawing.Color.White
        Me.btn_alterar_senha.Location = New System.Drawing.Point(423, 350)
        Me.btn_alterar_senha.Name = "btn_alterar_senha"
        Me.btn_alterar_senha.Size = New System.Drawing.Size(368, 39)
        Me.btn_alterar_senha.TabIndex = 1
        Me.btn_alterar_senha.Text = "ALTERAR SENHA"
        Me.btn_alterar_senha.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-28, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(521, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(500, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Selecione a opção desejada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Raleway", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(528, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Colaborador!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Raleway", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(538, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 27)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Bem Vindo,"
        '
        'lbl_nome_func
        '
        Me.lbl_nome_func.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nome_func.AutoSize = True
        Me.lbl_nome_func.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_nome_func.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_func.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_nome_func.Location = New System.Drawing.Point(12, 9)
        Me.lbl_nome_func.Name = "lbl_nome_func"
        Me.lbl_nome_func.Size = New System.Drawing.Size(0, 18)
        Me.lbl_nome_func.TabIndex = 36
        Me.lbl_nome_func.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_perfil_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(832, 453)
        Me.Controls.Add(Me.lbl_nome_func)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_alterar_senha)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_nova_venda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_perfil_caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLABORADOR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_nova_venda As Button
    Friend WithEvents btn_deslogar As Button
    Friend WithEvents btn_alterar_senha As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome_func As Label
End Class
