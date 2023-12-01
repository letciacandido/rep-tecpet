<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_perfil_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perfil_adm))
        Me.btn_estoque = New System.Windows.Forms.Button()
        Me.btn_relatorio = New System.Windows.Forms.Button()
        Me.btn_gerenciar_func = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_deslogar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_estoque
        '
        Me.btn_estoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_estoque.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_estoque.FlatAppearance.BorderSize = 0
        Me.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estoque.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.ForeColor = System.Drawing.Color.White
        Me.btn_estoque.Location = New System.Drawing.Point(485, 280)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Size = New System.Drawing.Size(319, 40)
        Me.btn_estoque.TabIndex = 1
        Me.btn_estoque.Text = "GERENCIAR ESTOQUE"
        Me.btn_estoque.UseVisualStyleBackColor = False
        '
        'btn_relatorio
        '
        Me.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_relatorio.FlatAppearance.BorderSize = 0
        Me.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorio.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorio.ForeColor = System.Drawing.Color.White
        Me.btn_relatorio.Location = New System.Drawing.Point(485, 326)
        Me.btn_relatorio.Name = "btn_relatorio"
        Me.btn_relatorio.Size = New System.Drawing.Size(319, 40)
        Me.btn_relatorio.TabIndex = 2
        Me.btn_relatorio.Text = "RELATÓRIOS"
        Me.btn_relatorio.UseVisualStyleBackColor = False
        '
        'btn_gerenciar_func
        '
        Me.btn_gerenciar_func.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_gerenciar_func.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_gerenciar_func.FlatAppearance.BorderSize = 0
        Me.btn_gerenciar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerenciar_func.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciar_func.ForeColor = System.Drawing.Color.White
        Me.btn_gerenciar_func.Location = New System.Drawing.Point(485, 234)
        Me.btn_gerenciar_func.Name = "btn_gerenciar_func"
        Me.btn_gerenciar_func.Size = New System.Drawing.Size(319, 40)
        Me.btn_gerenciar_func.TabIndex = 0
        Me.btn_gerenciar_func.Text = "GERENCIAR FUNCIONÁRIOS"
        Me.btn_gerenciar_func.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-77, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 586)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_deslogar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_deslogar.FlatAppearance.BorderSize = 0
        Me.btn_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deslogar.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deslogar.ForeColor = System.Drawing.Color.White
        Me.btn_deslogar.Location = New System.Drawing.Point(485, 372)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(319, 40)
        Me.btn_deslogar.TabIndex = 3
        Me.btn_deslogar.Text = "DESLOGAR"
        Me.btn_deslogar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Raleway", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(576, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 27)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Bem Vindo,"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Raleway", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(555, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 27)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Administrador!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Raleway", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(538, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Selecione a opção desejada"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(559, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'frm_perfil_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(832, 453)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_estoque)
        Me.Controls.Add(Me.btn_relatorio)
        Me.Controls.Add(Me.btn_gerenciar_func)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_perfil_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_gerenciar_func As Button
    Friend WithEvents btn_relatorio As Button
    Friend WithEvents btn_estoque As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_deslogar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
