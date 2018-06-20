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
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TextBoxAz = New System.Windows.Forms.TextBox()
        Me.TextBoxAy = New System.Windows.Forms.TextBox()
        Me.TextBoxAx = New System.Windows.Forms.TextBox()
        Me.LabelAz = New System.Windows.Forms.Label()
        Me.LabelAy = New System.Windows.Forms.Label()
        Me.LabelAx = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStatus.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(336, 20)
        Me.TextBoxStatus.TabIndex = 0
        Me.TextBoxStatus.Text = "00000000"
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMessage.Location = New System.Drawing.Point(12, 39)
        Me.TextBoxMessage.Multiline = True
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(417, 238)
        Me.TextBoxMessage.TabIndex = 2
        Me.TextBoxMessage.Text = "<"
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.Location = New System.Drawing.Point(354, 10)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'TextBoxAz
        '
        Me.TextBoxAz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAz.Location = New System.Drawing.Point(314, 283)
        Me.TextBoxAz.Name = "TextBoxAz"
        Me.TextBoxAz.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAz.TabIndex = 8
        Me.TextBoxAz.Text = "0"
        '
        'TextBoxAy
        '
        Me.TextBoxAy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAy.Location = New System.Drawing.Point(178, 283)
        Me.TextBoxAy.Name = "TextBoxAy"
        Me.TextBoxAy.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAy.TabIndex = 6
        Me.TextBoxAy.Text = "0"
        '
        'TextBoxAx
        '
        Me.TextBoxAx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAx.Location = New System.Drawing.Point(42, 283)
        Me.TextBoxAx.Name = "TextBoxAx"
        Me.TextBoxAx.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAx.TabIndex = 4
        Me.TextBoxAx.Text = "0"
        '
        'LabelAz
        '
        Me.LabelAz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelAz.AutoSize = True
        Me.LabelAz.Location = New System.Drawing.Point(284, 286)
        Me.LabelAz.Name = "LabelAz"
        Me.LabelAz.Size = New System.Drawing.Size(24, 13)
        Me.LabelAz.TabIndex = 7
        Me.LabelAz.Text = "az="
        '
        'LabelAy
        '
        Me.LabelAy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelAy.AutoSize = True
        Me.LabelAy.Location = New System.Drawing.Point(148, 286)
        Me.LabelAy.Name = "LabelAy"
        Me.LabelAy.Size = New System.Drawing.Size(24, 13)
        Me.LabelAy.TabIndex = 5
        Me.LabelAy.Text = "ay="
        '
        'LabelAx
        '
        Me.LabelAx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelAx.AutoSize = True
        Me.LabelAx.Location = New System.Drawing.Point(12, 286)
        Me.LabelAx.Name = "LabelAx"
        Me.LabelAx.Size = New System.Drawing.Size(24, 13)
        Me.LabelAx.TabIndex = 3
        Me.LabelAx.Text = "ax="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 315)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.TextBoxAz)
        Me.Controls.Add(Me.TextBoxAy)
        Me.Controls.Add(Me.TextBoxAx)
        Me.Controls.Add(Me.LabelAz)
        Me.Controls.Add(Me.LabelAy)
        Me.Controls.Add(Me.LabelAx)
        Me.Name = "Form1"
        Me.Text = "WiimotePLMAM1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMessage As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextBoxAz As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAy As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAx As System.Windows.Forms.TextBox
    Friend WithEvents LabelAz As System.Windows.Forms.Label
    Friend WithEvents LabelAy As System.Windows.Forms.Label
    Friend WithEvents LabelAx As System.Windows.Forms.Label

End Class
