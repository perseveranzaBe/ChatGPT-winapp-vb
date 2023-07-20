﻿Imports System.Net.Http
Imports System.Runtime
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private _messages As New List(Of Object)

    Private Async Function SendMessageToGPT3Async(inputText As String) As Task(Of String)
        Dim output As String = ""
        Dim apikey As String = My.Settings("ApiKey")

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & apikey)

            _messages.Add(New With {.role = "user", .content = inputText})

            Dim json As String = JsonConvert.SerializeObject(New With {
                .model = "gpt-3.5-turbo",
                .messages = _messages,
                .temperature = 0.7
            })

            Dim data As New StringContent(json, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync("https://api.openai.com/v1/chat/completions", data)
            Dim content As String = Await response.Content.ReadAsStringAsync()
            Debug.WriteLine("Response status: " + response.StatusCode.ToString())
            Debug.WriteLine("Response content: " + content)
            If response.IsSuccessStatusCode Then
                Dim jObject As JObject = JObject.Parse(content)
                output = jObject("choices")(0)("message")("content").ToString()

                _messages.Add(New With {.role = "assistant", .content = output})
            End If
        End Using

        Return output.Trim()
    End Function


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim act As String
        Dim create As String
        Dim show As String

        Dim inputText As String
        ' If it's the first message
        If _messages.Count = 0 Then
            If ActBox.SelectedItem.ToString() = "Custom" Then
                act = "Act as " + ActText.Text + ". "
            Else
                act = "Act as " + ActBox.SelectedItem.ToString() + ". "
            End If

            If CreateBox.SelectedItem.ToString() = "Custom" Then
                create = "Create As " + CreateText.Text + ". "
            Else
                create = "Create As " + CreateBox.SelectedItem.ToString()
            End If

            If ShowBox.SelectedItem.ToString() = "Custom" Then
                show = "Show as " + ShowText.Text + ". "
            Else
                show = "Show As " + ShowBox.SelectedItem.ToString() + ". " + ". about: "
            End If

            inputText = act + create + show + TextBox1.Text

            ActBox.Visible = False
            CreateBox.Visible = False
            ShowBox.Visible = False
            ActText.Visible = False
            CreateText.Visible = False
            ShowText.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Button3.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False


        Else
            ' If it's not the first message
            inputText = TextBox1.Text
        End If

        RichTextBox1.AppendText("You: " + Environment.NewLine + inputText + Environment.NewLine + Environment.NewLine)
        TextBox1.Clear()

        Dim output As String = Await SendMessageToGPT3Async(inputText)
        RichTextBox1.AppendText("ChatGPT: " + output + Environment.NewLine + Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
        TextBox1.Clear()
        _messages.Clear()
        ActBox.Visible = True
        CreateBox.Visible = True
        ShowBox.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Button3.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
    End Sub


    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inputText As String = My.Settings("CAN")
        Dim output As String = Await SendMessageToGPT3Async(inputText)
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ActBox.Visible = False
        CreateBox.Visible = False
        ShowBox.Visible = False
        ActText.Visible = False
        CreateText.Visible = False
        ShowText.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SetAPI As New SetAPI()
        SetAPI.ShowDialog()
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim inputText As String = My.Settings("STAN")
        Dim output As String = Await SendMessageToGPT3Async(inputText)
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ActBox.Visible = False
        CreateBox.Visible = False
        ShowBox.Visible = False
        ActText.Visible = False
        CreateText.Visible = False
        ShowText.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim inputText As String = My.Settings("MONGO")
        Dim output As String = Await SendMessageToGPT3Async(inputText)
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ActBox.Visible = False
        CreateBox.Visible = False
        ShowBox.Visible = False
        ActText.Visible = False
        CreateText.Visible = False
        ShowText.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim buttons As New buttons()
        buttons.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn3 As String = ""
        Dim btn5 As String = ""
        Dim btn6 As String = ""
        btn3 = My.Settings("BTNCAN")
        btn5 = My.Settings("BTNSTAN")
        btn6 = My.Settings("BTNMONGO")
        Button3.Text = btn3
        Button5.Text = btn5
        Button6.Text = btn6

        ActBox.SelectedIndex = 0
        ShowBox.SelectedIndex = 0
        CreateBox.SelectedIndex = 0


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActBox.SelectedIndexChanged
        ' Check if "Custom" option is selected
        If ActBox.SelectedItem.ToString() = "Custom" Then
            ' Make ActText field visible
            ActText.Visible = True
        Else
            ' Make ActText field invisible and clear its contents
            ActText.Visible = False
            ActText.Clear()
        End If
    End Sub

    Private Sub CreateBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CreateBox.SelectedIndexChanged
        ' Check if "Custom" option is selected
        If CreateBox.SelectedItem.ToString() = "Custom" Then
            ' Make ActText field visible
            CreateText.Visible = True
        Else
            ' Make ActText field invisible and clear its contents
            CreateText.Visible = False
            CreateText.Clear()
        End If
    End Sub

    Private Sub ShowBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowBox.SelectedIndexChanged
        ' Check if "Custom" option is selected
        If ShowBox.SelectedItem.ToString() = "Custom" Then
            ' Make ActText field visible
            ShowText.Visible = True
        Else
            ' Make ActText field invisible and clear its contents
            ShowText.Visible = False
            ShowText.Clear()
        End If
    End Sub
End Class