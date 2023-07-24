<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActCreateShowSetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RichTextBoxACT = New RichTextBox()
        RichTextBoxCREATE = New RichTextBox()
        RichTextBoxSHOW = New RichTextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' RichTextBoxACT
        ' 
        RichTextBoxACT.Location = New Point(95, 42)
        RichTextBoxACT.Name = "RichTextBoxACT"
        RichTextBoxACT.Size = New Size(223, 96)
        RichTextBoxACT.TabIndex = 0
        RichTextBoxACT.Text = ""
        ' 
        ' RichTextBoxCREATE
        ' 
        RichTextBoxCREATE.Location = New Point(95, 169)
        RichTextBoxCREATE.Name = "RichTextBoxCREATE"
        RichTextBoxCREATE.Size = New Size(223, 96)
        RichTextBoxCREATE.TabIndex = 1
        RichTextBoxCREATE.Text = ""
        ' 
        ' RichTextBoxSHOW
        ' 
        RichTextBoxSHOW.Location = New Point(95, 294)
        RichTextBoxSHOW.Name = "RichTextBoxSHOW"
        RichTextBoxSHOW.Size = New Size(223, 96)
        RichTextBoxSHOW.TabIndex = 2
        RichTextBoxSHOW.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(116, 420)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 42)
        Button1.TabIndex = 3
        Button1.Text = "Save / Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(95, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 4
        Label1.Text = "'Act as' list"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 5
        Label2.Text = "'Create as' list"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 6
        Label3.Text = "'Show as' list"
        ' 
        ' ActCreateShowSetting
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 501)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(RichTextBoxSHOW)
        Controls.Add(RichTextBoxCREATE)
        Controls.Add(RichTextBoxACT)
        Name = "ActCreateShowSetting"
        Text = "ActCreateShowSetting"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBoxACT As RichTextBox
    Friend WithEvents RichTextBoxCREATE As RichTextBox
    Friend WithEvents RichTextBoxSHOW As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
