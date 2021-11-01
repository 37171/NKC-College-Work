<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ballForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ballForm))
        Me.ballTimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.ballTimerHalf = New System.Windows.Forms.Timer(Me.components)
        Me.ballTimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.ballTimerSquash = New System.Windows.Forms.Timer(Me.components)
        Me.ballTimerUnSquash = New System.Windows.Forms.Timer(Me.components)
        Me.squashItSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.squashItUSTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ballTimerUp
        '
        Me.ballTimerUp.Enabled = True
        Me.ballTimerUp.Interval = 1
        '
        'ballTimerHalf
        '
        Me.ballTimerHalf.Enabled = True
        Me.ballTimerHalf.Interval = 600
        '
        'ballTimerDown
        '
        Me.ballTimerDown.Interval = 1
        '
        'ball
        '
        Me.ball.Image = CType(resources.GetObject("ball.Image"), System.Drawing.Image)
        Me.ball.Location = New System.Drawing.Point(213, 175)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(181, 188)
        Me.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ball.TabIndex = 0
        Me.ball.TabStop = False
        '
        'ballTimerSquash
        '
        Me.ballTimerSquash.Interval = 1
        '
        'ballTimerUnSquash
        '
        Me.ballTimerUnSquash.Interval = 1
        '
        'squashItSTimer
        '
        Me.squashItSTimer.Interval = 80
        '
        'squashItUSTimer
        '
        Me.squashItUSTimer.Interval = 80
        '
        'ballForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ball)
        Me.Name = "ballForm"
        Me.Text = "Le Bouncing Ball"
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ballTimerUp As Timer
    Friend WithEvents ballTimerHalf As Timer
    Friend WithEvents ballTimerDown As Timer
    Friend WithEvents ball As PictureBox
    Friend WithEvents ballTimerSquash As Timer
    Friend WithEvents ballTimerUnSquash As Timer
    Friend WithEvents squashItSTimer As Timer
    Friend WithEvents squashItUSTimer As Timer
End Class
