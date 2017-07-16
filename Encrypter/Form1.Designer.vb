<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtText = New Encrypter.NSTextBox()
        Me.rbtnMD5 = New Encrypter.NSRadioButton()
        Me.rbtnSha256 = New Encrypter.NSRadioButton()
        Me.rbtnBlowfish = New Encrypter.NSRadioButton()
        Me.btnSubmit = New Encrypter.NSButton()
        Me.NsTheme1 = New Encrypter.NSTheme()
        Me.btnExit = New Encrypter.NSButton()
        Me.NsSeperator3 = New Encrypter.NSSeperator()
        Me.NsSeperator2 = New Encrypter.NSSeperator()
        Me.NsSeperator1 = New Encrypter.NSSeperator()
        Me.txtOutput = New Encrypter.NSTextBox()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtText.Location = New System.Drawing.Point(58, 38)
        Me.txtText.MaxLength = 32767
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.ReadOnly = False
        Me.txtText.Size = New System.Drawing.Size(421, 88)
        Me.txtText.TabIndex = 0
        Me.txtText.Text = "Text"
        Me.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtText.UseSystemPasswordChar = False
        '
        'rbtnMD5
        '
        Me.rbtnMD5.Checked = False
        Me.rbtnMD5.Location = New System.Drawing.Point(69, 150)
        Me.rbtnMD5.Name = "rbtnMD5"
        Me.rbtnMD5.Size = New System.Drawing.Size(127, 23)
        Me.rbtnMD5.TabIndex = 1
        Me.rbtnMD5.Text = "MD5"
        '
        'rbtnSha256
        '
        Me.rbtnSha256.Checked = False
        Me.rbtnSha256.Location = New System.Drawing.Point(213, 150)
        Me.rbtnSha256.Name = "rbtnSha256"
        Me.rbtnSha256.Size = New System.Drawing.Size(127, 23)
        Me.rbtnSha256.TabIndex = 2
        Me.rbtnSha256.Text = "SHA256"
        '
        'rbtnBlowfish
        '
        Me.rbtnBlowfish.Checked = False
        Me.rbtnBlowfish.Location = New System.Drawing.Point(379, 150)
        Me.rbtnBlowfish.Name = "rbtnBlowfish"
        Me.rbtnBlowfish.Size = New System.Drawing.Size(127, 23)
        Me.rbtnBlowfish.TabIndex = 3
        Me.rbtnBlowfish.Text = "Blowfish"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(203, 319)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(137, 34)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "         Convert"
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Encrypter.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.btnExit)
        Me.NsTheme1.Controls.Add(Me.NsSeperator3)
        Me.NsTheme1.Controls.Add(Me.NsSeperator2)
        Me.NsTheme1.Controls.Add(Me.NsSeperator1)
        Me.NsTheme1.Controls.Add(Me.txtOutput)
        Me.NsTheme1.Controls.Add(Me.btnSubmit)
        Me.NsTheme1.Controls.Add(Me.rbtnBlowfish)
        Me.NsTheme1.Controls.Add(Me.rbtnSha256)
        Me.NsTheme1.Controls.Add(Me.rbtnMD5)
        Me.NsTheme1.Controls.Add(Me.txtText)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(531, 365)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "TCW Encrypter"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(497, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(34, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = " X"
        '
        'NsSeperator3
        '
        Me.NsSeperator3.Location = New System.Drawing.Point(12, 298)
        Me.NsSeperator3.Name = "NsSeperator3"
        Me.NsSeperator3.Size = New System.Drawing.Size(507, 23)
        Me.NsSeperator3.TabIndex = 8
        Me.NsSeperator3.Text = "NsSeperator3"
        '
        'NsSeperator2
        '
        Me.NsSeperator2.Location = New System.Drawing.Point(12, 132)
        Me.NsSeperator2.Name = "NsSeperator2"
        Me.NsSeperator2.Size = New System.Drawing.Size(507, 23)
        Me.NsSeperator2.TabIndex = 7
        Me.NsSeperator2.Text = "NsSeperator2"
        '
        'NsSeperator1
        '
        Me.NsSeperator1.Location = New System.Drawing.Point(12, 179)
        Me.NsSeperator1.Name = "NsSeperator1"
        Me.NsSeperator1.Size = New System.Drawing.Size(507, 23)
        Me.NsSeperator1.TabIndex = 6
        Me.NsSeperator1.Text = "NsSeperator1"
        '
        'txtOutput
        '
        Me.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOutput.Location = New System.Drawing.Point(58, 204)
        Me.txtOutput.MaxLength = 32767
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(421, 88)
        Me.txtOutput.TabIndex = 5
        Me.txtOutput.Text = "Output"
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtOutput.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 365)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.NsTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtText As NSTextBox
    Friend WithEvents rbtnMD5 As NSRadioButton
    Friend WithEvents rbtnSha256 As NSRadioButton
    Friend WithEvents rbtnBlowfish As NSRadioButton
    Friend WithEvents btnSubmit As NSButton
    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents txtOutput As NSTextBox
    Friend WithEvents btnExit As NSButton
    Friend WithEvents NsSeperator3 As NSSeperator
    Friend WithEvents NsSeperator2 As NSSeperator
    Friend WithEvents NsSeperator1 As NSSeperator
End Class
