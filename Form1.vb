Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblYear.Text = txtSalary.Text * 12
        lblVat.Text = txtSalary.Text * 5 / 100
        lblNet.Text = lblYear.Text - lblVat.Text
    End Sub
End Class
