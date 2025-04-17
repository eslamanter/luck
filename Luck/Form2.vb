Public Class Form2
    Dim x As New Random
    Private Sub nudleftno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudleftno.ValueChanged
        Me.prgleftno.Value = Me.nudleftno.Value
        Me.lblleftno.Text = Me.nudleftno.Value
    End Sub

    Private Sub nudrightno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudrightno.ValueChanged
        Me.prgrightno.Value = Me.nudrightno.Value
        Me.lblrightno.Text = Me.nudrightno.Value
    End Sub

    Private Sub nudleftluck_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudleftluck.ValueChanged
        Me.lblleftno.ForeColor = Color.White
        Me.lblrightno.ForeColor = Color.White
    End Sub

    Private Sub btnleftluck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleftluck.Click
        Me.Tag = x.Next(1, 3)
        If Me.Tag = "1" Then
            Me.lblleftno.ForeColor = Color.Lime
            Me.lblrightno.ForeColor = Color.Red
            If Me.nudleftno.Value + Me.nudleftluck.Value <= 1000000 Then
                Me.nudleftno.Value += Me.nudleftluck.Value
            Else
                Me.nudleftno.Value = 1000000
            End If
            If Me.nudrightno.Value - Me.nudleftluck.Value >= 0 Then
                Me.nudrightno.Value -= Me.nudleftluck.Value
            Else
                Me.nudrightno.Value = 0
                MessageBox.Show("The left player is the winner", "E.A Luck GAme 2012", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Form1.Visible = True
            End If
        End If
        If Me.Tag = "2" Then
            Me.lblrightno.ForeColor = Color.Lime
            Me.lblleftno.ForeColor = Color.Red
            If Me.nudleftno.Value - Me.nudleftluck.Value >= 0 Then
                Me.nudleftno.Value -= Me.nudleftluck.Value
            Else
                Me.nudleftno.Value = 0
                MessageBox.Show("The right player is the winner", "E.A Luck GAme 2012", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Form1.Visible = True
            End If
            If Me.nudrightno.Value + Me.nudleftluck.Value <= 1000000 Then
                Me.nudrightno.Value += Me.nudleftluck.Value
            Else
                Me.nudrightno.Value = 1000000
            End If
        End If
        Me.grbleftluck.Visible = False
        Me.nudleftluck.Visible = False
        Me.btnleftluck.Visible = False
        Me.grbrightluck.Visible = True
        Me.nudrightluck.Visible = True
        Me.btnrightluck.Visible = True
        Me.lblleftturn.Visible = False
        Me.lblrightturn.Visible = True
    End Sub

    Private Sub btnrightluck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrightluck.Click
        Me.Tag = x.Next(1, 3)
        If Me.Tag = "1" Then
            Me.lblleftno.ForeColor = Color.Lime
            Me.lblrightno.ForeColor = Color.Red
            If Me.nudleftno.Value + Me.nudrightluck.Value <= 1000000 Then
                Me.nudleftno.Value += Me.nudrightluck.Value
            Else
                Me.nudleftno.Value = 1000000
            End If
            If Me.nudrightno.Value - Me.nudrightluck.Value >= 0 Then
                Me.nudrightno.Value -= Me.nudrightluck.Value
            Else
                Me.nudrightno.Value = 0
                MessageBox.Show("The left player is the winner", "E.A Luck GAme 2012", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Form1.Visible = True
            End If
        End If
        If Me.Tag = "2" Then
            Me.lblrightno.ForeColor = Color.Lime
            Me.lblleftno.ForeColor = Color.Red
            If Me.nudleftno.Value - Me.nudrightluck.Value >= 0 Then
                Me.nudleftno.Value -= Me.nudrightluck.Value
            Else
                Me.nudleftno.Value = 0
                MessageBox.Show("The right player is the winner", "E.A Luck GAme 2012", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Form1.Visible = True
            End If
            If Me.nudrightno.Value + Me.nudrightluck.Value <= 1000000 Then
                Me.nudrightno.Value += Me.nudrightluck.Value
            Else
                Me.nudrightno.Value = 1000000
            End If
        End If
        Me.grbleftluck.Visible = True
        Me.nudleftluck.Visible = True
        Me.btnleftluck.Visible = True
        Me.grbrightluck.Visible = False
        Me.nudrightluck.Visible = False
        Me.btnrightluck.Visible = False
        Me.lblleftturn.Visible = True
        Me.lblrightturn.Visible = False
    End Sub

    Private Sub nudrightluck_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudrightluck.ValueChanged
        Me.lblleftno.ForeColor = Color.White
        Me.lblrightno.ForeColor = Color.White
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        Form1.Visible = True
    End Sub
End Class