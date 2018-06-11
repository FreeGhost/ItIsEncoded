Public Class EncodeWindow
    Dim Char1, Char2, MessageElements As String
    Dim MatricesSeparator, MessageElementsSeparator, MessageElement1, MessageElement2 As Integer
    Dim EncodedElement1, EncodedElement2 As Integer
    Dim AllowedString As String = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789 `~!@#$%^&*()_+-=\/;:?.,[]{}<>'"
    Dim AllowedCharsForKey = "123456789", IsBackSpacePressed As String = "No"
    Dim X, A, S, D, F As Integer
    Dim Ran = New Random

    Private Sub EncodeWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A = Ran.Next(1, 9)
        Element1TextBox.Text = A
        S = Ran.Next(1, 9)
        Element2TextBox.Text = S
        D = Ran.Next(1, 9)
        Element3TextBox.Text = D
        F = Ran.Next(1, 9)
        Element4TextBox.Text = F
    End Sub

    Private Sub PDTBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDTBUT.Click
        TextToEncodeRichTextBox.Text = Clipboard.GetText()
    End Sub

    Private Sub TextToEncodeRichTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextToEncodeRichTextBox.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub TextToEncodeRichTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextToEncodeRichTextBox.KeyPress
        If Not AllowedString.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Element1TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Element1TextBox.KeyDown, Element2TextBox.KeyDown, Element3TextBox.KeyDown, Element4TextBox.KeyDown
        If e.KeyCode = Keys.Back Then
            IsBackSpacePressed = "Yes"
        Else
            IsBackSpacePressed = "No"
        End If
    End Sub

    Private Sub Element1TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Element1TextBox.KeyPress, Element2TextBox.KeyPress, Element3TextBox.KeyPress, Element4TextBox.KeyPress
        If IsBackSpacePressed = "No" Then
            If AllowedCharsForKey.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StartEncodingBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartEncodingBUT.Click
        If Not TextToEncodeRichTextBox.Text = "" Then
            If Element1TextBox.Text = "" Or Element2TextBox.Text = "" Or Element3TextBox.Text = "" Or Element4TextBox.Text = "" Then
                MsgBox("You have to enter all of the matrix key.", MsgBoxStyle.Critical, "Error!")
            Else
                EncodedTextRichTextBox.Text = ""
                StartEncodingBUT.Enabled = False
                ConvertToNumTimer.Start()
            End If
        End If
    End Sub

    Private Sub ConvertToNumTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToNumTimer.Tick
        ConvertToNumTimer.Stop()
        If Not TextToEncodeRichTextBox.Text = "" Then
            If TextToEncodeRichTextBox.Text.Length = 1 Then
                If Char1 = "" Then
                    Char1 = TextToEncodeRichTextBox.Text
                    TextToEncodeRichTextBox.Text = ""
                    Char1 = ConvertToNum(Char1)
                    EncodedTextRichTextBox.Text &= Char1 & ",0|"
                Else
                    Char2 = TextToEncodeRichTextBox.Text
                    TextToEncodeRichTextBox.Text = ""
                    Char2 = ConvertToNum(Char2)
                    EncodedTextRichTextBox.Text &= Char2 & "|"
                End If
                TextToEncodeRichTextBox.Text = EncodedTextRichTextBox.Text
                Char1 = ""
                EncodedTextRichTextBox.Text = ""
                EncodeTimer.Start()
            Else
                If Char1 = "" Then
                    Char1 = TextToEncodeRichTextBox.Text.Remove(1)
                    TextToEncodeRichTextBox.Text = TextToEncodeRichTextBox.Text.Substring(1)
                    Char1 = ConvertToNum(Char1)
                    EncodedTextRichTextBox.Text &= Char1 & ","
                Else
                    Char2 = TextToEncodeRichTextBox.Text.Remove(1)
                    TextToEncodeRichTextBox.Text = TextToEncodeRichTextBox.Text.Substring(1)
                    Char2 = ConvertToNum(Char2)
                    EncodedTextRichTextBox.Text &= Char2 & "|"
                    Char1 = ""
                End If
                ConvertToNumTimer.Start()
            End If
        End If
    End Sub

    Function ConvertToNum(ByVal StringChar As String)
        If StringChar = " " Then
            StringChar = "0"
        ElseIf StringChar = "a" Then
            StringChar = "1"
        ElseIf StringChar = "b" Then
            StringChar = "2"
        ElseIf StringChar = "c" Then
            StringChar = "3"
        ElseIf StringChar = "d" Then
            StringChar = "4"
        ElseIf StringChar = "e" Then
            StringChar = "5"
        ElseIf StringChar = "f" Then
            StringChar = "6"
        ElseIf StringChar = "g" Then
            StringChar = "7"
        ElseIf StringChar = "h" Then
            StringChar = "8"
        ElseIf StringChar = "i" Then
            StringChar = "9"
        ElseIf StringChar = "j" Then
            StringChar = "10"
        ElseIf StringChar = "k" Then
            StringChar = "11"
        ElseIf StringChar = "l" Then
            StringChar = "12"
        ElseIf StringChar = "m" Then
            StringChar = "13"
        ElseIf StringChar = "n" Then
            StringChar = "14"
        ElseIf StringChar = "o" Then
            StringChar = "15"
        ElseIf StringChar = "p" Then
            StringChar = "16"
        ElseIf StringChar = "q" Then
            StringChar = "17"
        ElseIf StringChar = "r" Then
            StringChar = "18"
        ElseIf StringChar = "s" Then
            StringChar = "19"
        ElseIf StringChar = "t" Then
            StringChar = "20"
        ElseIf StringChar = "u" Then
            StringChar = "21"
        ElseIf StringChar = "v" Then
            StringChar = "22"
        ElseIf StringChar = "w" Then
            StringChar = "23"
        ElseIf StringChar = "x" Then
            StringChar = "24"
        ElseIf StringChar = "y" Then
            StringChar = "25"
        ElseIf StringChar = "z" Then
            StringChar = "26"
        ElseIf StringChar = "0" Then
            StringChar = "27"
        ElseIf StringChar = "1" Then
            StringChar = "28"
        ElseIf StringChar = "2" Then
            StringChar = "29"
        ElseIf StringChar = "3" Then
            StringChar = "30"
        ElseIf StringChar = "4" Then
            StringChar = "31"
        ElseIf StringChar = "5" Then
            StringChar = "32"
        ElseIf StringChar = "6" Then
            StringChar = "33"
        ElseIf StringChar = "7" Then
            StringChar = "34"
        ElseIf StringChar = "8" Then
            StringChar = "35"
        ElseIf StringChar = "9" Then
            StringChar = "36"
        ElseIf StringChar = "`" Then
            StringChar = "37"
        ElseIf StringChar = "~" Then
            StringChar = "38"
        ElseIf StringChar = "!" Then
            StringChar = "39"
        ElseIf StringChar = "@" Then
            StringChar = "40"
        ElseIf StringChar = "#" Then
            StringChar = "41"
        ElseIf StringChar = "$" Then
            StringChar = "42"
        ElseIf StringChar = "%" Then
            StringChar = "43"
        ElseIf StringChar = "^" Then
            StringChar = "44"
        ElseIf StringChar = "&" Then
            StringChar = "45"
        ElseIf StringChar = "*" Then
            StringChar = "46"
        ElseIf StringChar = "(" Then
            StringChar = "47"
        ElseIf StringChar = ")" Then
            StringChar = "48"
        ElseIf StringChar = "_" Then
            StringChar = "49"
        ElseIf StringChar = "-" Then
            StringChar = "50"
        ElseIf StringChar = "+" Then
            StringChar = "51"
        ElseIf StringChar = "=" Then
            StringChar = "52"
        ElseIf StringChar = "\" Then
            StringChar = "53"
        ElseIf StringChar = "/" Then
            StringChar = "54"
        ElseIf StringChar = ";" Then
            StringChar = "55"
        ElseIf StringChar = ":" Then
            StringChar = "56"
        ElseIf StringChar = "?" Then
            StringChar = "57"
        ElseIf StringChar = "." Then
            StringChar = "58"
        ElseIf StringChar = "," Then
            StringChar = "59"
        ElseIf StringChar = "[" Then
            StringChar = "60"
        ElseIf StringChar = "]" Then
            StringChar = "61"
        ElseIf StringChar = "{" Then
            StringChar = "62"
        ElseIf StringChar = "}" Then
            StringChar = "63"
        ElseIf StringChar = "<" Then
            StringChar = "64"
        ElseIf StringChar = ">" Then
            StringChar = "65"
        ElseIf StringChar = "'" Then
            StringChar = "66"
        ElseIf StringChar = vbLf Then
            StringChar = "67"
        ElseIf StringChar = "A" Then
            StringChar = "68"
        ElseIf StringChar = "B" Then
            StringChar = "69"
        ElseIf StringChar = "V" Then
            StringChar = "70"
        ElseIf StringChar = "D" Then
            StringChar = "71"
        ElseIf StringChar = "E" Then
            StringChar = "72"
        ElseIf StringChar = "F" Then
            StringChar = "73"
        ElseIf StringChar = "G" Then
            StringChar = "74"
        ElseIf StringChar = "H" Then
            StringChar = "75"
        ElseIf StringChar = "I" Then
            StringChar = "76"
        ElseIf StringChar = "J" Then
            StringChar = "77"
        ElseIf StringChar = "K" Then
            StringChar = "78"
        ElseIf StringChar = "L" Then
            StringChar = "79"
        ElseIf StringChar = "M" Then
            StringChar = "80"
        ElseIf StringChar = "N" Then
            StringChar = "81"
        ElseIf StringChar = "O" Then
            StringChar = "82"
        ElseIf StringChar = "P" Then
            StringChar = "83"
        ElseIf StringChar = "Q" Then
            StringChar = "84"
        ElseIf StringChar = "R" Then
            StringChar = "85"
        ElseIf StringChar = "S" Then
            StringChar = "86"
        ElseIf StringChar = "T" Then
            StringChar = "87"
        ElseIf StringChar = "U" Then
            StringChar = "88"
        ElseIf StringChar = "V" Then
            StringChar = "89"
        ElseIf StringChar = "W" Then
            StringChar = "90"
        ElseIf StringChar = "X" Then
            StringChar = "91"
        ElseIf StringChar = "Y" Then
            StringChar = "92"
        ElseIf StringChar = "Z`" Then
            StringChar = "93"
        End If
        Return StringChar
    End Function

    Private Sub EncodeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncodeTimer.Tick
        EncodeTimer.Stop()
        If Not TextToEncodeRichTextBox.Text = "" Then
            Try
                MatricesSeparator = TextToEncodeRichTextBox.Text.IndexOf("|")
                MessageElements = TextToEncodeRichTextBox.Text.Remove(MatricesSeparator)
                TextToEncodeRichTextBox.Text = TextToEncodeRichTextBox.Text.Substring(MatricesSeparator + 1)
                MessageElementsSeparator = MessageElements.IndexOf(",")
                MessageElement1 = MessageElements.Remove(MessageElementsSeparator)
                MessageElements = MessageElements.Substring(MessageElementsSeparator + 1)
                MessageElement2 = MessageElements
                EncodedElement1 = (MessageElement1 * Element1TextBox.Text) + (MessageElement2 * Element2TextBox.Text)
                EncodedElement2 = (MessageElement1 * Element3TextBox.Text) + (MessageElement2 * Element4TextBox.Text)
                EncodedTextRichTextBox.Text &= EncodedElement1 & "," & EncodedElement2 & "|"
                EncodeTimer.Start()
            Catch
                MsgBox("Unknown charachter found!", MsgBoxStyle.Critical, "Error!")
                TextToEncodeRichTextBox.Text = ""
                EncodedTextRichTextBox.Text = ""
                StartEncodingBUT.Enabled = True
                Beep()
            End Try
        Else
            Beep()
            StartEncodingBUT.Enabled = True
        End If
    End Sub

    Private Sub GenerateKeyBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateKeyBUT.Click
        A = Ran.Next(1, 9)
        Element1TextBox.Text = A
        S = Ran.Next(1, 9)
        Element2TextBox.Text = S
        D = Ran.Next(1, 9)
        Element3TextBox.Text = D
        F = Ran.Next(1, 9)
        Element4TextBox.Text = F
    End Sub

    Private Sub CopyKeyBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyKeyBUT.Click
        Clipboard.SetText("MatrixKey:" & Element1TextBox.Text & "," & Element2TextBox.Text & "," & Element3TextBox.Text & "," & Element4TextBox.Text)
    End Sub

    Private Sub HelpBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBUT.Click
        MsgBox("Use the matrix key to encode a text message, and the same key to decode it and any other key will not be able to decode the message." & vbLf & vbLf & "Use the '*' button to generate random keys.", MsgBoxStyle.Information, "ItIsEncoded")
    End Sub

    Private Sub EncodeWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainWindow.Show()
    End Sub

    Private Sub CopyEmcodedTextBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEmcodedTextBUT.Click
        Clipboard.SetText(EncodedTextRichTextBox.Text)
    End Sub

    Private Sub GTDWBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GTDWBUT.Click
        DecodeWindow.Show()
    End Sub
End Class