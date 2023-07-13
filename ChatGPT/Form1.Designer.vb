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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActBox = New System.Windows.Forms.ComboBox()
        Me.CreateBox = New System.Windows.Forms.ComboBox()
        Me.ShowBox = New System.Windows.Forms.ComboBox()
        Me.ActText = New System.Windows.Forms.TextBox()
        Me.CreateText = New System.Windows.Forms.TextBox()
        Me.ShowText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1027, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1027, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(64, 636)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Run as CAN"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(64, 918)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 42)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Set API Key"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(286, 185)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(896, 775)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(286, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(723, 90)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = ""
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(64, 712)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 42)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Run as STAN"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(64, 786)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 42)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Run as Mongo Tom"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(64, 854)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(155, 42)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Set button behavior"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter prompt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "History"
        '
        'ActBox
        '
        Me.ActBox.AllowDrop = True
        Me.ActBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActBox.FormattingEnabled = True
        Me.ActBox.Items.AddRange(New Object() {"Marketer", "Advertiser", "Mindset Coach", "Best selling author", "Therapist", "Website designer", "Journalist", "Inventor", "Chief financial officer", "Copywriter", "Prompt engineer", "Accountant", "Lawyer", "Analyst", "Ghostwriter", "Project manager", "Custom"})
        Me.ActBox.Location = New System.Drawing.Point(49, 53)
        Me.ActBox.Name = "ActBox"
        Me.ActBox.Size = New System.Drawing.Size(170, 23)
        Me.ActBox.TabIndex = 12
        '
        'CreateBox
        '
        Me.CreateBox.FormattingEnabled = True
        Me.CreateBox.Items.AddRange(New Object() {"Headline", "Article", "Essay", "Book outline", "Email sequence", "Social media post", "Product description", "Cover letter", "Blog post", "SEO keywords", "Summary", "Video script", "Recipe", "Sales copy", "Analysis", "Ad copy", "Custom"})
        Me.CreateBox.Location = New System.Drawing.Point(49, 132)
        Me.CreateBox.Name = "CreateBox"
        Me.CreateBox.Size = New System.Drawing.Size(170, 23)
        Me.CreateBox.TabIndex = 13
        '
        'ShowBox
        '
        Me.ShowBox.FormattingEnabled = True
        Me.ShowBox.Items.AddRange(New Object() {"A table", "A list", "Summary", "HTML", "Code", "Spreadsheet", "Graphs", "CSV file", "Plain text file", "JSON", "Rich text", "PDF", "XML", "Markdown", "Gannt chart", "Word Cloud", "Custom"})
        Me.ShowBox.Location = New System.Drawing.Point(49, 217)
        Me.ShowBox.Name = "ShowBox"
        Me.ShowBox.Size = New System.Drawing.Size(170, 23)
        Me.ShowBox.TabIndex = 14
        '
        'ActText
        '
        Me.ActText.Location = New System.Drawing.Point(49, 81)
        Me.ActText.Name = "ActText"
        Me.ActText.Size = New System.Drawing.Size(170, 23)
        Me.ActText.TabIndex = 15
        Me.ActText.Visible = False
        '
        'CreateText
        '
        Me.CreateText.Location = New System.Drawing.Point(49, 161)
        Me.CreateText.Name = "CreateText"
        Me.CreateText.Size = New System.Drawing.Size(170, 23)
        Me.CreateText.TabIndex = 16
        Me.CreateText.Visible = False
        '
        'ShowText
        '
        Me.ShowText.Location = New System.Drawing.Point(49, 246)
        Me.ShowText.Name = "ShowText"
        Me.ShowText.Size = New System.Drawing.Size(170, 23)
        Me.ShowText.TabIndex = 17
        Me.ShowText.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(49, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Act as"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Create a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Show as"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1211, 993)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowText)
        Me.Controls.Add(Me.CreateText)
        Me.Controls.Add(Me.ActText)
        Me.Controls.Add(Me.ShowBox)
        Me.Controls.Add(Me.CreateBox)
        Me.Controls.Add(Me.ActBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ChatGPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
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
End Class
