﻿Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()

        Dim num As Integer
        Do While (num <= 2)
            lstResult.Items.Add("Number is " & num ^ 2)
            num = num + 1
        Loop

        lstResult.Items.Add("Not implemented yet")
    End Sub
End Class
