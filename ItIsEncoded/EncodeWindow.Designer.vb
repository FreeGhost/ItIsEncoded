<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncodeWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EncodeWindow))
        Me.TextToEncodeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Element1TextBox = New System.Windows.Forms.TextBox()
        Me.Element2TextBox = New System.Windows.Forms.TextBox()
        Me.Element3TextBox = New System.Windows.Forms.TextBox()
        Me.Element4TextBox = New System.Windows.Forms.TextBox()
        Me.HelpBUT = New System.Windows.Forms.Label()
        Me.EncodedTextRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.StartEncodingBUT = New System.Windows.Forms.Label()
        Me.ConvertToNumTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EncodeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GenerateKeyBUT = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CopyKeyBUT = New System.Windows.Forms.Label()
        Me.CopyEmcodedTextBUT = New System.Windows.Forms.Label()
        Me.GTDWBUT = New System.Windows.Forms.Label()
        Me.PDTBUT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextToEncodeRichTextBox
        '
        Me.TextToEncodeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextToEncodeRichTextBox.Location = New System.Drawing.Point(13, 39)
        Me.TextToEncodeRichTextBox.Name = "TextToEncodeRichTextBox"
        Me.TextToEncodeRichTextBox.Size = New System.Drawing.Size(408, 114)
        Me.TextToEncodeRichTextBox.TabIndex = 0
        Me.TextToEncodeRichTextBox.Text = ""
        '
        'Element1TextBox
        '
        Me.Element1TextBox.Location = New System.Drawing.Point(160, 168)
        Me.Element1TextBox.MaxLength = 2
        Me.Element1TextBox.Name = "Element1TextBox"
        Me.Element1TextBox.ShortcutsEnabled = False
        Me.Element1TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element1TextBox.TabIndex = 1
        '
        'Element2TextBox
        '
        Me.Element2TextBox.Location = New System.Drawing.Point(196, 168)
        Me.Element2TextBox.MaxLength = 2
        Me.Element2TextBox.Name = "Element2TextBox"
        Me.Element2TextBox.ShortcutsEnabled = False
        Me.Element2TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element2TextBox.TabIndex = 2
        '
        'Element3TextBox
        '
        Me.Element3TextBox.Location = New System.Drawing.Point(232, 168)
        Me.Element3TextBox.MaxLength = 2
        Me.Element3TextBox.Name = "Element3TextBox"
        Me.Element3TextBox.ShortcutsEnabled = False
        Me.Element3TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element3TextBox.TabIndex = 3
        '
        'Element4TextBox
        '
        Me.Element4TextBox.Location = New System.Drawing.Point(268, 168)
        Me.Element4TextBox.MaxLength = 2
        Me.Element4TextBox.Name = "Element4TextBox"
        Me.Element4TextBox.ShortcutsEnabled = False
        Me.Element4TextBox.Size = New System.Drawing.Size(30, 20)
        Me.Element4TextBox.TabIndex = 4
        '
        'HelpBUT
        '
        Me.HelpBUT.BackColor = System.Drawing.Color.Transparent
        Me.HelpBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpBUT.Location = New System.Drawing.Point(353, 169)
        Me.HelpBUT.Name = "HelpBUT"
        Me.HelpBUT.Size = New System.Drawing.Size(19, 19)
        Me.HelpBUT.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.HelpBUT, "Help!")
        '
        'EncodedTextRichTextBox
        '
        Me.EncodedTextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EncodedTextRichTextBox.Location = New System.Drawing.Point(12, 285)
        Me.EncodedTextRichTextBox.Name = "EncodedTextRichTextBox"
        Me.EncodedTextRichTextBox.ReadOnly = True
        Me.EncodedTextRichTextBox.Size = New System.Drawing.Size(408, 114)
        Me.EncodedTextRichTextBox.TabIndex = 6
        Me.EncodedTextRichTextBox.Text = ""
        '
        'StartEncodingBUT
        '
        Me.StartEncodingBUT.BackColor = System.Drawing.Color.Transparent
        Me.StartEncodingBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartEncodingBUT.Location = New System.Drawing.Point(165, 217)
        Me.StartEncodingBUT.Name = "StartEncodingBUT"
        Me.StartEncodingBUT.Size = New System.Drawing.Size(122, 19)
        Me.StartEncodingBUT.TabIndex = 7
        '
        'ConvertToNumTimer
        '
        Me.ConvertToNumTimer.Interval = 1
        '
        'EncodeTimer
        '
        Me.EncodeTimer.Interval = 1
        '
        'GenerateKeyBUT
        '
        Me.GenerateKeyBUT.BackColor = System.Drawing.Color.Transparent
        Me.GenerateKeyBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateKeyBUT.Location = New System.Drawing.Point(306, 170)
        Me.GenerateKeyBUT.Name = "GenerateKeyBUT"
        Me.GenerateKeyBUT.Size = New System.Drawing.Size(19, 19)
        Me.GenerateKeyBUT.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.GenerateKeyBUT, "Generate random key")
        '
        'CopyKeyBUT
        '
        Me.CopyKeyBUT.BackColor = System.Drawing.Color.Transparent
        Me.CopyKeyBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyKeyBUT.Location = New System.Drawing.Point(328, 169)
        Me.CopyKeyBUT.Name = "CopyKeyBUT"
        Me.CopyKeyBUT.Size = New System.Drawing.Size(19, 19)
        Me.CopyKeyBUT.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.CopyKeyBUT, "Copy the key")
        '
        'CopyEmcodedTextBUT
        '
        Me.CopyEmcodedTextBUT.BackColor = System.Drawing.Color.Transparent
        Me.CopyEmcodedTextBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopyEmcodedTextBUT.Location = New System.Drawing.Point(402, 259)
        Me.CopyEmcodedTextBUT.Name = "CopyEmcodedTextBUT"
        Me.CopyEmcodedTextBUT.Size = New System.Drawing.Size(19, 19)
        Me.CopyEmcodedTextBUT.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.CopyEmcodedTextBUT, "Copy the encoded text")
        '
        'GTDWBUT
        '
        Me.GTDWBUT.BackColor = System.Drawing.Color.Transparent
        Me.GTDWBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GTDWBUT.Location = New System.Drawing.Point(281, 426)
        Me.GTDWBUT.Name = "GTDWBUT"
        Me.GTDWBUT.Size = New System.Drawing.Size(151, 10)
        Me.GTDWBUT.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.GTDWBUT, "Copy the encoded text")
        '
        'PDTBUT
        '
        Me.PDTBUT.BackColor = System.Drawing.Color.Transparent
        Me.PDTBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PDTBUT.Location = New System.Drawing.Point(402, 12)
        Me.PDTBUT.Name = "PDTBUT"
        Me.PDTBUT.Size = New System.Drawing.Size(19, 19)
        Me.PDTBUT.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.PDTBUT, "Paste the decoded text")
        '
        'EncodeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ItIsEncoded.My.Resources.Resources.EncodeWindowBG
        Me.ClientSize = New System.Drawing.Size(434, 441)
        Me.Controls.Add(Me.PDTBUT)
        Me.Controls.Add(Me.GTDWBUT)
        Me.Controls.Add(Me.CopyEmcodedTextBUT)
        Me.Controls.Add(Me.CopyKeyBUT)
        Me.Controls.Add(Me.GenerateKeyBUT)
        Me.Controls.Add(Me.StartEncodingBUT)
        Me.Controls.Add(Me.EncodedTextRichTextBox)
        Me.Controls.Add(Me.HelpBUT)
        Me.Controls.Add(Me.Element4TextBox)
        Me.Controls.Add(Me.Element3TextBox)
        Me.Controls.Add(Me.Element2TextBox)
        Me.Controls.Add(Me.Element1TextBox)
        Me.Controls.Add(Me.TextToEncodeRichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EncodeWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItIsEncoded"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextToEncodeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Element1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Element4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpBUT As System.Windows.Forms.Label
    Friend WithEvents EncodedTextRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents StartEncodingBUT As System.Windows.Forms.Label
    Friend WithEvents ConvertToNumTimer As System.Windows.Forms.Timer
    Friend WithEvents EncodeTimer As System.Windows.Forms.Timer
    Friend WithEvents GenerateKeyBUT As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents CopyKeyBUT As System.Windows.Forms.Label
    Friend WithEvents CopyEmcodedTextBUT As System.Windows.Forms.Label
    Friend WithEvents GTDWBUT As System.Windows.Forms.Label
    Friend WithEvents PDTBUT As System.Windows.Forms.Label
End Class
