<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ResetLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.PictureBox()
        CType(Me.OkButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetLabel1
        '
        Me.ResetLabel1.AutoSize = True
        Me.ResetLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ResetLabel1.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ResetLabel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ResetLabel1.Location = New System.Drawing.Point(45, 63)
        Me.ResetLabel1.Name = "ResetLabel1"
        Me.ResetLabel1.Size = New System.Drawing.Size(194, 16)
        Me.ResetLabel1.TabIndex = 19
        Me.ResetLabel1.Text = "Cataclysm Launcher (c) 2018"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(45, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Application programmed by Ovahlord"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(45, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 61)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Images used for this application are created and owned by Blizzard Entertainment " &
    "and used only for non-commercial purposes for this open-source project."
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Transparent
        Me.OkButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.okButtonBase
        Me.OkButton.Location = New System.Drawing.Point(289, 171)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(91, 32)
        Me.OkButton.TabIndex = 24
        Me.OkButton.TabStop = False
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.InternalFormBackground2
        Me.ClientSize = New System.Drawing.Size(418, 244)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResetLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutForm"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.OkButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ResetLabel1 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents OkButton As PictureBox
End Class
