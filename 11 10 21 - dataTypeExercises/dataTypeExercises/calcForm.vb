Public Class calculatorTest
    Dim input1 As String
    Dim input2 As String
    Dim total As String
    Private Sub inputBox1_TextChanged(sender As Object, e As EventArgs) Handles inputBox1.TextChanged
        input1 = inputBox1.Text
    End Sub

    Private Sub inputBox2_TextChanged(sender As Object, e As EventArgs) Handles inputBox2.TextChanged
        input2 = inputBox2.Text
    End Sub
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Try
            Dim num1 As Decimal = input1
            Dim num2 As Decimal = input2
            If operationSelection.SelectedItem = "Add" Then
                total = num1 + num2
            ElseIf operationSelection.SelectedItem = "Subtract" Then
                total = num1 - num2
            ElseIf operationSelection.SelectedItem = "Multiply" Then
                total = num1 * num2
            ElseIf operationSelection.SelectedItem = "Divide" Then
                total = num1 / num2
            End If
            buttonLabel1.Text = "Answer: " + total
        Catch inputError As System.InvalidCastException
            buttonLabel1.Text = "INPUT ERROR; please enter valid numbers."
        Catch divZero As System.DivideByZeroException
            buttonLabel1.Text = "INPUT ERROR; do not divide by zero."
        End Try
    End Sub
End Class
