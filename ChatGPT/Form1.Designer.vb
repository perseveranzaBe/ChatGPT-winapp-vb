<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        RichTextBox1 = New RichTextBox()
        TextBox1 = New RichTextBox()
        Button5 = New Button()
        Button6 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ActBox = New ComboBox()
        CreateBox = New ComboBox()
        ShowBox = New ComboBox()
        ActText = New TextBox()
        CreateText = New TextBox()
        ShowText = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        MenuStrip1 = New MenuStrip()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        SetButtonBehaviorToolStripMenuItem = New ToolStripMenuItem()
        SetAPIKeyToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1027, 80)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 42)
        Button1.TabIndex = 0
        Button1.Text = "Send"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1027, 128)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 42)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(64, 732)
        Button3.Name = "Button3"
        Button3.Size = New Size(155, 42)
        Button3.TabIndex = 2
        Button3.Text = "Run as CAN"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(64, 949)
        Button4.Name = "Button4"
        Button4.Size = New Size(155, 42)
        Button4.TabIndex = 3
        Button4.Text = "Set API Key"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(286, 216)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(896, 775)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(286, 80)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(723, 90)
        TextBox1.TabIndex = 6
        TextBox1.Text = ""
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(64, 808)
        Button5.Name = "Button5"
        Button5.Size = New Size(155, 42)
        Button5.TabIndex = 7
        Button5.Text = "Run as STAN"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(64, 882)
        Button6.Name = "Button6"
        Button6.Size = New Size(155, 42)
        Button6.TabIndex = 8
        Button6.Text = "Run as Mongo Tom"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(289, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 10
        Label1.Text = "Enter prompt"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(289, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 11
        Label2.Text = "History"
        ' 
        ' ActBox
        ' 
        ActBox.AllowDrop = True
        ActBox.DropDownStyle = ComboBoxStyle.DropDownList
        ActBox.FormattingEnabled = True
        ActBox.ImeMode = ImeMode.NoControl
        ActBox.ItemHeight = 15
        ActBox.Items.AddRange(New Object() {"Accountant", "Advertiser", "Analyst", "Best selling author", "Chief financial officer", "Copywriter", "Custom", "Ghostwriter", "Inventor", "Journalist", "Lawyer", "Marketer", "Mindset Coach", "Project manager", "Prompt engineer", "Therapist", "Website designer"})
        ActBox.Location = New Point(49, 84)
        ActBox.Name = "ActBox"
        ActBox.Size = New Size(170, 23)
        ActBox.Sorted = True
        ActBox.TabIndex = 12
        ' 
        ' CreateBox
        ' 
        CreateBox.FormattingEnabled = True
        CreateBox.Items.AddRange(New Object() {"Ad copy", "Analysis", "Article", "Blog post", "Book outline", "Cover letter", "Custom", "Email sequence", "Essay", "Headline", "Product description", "Recipe", "Sales copy", "SEO keywords", "Social media post", "Summary", "Video script"})
        CreateBox.Location = New Point(49, 163)
        CreateBox.Name = "CreateBox"
        CreateBox.Size = New Size(170, 23)
        CreateBox.Sorted = True
        CreateBox.TabIndex = 13
        ' 
        ' ShowBox
        ' 
        ShowBox.FormattingEnabled = True
        ShowBox.Items.AddRange(New Object() {"A list", "A table", "Code", "CSV file", "Custom", "Gannt chart", "Graphs", "HTML", "JSON", "Markdown", "PDF", "Plain text file", "Rich text", "Spreadsheet", "Summary", "Word Cloud", "XML"})
        ShowBox.Location = New Point(49, 248)
        ShowBox.Name = "ShowBox"
        ShowBox.Size = New Size(170, 23)
        ShowBox.Sorted = True
        ShowBox.TabIndex = 14
        ' 
        ' ActText
        ' 
        ActText.Location = New Point(49, 112)
        ActText.Name = "ActText"
        ActText.Size = New Size(170, 23)
        ActText.TabIndex = 15
        ActText.Visible = False
        ' 
        ' CreateText
        ' 
        CreateText.Location = New Point(49, 192)
        CreateText.Name = "CreateText"
        CreateText.Size = New Size(170, 23)
        CreateText.TabIndex = 16
        CreateText.Visible = False
        ' 
        ' ShowText
        ' 
        ShowText.Location = New Point(49, 277)
        ShowText.Name = "ShowText"
        ShowText.Size = New Size(170, 23)
        ShowText.TabIndex = 17
        ShowText.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(49, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 18
        Label3.Text = "Act as"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 19
        Label4.Text = "Create a"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 20
        Label5.Text = "Show as"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1211, 24)
        MenuStrip1.TabIndex = 21
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SetButtonBehaviorToolStripMenuItem, SetAPIKeyToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(61, 20)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' SetButtonBehaviorToolStripMenuItem
        ' 
        SetButtonBehaviorToolStripMenuItem.Name = "SetButtonBehaviorToolStripMenuItem"
        SetButtonBehaviorToolStripMenuItem.Size = New Size(180, 22)
        SetButtonBehaviorToolStripMenuItem.Text = "Set button behavior"
        ' 
        ' SetAPIKeyToolStripMenuItem
        ' 
        SetAPIKeyToolStripMenuItem.Name = "SetAPIKeyToolStripMenuItem"
        SetAPIKeyToolStripMenuItem.Size = New Size(180, 22)
        SetAPIKeyToolStripMenuItem.Text = "Set API Key"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1211, 1021)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ShowText)
        Controls.Add(CreateText)
        Controls.Add(ActText)
        Controls.Add(ShowBox)
        Controls.Add(CreateBox)
        Controls.Add(ActBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "ChatGPT"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ActBox As ComboBox
    Friend WithEvents CreateBox As ComboBox
    Friend WithEvents ShowBox As ComboBox
    Friend WithEvents ActText As TextBox
    Friend WithEvents CreateText As TextBox
    Friend WithEvents ShowText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetButtonBehaviorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetAPIKeyToolStripMenuItem As ToolStripMenuItem
End Class
