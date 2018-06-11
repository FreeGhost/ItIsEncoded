<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.EncodeTextBUT = New System.Windows.Forms.Label()
        Me.DecodeBUT = New System.Windows.Forms.Label()
        Me.AboutBUT = New System.Windows.Forms.Label()
        Me.ExitBUT = New System.Windows.Forms.Label()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.TermsAndConditionsBUT = New System.Windows.Forms.Label()
        Me.WebsiteBUT = New System.Windows.Forms.Label()
        Me.TwitterBUT = New System.Windows.Forms.Label()
        Me.YouTubeBUT = New System.Windows.Forms.Label()
        Me.AboutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EncodeTextBUT
        '
        Me.EncodeTextBUT.BackColor = System.Drawing.Color.Transparent
        Me.EncodeTextBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EncodeTextBUT.Location = New System.Drawing.Point(83, 46)
        Me.EncodeTextBUT.Name = "EncodeTextBUT"
        Me.EncodeTextBUT.Size = New System.Drawing.Size(123, 21)
        Me.EncodeTextBUT.TabIndex = 0
        '
        'DecodeBUT
        '
        Me.DecodeBUT.BackColor = System.Drawing.Color.Transparent
        Me.DecodeBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DecodeBUT.Location = New System.Drawing.Point(83, 88)
        Me.DecodeBUT.Name = "DecodeBUT"
        Me.DecodeBUT.Size = New System.Drawing.Size(123, 21)
        Me.DecodeBUT.TabIndex = 1
        '
        'AboutBUT
        '
        Me.AboutBUT.BackColor = System.Drawing.Color.Transparent
        Me.AboutBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutBUT.Location = New System.Drawing.Point(114, 129)
        Me.AboutBUT.Name = "AboutBUT"
        Me.AboutBUT.Size = New System.Drawing.Size(60, 21)
        Me.AboutBUT.TabIndex = 2
        '
        'ExitBUT
        '
        Me.ExitBUT.BackColor = System.Drawing.Color.Transparent
        Me.ExitBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBUT.Location = New System.Drawing.Point(126, 176)
        Me.ExitBUT.Name = "ExitBUT"
        Me.ExitBUT.Size = New System.Drawing.Size(40, 21)
        Me.ExitBUT.TabIndex = 3
        '
        'AboutPanel
        '
        Me.AboutPanel.BackgroundImage = Global.ItIsEncoded.My.Resources.Resources.AboutPanelBG
        Me.AboutPanel.Controls.Add(Me.TermsAndConditionsBUT)
        Me.AboutPanel.Controls.Add(Me.WebsiteBUT)
        Me.AboutPanel.Controls.Add(Me.TwitterBUT)
        Me.AboutPanel.Controls.Add(Me.YouTubeBUT)
        Me.AboutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.Size = New System.Drawing.Size(434, 311)
        Me.AboutPanel.TabIndex = 4
        Me.AboutPanel.Visible = False
        '
        'TermsAndConditionsBUT
        '
        Me.TermsAndConditionsBUT.BackColor = System.Drawing.Color.Transparent
        Me.TermsAndConditionsBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TermsAndConditionsBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TermsAndConditionsBUT.Location = New System.Drawing.Point(169, 200)
        Me.TermsAndConditionsBUT.Name = "TermsAndConditionsBUT"
        Me.TermsAndConditionsBUT.Size = New System.Drawing.Size(115, 11)
        Me.TermsAndConditionsBUT.TabIndex = 16
        '
        'WebsiteBUT
        '
        Me.WebsiteBUT.BackColor = System.Drawing.Color.Transparent
        Me.WebsiteBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WebsiteBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WebsiteBUT.Location = New System.Drawing.Point(167, 240)
        Me.WebsiteBUT.Name = "WebsiteBUT"
        Me.WebsiteBUT.Size = New System.Drawing.Size(116, 60)
        Me.WebsiteBUT.TabIndex = 15
        '
        'TwitterBUT
        '
        Me.TwitterBUT.BackColor = System.Drawing.Color.Transparent
        Me.TwitterBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TwitterBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TwitterBUT.Location = New System.Drawing.Point(299, 240)
        Me.TwitterBUT.Name = "TwitterBUT"
        Me.TwitterBUT.Size = New System.Drawing.Size(61, 60)
        Me.TwitterBUT.TabIndex = 14
        '
        'YouTubeBUT
        '
        Me.YouTubeBUT.BackColor = System.Drawing.Color.Transparent
        Me.YouTubeBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YouTubeBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YouTubeBUT.Location = New System.Drawing.Point(119, 240)
        Me.YouTubeBUT.Name = "YouTubeBUT"
        Me.YouTubeBUT.Size = New System.Drawing.Size(61, 60)
        Me.YouTubeBUT.TabIndex = 13
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.ItIsEncoded.My.Resources.Resources.MainWindowBG
        Me.ClientSize = New System.Drawing.Size(289, 232)
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.ExitBUT)
        Me.Controls.Add(Me.AboutBUT)
        Me.Controls.Add(Me.DecodeBUT)
        Me.Controls.Add(Me.EncodeTextBUT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItIsEncoded"
        Me.AboutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EncodeTextBUT As System.Windows.Forms.Label
    Friend WithEvents DecodeBUT As System.Windows.Forms.Label
    Friend WithEvents AboutBUT As System.Windows.Forms.Label
    Friend WithEvents ExitBUT As System.Windows.Forms.Label
    Friend WithEvents AboutPanel As System.Windows.Forms.Panel
    Friend WithEvents TermsAndConditionsBUT As System.Windows.Forms.Label
    Friend WithEvents WebsiteBUT As System.Windows.Forms.Label
    Friend WithEvents TwitterBUT As System.Windows.Forms.Label
    Friend WithEvents YouTubeBUT As System.Windows.Forms.Label

End Class
