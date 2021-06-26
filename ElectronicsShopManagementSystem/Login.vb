Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles uname.Click

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If unameTextBox.Text = "admin" Then
            If pwdTextBox.Text = "admin" Then
                unameTextBox.Text = ""
                pwdTextBox.Text = ""
                HomePage.Show()
                Me.Hide()
            Else
                MsgBox("Please provide correct Password!")
            End If
        Else
            MsgBox("Please provide correct UserName!")
        End If

    End Sub

    Private Sub unameTextBox_TextChanged(sender As Object, e As EventArgs) Handles unameTextBox.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
