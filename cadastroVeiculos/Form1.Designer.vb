<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_renavam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.img_montadora = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_montadora = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_cor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.carregar_foto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_pesquisar = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_montadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 109)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(297, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código do Renavam"
        '
        'txt_renavam
        '
        Me.txt_renavam.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_renavam.Location = New System.Drawing.Point(48, 156)
        Me.txt_renavam.Name = "txt_renavam"
        Me.txt_renavam.Size = New System.Drawing.Size(136, 20)
        Me.txt_renavam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(205, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição do Veículo"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descricao.Location = New System.Drawing.Point(208, 156)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(256, 77)
        Me.txt_descricao.TabIndex = 5
        '
        'img_montadora
        '
        Me.img_montadora.Image = CType(resources.GetObject("img_montadora.Image"), System.Drawing.Image)
        Me.img_montadora.Location = New System.Drawing.Point(485, 127)
        Me.img_montadora.Name = "img_montadora"
        Me.img_montadora.Size = New System.Drawing.Size(102, 106)
        Me.img_montadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_montadora.TabIndex = 6
        Me.img_montadora.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Montadora"
        '
        'cmb_montadora
        '
        Me.cmb_montadora.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_montadora.FormattingEnabled = True
        Me.cmb_montadora.Items.AddRange(New Object() {"Chevrolet", "Volkswagen", "Fiat", "Hyundai", "Ford", "Honda", "Toyota", "BMW", "Nissan", "Volvo", "Peugeot", "Citroën"})
        Me.cmb_montadora.Location = New System.Drawing.Point(48, 209)
        Me.cmb_montadora.Name = "cmb_montadora"
        Me.cmb_montadora.Size = New System.Drawing.Size(131, 24)
        Me.cmb_montadora.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Placa"
        '
        'txt_placa
        '
        Me.txt_placa.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_placa.Location = New System.Drawing.Point(48, 259)
        Me.txt_placa.Multiline = True
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(136, 24)
        Me.txt_placa.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(225, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cor"
        '
        'cmb_cor
        '
        Me.cmb_cor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cor.FormattingEnabled = True
        Me.cmb_cor.Items.AddRange(New Object() {"Branco", "Prata", "Preta", "Cinza", "Vermelho", "Azul"})
        Me.cmb_cor.Location = New System.Drawing.Point(228, 259)
        Me.cmb_cor.Name = "cmb_cor"
        Me.cmb_cor.Size = New System.Drawing.Size(166, 24)
        Me.cmb_cor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(429, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Valor de Mercado"
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(432, 259)
        Me.txt_valor.Multiline = True
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(155, 24)
        Me.txt_valor.TabIndex = 14
        '
        'carregar_foto
        '
        Me.carregar_foto.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_excluir)
        Me.Panel2.Controls.Add(Me.btn_pesquisar)
        Me.Panel2.Controls.Add(Me.btn_salvar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 316)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 67)
        Me.Panel2.TabIndex = 15
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.Maroon
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), System.Drawing.Image)
        Me.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excluir.Location = New System.Drawing.Point(409, 9)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(120, 45)
        Me.btn_excluir.TabIndex = 2
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.BackColor = System.Drawing.Color.Teal
        Me.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pesquisar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pesquisar.Image = CType(resources.GetObject("btn_pesquisar.Image"), System.Drawing.Image)
        Me.btn_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pesquisar.Location = New System.Drawing.Point(262, 9)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(120, 45)
        Me.btn_pesquisar.TabIndex = 1
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pesquisar.UseVisualStyleBackColor = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Green
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salvar.Location = New System.Drawing.Point(123, 9)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(106, 45)
        Me.btn_salvar.TabIndex = 0
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(268, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 27)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "AcessaCar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 383)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_cor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_montadora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.img_montadora)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_renavam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "CADASTRO DE VEÍCULOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_montadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_renavam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descricao As System.Windows.Forms.TextBox
    Friend WithEvents img_montadora As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_montadora As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_placa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_cor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_valor As System.Windows.Forms.TextBox
    Friend WithEvents carregar_foto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents btn_salvar As System.Windows.Forms.Button
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
