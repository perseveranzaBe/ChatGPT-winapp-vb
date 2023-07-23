Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class getModels
    Dim ApiKey As String = My.Settings("ApiKey")
    Dim client As HttpClient
    Dim modelsUrl As String = "https://api.openai.com/v1/models"

    Private Async Sub getModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get language for form
        Dim lang As String = ""
        lang = My.Settings("language")
        TranslateForm(Me, lang)

        client = New HttpClient()
        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + ApiKey)

        lblStatus.Text = "Loading GPT Models..."

        Try
            Dim response = Await client.GetAsync(modelsUrl)
            response.EnsureSuccessStatusCode()

            Dim stringResult = Await response.Content.ReadAsStringAsync()

            Dim result As JObject = JsonConvert.DeserializeObject(Of JObject)(stringResult)
            Dim data As JArray = result("data")

            For Each item As JObject In data
                Dim id As String = item("id")

                If id.StartsWith("gpt-") Then
                    cboModels.Items.Add(id)
                End If
            Next

            lblStatus.Text = "GPT Models Loaded Successfully."

        Catch ex As Exception
            lblStatus.Text = "Failed to Load GPT Models. Please check your API Key or try again later."
        End Try
    End Sub

    Private Sub btnSaveModel_Click(sender As Object, e As EventArgs) Handles btnSaveModel.Click
        If cboModels.SelectedItem IsNot Nothing Then
            My.Settings("model") = cboModels.SelectedItem.ToString()
            My.Settings.Save()
            lblStatus.Text = "Model Saved Successfully."
            Me.Close()
        Else
            lblStatus.Text = "Please select a model before saving."
        End If
    End Sub
End Class