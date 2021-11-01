<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.textIterate = New System.Windows.Forms.TextBox()
        Me.stringIterate = New System.Windows.Forms.Button()
        Me.numOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textIterate
        '
        Me.textIterate.Location = New System.Drawing.Point(12, 12)
        Me.textIterate.Name = "textIterate"
        Me.textIterate.Size = New System.Drawing.Size(100, 20)
        Me.textIterate.TabIndex = 0
        '
        'stringIterate
        '
        Me.stringIterate.Location = New System.Drawing.Point(12, 38)
        Me.stringIterate.Name = "stringIterate"
        Me.stringIterate.Size = New System.Drawing.Size(75, 23)
        Me.stringIterate.TabIndex = 1
        Me.stringIterate.Text = "Execute"
        Me.stringIterate.UseVisualStyleBackColor = True
        '
        'numOut
        '
        Me.numOut.AutoSize = True
        Me.numOut.Location = New System.Drawing.Point(168, 38)
        Me.numOut.Name = "numOut"
        Me.numOut.Size = New System.Drawing.Size(0, 13)
        Me.numOut.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 75)
        Me.Controls.Add(Me.numOut)
        Me.Controls.Add(Me.stringIterate)
        Me.Controls.Add(Me.textIterate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textIterate As TextBox
    Friend WithEvents stringIterate As Button
    Friend WithEvents numOut As Label
End Class
