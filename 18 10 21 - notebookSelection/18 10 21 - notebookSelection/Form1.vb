Public Class voteAge
    Private Sub inputAgeTest_Click(sender As Object, e As EventArgs) Handles inputAgeTest.Click
        Dim age As Integer
        Try
            age = inputAgeBox.Text
            outputAgeTest.ForeColor = Color.FromArgb(0, 0, 0)
            If age >= 18 Then
                outputAgeTest.Text = "You are old enough to vote!"
            Else
                age = 18 - age
                outputAgeTest.Text = "You can vote in " + Convert.ToString(age) + " years."
            End If
        Catch ex As System.InvalidCastException
            outputAgeTest.Text = "ERROR: Please enter a valid number."
            outputAgeTest.ForeColor = Color.FromArgb(230, 0, 0)
        End Try
    End Sub

End Class
