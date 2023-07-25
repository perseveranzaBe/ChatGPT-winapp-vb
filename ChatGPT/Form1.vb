Imports System.Net.Http
Imports System.Runtime
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private _messages As New List(Of Object)

    Private Async Function SendMessageToGPT3Async(inputText As String, role As String) As Task(Of String)
        Dim output As String = ""
        Dim apikey As String = My.Settings("ApiKey")

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & apikey)

            _messages.Add(New With {.role = role, .content = inputText})

            Dim json As String = JsonConvert.SerializeObject(New With {
            .model = My.Settings("model"),
            .messages = _messages,
            .temperature = 0.7
        })

            'RichTextBox1.AppendText($"Sending to API: {json}" + Environment.NewLine + Environment.NewLine) ' Append the json data to RichTextBox1 for debugging

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
            act = Label3.Text + " " + ActBox.SelectedItem.ToString() + ". "
            create = Label4.Text + " " + CreateBox.SelectedItem.ToString() + ". "
            show = Label5.Text + " " + ShowBox.SelectedItem.ToString() + ". "
            inputText = act + create + show + TextBox1.Text

            ToggleExtraControls(False)


        Else
            ' If it's not the first message
            inputText = TextBox1.Text
        End If

        RichTextBox1.AppendText("You: " + Environment.NewLine + inputText + Environment.NewLine + Environment.NewLine)
        TextBox1.Clear()

        Dim output As String = Await SendMessageToGPT3Async(inputText, "user")
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

    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inputText As String = My.Settings("CAN")
        Dim output As String = Await SendMessageToGPT3Async(inputText, "system")
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ToggleExtraControls(False)
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim inputText As String = My.Settings("STAN")
        Dim output As String = Await SendMessageToGPT3Async(inputText, "system")
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ToggleExtraControls(False)
    End Sub

    Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim inputText As String = My.Settings("MONGO")
        Dim output As String = Await SendMessageToGPT3Async(inputText, "system")
        RichTextBox1.AppendText(output + Environment.NewLine + Environment.NewLine)

        ToggleExtraControls(False)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox()
        Dim btn3 As String = ""
        Dim btn5 As String = ""
        Dim btn6 As String = ""
        btn3 = My.Settings("BTNCAN")
        btn5 = My.Settings("BTNSTAN")
        btn6 = My.Settings("BTNMONGO")
        Button3.Text = btn3
        Button5.Text = btn5
        Button6.Text = btn6

        'get language for form
        Dim lang As String = ""
        lang = My.Settings("language")
        TranslateForm(Me, lang)

        ActBox.SelectedIndex = 0
        ShowBox.SelectedIndex = 0
        CreateBox.SelectedIndex = 0
    End Sub



    Private Sub ToggleExtraControls(isVisible As Boolean)
        ActBox.Visible = isVisible
        CreateBox.Visible = isVisible
        ShowBox.Visible = isVisible
        Label3.Visible = isVisible
        Label4.Visible = isVisible
        Label5.Visible = isVisible
        Button3.Visible = isVisible
        Button5.Visible = isVisible
        Button6.Visible = isVisible
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim AboutBox As New AboutBox()
        AboutBox.ShowDialog()
    End Sub

    Private Sub SetButtonBehaviorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetButtonBehaviorToolStripMenuItem.Click
        Dim buttons As New buttons()
        buttons.ShowDialog()
    End Sub

    Private Sub SetAPIKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAPIKeyToolStripMenuItem.Click
        Dim SetAPI As New SetAPI()
        SetAPI.ShowDialog()
    End Sub

    Private Sub SetModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetModelToolStripMenuItem.Click
        Dim getModels As New getModels()
        getModels.ShowDialog()
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        TranslateForm(Me, "English")
        My.Settings.language = "English"
        My.Settings.Save()
    End Sub

    Private Sub NederlandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NederlandsToolStripMenuItem.Click
        TranslateForm(Me, "Dutch")
        My.Settings.language = "Dutch"
        My.Settings.Save()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub FrançaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrançaisToolStripMenuItem.Click
        TranslateForm(Me, "French")
        My.Settings.language = "French"
        My.Settings.Save()
    End Sub

    Friend Sub PopulateComboBox()
        ' Clear the ComboBox
        ActBox.Items.Clear()
        CreateBox.Items.Clear()
        ShowBox.Items.Clear()

        ' Get the 'ACT' setting
        Dim actSetting As String = My.Settings.ACT
        Dim createSetting As String = My.Settings.CREATE
        Dim showSetting As String = My.Settings.SHOW

        ' Split the string into an array
        Dim valuesAct As String() = actSetting.Split(","c)
        Dim valuesCreate As String() = createSetting.Split(","c)
        Dim valuesShow As String() = showSetting.Split(","c)

        ' Add each value to the ComboBox
        For Each value As String In valuesAct
            ActBox.Items.Add(value.Trim())
        Next
        For Each value As String In valuesCreate
            CreateBox.Items.Add(value.Trim())
        Next
        For Each value As String In valuesShow
            ShowBox.Items.Add(value.Trim())
        Next

        ' Set the default selected item if any items exist
        If ActBox.Items.Count > 0 Then
            ActBox.SelectedIndex = 0
        End If
        If CreateBox.Items.Count > 0 Then
            CreateBox.SelectedIndex = 0
        End If
        If ShowBox.Items.Count > 0 Then
            ShowBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub ActCreateShowSetting_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Call your method here
        PopulateComboBox()
    End Sub
    Private Sub ModifyDropdownValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyDropdownValuesToolStripMenuItem.Click
        Dim ActCreateShowSetting As New ActCreateShowSetting()
        ' Attach an event handler to the FormClosing event
        AddHandler ActCreateShowSetting.FormClosing, AddressOf ActCreateShowSetting_FormClosing
        ActCreateShowSetting.ShowDialog()
    End Sub
End Class