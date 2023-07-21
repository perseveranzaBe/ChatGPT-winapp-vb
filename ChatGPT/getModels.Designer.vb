<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class getModels
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
        lblStatus = New Label()
        cboModels = New ComboBox()
        btnSaveModel = New Button()
        SuspendLayout()
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(110, 67)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(41, 15)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Label1"
        ' 
        ' cboModels
        ' 
        cboModels.FormattingEnabled = True
        cboModels.Location = New Point(110, 98)
        cboModels.Name = "cboModels"
        cboModels.Size = New Size(163, 23)
        cboModels.TabIndex = 1
        ' 
        ' btnSaveModel
        ' 
        btnSaveModel.Location = New Point(110, 149)
        btnSaveModel.Name = "btnSaveModel"
        btnSaveModel.Size = New Size(163, 47)
        btnSaveModel.TabIndex = 2
        btnSaveModel.Text = "Save model"
        btnSaveModel.UseVisualStyleBackColor = True
        ' 
        ' getModels
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(389, 277)
        Controls.Add(btnSaveModel)
        Controls.Add(cboModels)
        Controls.Add(lblStatus)
        Name = "getModels"
        Text = "Set model"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents cboModels As ComboBox
    Friend WithEvents btnSaveModel As Button
End Class
