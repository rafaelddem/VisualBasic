
Namespace Model.Entities

    Public Class Cargo

        Public ReadOnly Property id As Integer
        Public Property nome As String

        Private var_salarioBase As Double
        Public Property salarioBase As Double
            Get
                Return var_salarioBase
            End Get
            Set(value As Double)
                If value > 0 Then
                    var_salarioBase = value
                End If
            End Set
        End Property
        Public Property bonificacaoPorTempoTrabalhado As Double
        Public Property vlTransporte As Double
        Public Property vlAlimentacao As Double

        Public Sub New(_id As Integer, _nome As String, salarioBase As Double, _bonificacaoPorTempoTrabalhado As Double, _vlTransporte As Double, _vlAlimentacao As Double)
            id = _id
            nome = _nome
            var_salarioBase = salarioBase
            bonificacaoPorTempoTrabalhado = _bonificacaoPorTempoTrabalhado
            vlTransporte = _vlTransporte
            vlAlimentacao = _vlAlimentacao
        End Sub

    End Class

End Namespace
