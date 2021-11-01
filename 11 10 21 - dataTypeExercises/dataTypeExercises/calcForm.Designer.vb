<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculatorTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculatorTest))
        Me.inputBox1 = New System.Windows.Forms.TextBox()
        Me.boxLabel1 = New System.Windows.Forms.Label()
        Me.boxLabel2 = New System.Windows.Forms.Label()
        Me.inputBox2 = New System.Windows.Forms.TextBox()
        Me.operationSelection = New System.Windows.Forms.ComboBox()
        Me.boxLabel3 = New System.Windows.Forms.Label()
        Me.calculate = New System.Windows.Forms.Button()
        Me.buttonLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputBox1
        '
        Me.inputBox1.Location = New System.Drawing.Point(116, 6)
        Me.inputBox1.Name = "inputBox1"
        Me.inputBox1.Size = New System.Drawing.Size(100, 20)
        Me.inputBox1.TabIndex = 0
        '
        'boxLabel1
        '
        Me.boxLabel1.AutoSize = True
        Me.boxLabel1.Location = New System.Drawing.Point(12, 9)
        Me.boxLabel1.Name = "boxLabel1"
        Me.boxLabel1.Size = New System.Drawing.Size(69, 13)
        Me.boxLabel1.TabIndex = 1
        Me.boxLabel1.Text = "First Number:"
        '
        'boxLabel2
        '
        Me.boxLabel2.AutoSize = True
        Me.boxLabel2.Location = New System.Drawing.Point(12, 38)
        Me.boxLabel2.Name = "boxLabel2"
        Me.boxLabel2.Size = New System.Drawing.Size(87, 13)
        Me.boxLabel2.TabIndex = 2
        Me.boxLabel2.Text = "Second Number:"
        '
        'inputBox2
        '
        Me.inputBox2.Location = New System.Drawing.Point(116, 35)
        Me.inputBox2.Name = "inputBox2"
        Me.inputBox2.Size = New System.Drawing.Size(100, 20)
        Me.inputBox2.TabIndex = 3
        '
        'operationSelection
        '
        Me.operationSelection.FormattingEnabled = True
        Me.operationSelection.Items.AddRange(New Object() {"Add", "Subtract", "Multiply", "Divide"})
        Me.operationSelection.Location = New System.Drawing.Point(95, 61)
        Me.operationSelection.Name = "operationSelection"
        Me.operationSelection.Size = New System.Drawing.Size(121, 21)
        Me.operationSelection.TabIndex = 4
        '
        'boxLabel3
        '
        Me.boxLabel3.AutoSize = True
        Me.boxLabel3.Location = New System.Drawing.Point(12, 64)
        Me.boxLabel3.Name = "boxLabel3"
        Me.boxLabel3.Size = New System.Drawing.Size(56, 13)
        Me.boxLabel3.TabIndex = 5
        Me.boxLabel3.Text = "Operation:"
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(141, 88)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(75, 23)
        Me.calculate.TabIndex = 6
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'buttonLabel1
        '
        Me.buttonLabel1.AutoSize = True
        Me.buttonLabel1.Location = New System.Drawing.Point(12, 111)
        Me.buttonLabel1.Name = "buttonLabel1"
        Me.buttonLabel1.Size = New System.Drawing.Size(48, 13)
        Me.buttonLabel1.TabIndex = 7
        Me.buttonLabel1.Text = "Answer: "
        '
        'calculatorTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 134)
        Me.Controls.Add(Me.buttonLabel1)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.boxLabel3)
        Me.Controls.Add(Me.operationSelection)
        Me.Controls.Add(Me.inputBox2)
        Me.Controls.Add(Me.boxLabel2)
        Me.Controls.Add(Me.boxLabel1)
        Me.Controls.Add(Me.inputBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "calculatorTest"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputBox1 As TextBox
    Friend WithEvents boxLabel1 As Label
    Friend WithEvents boxLabel2 As Label
    Friend WithEvents inputBox2 As TextBox
    Friend WithEvents operationSelection As ComboBox
    Friend WithEvents boxLabel3 As Label
    Friend WithEvents calculate As Button
    Friend WithEvents buttonLabel1 As Label
End Class
