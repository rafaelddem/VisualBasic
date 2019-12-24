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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubTesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarreiraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TesteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubTesteToolStripMenuItem})
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.TesteToolStripMenuItem.Text = "Menu"
        '
        'SubTesteToolStripMenuItem
        '
        Me.SubTesteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarreiraToolStripMenuItem, Me.CargoToolStripMenuItem, Me.FuncionárioToolStripMenuItem})
        Me.SubTesteToolStripMenuItem.Name = "SubTesteToolStripMenuItem"
        Me.SubTesteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SubTesteToolStripMenuItem.Text = "Carreira"
        '
        'CarreiraToolStripMenuItem
        '
        Me.CarreiraToolStripMenuItem.Name = "CarreiraToolStripMenuItem"
        Me.CarreiraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CarreiraToolStripMenuItem.Text = "Carreira"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FuncionárioToolStripMenuItem.Text = "Funcionário"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubTesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarreiraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As ToolStripMenuItem
End Class
