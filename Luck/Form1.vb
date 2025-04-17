Public Class Form1

   
    Private Sub btnplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplay.Click
        Me.Visible = False
        Form2.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnplay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnplay.MouseLeave
        Me.btnplay.BackColor = Color.Black
    End Sub

    Private Sub btnplay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnplay.MouseMove
        Me.btnplay.BackColor = Color.DimGray
    End Sub

    Private Sub btnhow_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhow.MouseLeave
        Me.btnhow.BackColor = Color.Black
    End Sub

    Private Sub btnhow_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnhow.MouseMove
        Me.btnhow.BackColor = Color.DimGray
    End Sub

    Private Sub btnexit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.MouseLeave
        Me.btnexit.BackColor = Color.Black
    End Sub

    Private Sub btnexit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnexit.MouseMove
        Me.btnexit.BackColor = Color.DimGray
    End Sub

    Private Sub btnhow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhow.Click
        Form3.Show()
    End Sub
End Class
