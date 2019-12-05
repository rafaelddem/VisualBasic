
Namespace Model.Entities

    Public Class Cargo

        Public Property id As Integer
        Public Property nome As String
        Public Property salarioBase As Double
        Public Property bonificacaoPorTempoTrabalhado As Double
        Public Property vlTransporte As Double
        Public Property vlAlimentacao As Double

        Public Sub New(_id As Integer, _nome As String, _salario As Double, _bonificacaoPorTempoTrabalhado As Double, _vlTransporte As Double, _vlAlimentacao As Double)
            id = _id
            nome = _nome
            salarioBase = _salario
            bonificacaoPorTempoTrabalhado = _bonificacaoPorTempoTrabalhado
            vlTransporte = _vlTransporte
            vlAlimentacao = _vlAlimentacao
        End Sub

    End Class

End Namespace
