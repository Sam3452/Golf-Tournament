<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.startdatetxt = New System.Windows.Forms.TextBox()
        Me.coursetxt = New System.Windows.Forms.TextBox()
        Me.Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course"
        '
        'startdate
        '
        Me.startdate.Location = New System.Drawing.Point(85, 85)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(200, 20)
        Me.startdate.TabIndex = 3
        '
        'startdatetxt
        '
        Me.startdatetxt.Location = New System.Drawing.Point(85, 44)
        Me.startdatetxt.Name = "startdatetxt"
        Me.startdatetxt.Size = New System.Drawing.Size(100, 20)
        Me.startdatetxt.TabIndex = 4
        '
        'coursetxt
        '
        Me.coursetxt.Location = New System.Drawing.Point(85, 124)
        Me.coursetxt.Name = "coursetxt"
        Me.coursetxt.Size = New System.Drawing.Size(100, 20)
        Me.coursetxt.TabIndex = 5
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(110, 184)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 6
        Me.Close.Text = "Button1"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 283)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.coursetxt)
        Me.Controls.Add(Me.startdatetxt)
        Me.Controls.Add(Me.startdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Manage Tournamet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents startdate As DateTimePicker
    Friend WithEvents startdatetxt As TextBox
    Friend WithEvents coursetxt As TextBox
    Friend WithEvents Close As Button
End Class
