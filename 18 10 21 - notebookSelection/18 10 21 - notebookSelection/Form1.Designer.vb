<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voteAge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inputAgeBox = New System.Windows.Forms.TextBox()
        Me.inputAgeTest = New System.Windows.Forms.Button()
        Me.outputAgeTest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputAgeBox
        '
        Me.inputAgeBox.Location = New System.Drawing.Point(167, 12)
        Me.inputAgeBox.Name = "inputAgeBox"
        Me.inputAgeBox.Size = New System.Drawing.Size(100, 23)
        Me.inputAgeBox.TabIndex = 0
        '
        'inputAgeTest
        '
        Me.inputAgeTest.Location = New System.Drawing.Point(12, 12)
        Me.inputAgeTest.Name = "inputAgeTest"
        Me.inputAgeTest.Size = New System.Drawing.Size(149, 23)
        Me.inputAgeTest.TabIndex = 1
        Me.inputAgeTest.Text = "Am I old enough to vote?"
        Me.inputAgeTest.UseVisualStyleBackColor = True
        '
        'outputAgeTest
        '
        Me.outputAgeTest.AutoSize = True
        Me.outputAgeTest.Location = New System.Drawing.Point(12, 38)
        Me.outputAgeTest.Name = "outputAgeTest"
        Me.outputAgeTest.Size = New System.Drawing.Size(244, 15)
        Me.outputAgeTest.TabIndex = 2
        Me.outputAgeTest.Text = "Enter your age and hit the button to find out."
        '
        'voteAge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 65)
        Me.Controls.Add(Me.outputAgeTest)
        Me.Controls.Add(Me.inputAgeTest)
        Me.Controls.Add(Me.inputAgeBox)
        Me.Name = "voteAge"
        Me.Text = "Voting Age Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputAgeBox As TextBox
    Friend WithEvents inputAgeTest As Button
    Friend WithEvents outputAgeTest As Label
End Class
