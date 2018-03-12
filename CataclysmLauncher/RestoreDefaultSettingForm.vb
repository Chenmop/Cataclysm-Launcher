Public Class RestoreDefaultSettingForm

    Dim configMgr As ConfigManager

    Private Sub RestoreDefaultSettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configMgr = MainWindow.configMgr
    End Sub

    ' Form Movement
    Dim drag As Boolean = False
    Dim x, y As Integer

    Private Sub TopFrame_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        x = e.X
        y = e.Y
    End Sub

    Private Sub TopFrame_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Left = MousePosition.X - x
            Me.Top = MousePosition.Y - y
        End If
    End Sub

    Private Sub TopFrame_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    ' Yes Button
    Private Sub YesButton_MouseEnter(sender As Object, e As EventArgs) Handles YesButton.MouseEnter
        YesButton.BackgroundImage = My.Resources.yesButtonHover
    End Sub

    Private Sub YesButton_MouseDown(sender As Object, e As MouseEventArgs) Handles YesButton.MouseDown
        YesButton.BackgroundImage = My.Resources.yesButtonDown
    End Sub

    Private Sub YesButton_MouseUp(sender As Object, e As MouseEventArgs) Handles YesButton.MouseUp
        YesButton.BackgroundImage = My.Resources.yesButtonHover
    End Sub

    Private Sub YesButton_MouseLeave(sender As Object, e As EventArgs) Handles YesButton.MouseLeave
        YesButton.BackgroundImage = My.Resources.yesButtonBase
    End Sub

    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        SettingsForm.TopMost = True
        configMgr.ResetGameConfiguration()
        SettingsForm.BringToFront()
        MyBase.Close()
    End Sub

    ' No Button
    Private Sub NoButton_MouseEnter(sender As Object, e As EventArgs) Handles NoButton.MouseEnter
        NoButton.BackgroundImage = My.Resources.noButtonHover
    End Sub

    Private Sub NoButton_MouseDown(sender As Object, e As MouseEventArgs) Handles NoButton.MouseDown
        NoButton.BackgroundImage = My.Resources.noButtonDown
    End Sub

    Private Sub NoButton_MouseUp(sender As Object, e As MouseEventArgs) Handles NoButton.MouseUp
        NoButton.BackgroundImage = My.Resources.noButtonHover
    End Sub

    Private Sub NoButton_MouseLeave(sender As Object, e As EventArgs) Handles NoButton.MouseLeave
        NoButton.BackgroundImage = My.Resources.noButtonBase
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        SettingsForm.TopMost = True
        SettingsForm.BringToFront()
        MyBase.Close()
    End Sub
End Class