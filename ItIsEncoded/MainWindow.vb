Imports System.ComponentModel
Imports System.Threading

Public Class MainWindow
    Dim MutexOBJ As Mutex, MutexKey As String = "jA0ECQMCIYGmQwYY7Zmz0j0BHfBsSsxgmK5FoJU5oAsVogTQ329bgLJimBwSY1wlhIL40rCDY1utFc72n2Z7k8HQaIF0c7/WsLR/opvo=RXVF"

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MutexOBJ = New Mutex(False, MutexKey)
        If MutexOBJ.WaitOne(0, False) = False Then
            MutexOBJ.Close()
            MutexOBJ = Nothing
            MsgBox("Could not launch ItIsEncoded" & vbCrLf & "Only one instance of ItIsEncoded can be run at a time.", MsgBoxStyle.Critical, "ItIsEncoded - ERROR")
            Close()
        End If
    End Sub

    Private Sub EncodeTextBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EncodeTextBUT.Click
        Hide()
        EncodeWindow.Show()
    End Sub

    Private Sub DecodeBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles DecodeBUT.Click
        Hide()
        DecodeWindow.Show()
    End Sub

    Private Sub AboutBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AboutBUT.Click
        AboutPanel.Visible = True
        Size = New Size(450, 350)
        CenterToParent()
    End Sub

    Private Sub TermsAndConditionsBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TermsAndConditionsBUT.Click
        Process.Start("https://mousa.alfhaily.me/Apps/LICENSE")
    End Sub

    Private Sub YouTubeBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YouTubeBUT.Click
        Process.Start("https://www.youtube.com/channel/UCWeRjXP-I7OmAwKKF8xHCFQ")
    End Sub

    Private Sub TwitterBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TwitterBUT.Click
        Process.Start("https://twitter.com/FreeGh0o0st")
    End Sub

    Private Sub WebsiteBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WebsiteBUT.Click
        Process.Start("http://mousa.alfhaily.me")
    End Sub

    Private Sub AboutPanel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutPanel.Click
        AboutPanel.Visible = False
        Size = New Size(305, 271)
        CenterToParent()
    End Sub

    Private Sub ExitBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ExitBUT.Click
        Close()
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If AboutPanel.Visible = True Then
            AboutPanel.Visible = False
            Size = New Size(305, 271)
            CenterToParent()
            e.Cancel = True
        End If
    End Sub
End Class