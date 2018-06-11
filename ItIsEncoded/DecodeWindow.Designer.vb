<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecodeWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DecodeWindow))
        Me.CopyEmcodedTextBUT = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpBUT = New System.Windows.Forms.Label()
        Me.PasteKey = New System.Windows.Forms.Label()
        Me.PastTextToDecodeLabel = New System.Windows.Forms.Label()
        Me.GTEWBUT = New System.Windows.Forms.Label()
        Me.StartDecodingBUT = New System.Windows.Forms.Label()
        Me.DecodedTextRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Element4TextBox = New System.Windows.Forms.TextBox()
        Me.Element3TextBox = New System.Windows.Forms.TextBox()
        Me.Element2TextBox = New System.Windows.Forms.TextBox()
        Me.Element1TextBox = New System.Windows.Forms.TextBox()
        Me.TextToDecodeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DecodeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ConvertToStrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'CopyEmcodedTextBUT
        '
        Me.CopyEmcodedTextBUT.BackColor = System.Drawing.Color.Transparent
        Me.CopyEmcodedTextBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyEmcodedTextBUT.Location = New System.Drawing.Point(402, 259)
        Me.CopyEmcodedTextBUT.Name = "CopyEmcodedTextBUT"
        Me.CopyEmcodedTextBUT.Size = New System.Drawing.Size(19, 19)
        Me.CopyEmcodedTextBUT.TabIndex = 21
        Me.ToolTip.SetToolTip(Me.CopyEmcodedTextBUT, "Copy the decoded text")
        '
        'HelpBUT
        '
        Me.HelpBUT.BackColor = System.Drawing.Color.Transparent
        Me.HelpBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpBUT.Location = New System.Drawing.Point(328, 169)
        Me.HelpBUT.Name = "HelpBUT"
        Me.HelpBUT.Size = New System.Drawing.Size(19, 19)
        Me.HelpBUT.TabIndex = 20
        Me.ToolTip.SetToolTip(Me.HelpBUT, "Help!")
        '
        'PasteKey
        '
        Me.PasteKey.BackColor = System.Drawing.Color.Transparent
        Me.PasteKey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PasteKey.Location = New System.Drawing.Point(306, 170)
        Me.PasteKey.Name = "PasteKey"
        Me.PasteKey.Size = New System.Drawing.Size(19, 19)
        Me.PasteKey.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.PasteKey, "Paste the key")
        '
        'PastTextToDecodeLabel
        '
        Me.PastTextToDecodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.PastTextToDecodeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PastTextToDecodeLabel.Location = New System.Drawing.Point(402, 12)
        Me.PastTextToDecodeLabel.Name = "PastTextToDecodeLabel"
        Me.PastTextToDecodeLabel.Size = New System.Drawing.Size(19, 19)
        Me.PastTextToDecodeLabel.TabIndex = 22
        Me.ToolTip.SetToolTip(Me.PastTextToDecodeLabel, "Paste the encoded text")
        '
        'GTEWBUT
        '
        Me.GTEWBUT.BackColor = System.Drawing.Color.Transparent
        Me.GTEWBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GTEWBUT.Location = New System.Drawing.Point(282, 426)
        Me.GTEWBUT.Name = "GTEWBUT"
        Me.GTEWBUT.Size = New System.Drawing.Size(151, 10)
        Me.GTEWBUT.TabIndex = 23
        Me.ToolTip.SetToolTip(Me.GTEWBUT, "Copy the encoded text")
        '
        'StartDecodingBUT
        '
        Me.StartDecodingBUT.BackColor = System.Drawing.Color.Transparent
        Me.StartDecodingBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartDecodingBUT.Location = New System.Drawing.Point(165, 217)
        Me.StartDecodingBUT.Name = "StartDecodingBUT"
        Me.StartDecodingBUT.Size = New System.Drawing.Size(122, 19)
        Me.StartDecodingBUT.TabIndex = 18
        '
        'DecodedTextRichTextBox
        '
        Me.DecodedTextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DecodedTextRichTextBox.Location = New System.Drawing.Point(12, 285)
        Me.DecodedTextRichTextBox.Name = "DecodedTextRichTextBox"
        Me.DecodedTextRichTextBox.ReadOnly = True
        Me.DecodedTextRichTextBox.Size = New System.Drawing.Size(408, 114)
        Me.DecodedTextRichTextBox.TabIndex = 17
        Me.DecodedTextRichTextBox.Text = ""
        '
        'Element4TextBox
        '
        Me.Element4TextBox.Location = New System.Drawing.Point(268, 168)
        Me.Element4TextBox.MaxLength = 2
        Me.Element4TextBox.Name = "Element4TextBox"
        Me.Element4TextBox.ShortcutsEnabled = False
        Me.Element4TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element4TextBox.TabIndex = 15
        '
        'Element3TextBox
        '
        Me.Element3TextBox.Location = New System.Drawing.Point(232, 168)
        Me.Element3TextBox.MaxLength = 2
        Me.Element3TextBox.Name = "Element3TextBox"
        Me.Element3TextBox.ShortcutsEnabled = False
        Me.Element3TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element3TextBox.TabIndex = 14
        '
        'Element2TextBox
        '
        Me.Element2TextBox.Location = New System.Drawing.Point(196, 168)
        Me.Element2TextBox.MaxLength = 2
        Me.Element2TextBox.Name = "Element2TextBox"
        Me.Element2TextBox.ShortcutsEnabled = False
        Me.Element2TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element2TextBox.TabIndex = 13
        '
        'Element1TextBox
        '
        Me.Element1TextBox.Location = New System.Drawing.Point(160, 168)
        Me.Element1TextBox.MaxLength = 2
        Me.Element1TextBox.Name = "Element1TextBox"
        Me.Element1TextBox.ShortcutsEnabled = False
        Me.Element1TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element1TextBox.TabIndex = 12
        '
        'TextToDecodeRichTextBox
        '
        Me.TextToDecodeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextToDecodeRichTextBox.Location = New System.Drawing.Point(13, 39)
        Me.TextToDecodeRichTextBox.Name = "TextToDecodeRichTextBox"
        Me.TextToDecodeRichTextBox.Size = New System.Drawing.Size(408, 114)
        Me.TextToDecodeRichTextBox.TabIndex = 11
        Me.TextToDecodeRichTextBox.Text = ""
        '
        'DecodeTimer
        '
        Me.DecodeTimer.Interval = 1
        '
        'ConvertToStrTimer
        '
        Me.ConvertToStrTimer.Interval = 1
        '
        'DecodeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ItIsEncoded.My.Resources.Resources.DecodeWindowBG
        Me.ClientSize = New System.Drawing.Size(434, 441)
        Me.Controls.Add(Me.GTEWBUT)
        Me.Controls.Add(Me.PastTextToDecodeLabel)
        Me.Controls.Add(Me.CopyEmcodedTextBUT)
        Me.Controls.Add(Me.HelpBUT)
        Me.Controls.Add(Me.PasteKey)
        Me.Controls.Add(Me.StartDecodingBUT)
        Me.Controls.Add(Me.DecodedTextRichTextBox)
        Me.Controls.Add(Me.Element4TextBox)
        Me.Controls.Add(Me.Element3TextBox)
        Me.Controls.Add(Me.Element2TextBox)
        Me.Controls.Add(Me.Element1TextBox)
        Me.Controls.Add(Me.TextToDecodeRichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DecodeWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItIsEncoded"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CopyEmcodedTextBUT As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents HelpBUT As System.Windows.Forms.Label
    Friend WithEvents PasteKey As System.Windows.Forms.Label
    Friend WithEvents StartDecodingBUT As System.Windows.Forms.Label
    Friend WithEvents DecodedTextRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Element4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextToDecodeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DecodeTimer As System.Windows.Forms.Timer
    Friend WithEvents ConvertToStrTimer As System.Windows.Forms.Timer
    Friend WithEvents PastTextToDecodeLabel As System.Windows.Forms.Label
    Friend WithEvents GTEWBUT As System.Windows.Forms.Label
End Class
