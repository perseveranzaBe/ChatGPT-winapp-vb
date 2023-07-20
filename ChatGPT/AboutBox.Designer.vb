<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 15)
        Label1.TabIndex = 0
        Label1.Text = "This program is created by Dave Bosman as a proof of concept in visual basic"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(214, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(179, 49)
        Button1.TabIndex = 1
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AboutBox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(608, 306)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "AboutBox"
        Text = "About"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
