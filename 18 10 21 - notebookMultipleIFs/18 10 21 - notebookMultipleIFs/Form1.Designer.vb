<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.compareExec = New System.Windows.Forms.Button()
        Me.compareNumIn1 = New System.Windows.Forms.TextBox()
        Me.compareNumIn2 = New System.Windows.Forms.TextBox()
        Me.compareOut = New System.Windows.Forms.Label()
        Me.compareBox = New System.Windows.Forms.GroupBox()
        Me.passTestBox = New System.Windows.Forms.GroupBox()
        Me.passTestOut = New System.Windows.Forms.Label()
        Me.passTest = New System.Windows.Forms.Button()
        Me.passTestIn = New System.Windows.Forms.TextBox()
        Me.rangeCheckBox = New System.Windows.Forms.GroupBox()
        Me.rangeCheckOut = New System.Windows.Forms.Label()
        Me.rangeCheckIn = New System.Windows.Forms.TextBox()
        Me.rangeCheck = New System.Windows.Forms.Button()
        Me.oddEvenBox = New System.Windows.Forms.GroupBox()
        Me.oddEvenCheck = New System.Windows.Forms.Button()
        Me.oddEvenOut = New System.Windows.Forms.Label()
        Me.oddEvenIn = New System.Windows.Forms.TextBox()
        Me.compareBox.SuspendLayout()
        Me.passTestBox.SuspendLayout()
        Me.rangeCheckBox.SuspendLayout()
        Me.oddEvenBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'compareExec
        '
        Me.compareExec.Location = New System.Drawing.Point(6, 22)
        Me.compareExec.Name = "compareExec"
        Me.compareExec.Size = New System.Drawing.Size(75, 23)
        Me.compareExec.TabIndex = 0
        Me.compareExec.Text = "Compare!"
        Me.compareExec.UseVisualStyleBackColor = True
        '
        'compareNumIn1
        '
        Me.compareNumIn1.Location = New System.Drawing.Point(87, 22)
        Me.compareNumIn1.Name = "compareNumIn1"
        Me.compareNumIn1.Size = New System.Drawing.Size(100, 23)
        Me.compareNumIn1.TabIndex = 1
        '
        'compareNumIn2
        '
        Me.compareNumIn2.Location = New System.Drawing.Point(193, 22)
        Me.compareNumIn2.Name = "compareNumIn2"
        Me.compareNumIn2.Size = New System.Drawing.Size(100, 23)
        Me.compareNumIn2.TabIndex = 2
        '
        'compareOut
        '
        Me.compareOut.AutoSize = True
        Me.compareOut.Location = New System.Drawing.Point(6, 48)
        Me.compareOut.Name = "compareOut"
        Me.compareOut.Size = New System.Drawing.Size(307, 15)
        Me.compareOut.TabIndex = 3
        Me.compareOut.Text = "Enter two numbers, and hit the button to compare them!"
        '
        'compareBox
        '
        Me.compareBox.Controls.Add(Me.compareExec)
        Me.compareBox.Controls.Add(Me.compareOut)
        Me.compareBox.Controls.Add(Me.compareNumIn1)
        Me.compareBox.Controls.Add(Me.compareNumIn2)
        Me.compareBox.Location = New System.Drawing.Point(12, 12)
        Me.compareBox.Name = "compareBox"
        Me.compareBox.Size = New System.Drawing.Size(323, 75)
        Me.compareBox.TabIndex = 4
        Me.compareBox.TabStop = False
        Me.compareBox.Text = "Number Comparison"
        '
        'passTestBox
        '
        Me.passTestBox.Controls.Add(Me.passTestOut)
        Me.passTestBox.Controls.Add(Me.passTest)
        Me.passTestBox.Controls.Add(Me.passTestIn)
        Me.passTestBox.Location = New System.Drawing.Point(341, 12)
        Me.passTestBox.Name = "passTestBox"
        Me.passTestBox.Size = New System.Drawing.Size(198, 75)
        Me.passTestBox.TabIndex = 5
        Me.passTestBox.TabStop = False
        Me.passTestBox.Text = "Password Entry"
        '
        'passTestOut
        '
        Me.passTestOut.AutoSize = True
        Me.passTestOut.Location = New System.Drawing.Point(6, 48)
        Me.passTestOut.Name = "passTestOut"
        Me.passTestOut.Size = New System.Drawing.Size(101, 15)
        Me.passTestOut.TabIndex = 7
        Me.passTestOut.Text = "Enter PASSWORD."
        '
        'passTest
        '
        Me.passTest.Location = New System.Drawing.Point(6, 22)
        Me.passTest.Name = "passTest"
        Me.passTest.Size = New System.Drawing.Size(75, 23)
        Me.passTest.TabIndex = 8
        Me.passTest.Text = "Enter"
        Me.passTest.UseVisualStyleBackColor = True
        '
        'passTestIn
        '
        Me.passTestIn.Location = New System.Drawing.Point(87, 22)
        Me.passTestIn.Name = "passTestIn"
        Me.passTestIn.Size = New System.Drawing.Size(100, 23)
        Me.passTestIn.TabIndex = 6
        '
        'rangeCheckBox
        '
        Me.rangeCheckBox.Controls.Add(Me.rangeCheckOut)
        Me.rangeCheckBox.Controls.Add(Me.rangeCheckIn)
        Me.rangeCheckBox.Controls.Add(Me.rangeCheck)
        Me.rangeCheckBox.Location = New System.Drawing.Point(545, 12)
        Me.rangeCheckBox.Name = "rangeCheckBox"
        Me.rangeCheckBox.Size = New System.Drawing.Size(240, 75)
        Me.rangeCheckBox.TabIndex = 6
        Me.rangeCheckBox.TabStop = False
        Me.rangeCheckBox.Text = "Range Check"
        '
        'rangeCheckOut
        '
        Me.rangeCheckOut.AutoSize = True
        Me.rangeCheckOut.Location = New System.Drawing.Point(6, 47)
        Me.rangeCheckOut.Name = "rangeCheckOut"
        Me.rangeCheckOut.Size = New System.Drawing.Size(222, 15)
        Me.rangeCheckOut.TabIndex = 7
        Me.rangeCheckOut.Text = "Enter a number to see if it's within range."
        '
        'rangeCheckIn
        '
        Me.rangeCheckIn.Location = New System.Drawing.Point(87, 21)
        Me.rangeCheckIn.Name = "rangeCheckIn"
        Me.rangeCheckIn.Size = New System.Drawing.Size(100, 23)
        Me.rangeCheckIn.TabIndex = 1
        '
        'rangeCheck
        '
        Me.rangeCheck.Location = New System.Drawing.Point(6, 21)
        Me.rangeCheck.Name = "rangeCheck"
        Me.rangeCheck.Size = New System.Drawing.Size(75, 23)
        Me.rangeCheck.TabIndex = 0
        Me.rangeCheck.Text = "Check"
        Me.rangeCheck.UseVisualStyleBackColor = True
        '
        'oddEvenBox
        '
        Me.oddEvenBox.Controls.Add(Me.oddEvenIn)
        Me.oddEvenBox.Controls.Add(Me.oddEvenOut)
        Me.oddEvenBox.Controls.Add(Me.oddEvenCheck)
        Me.oddEvenBox.Location = New System.Drawing.Point(12, 93)
        Me.oddEvenBox.Name = "oddEvenBox"
        Me.oddEvenBox.Size = New System.Drawing.Size(256, 75)
        Me.oddEvenBox.TabIndex = 7
        Me.oddEvenBox.TabStop = False
        Me.oddEvenBox.Text = "Odd or Even?"
        '
        'oddEvenCheck
        '
        Me.oddEvenCheck.Location = New System.Drawing.Point(6, 22)
        Me.oddEvenCheck.Name = "oddEvenCheck"
        Me.oddEvenCheck.Size = New System.Drawing.Size(75, 23)
        Me.oddEvenCheck.TabIndex = 0
        Me.oddEvenCheck.Text = "Check"
        Me.oddEvenCheck.UseVisualStyleBackColor = True
        '
        'oddEvenOut
        '
        Me.oddEvenOut.AutoSize = True
        Me.oddEvenOut.Location = New System.Drawing.Point(6, 48)
        Me.oddEvenOut.Name = "oddEvenOut"
        Me.oddEvenOut.Size = New System.Drawing.Size(246, 15)
        Me.oddEvenOut.TabIndex = 1
        Me.oddEvenOut.Text = "Enter an integer to find out if it's odd or even."
        '
        'oddEvenIn
        '
        Me.oddEvenIn.Location = New System.Drawing.Point(87, 22)
        Me.oddEvenIn.Name = "oddEvenIn"
        Me.oddEvenIn.Size = New System.Drawing.Size(100, 23)
        Me.oddEvenIn.TabIndex = 2
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 409)
        Me.Controls.Add(Me.oddEvenBox)
        Me.Controls.Add(Me.rangeCheckBox)
        Me.Controls.Add(Me.passTestBox)
        Me.Controls.Add(Me.compareBox)
        Me.Name = "mainForm"
        Me.Text = "Multiple IFs"
        Me.compareBox.ResumeLayout(False)
        Me.compareBox.PerformLayout()
        Me.passTestBox.ResumeLayout(False)
        Me.passTestBox.PerformLayout()
        Me.rangeCheckBox.ResumeLayout(False)
        Me.rangeCheckBox.PerformLayout()
        Me.oddEvenBox.ResumeLayout(False)
        Me.oddEvenBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents compareExec As Button
    Friend WithEvents compareNumIn1 As TextBox
    Friend WithEvents compareNumIn2 As TextBox
    Friend WithEvents compareOut As Label
    Friend WithEvents compareBox As GroupBox
    Friend WithEvents passTestBox As GroupBox
    Friend WithEvents passTestOut As Label
    Friend WithEvents passTest As Button
    Friend WithEvents passTestIn As TextBox
    Friend WithEvents rangeCheckBox As GroupBox
    Friend WithEvents rangeCheckOut As Label
    Friend WithEvents rangeCheckIn As TextBox
    Friend WithEvents rangeCheck As Button
    Friend WithEvents oddEvenBox As GroupBox
    Friend WithEvents oddEvenIn As TextBox
    Friend WithEvents oddEvenOut As Label
    Friend WithEvents oddEvenCheck As Button
End Class
