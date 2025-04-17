<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnleftluck = New System.Windows.Forms.Button
        Me.nudleftluck = New System.Windows.Forms.NumericUpDown
        Me.grbleftluck = New System.Windows.Forms.GroupBox
        Me.prgleftno = New System.Windows.Forms.ProgressBar
        Me.prgrightno = New System.Windows.Forms.ProgressBar
        Me.nudleftno = New System.Windows.Forms.NumericUpDown
        Me.nudrightno = New System.Windows.Forms.NumericUpDown
        Me.lblleftno = New System.Windows.Forms.Label
        Me.lblrightno = New System.Windows.Forms.Label
        Me.lblleftturn = New System.Windows.Forms.Label
        Me.grbrightluck = New System.Windows.Forms.GroupBox
        Me.btnrightluck = New System.Windows.Forms.Button
        Me.nudrightluck = New System.Windows.Forms.NumericUpDown
        Me.lblrightturn = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.grbrights = New System.Windows.Forms.GroupBox
        CType(Me.nudleftluck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbleftluck.SuspendLayout()
        CType(Me.nudleftno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudrightno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbrightluck.SuspendLayout()
        CType(Me.nudrightluck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbrights.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnleftluck
        '
        Me.btnleftluck.AutoSize = True
        Me.btnleftluck.BackColor = System.Drawing.Color.Black
        Me.btnleftluck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnleftluck.ForeColor = System.Drawing.Color.White
        Me.btnleftluck.Location = New System.Drawing.Point(6, 112)
        Me.btnleftluck.Name = "btnleftluck"
        Me.btnleftluck.Size = New System.Drawing.Size(274, 42)
        Me.btnleftluck.TabIndex = 0
        Me.btnleftluck.Text = "Your Luck"
        Me.btnleftluck.UseVisualStyleBackColor = False
        '
        'nudleftluck
        '
        Me.nudleftluck.BackColor = System.Drawing.Color.Black
        Me.nudleftluck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudleftluck.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudleftluck.ForeColor = System.Drawing.Color.White
        Me.nudleftluck.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudleftluck.Location = New System.Drawing.Point(6, 25)
        Me.nudleftluck.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudleftluck.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudleftluck.Name = "nudleftluck"
        Me.nudleftluck.ReadOnly = True
        Me.nudleftluck.Size = New System.Drawing.Size(274, 81)
        Me.nudleftluck.TabIndex = 1
        Me.nudleftluck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudleftluck.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'grbleftluck
        '
        Me.grbleftluck.Controls.Add(Me.btnleftluck)
        Me.grbleftluck.Controls.Add(Me.nudleftluck)
        Me.grbleftluck.ForeColor = System.Drawing.Color.White
        Me.grbleftluck.Location = New System.Drawing.Point(12, 157)
        Me.grbleftluck.Name = "grbleftluck"
        Me.grbleftluck.Size = New System.Drawing.Size(286, 162)
        Me.grbleftluck.TabIndex = 0
        Me.grbleftluck.TabStop = False
        '
        'prgleftno
        '
        Me.prgleftno.ForeColor = System.Drawing.Color.White
        Me.prgleftno.Location = New System.Drawing.Point(12, 96)
        Me.prgleftno.Maximum = 1000000
        Me.prgleftno.Name = "prgleftno"
        Me.prgleftno.Size = New System.Drawing.Size(286, 23)
        Me.prgleftno.Step = 100
        Me.prgleftno.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgleftno.TabIndex = 0
        Me.prgleftno.Value = 1000000
        '
        'prgrightno
        '
        Me.prgrightno.ForeColor = System.Drawing.Color.White
        Me.prgrightno.Location = New System.Drawing.Point(346, 95)
        Me.prgrightno.Maximum = 1000000
        Me.prgrightno.Name = "prgrightno"
        Me.prgrightno.Size = New System.Drawing.Size(286, 23)
        Me.prgrightno.Step = 100
        Me.prgrightno.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgrightno.TabIndex = 0
        Me.prgrightno.Value = 1000000
        '
        'nudleftno
        '
        Me.nudleftno.BackColor = System.Drawing.Color.Black
        Me.nudleftno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudleftno.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudleftno.ForeColor = System.Drawing.Color.White
        Me.nudleftno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudleftno.Location = New System.Drawing.Point(12, 9)
        Me.nudleftno.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudleftno.Name = "nudleftno"
        Me.nudleftno.ReadOnly = True
        Me.nudleftno.Size = New System.Drawing.Size(286, 81)
        Me.nudleftno.TabIndex = 4
        Me.nudleftno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudleftno.Value = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudleftno.Visible = False
        '
        'nudrightno
        '
        Me.nudrightno.BackColor = System.Drawing.Color.Black
        Me.nudrightno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudrightno.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudrightno.ForeColor = System.Drawing.Color.White
        Me.nudrightno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudrightno.Location = New System.Drawing.Point(346, 8)
        Me.nudrightno.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudrightno.Name = "nudrightno"
        Me.nudrightno.ReadOnly = True
        Me.nudrightno.Size = New System.Drawing.Size(286, 81)
        Me.nudrightno.TabIndex = 5
        Me.nudrightno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudrightno.Value = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudrightno.Visible = False
        '
        'lblleftno
        '
        Me.lblleftno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblleftno.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblleftno.Location = New System.Drawing.Point(12, 9)
        Me.lblleftno.Name = "lblleftno"
        Me.lblleftno.Size = New System.Drawing.Size(286, 81)
        Me.lblleftno.TabIndex = 6
        Me.lblleftno.Text = "1000000"
        Me.lblleftno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblrightno
        '
        Me.lblrightno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblrightno.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrightno.Location = New System.Drawing.Point(346, 8)
        Me.lblrightno.Name = "lblrightno"
        Me.lblrightno.Size = New System.Drawing.Size(286, 81)
        Me.lblrightno.TabIndex = 7
        Me.lblrightno.Text = "1000000"
        Me.lblrightno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblleftturn
        '
        Me.lblleftturn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblleftturn.Location = New System.Drawing.Point(12, 122)
        Me.lblleftturn.Name = "lblleftturn"
        Me.lblleftturn.Size = New System.Drawing.Size(286, 32)
        Me.lblleftturn.TabIndex = 10
        Me.lblleftturn.Text = "Your Turn Now"
        Me.lblleftturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbrightluck
        '
        Me.grbrightluck.Controls.Add(Me.btnrightluck)
        Me.grbrightluck.Controls.Add(Me.nudrightluck)
        Me.grbrightluck.ForeColor = System.Drawing.Color.White
        Me.grbrightluck.Location = New System.Drawing.Point(346, 156)
        Me.grbrightluck.Name = "grbrightluck"
        Me.grbrightluck.Size = New System.Drawing.Size(286, 163)
        Me.grbrightluck.TabIndex = 1
        Me.grbrightluck.TabStop = False
        Me.grbrightluck.Visible = False
        '
        'btnrightluck
        '
        Me.btnrightluck.AutoSize = True
        Me.btnrightluck.BackColor = System.Drawing.Color.Black
        Me.btnrightluck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrightluck.ForeColor = System.Drawing.Color.White
        Me.btnrightluck.Location = New System.Drawing.Point(6, 112)
        Me.btnrightluck.Name = "btnrightluck"
        Me.btnrightluck.Size = New System.Drawing.Size(274, 42)
        Me.btnrightluck.TabIndex = 0
        Me.btnrightluck.Text = "Your Luck"
        Me.btnrightluck.UseVisualStyleBackColor = False
        '
        'nudrightluck
        '
        Me.nudrightluck.BackColor = System.Drawing.Color.Black
        Me.nudrightluck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudrightluck.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudrightluck.ForeColor = System.Drawing.Color.White
        Me.nudrightluck.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudrightluck.Location = New System.Drawing.Point(6, 25)
        Me.nudrightluck.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudrightluck.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudrightluck.Name = "nudrightluck"
        Me.nudrightluck.ReadOnly = True
        Me.nudrightluck.Size = New System.Drawing.Size(274, 81)
        Me.nudrightluck.TabIndex = 1
        Me.nudrightluck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudrightluck.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblrightturn
        '
        Me.lblrightturn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrightturn.Location = New System.Drawing.Point(346, 121)
        Me.lblrightturn.Name = "lblrightturn"
        Me.lblrightturn.Size = New System.Drawing.Size(286, 32)
        Me.lblrightturn.TabIndex = 12
        Me.lblrightturn.Text = "Your Turn Now"
        Me.lblrightturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblrightturn.Visible = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Black
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(375, 15)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(239, 23)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'grbrights
        '
        Me.grbrights.Controls.Add(Me.btnexit)
        Me.grbrights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.grbrights.ForeColor = System.Drawing.Color.White
        Me.grbrights.Location = New System.Drawing.Point(12, 352)
        Me.grbrights.Name = "grbrights"
        Me.grbrights.Size = New System.Drawing.Size(620, 44)
        Me.grbrights.TabIndex = 0
        Me.grbrights.TabStop = False
        Me.grbrights.Text = "All rights reserved ® 2012 - Designed by : Eslam Abdullah"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(644, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbrights)
        Me.Controls.Add(Me.lblrightturn)
        Me.Controls.Add(Me.grbrightluck)
        Me.Controls.Add(Me.lblleftturn)
        Me.Controls.Add(Me.lblrightno)
        Me.Controls.Add(Me.lblleftno)
        Me.Controls.Add(Me.nudrightno)
        Me.Controls.Add(Me.nudleftno)
        Me.Controls.Add(Me.prgrightno)
        Me.Controls.Add(Me.prgleftno)
        Me.Controls.Add(Me.grbleftluck)
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(652, 442)
        Me.MinimumSize = New System.Drawing.Size(652, 442)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.A Luck Game 2012"
        CType(Me.nudleftluck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbleftluck.ResumeLayout(False)
        Me.grbleftluck.PerformLayout()
        CType(Me.nudleftno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudrightno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbrightluck.ResumeLayout(False)
        Me.grbrightluck.PerformLayout()
        CType(Me.nudrightluck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbrights.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnleftluck As System.Windows.Forms.Button
    Friend WithEvents nudleftluck As System.Windows.Forms.NumericUpDown
    Friend WithEvents grbleftluck As System.Windows.Forms.GroupBox
    Friend WithEvents prgleftno As System.Windows.Forms.ProgressBar
    Friend WithEvents prgrightno As System.Windows.Forms.ProgressBar
    Friend WithEvents nudleftno As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudrightno As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblleftno As System.Windows.Forms.Label
    Friend WithEvents lblrightno As System.Windows.Forms.Label
    Friend WithEvents lblleftturn As System.Windows.Forms.Label
    Friend WithEvents grbrightluck As System.Windows.Forms.GroupBox
    Friend WithEvents btnrightluck As System.Windows.Forms.Button
    Friend WithEvents nudrightluck As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblrightturn As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents grbrights As System.Windows.Forms.GroupBox
End Class
