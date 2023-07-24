Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Linq

Public Class ActCreateShowSetting
    Private Sub ActCreateShowSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettingsToRichTextBoxes()
    End Sub

    Private Sub LoadSettingsToRichTextBoxes()
        ' Assuming RichTextBoxACT, RichTextBoxCREATE, and RichTextBoxSHOW exist
        RichTextBoxACT.Lines = My.Settings.ACT.Split(New Char() {","c})
        RichTextBoxCREATE.Lines = My.Settings.CREATE.Split(New Char() {","c})
        RichTextBoxSHOW.Lines = My.Settings.SHOW.Split(New Char() {","c})
    End Sub

    Private Function GetCommaSeparatedFromRichTextBox(rtb As RichTextBox) As String
        Return String.Join(",", rtb.Lines.Where(Function(line) Not String.IsNullOrWhiteSpace(line)))
    End Function

    Private Sub SaveSettingsFromRichTextBoxes()
        ' Assuming RichTextBoxACT, RichTextBoxCREATE, and RichTextBoxSHOW exist
        My.Settings.ACT = GetCommaSeparatedFromRichTextBox(RichTextBoxACT)
        My.Settings.CREATE = GetCommaSeparatedFromRichTextBox(RichTextBoxCREATE)
        My.Settings.SHOW = GetCommaSeparatedFromRichTextBox(RichTextBoxSHOW)

        My.Settings.Save()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSettingsFromRichTextBoxes()
        Me.Close()
    End Sub
End Class