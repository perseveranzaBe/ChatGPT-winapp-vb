Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class buttons
    Private Sub buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim txt1 As String = ""
        Dim txt2 As String = ""
        Dim txt3 As String = ""
        Dim txt4 As String = ""
        Dim txt5 As String = ""
        Dim txt6 As String = ""
        txt1 = My.Settings("BTNCAN")
        txt2 = My.Settings("CAN")
        txt3 = My.Settings("BTNSTAN")
        txt4 = My.Settings("STAN")
        txt5 = My.Settings("BTNMONGO")
        txt6 = My.Settings("MONGO")
        TextBox1.Text = txt1
        RichTextBox1.Text = txt2
        TextBox2.Text = txt3
        RichTextBox2.Text = txt4
        TextBox3.Text = txt5
        RichTextBox3.Text = txt6
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.BTNCAN = TextBox1.Text
        My.Settings.Save()

        My.Settings.CAN = RichTextBox1.Text
        My.Settings.Save()

        My.Settings.BTNSTAN = TextBox2.Text
        My.Settings.Save()

        My.Settings.STAN = RichTextBox2.Text
        My.Settings.Save()

        My.Settings.BTNMONGO = TextBox3.Text
        My.Settings.Save()

        My.Settings.MONGO = RichTextBox3.Text
        My.Settings.Save()


        MsgBox("Button config stored successfully!")
        Application.Restart()
        'Me.Close()
    End Sub
End Class