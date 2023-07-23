<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetAPI
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SetAPI))
        txtInput = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(40, 60)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(350, 23)
        txtInput.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(40, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 42)
        Button1.TabIndex = 1
        Button1.Text = "Save API key"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(241, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 42)
        Button2.TabIndex = 2
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 3
        Label1.Text = "Enter new API key"
        ' 
        ' SetAPI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(429, 202)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtInput)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SetAPI"
        Text = "Set API key "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
