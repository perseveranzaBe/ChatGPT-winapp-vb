Public Class AboutBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get language for form
        Dim lang As String = ""
        lang = My.Settings("language")
        TranslateForm(Me, lang)
    End Sub
End Class