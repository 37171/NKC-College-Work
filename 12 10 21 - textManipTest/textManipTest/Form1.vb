Public Class Form1
    Private Sub stringIterate_Click(sender As Object, e As EventArgs) Handles stringIterate.Click
        Dim stringTest As String = textIterate.Text
        Dim numList(0) As Decimal
        Dim numC As Integer = 0
        Dim numStore As String = ""
        numOut.Text = ""
        For Each c As Char In stringTest
            If IsNumeric(c) Or c = "." Then
                numStore &= c
            ElseIf numStore = "" Then

            Else
                numList(numC) = Convert.ToDecimal(numStore)
                numStore = ""
                numC += 1
                ReDim Preserve numList(numC)
            End If
        Next
        If Not (numStore = "") Then
            numList(numC) = Convert.ToDecimal(numStore)
        End If
        For Each num As String In numList
            If Not (numOut.Text = "") Then
                numOut.Text &= ", " & num
            Else
                numOut.Text &= num
            End If
        Next
    End Sub
End Class
