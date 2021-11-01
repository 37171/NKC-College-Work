Public Class ballForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ballTimerUp_Tick(sender As Object, e As EventArgs) Handles ballTimerUp.Tick
        ball.Location = New Point(ball.Location.X, ball.Location.Y - 8)
    End Sub

    Private Sub ballTimerHalf_Tick(sender As Object, e As EventArgs) Handles ballTimerHalf.Tick
        ballTimerUp.Enabled = Not (ballTimerUp.Enabled)
        ballTimerDown.Enabled = Not (ballTimerDown.Enabled)
        ballTimerSquash.Enabled = True
        squashItSTimer.Enabled = True
    End Sub

    Private Sub ballTimerDown_Tick(sender As Object, e As EventArgs) Handles ballTimerDown.Tick
        ball.Location = New Point(ball.Location.X, ball.Location.Y + 8)
    End Sub

    Private Sub ballTimerSquash_Tick(sender As Object, e As EventArgs) Handles ballTimerSquash.Tick
        'attempt to make the ball squash, would later be used to make it squash against a wall or something
        'Dim ballHeightChange = ball.Height - (ball.Height * 0.95)
        'Dim ballWidthChange = ball.Width - (ball.Width * 1.05)
        'ball.Height = ball.Height + ballHeightChange
        'ball.Width = ball.Width + ballWidthChange
        'ball.Location = New Point(ball.Location.X - (ballWidthChange), ball.Location.Y)
    End Sub

    Private Sub ballTimerUnSquash_Tick(sender As Object, e As EventArgs) Handles ballTimerUnSquash.Tick
        'Dim ballHeightChange = ball.Height - (ball.Height / 0.95)
        'Dim ballWidthChange = ball.Width - (ball.Width / 1.05)
        'ball.Height = ball.Height + ballHeightChange
        'ball.Width = ball.Width + ballWidthChange
        'ball.Location = New Point(ball.Location.X - (ballWidthChange), ball.Location.Y)
    End Sub

    Private Sub squashItSTimer_Tick(sender As Object, e As EventArgs) Handles squashItSTimer.Tick
        ballTimerSquash.Enabled = False
        squashItSTimer.Enabled = False
        ballTimerUnSquash.Enabled = True
        squashItUSTimer.Enabled = True
    End Sub
    Private Sub squashItUSTimer_Tick(sender As Object, e As EventArgs) Handles squashItUSTimer.Tick
        ballTimerUnSquash.Enabled = False
        squashItUSTimer.Enabled = False
    End Sub
End Class
