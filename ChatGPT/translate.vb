Imports System.Xml

Module translate

    Public Sub TranslateForm(form As Form, language As String)
        Dim doc As New XmlDocument()
        Try
            doc.Load($"translations\{language}.xml")
            Dim root As XmlNode = doc.DocumentElement
            For Each data As XmlNode In root.SelectNodes("data")
                Dim nameParts As String() = data.Attributes("name").Value.Split(".")
                If nameParts.Length = 3 Then
                    Dim formName As String = nameParts(0)
                    Dim controlName As String = nameParts(1)
                    Dim propertyName As String = nameParts(2)
                    If formName = form.Name Then
                        Dim control As Control = form.Controls.Find(controlName, True).FirstOrDefault()
                        If control IsNot Nothing Then
                            control.GetType().GetProperty(propertyName).SetValue(control, data.SelectSingleNode("value").InnerText)
                        End If
                    End If
                End If
            Next
            For Each control As Control In form.Controls
                If TypeOf control Is MenuStrip Then
                    TranslateMenuItems(CType(control, MenuStrip), root, form.Name)
                End If
            Next
        Catch ex As Exception
            ' Handle the error
        End Try
    End Sub

    Private Sub TranslateMenuItems(menuStrip As MenuStrip, root As XmlNode, formName As String)
        For Each item As ToolStripMenuItem In menuStrip.Items
            TranslateMenuItem(item, root, formName)
        Next
    End Sub

    Private Sub TranslateMenuItem(menuItem As ToolStripMenuItem, root As XmlNode, formName As String)
        Dim controlName As String = menuItem.Name
        Dim propertyName As String = "Text" ' Assuming all you want to translate is the Text property
        Dim data As XmlNode = root.SelectSingleNode($"data[@name='{formName}.{controlName}.{propertyName}']")
        If data IsNot Nothing Then
            menuItem.Text = data.SelectSingleNode("value").InnerText
        End If

        ' Recursively translate nested items
        For Each dropdownItem As ToolStripMenuItem In menuItem.DropDownItems
            TranslateMenuItem(dropdownItem, root, formName)
        Next
    End Sub
End Module
