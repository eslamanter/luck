<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grbname = New System.Windows.Forms.GroupBox
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnhow = New System.Windows.Forms.Button
        Me.btnplay = New System.Windows.Forms.Button
        Me.lblea = New System.Windows.Forms.Label
        Me.lbleslam = New System.Windows.Forms.Label
        Me.lbl2012 = New System.Windows.Forms.Label
        Me.grbname.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbname
        '
        Me.grbname.Controls.Add(Me.btnexit)
        Me.grbname.Controls.Add(Me.btnhow)
        Me.grbname.Controls.Add(Me.btnplay)
        Me.grbname.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbname.ForeColor = System.Drawing.Color.White
        Me.grbname.Location = New System.Drawing.Point(382, 12)
        Me.grbname.Name = "grbname"
        Me.grbname.Size = New System.Drawing.Size(186, 198)
        Me.grbname.TabIndex = 0
        Me.grbname.TabStop = False
        Me.grbname.Text = "Luck Game"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Black
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(6, 150)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(174, 40)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnhow
        '
        Me.btnhow.BackColor = System.Drawing.Color.Black
        Me.btnhow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhow.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhow.ForeColor = System.Drawing.Color.White
        Me.btnhow.Location = New System.Drawing.Point(6, 104)
        Me.btnhow.Name = "btnhow"
        Me.btnhow.Size = New System.Drawing.Size(174, 40)
        Me.btnhow.TabIndex = 1
        Me.btnhow.Text = "How ?"
        Me.btnhow.UseVisualStyleBackColor = False
        '
        'btnplay
        '
        Me.btnplay.BackColor = System.Drawing.Color.Black
        Me.btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplay.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplay.ForeColor = System.Drawing.Color.White
        Me.btnplay.Location = New System.Drawing.Point(6, 58)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(174, 40)
        Me.btnplay.TabIndex = 0
        Me.btnplay.Text = "Play"
        Me.btnplay.UseVisualStyleBackColor = False
        '
        'lblea
        '
        Me.lblea.AutoSize = True
        Me.lblea.Font = New System.Drawing.Font("Arial", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblea.Location = New System.Drawing.Point(12, 9)
        Me.lblea.Name = "lblea"
        Me.lblea.Size = New System.Drawing.Size(283, 153)
        Me.lblea.TabIndex = 1
        Me.lblea.Text = "E.A"
        '
        'lbleslam
        '
        Me.lbleslam.AutoSize = True
        Me.lbleslam.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleslam.Location = New System.Drawing.Point(41, 140)
        Me.lbleslam.Name = "lbleslam"
        Me.lbleslam.Size = New System.Drawing.Size(223, 32)
        Me.lbleslam.TabIndex = 2
        Me.lbleslam.Text = "Eslam Abdullah"
        '
        'lbl2012
        '
        Me.lbl2012.AutoSize = True
        Me.lbl2012.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2012.Location = New System.Drawing.Point(229, 30)
        Me.lbl2012.Name = "lbl2012"
        Me.lbl2012.Size = New System.Drawing.Size(103, 32)
        Me.lbl2012.TabIndex = 3
        Me.lbl2012.Text = "® 2012"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(580, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl2012)
        Me.Controls.Add(Me.lbleslam)
        Me.Controls.Add(Me.lblea)
        Me.Controls.Add(Me.grbname)
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(588, 256)
        Me.MinimumSize = New System.Drawing.Size(588, 256)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E.A Luck Game 2012"
        Me.grbname.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbname As System.Windows.Forms.GroupBox
    Friend WithEvents btnplay As System.Windows.Forms.Button
    Friend WithEvents lblea As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnhow As System.Windows.Forms.Button
    Friend WithEvents lbleslam As System.Windows.Forms.Label
    Friend WithEvents lbl2012 As System.Windows.Forms.Label

End Class
