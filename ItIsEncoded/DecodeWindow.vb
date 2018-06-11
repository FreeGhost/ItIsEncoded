Public Class DecodeWindow
    Dim DecodeMessageSeparator, DeterminantElement, DecodededElement1, DecodededElement2, DecodedMessageElement1, DecodedMessageElement2 As Integer
    Dim DecodedMessageSepparator, DecodingCharsSepparator, CommaPosition As Integer
    Dim A, B, C, D As Decimal
    Dim AllowedString As String = "|,0123456789"
    Dim AllowedCharsFroKey = "123456789", IsBackSpacePressed As String = "No"
    Dim Char1, Char2, DecodingChars, DecodeElements As String

    Private Sub TextToDecodeRichTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextToDecodeRichTextBox.KeyPress
        If Not AllowedString.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PastTextToDecodeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastTextToDecodeLabel.Click
        If Clipboard.GetText.Contains("|") And Clipboard.GetText.Contains(",") Then
            TextToDecodeRichTextBox.Text = Clipboard.GetText()
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
            If AllowedCharsFroKey.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StartDecodingBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDecodingBUT.Click
        If Not TextToDecodeRichTextBox.Text = "" Then
            If Element1TextBox.Text = "" Or Element2TextBox.Text = "" Or Element3TextBox.Text = "" Or Element4TextBox.Text = "" Then
                MsgBox("You have to enter all of the matrix key.", MsgBoxStyle.Critical, "Error!")
            Else
                If Not TextToDecodeRichTextBox.Text.Contains("|") Then
                    MsgBox("Invalid encoded text", MsgBoxStyle.Critical, "Error!")
                Else
                    InverseMatrix()
                    DecodedTextRichTextBox.Text = ""
                    DecodeTimer.Start()
                End If
            End If
        End If
    End Sub

    Private Sub DecodeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodeTimer.Tick
        DecodeTimer.Stop()
        If Not TextToDecodeRichTextBox.Text = "" Then
            Try
                DecodeMessageSeparator = TextToDecodeRichTextBox.Text.IndexOf("|")
                DecodeElements = TextToDecodeRichTextBox.Text.Remove(DecodeMessageSeparator)
                TextToDecodeRichTextBox.Text = TextToDecodeRichTextBox.Text.Substring(DecodeMessageSeparator + 1)
                DecodeMessageSeparator = DecodeElements.IndexOf(",")
                DecodedMessageElement1 = DecodeElements.Remove(DecodeMessageSeparator)
                DecodeElements = DecodeElements.Substring(DecodeMessageSeparator + 1)
                DecodedMessageElement2 = DecodeElements
                DecodededElement1 = (DecodedMessageElement1 * A) + (DecodedMessageElement2 * B)
                DecodededElement2 = (DecodedMessageElement1 * C) + (DecodedMessageElement2 * D)
                DecodedTextRichTextBox.Text &= DecodededElement1 & "," & DecodededElement2 & "|"
                DecodeTimer.Start()
            Catch ex As Exception
                MsgBox("Invalid encoded text", MsgBoxStyle.Critical, "Error!")
                DecodedTextRichTextBox.Text = ""
                TextToDecodeRichTextBox.Text = ""
            End Try
        Else
            TextToDecodeRichTextBox.Text = DecodedTextRichTextBox.Text
            DecodedTextRichTextBox.Text = ""
            ConvertToStrTimer.Start()
        End If
    End Sub

    Function InverseMatrix()
        DeterminantElement = (Element1TextBox.Text * Element4TextBox.Text) - (Element2TextBox.Text * Element3TextBox.Text)
        If Not DeterminantElement = 0 Then
            A = Element4TextBox.Text
            D = Element1TextBox.Text
            B = -Element2TextBox.Text
            C = -Element3TextBox.Text
            A = A * (1 / DeterminantElement)
            B = B * (1 / DeterminantElement)
            C = C * (1 / DeterminantElement)
            D = D * (1 / DeterminantElement)
        Else

        End If
        Return 0
    End Function

    Private Sub ConvertToStrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToStrTimer.Tick
        ConvertToStrTimer.Stop()
        If Not TextToDecodeRichTextBox.Text = "" Then
            DecodedMessageSepparator = TextToDecodeRichTextBox.Text.IndexOf("|")
            DecodingChars = TextToDecodeRichTextBox.Text.Remove(DecodedMessageSepparator)
            TextToDecodeRichTextBox.Text = TextToDecodeRichTextBox.Text.Substring(DecodedMessageSepparator + 1)
            DecodingCharsSepparator = DecodingChars.IndexOf(",")
            Char1 = DecodingChars.Remove(DecodingCharsSepparator)
            Char1 = convertToStr(Char1)
            DecodingChars = DecodingChars.Substring(DecodingCharsSepparator + 1)
            Char2 = DecodingChars
            Char2 = convertToStr(Char2)
            DecodedTextRichTextBox.Text &= Char1 & Char2
            ConvertToStrTimer.Start()
        Else
            Char1 = ""
        End If
    End Sub

    Function convertToStr(ByVal StringChar As String)
        If StringChar = "0" Then
            StringChar = " "
        ElseIf StringChar = "1" Then
            StringChar = "a"
        ElseIf StringChar = "2" Then
            StringChar = "b"
        ElseIf StringChar = "3" Then
            StringChar = "c"
        ElseIf StringChar = "4" Then
            StringChar = "d"
        ElseIf StringChar = "5" Then
            StringChar = "e"
        ElseIf StringChar = "6" Then
            StringChar = "f"
        ElseIf StringChar = "7" Then
            StringChar = "g"
        ElseIf StringChar = "8" Then
            StringChar = "h"
        ElseIf StringChar = "9" Then
            StringChar = "i"
        ElseIf StringChar = "10" Then
            StringChar = "j"
        ElseIf StringChar = "11" Then
            StringChar = "k"
        ElseIf StringChar = "12" Then
            StringChar = "l"
        ElseIf StringChar = "13" Then
            StringChar = "m"
        ElseIf StringChar = "14" Then
            StringChar = "n"
        ElseIf StringChar = "15" Then
            StringChar = "o"
        ElseIf StringChar = "16" Then
            StringChar = "p"
        ElseIf StringChar = "17" Then
            StringChar = "q"
        ElseIf StringChar = "18" Then
            StringChar = "r"
        ElseIf StringChar = "19" Then
            StringChar = "s"
        ElseIf StringChar = "20" Then
            StringChar = "t"
        ElseIf StringChar = "21" Then
            StringChar = "u"
        ElseIf StringChar = "22" Then
            StringChar = "v"
        ElseIf StringChar = "23" Then
            StringChar = "w"
        ElseIf StringChar = "24" Then
            StringChar = "x"
        ElseIf StringChar = "25" Then
            StringChar = "y"
        ElseIf StringChar = "26" Then
            StringChar = "z"
        ElseIf StringChar = "27" Then
            StringChar = "0"
        ElseIf StringChar = "28" Then
            StringChar = "1"
        ElseIf StringChar = "29" Then
            StringChar = "2"
        ElseIf StringChar = "30" Then
            StringChar = "3"
        ElseIf StringChar = "31" Then
            StringChar = "4"
        ElseIf StringChar = "32" Then
            StringChar = "5"
        ElseIf StringChar = "33" Then
            StringChar = "6"
        ElseIf StringChar = "34" Then
            StringChar = "7"
        ElseIf StringChar = "35" Then
            StringChar = "8"
        ElseIf StringChar = "36" Then
            StringChar = "9"
        ElseIf StringChar = "37" Then
            StringChar = "`"
        ElseIf StringChar = "38" Then
            StringChar = "~"
        ElseIf StringChar = "39" Then
            StringChar = "!"
        ElseIf StringChar = "40" Then
            StringChar = "@"
        ElseIf StringChar = "41" Then
            StringChar = "#"
        ElseIf StringChar = "42" Then
            StringChar = "$"
        ElseIf StringChar = "43" Then
            StringChar = "%"
        ElseIf StringChar = "44" Then
            StringChar = "^"
        ElseIf StringChar = "45" Then
            StringChar = "&"
        ElseIf StringChar = "46" Then
            StringChar = "*"
        ElseIf StringChar = "47" Then
            StringChar = "("
        ElseIf StringChar = "48" Then
            StringChar = ")"
        ElseIf StringChar = "49" Then
            StringChar = "_"
        ElseIf StringChar = "50" Then
            StringChar = "-"
        ElseIf StringChar = "51" Then
            StringChar = "+"
        ElseIf StringChar = "52" Then
            StringChar = "="
        ElseIf StringChar = "53" Then
            StringChar = "\"
        ElseIf StringChar = "54" Then
            StringChar = "/"
        ElseIf StringChar = "55" Then
            StringChar = ";"
        ElseIf StringChar = "56" Then
            StringChar = ":"
        ElseIf StringChar = "57" Then
            StringChar = "?"
        ElseIf StringChar = "58" Then
            StringChar = "."
        ElseIf StringChar = "59" Then
            StringChar = ","
        ElseIf StringChar = "60" Then
            StringChar = "["
        ElseIf StringChar = "61" Then
            StringChar = "]"
        ElseIf StringChar = "62" Then
            StringChar = "{"
        ElseIf StringChar = "63" Then
            StringChar = "}"
        ElseIf StringChar = "64" Then
            StringChar = "<"
        ElseIf StringChar = "65" Then
            StringChar = ">"
        ElseIf StringChar = "66" Then
            StringChar = "'"
        ElseIf StringChar = "67" Then
            StringChar = vbLf
        ElseIf StringChar = "0" Then
            StringChar = " "
        ElseIf StringChar = "68" Then
            StringChar = "A"
        ElseIf StringChar = "69" Then
            StringChar = "B"
        ElseIf StringChar = "70" Then
            StringChar = "C"
        ElseIf StringChar = "71" Then
            StringChar = "D"
        ElseIf StringChar = "72" Then
            StringChar = "E"
        ElseIf StringChar = "73" Then
            StringChar = "F"
        ElseIf StringChar = "74" Then
            StringChar = "G"
        ElseIf StringChar = "75" Then
            StringChar = "H"
        ElseIf StringChar = "76" Then
            StringChar = "I"
        ElseIf StringChar = "77" Then
            StringChar = "J"
        ElseIf StringChar = "78" Then
            StringChar = "K"
        ElseIf StringChar = "79" Then
            StringChar = "L"
        ElseIf StringChar = "80" Then
            StringChar = "M"
        ElseIf StringChar = "81" Then
            StringChar = "N"
        ElseIf StringChar = "82" Then
            StringChar = "O"
        ElseIf StringChar = "83" Then
            StringChar = "P"
        ElseIf StringChar = "84" Then
            StringChar = "Q"
        ElseIf StringChar = "85" Then
            StringChar = "R"
        ElseIf StringChar = "86" Then
            StringChar = "S"
        ElseIf StringChar = "87" Then
            StringChar = "T"
        ElseIf StringChar = "88" Then
            StringChar = "U"
        ElseIf StringChar = "89" Then
            StringChar = "V"
        ElseIf StringChar = "90" Then
            StringChar = "W"
        ElseIf StringChar = "91" Then
            StringChar = "X"
        ElseIf StringChar = "92" Then
            StringChar = "Y"
        ElseIf StringChar = "93" Then
            StringChar = "Z"
        End If
        Return StringChar
    End Function

    Private Sub DecodeWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainWindow.Show()
    End Sub

    Private Sub PasteKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteKey.Click
        If Clipboard.GetText.Contains("MatrixKey:") Then
            Clipboard.SetText(Clipboard.GetText.Substring(10))
            CommaPosition = Clipboard.GetText.IndexOf(",")
            Element1TextBox.Text = Clipboard.GetText.Remove(CommaPosition)
            Clipboard.SetText(Clipboard.GetText.Substring(CommaPosition + 1))
            Element2TextBox.Text = Clipboard.GetText.Remove(CommaPosition)
            Clipboard.SetText(Clipboard.GetText.Substring(CommaPosition + 1))
            Element3TextBox.Text = Clipboard.GetText.Remove(CommaPosition)
            Clipboard.SetText(Clipboard.GetText.Substring(CommaPosition + 1))
            Element4TextBox.Text = Clipboard.GetText()
        End If
    End Sub

    Private Sub HelpBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBUT.Click
        MsgBox("Use the matrix key to encode a text message, and the same key to decode it and any other key will not be able to decode the message.", MsgBoxStyle.Information, "ItIsEncoded")
    End Sub

    Private Sub CopyEmcodedTextBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyEmcodedTextBUT.Click
        If Not DecodedTextRichTextBox.Text = "" Then
            Clipboard.SetText(DecodedTextRichTextBox.Text)
        End If
    End Sub

    Private Sub GTEWBUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GTEWBUT.Click
        EncodeWindow.Show()
    End Sub
End Class