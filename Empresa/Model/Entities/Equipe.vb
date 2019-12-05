
Namespace Model.Entities

    Public Class Equipe

        Public Property id As Integer
        Public Property nomeEquipe As String
        Public Property lider As Funcionario
        Public Property colaboradores As List(Of Funcionario)

        Public Sub New(_id As Integer, _nomeEquipe As String)
            id = _id
            nomeEquipe = _nomeEquipe
            colaboradores = New List(Of Funcionario)
        End Sub

        Public Function ApresentaEquipe() As String
            Dim mensagem As String = ""
            mensagem = "Nome da equipe: " + nomeEquipe + vbCrLf
            If lider Is Nothing Then
                mensagem += "Líder da equipe ainda não definido" + vbCrLf
            Else
                mensagem += "Líder da equipe: " + lider.ApresentaFuncionario + vbCrLf
            End If

            If colaboradores Is Nothing Then
                mensagem += "Equipe ainda não definida" + vbCrLf
            Else
                mensagem += "Equipe:" + vbCrLf
                For Each funcionario In colaboradores
                    mensagem += " - " + funcionario.ApresentaFuncionario + vbCrLf
                Next
            End If

            Return mensagem
        End Function

    End Class

End Namespace
