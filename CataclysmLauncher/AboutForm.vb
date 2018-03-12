Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newPos As Point = MainWindow.Location
        newPos.X -= (Me.Width - MainWindow.Width) * 0.5
        newPos.Y -= (Me.Height - MainWindow.Height) * 0.5
        Me.Location = newPos
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

    ' Ok Button
    Private Sub OkButton_MouseEnter(sender As Object, e As EventArgs) Handles OkButton.MouseEnter
        OkButton.BackgroundImage = My.Resources.okButtonHover
    End Sub

    Private Sub OkButton_MouseDown(sender As Object, e As MouseEventArgs) Handles OkButton.MouseDown
        OkButton.BackgroundImage = My.Resources.okButtonDown
    End Sub

    Private Sub OkButton_MouseUp(sender As Object, e As MouseEventArgs) Handles OkButton.MouseUp
        OkButton.BackgroundImage = My.Resources.okButtonHover
    End Sub

    Private Sub OkButton_MouseLeave(sender As Object, e As EventArgs) Handles OkButton.MouseLeave
        OkButton.BackgroundImage = My.Resources.okButtonBase
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        MainWindow.RemoveGrayForm()
        MyBase.Close()
    End Sub
End Class