﻿
Imports Empresa.Model.Entities

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Desenvolvimento
        Dim cargo1 As New Cargo(1, "Programador Jr I", 1800.0, 100.0, 300.0, 350.0)
        Dim cargo2 As New Cargo(1, "Programador Jr II", 3000.0, 100.0, 300.0, 350.0)
        Dim cargo3 As New Cargo(1, "Programador Pl I", 3500.0, 100.0, 300.0, 350.0)
        Dim cargo4 As New Cargo(1, "Programador Pl II", 4500.0, 100.0, 300.0, 350.0)
        Dim cargo5 As New Cargo(1, "Programador Sn I", 5500.0, 100.0, 300.0, 350.0)
        Dim cargo6 As New Cargo(1, "Programador Sn II", 7000.0, 100.0, 300.0, 350.0)

        Dim carreira1 As New Carreira(1, "Desenvolvimento")
        carreira1.cargos.Add(cargo1)
        carreira1.cargos.Add(cargo2)
        carreira1.cargos.Add(cargo3)
        carreira1.cargos.Add(cargo4)
        carreira1.cargos.Add(cargo5)
        carreira1.cargos.Add(cargo6)

        'Analista
        Dim cargo7 As New Cargo(1, "Analista I", 3500.0, 110.0, 300.0, 350.0)
        Dim cargo8 As New Cargo(1, "Analista II", 6000.0, 110.0, 300.0, 350.0)

        Dim carreira2 As New Carreira(2, "Analista")
        carreira1.cargos.Add(cargo7)
        carreira1.cargos.Add(cargo8)

        'Banco
        Dim cargo9 As New Cargo(1, "DBA", 4500.0, 120.0, 300.0, 350.0)

        Dim carreira3 As New Carreira(3, "DBA")
        carreira1.cargos.Add(cargo9)

        'Funcionario
        Dim funcionario1 As New Funcionario(1, "Rafael", New Date(2010, 12, 3), cargo3)
        Dim teste = funcionario1.salario
        MsgBox(teste.ToString)

    End Sub
End Class