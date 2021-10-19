Public Class mainForm
    Private Sub compareExec_Click(sender As Object, e As EventArgs) Handles compareExec.Click
        Dim num1 As Double
        Dim num2 As Double
        'Note; as all exceptions handled in this program are InvalidCastExceptions, it would be more efficient to use TypeCast()
        Try
            num1 = compareNumIn1.Text
            num2 = compareNumIn2.Text
            compareOut.ForeColor = Color.FromArgb(0, 0, 0)
            If num1 = num2 Then
                compareOut.Text = "The two numbers are equal!"
            ElseIf num1 > num2 Then
                compareOut.Text = "The first number is greater than the second."
            Else
                compareOut.Text = "The second number is greater than the first."
            End If
        Catch ex As System.InvalidCastException
            compareOut.Text = "ERROR: please enter two valid numbers!"
            compareOut.ForeColor = Color.FromArgb(230, 0, 0)
        End Try
    End Sub
    Private Sub passTest_Click(sender As Object, e As EventArgs) Handles passTest.Click
        Dim pass As String = "PASSWORD"
        If passTestIn.Text = pass Then
            passTestOut.Text = "Welcome to the treasure."
        Else
            passTestOut.Text = "Go away, the treasure's all mine!"
        End If
    End Sub

    Private Sub rangeCheck_Click(sender As Object, e As EventArgs) Handles rangeCheck.Click
        Dim rangeNum As Double
        Try
            rangeNum = rangeCheckIn.Text
            rangeCheckOut.ForeColor = Color.FromArgb(0, 0, 0)
            If 1 <= rangeNum And rangeNum <= 10 Then
                rangeCheckOut.Text = "This number is within range."
            Else
                rangeCheckOut.Text = "This number is out of range!"
            End If
        Catch ex As System.InvalidCastException
            rangeCheckOut.Text = "ERROR: please enter a valid number!"
            rangeCheckOut.ForeColor = Color.FromArgb(230, 0, 0)
        End Try
    End Sub

    Private Sub oddEvenCheck_Click(sender As Object, e As EventArgs) Handles oddEvenCheck.Click
        Dim oddEvenNum As Integer
        Try
            oddEvenNum = oddEvenIn.Text
            oddEvenOut.ForeColor = Color.FromArgb(0, 0, 0)
            If oddEvenNum Mod 2 = 0 Then
                oddEvenOut.Text = "Your number is even."
            Else
                oddEvenOut.Text = "Your number is odd."
            End If
        Catch ex As System.InvalidCastException
            oddEvenOut.Text = "ERROR: please enter a valid number!"
            oddEvenOut.ForeColor = Color.FromArgb(230, 0, 0)
        End Try
    End Sub

    Private Sub BMIExec_Click(sender As Object, e As EventArgs) Handles BMIExec.Click
        Try
            Dim weight As Decimal = 0.45359237 * BMIInLBS.Text
            Dim height As Decimal = 0.0254 * BMIInINCHS.Text
            Dim BMI As Decimal = Math.Round((weight / height ^ 2), 2)
            BMIOut.ForeColor = Color.FromArgb(0, 0, 0)
            BMIOut.Text = "BMI: " + Convert.ToString(BMI)
        Catch ex As System.InvalidCastException
            BMIOut.Text = "ERROR: please enter two valid numbers!"
            BMIOut.ForeColor = Color.FromArgb(230, 0, 0)
        End Try
    End Sub
End Class
