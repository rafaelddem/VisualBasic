
Namespace Model.Entities

    Public Class Carreira

        Public Property id As Integer
        Public Property nome As String
        Public Property cargos As List(Of Cargo)

        Public Sub New(_id As Integer, _nome As String)
            id = _id
            nome = _nome
            cargos = New List(Of Cargo)
        End Sub

    End Class

End Namespace
