
Namespace Model.Entities

    Public Class Funcionario

        Public Property id As Integer
        Public Property nome As String
        Public Property dataAdmissao As Date
        Public Property cargo As Cargo
        Public ReadOnly Property salario As Double
            Get
                Return calculaSalario()
            End Get
        End Property

        Public Sub New(_id As Integer, _nome As String, _dataAdmissao As Date, _cargo As Cargo)
            id = _id
            nome = _nome
            dataAdmissao = _dataAdmissao
            cargo = _cargo
        End Sub

        Private Function calculaSalario() As Double
            Dim vlSalario = cargo.salarioBase
            vlSalario += (diferencaAnos() * cargo.bonificacaoPorTempoTrabalhado)
            Return vlSalario
        End Function

        Private Function diferencaAnos() As Integer
            Dim dataAtual As Date = Now
            Dim diferenca As Integer = 0
            If dataAdmissao.Year < dataAtual.Year Then

                diferenca = dataAtual.Year - dataAdmissao.Year

                If dataAdmissao.Month > dataAtual.Month _
                    Or (dataAdmissao.Month = dataAtual.Month And dataAdmissao.Day > dataAtual.Day) Then
                    Return diferenca - 1
                End If

            End If
            Return diferenca
        End Function

        Public Function ApresentaFuncionario() As String
            Dim retorno As String = ""
            retorno = nome + " (" + cargo.nome + ")"
            Return retorno
        End Function

    End Class

End Namespace
