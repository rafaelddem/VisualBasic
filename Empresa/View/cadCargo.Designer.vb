<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadCargo
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_tituloJanela = New System.Windows.Forms.Label()
        Me.lbl_identificacao = New System.Windows.Forms.Label()
        Me.lbl_salario = New System.Windows.Forms.Label()
        Me.lbl_bonificacao = New System.Windows.Forms.Label()
        Me.lbl_valeTransporte = New System.Windows.Forms.Label()
        Me.lbl_valeAlimentacao = New System.Windows.Forms.Label()
        Me.tbx_identificacao = New System.Windows.Forms.TextBox()
        Me.tbx_salario = New System.Windows.Forms.TextBox()
        Me.tbx_bonificacao = New System.Windows.Forms.TextBox()
        Me.tbx_valeTransporte = New System.Windows.Forms.TextBox()
        Me.tbx_valeAlimentacao = New System.Windows.Forms.TextBox()
        Me.GroupBox_manutencao = New System.Windows.Forms.GroupBox()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.GroupBox_registros = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_regValor_valeAlimentacao = New System.Windows.Forms.Label()
        Me.lbl_regDescr_valeAlimentacao = New System.Windows.Forms.Label()
        Me.lbl_regValor_identificacao = New System.Windows.Forms.Label()
        Me.lbl_regValor_salario = New System.Windows.Forms.Label()
        Me.lbl_regValor_bonificacao = New System.Windows.Forms.Label()
        Me.lbl_regDescr_bonificacao = New System.Windows.Forms.Label()
        Me.lbl_regDescr_salario = New System.Windows.Forms.Label()
        Me.lbl_regDescr_valeTransporte = New System.Windows.Forms.Label()
        Me.lbl_regValor_valeTransporte = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox_manutencao.SuspendLayout()
        Me.GroupBox_registros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tituloJanela
        '
        Me.lbl_tituloJanela.AutoSize = True
        Me.lbl_tituloJanela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloJanela.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_tituloJanela.Location = New System.Drawing.Point(206, 9)
        Me.lbl_tituloJanela.Name = "lbl_tituloJanela"
        Me.lbl_tituloJanela.Size = New System.Drawing.Size(167, 20)
        Me.lbl_tituloJanela.TabIndex = 0
        Me.lbl_tituloJanela.Text = "Cadastro de Cargo"
        Me.lbl_tituloJanela.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_identificacao
        '
        Me.lbl_identificacao.AutoSize = True
        Me.lbl_identificacao.Location = New System.Drawing.Point(6, 32)
        Me.lbl_identificacao.Name = "lbl_identificacao"
        Me.lbl_identificacao.Size = New System.Drawing.Size(116, 13)
        Me.lbl_identificacao.TabIndex = 1
        Me.lbl_identificacao.Text = "Identificação do cargo:"
        '
        'lbl_salario
        '
        Me.lbl_salario.AutoSize = True
        Me.lbl_salario.Location = New System.Drawing.Point(6, 71)
        Me.lbl_salario.Name = "lbl_salario"
        Me.lbl_salario.Size = New System.Drawing.Size(68, 13)
        Me.lbl_salario.TabIndex = 2
        Me.lbl_salario.Text = "Salário base:"
        '
        'lbl_bonificacao
        '
        Me.lbl_bonificacao.AutoSize = True
        Me.lbl_bonificacao.Location = New System.Drawing.Point(6, 110)
        Me.lbl_bonificacao.Name = "lbl_bonificacao"
        Me.lbl_bonificacao.Size = New System.Drawing.Size(174, 13)
        Me.lbl_bonificacao.TabIndex = 3
        Me.lbl_bonificacao.Text = "Bonificação (por anos trabalhados):"
        '
        'lbl_valeTransporte
        '
        Me.lbl_valeTransporte.AutoSize = True
        Me.lbl_valeTransporte.Location = New System.Drawing.Point(6, 149)
        Me.lbl_valeTransporte.Name = "lbl_valeTransporte"
        Me.lbl_valeTransporte.Size = New System.Drawing.Size(85, 13)
        Me.lbl_valeTransporte.TabIndex = 4
        Me.lbl_valeTransporte.Text = "Vale Transporte:"
        '
        'lbl_valeAlimentacao
        '
        Me.lbl_valeAlimentacao.AutoSize = True
        Me.lbl_valeAlimentacao.Location = New System.Drawing.Point(166, 149)
        Me.lbl_valeAlimentacao.Name = "lbl_valeAlimentacao"
        Me.lbl_valeAlimentacao.Size = New System.Drawing.Size(92, 13)
        Me.lbl_valeAlimentacao.TabIndex = 5
        Me.lbl_valeAlimentacao.Text = "Vale Alimentação:"
        '
        'tbx_identificacao
        '
        Me.tbx_identificacao.Location = New System.Drawing.Point(9, 48)
        Me.tbx_identificacao.Name = "tbx_identificacao"
        Me.tbx_identificacao.Size = New System.Drawing.Size(260, 20)
        Me.tbx_identificacao.TabIndex = 6
        '
        'tbx_salario
        '
        Me.tbx_salario.Location = New System.Drawing.Point(9, 87)
        Me.tbx_salario.Name = "tbx_salario"
        Me.tbx_salario.Size = New System.Drawing.Size(100, 20)
        Me.tbx_salario.TabIndex = 7
        '
        'tbx_bonificacao
        '
        Me.tbx_bonificacao.Location = New System.Drawing.Point(9, 126)
        Me.tbx_bonificacao.Name = "tbx_bonificacao"
        Me.tbx_bonificacao.Size = New System.Drawing.Size(100, 20)
        Me.tbx_bonificacao.TabIndex = 8
        '
        'tbx_valeTransporte
        '
        Me.tbx_valeTransporte.Location = New System.Drawing.Point(9, 165)
        Me.tbx_valeTransporte.Name = "tbx_valeTransporte"
        Me.tbx_valeTransporte.Size = New System.Drawing.Size(100, 20)
        Me.tbx_valeTransporte.TabIndex = 9
        '
        'tbx_valeAlimentacao
        '
        Me.tbx_valeAlimentacao.Location = New System.Drawing.Point(169, 165)
        Me.tbx_valeAlimentacao.Name = "tbx_valeAlimentacao"
        Me.tbx_valeAlimentacao.Size = New System.Drawing.Size(100, 20)
        Me.tbx_valeAlimentacao.TabIndex = 10
        '
        'GroupBox_manutencao
        '
        Me.GroupBox_manutencao.Controls.Add(Me.btn_excluir)
        Me.GroupBox_manutencao.Controls.Add(Me.btn_salvar)
        Me.GroupBox_manutencao.Controls.Add(Me.lbl_identificacao)
        Me.GroupBox_manutencao.Controls.Add(Me.tbx_valeAlimentacao)
        Me.GroupBox_manutencao.Controls.Add(Me.tbx_identificacao)
        Me.GroupBox_manutencao.Controls.Add(Me.lbl_valeAlimentacao)
        Me.GroupBox_manutencao.Controls.Add(Me.tbx_valeTransporte)
        Me.GroupBox_manutencao.Controls.Add(Me.lbl_salario)
        Me.GroupBox_manutencao.Controls.Add(Me.tbx_bonificacao)
        Me.GroupBox_manutencao.Controls.Add(Me.lbl_valeTransporte)
        Me.GroupBox_manutencao.Controls.Add(Me.tbx_salario)
        Me.GroupBox_manutencao.Controls.Add(Me.lbl_bonificacao)
        Me.GroupBox_manutencao.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox_manutencao.Name = "GroupBox_manutencao"
        Me.GroupBox_manutencao.Size = New System.Drawing.Size(275, 232)
        Me.GroupBox_manutencao.TabIndex = 11
        Me.GroupBox_manutencao.TabStop = False
        Me.GroupBox_manutencao.Text = "Manutenção"
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(194, 202)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 13
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_salvar
        '
        Me.btn_salvar.Location = New System.Drawing.Point(9, 202)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(75, 23)
        Me.btn_salvar.TabIndex = 13
        Me.btn_salvar.Text = "Salvar"
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'GroupBox_registros
        '
        Me.GroupBox_registros.Controls.Add(Me.DataGridView1)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regValor_valeAlimentacao)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regDescr_valeAlimentacao)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regValor_identificacao)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regValor_salario)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regValor_bonificacao)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regDescr_bonificacao)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regDescr_salario)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regDescr_valeTransporte)
        Me.GroupBox_registros.Controls.Add(Me.lbl_regValor_valeTransporte)
        Me.GroupBox_registros.Location = New System.Drawing.Point(293, 32)
        Me.GroupBox_registros.Name = "GroupBox_registros"
        Me.GroupBox_registros.Size = New System.Drawing.Size(275, 232)
        Me.GroupBox_registros.TabIndex = 12
        Me.GroupBox_registros.TabStop = False
        Me.GroupBox_registros.Text = "Registros"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(260, 151)
        Me.DataGridView1.TabIndex = 22
        '
        'lbl_regValor_valeAlimentacao
        '
        Me.lbl_regValor_valeAlimentacao.AutoSize = True
        Me.lbl_regValor_valeAlimentacao.Location = New System.Drawing.Point(212, 58)
        Me.lbl_regValor_valeAlimentacao.Name = "lbl_regValor_valeAlimentacao"
        Me.lbl_regValor_valeAlimentacao.Size = New System.Drawing.Size(57, 13)
        Me.lbl_regValor_valeAlimentacao.TabIndex = 21
        Me.lbl_regValor_valeAlimentacao.Text = "R$ 000,00"
        '
        'lbl_regDescr_valeAlimentacao
        '
        Me.lbl_regDescr_valeAlimentacao.AutoSize = True
        Me.lbl_regDescr_valeAlimentacao.Location = New System.Drawing.Point(140, 58)
        Me.lbl_regDescr_valeAlimentacao.Name = "lbl_regDescr_valeAlimentacao"
        Me.lbl_regDescr_valeAlimentacao.Size = New System.Drawing.Size(35, 13)
        Me.lbl_regDescr_valeAlimentacao.TabIndex = 20
        Me.lbl_regDescr_valeAlimentacao.Text = "Vl. A.:"
        '
        'lbl_regValor_identificacao
        '
        Me.lbl_regValor_identificacao.AutoSize = True
        Me.lbl_regValor_identificacao.Location = New System.Drawing.Point(6, 32)
        Me.lbl_regValor_identificacao.Name = "lbl_regValor_identificacao"
        Me.lbl_regValor_identificacao.Size = New System.Drawing.Size(35, 13)
        Me.lbl_regValor_identificacao.TabIndex = 13
        Me.lbl_regValor_identificacao.Text = "Nome"
        '
        'lbl_regValor_salario
        '
        Me.lbl_regValor_salario.AutoSize = True
        Me.lbl_regValor_salario.Location = New System.Drawing.Point(69, 45)
        Me.lbl_regValor_salario.Name = "lbl_regValor_salario"
        Me.lbl_regValor_salario.Size = New System.Drawing.Size(66, 13)
        Me.lbl_regValor_salario.TabIndex = 16
        Me.lbl_regValor_salario.Text = "R$ 0.000,00"
        '
        'lbl_regValor_bonificacao
        '
        Me.lbl_regValor_bonificacao.AutoSize = True
        Me.lbl_regValor_bonificacao.Location = New System.Drawing.Point(212, 45)
        Me.lbl_regValor_bonificacao.Name = "lbl_regValor_bonificacao"
        Me.lbl_regValor_bonificacao.Size = New System.Drawing.Size(57, 13)
        Me.lbl_regValor_bonificacao.TabIndex = 14
        Me.lbl_regValor_bonificacao.Text = "R$ 000,00"
        '
        'lbl_regDescr_bonificacao
        '
        Me.lbl_regDescr_bonificacao.AutoSize = True
        Me.lbl_regDescr_bonificacao.Location = New System.Drawing.Point(140, 45)
        Me.lbl_regDescr_bonificacao.Name = "lbl_regDescr_bonificacao"
        Me.lbl_regDescr_bonificacao.Size = New System.Drawing.Size(66, 13)
        Me.lbl_regDescr_bonificacao.TabIndex = 17
        Me.lbl_regDescr_bonificacao.Text = "Bonificação:"
        '
        'lbl_regDescr_salario
        '
        Me.lbl_regDescr_salario.AutoSize = True
        Me.lbl_regDescr_salario.Location = New System.Drawing.Point(6, 45)
        Me.lbl_regDescr_salario.Name = "lbl_regDescr_salario"
        Me.lbl_regDescr_salario.Size = New System.Drawing.Size(42, 13)
        Me.lbl_regDescr_salario.TabIndex = 15
        Me.lbl_regDescr_salario.Text = "Salário:"
        '
        'lbl_regDescr_valeTransporte
        '
        Me.lbl_regDescr_valeTransporte.AutoSize = True
        Me.lbl_regDescr_valeTransporte.Location = New System.Drawing.Point(6, 58)
        Me.lbl_regDescr_valeTransporte.Name = "lbl_regDescr_valeTransporte"
        Me.lbl_regDescr_valeTransporte.Size = New System.Drawing.Size(35, 13)
        Me.lbl_regDescr_valeTransporte.TabIndex = 18
        Me.lbl_regDescr_valeTransporte.Text = "Vl. T.:"
        '
        'lbl_regValor_valeTransporte
        '
        Me.lbl_regValor_valeTransporte.AutoSize = True
        Me.lbl_regValor_valeTransporte.Location = New System.Drawing.Point(78, 58)
        Me.lbl_regValor_valeTransporte.Name = "lbl_regValor_valeTransporte"
        Me.lbl_regValor_valeTransporte.Size = New System.Drawing.Size(57, 13)
        Me.lbl_regValor_valeTransporte.TabIndex = 19
        Me.lbl_regValor_valeTransporte.Text = "R$ 000,00"
        '
        'cadCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 275)
        Me.Controls.Add(Me.GroupBox_registros)
        Me.Controls.Add(Me.GroupBox_manutencao)
        Me.Controls.Add(Me.lbl_tituloJanela)
        Me.Name = "cadCargo"
        Me.Text = "cadCargo"
        Me.GroupBox_manutencao.ResumeLayout(False)
        Me.GroupBox_manutencao.PerformLayout()
        Me.GroupBox_registros.ResumeLayout(False)
        Me.GroupBox_registros.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tituloJanela As Label
    Friend WithEvents lbl_identificacao As Label
    Friend WithEvents lbl_salario As Label
    Friend WithEvents lbl_bonificacao As Label
    Friend WithEvents lbl_valeTransporte As Label
    Friend WithEvents lbl_valeAlimentacao As Label
    Friend WithEvents tbx_identificacao As TextBox
    Friend WithEvents tbx_salario As TextBox
    Friend WithEvents tbx_bonificacao As TextBox
    Friend WithEvents tbx_valeTransporte As TextBox
    Friend WithEvents tbx_valeAlimentacao As TextBox
    Friend WithEvents GroupBox_manutencao As GroupBox
    Friend WithEvents GroupBox_registros As GroupBox
    Friend WithEvents lbl_regValor_valeAlimentacao As Label
    Friend WithEvents lbl_regValor_bonificacao As Label
    Friend WithEvents lbl_regDescr_valeAlimentacao As Label
    Friend WithEvents lbl_regDescr_bonificacao As Label
    Friend WithEvents lbl_regValor_valeTransporte As Label
    Friend WithEvents lbl_regDescr_valeTransporte As Label
    Friend WithEvents lbl_regValor_identificacao As Label
    Friend WithEvents lbl_regDescr_salario As Label
    Friend WithEvents lbl_regValor_salario As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_salvar As Button
End Class
