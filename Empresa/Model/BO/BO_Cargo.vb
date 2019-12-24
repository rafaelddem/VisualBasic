Imports Empresa.Model.Entities

Public Class BO_Cargo

    Public Sub salva(_id As Integer, _nome As String, _salario As Double, _bonificacaoPorTempoTrabalhado As Double, _vlTransporte As Double, _vlAlimentacao As Double)

        Dim novoCargo As New Cargo(_id, _nome, _salario, _bonificacaoPorTempoTrabalhado, _vlTransporte, _vlAlimentacao)

    End Sub

End Class
