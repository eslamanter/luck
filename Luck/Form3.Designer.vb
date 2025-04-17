<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.grbhow = New System.Windows.Forms.GroupBox
        Me.lblrights = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.txthow = New System.Windows.Forms.TextBox
        Me.grbhow.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbhow
        '
        Me.grbhow.Controls.Add(Me.lblrights)
        Me.grbhow.Controls.Add(Me.btnclose)
        Me.grbhow.Controls.Add(Me.txthow)
        Me.grbhow.ForeColor = System.Drawing.Color.White
        Me.grbhow.Location = New System.Drawing.Point(12, 0)
        Me.grbhow.Name = "grbhow"
        Me.grbhow.Size = New System.Drawing.Size(407, 373)
        Me.grbhow.TabIndex = 0
        Me.grbhow.TabStop = False
        Me.grbhow.Text = "How to play"
        '
        'lblrights
        '
        Me.lblrights.AutoSize = True
        Me.lblrights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrights.Location = New System.Drawing.Point(204, 354)
        Me.lblrights.Name = "lblrights"
        Me.lblrights.Size = New System.Drawing.Size(197, 16)
        Me.lblrights.TabIndex = 3
        Me.lblrights.Text = "Designed by : Eslam Abdullah"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Black
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(350, 8)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(51, 23)
        Me.btnclose.TabIndex = 0
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'txthow
        '
        Me.txthow.BackColor = System.Drawing.Color.Black
        Me.txthow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthow.Font = New System.Drawing.Font("Arial", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthow.ForeColor = System.Drawing.Color.White
        Me.txthow.Location = New System.Drawing.Point(6, 38)
        Me.txthow.Multiline = True
        Me.txthow.Name = "txthow"
        Me.txthow.ReadOnly = True
        Me.txthow.Size = New System.Drawing.Size(395, 270)
        Me.txthow.TabIndex = 1
        Me.txthow.Text = resources.GetString("txthow.Text")
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(431, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbhow)
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(439, 419)
        Me.MinimumSize = New System.Drawing.Size(439, 419)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.A Luck Game 2012"
        Me.grbhow.ResumeLayout(False)
        Me.grbhow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbhow As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txthow As System.Windows.Forms.TextBox
    Friend WithEvents lblrights As System.Windows.Forms.Label
End Class
