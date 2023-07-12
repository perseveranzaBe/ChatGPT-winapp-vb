Public Class SetAPI
    Private Sub SetAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.ApiKey = txtInput.Text
        My.Settings.Save()
        MsgBox("API Key stored successfully!")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class