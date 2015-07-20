<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button
        Me.fraScores = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblScore1 = New System.Windows.Forms.Label
        Me.lblPlayer1 = New System.Windows.Forms.Label
        Me.lblScoreTitle = New System.Windows.Forms.Label
        Me.lblNameTitle = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.fraScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(146, 215)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(64, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'fraScores
        '
        Me.fraScores.Controls.Add(Me.Label7)
        Me.fraScores.Controls.Add(Me.Label8)
        Me.fraScores.Controls.Add(Me.Label5)
        Me.fraScores.Controls.Add(Me.Label6)
        Me.fraScores.Controls.Add(Me.Label3)
        Me.fraScores.Controls.Add(Me.Label4)
        Me.fraScores.Controls.Add(Me.Label1)
        Me.fraScores.Controls.Add(Me.Label2)
        Me.fraScores.Controls.Add(Me.lblScore1)
        Me.fraScores.Controls.Add(Me.lblPlayer1)
        Me.fraScores.Controls.Add(Me.lblScoreTitle)
        Me.fraScores.Controls.Add(Me.lblNameTitle)
        Me.fraScores.Controls.Add(Me.Label9)
        Me.fraScores.Controls.Add(Me.Label10)
        Me.fraScores.Controls.Add(Me.Label11)
        Me.fraScores.Controls.Add(Me.Label12)
        Me.fraScores.Controls.Add(Me.Label13)
        Me.fraScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraScores.Location = New System.Drawing.Point(12, 12)
        Me.fraScores.Name = "fraScores"
        Me.fraScores.Size = New System.Drawing.Size(335, 197)
        Me.fraScores.TabIndex = 1
        Me.fraScores.TabStop = False
        Me.fraScores.Text = "  Hall of Fame  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Score5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(239, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = Global.SimonSays.My.MySettings.Default.Score5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Player5", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = Global.SimonSays.My.MySettings.Default.Player5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Score4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = Global.SimonSays.My.MySettings.Default.Score4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Player4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = Global.SimonSays.My.MySettings.Default.Player4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Score3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = Global.SimonSays.My.MySettings.Default.Score3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Player3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = Global.SimonSays.My.MySettings.Default.Player3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Score2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = Global.SimonSays.My.MySettings.Default.Score2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Player2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = Global.SimonSays.My.MySettings.Default.Player2
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Score1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(239, 71)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(28, 15)
        Me.lblScore1.TabIndex = 3
        Me.lblScore1.Text = Global.SimonSays.My.MySettings.Default.Score1
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SimonSays.My.MySettings.Default, "Player1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(45, 71)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(43, 15)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = Global.SimonSays.My.MySettings.Default.Player1
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.AutoSize = True
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.Location = New System.Drawing.Point(229, 40)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(57, 16)
        Me.lblScoreTitle.TabIndex = 1
        Me.lblScoreTitle.Text = "Score :"
        '
        'lblNameTitle
        '
        Me.lblNameTitle.AutoSize = True
        Me.lblNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameTitle.Location = New System.Drawing.Point(30, 40)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(61, 16)
        Me.lblNameTitle.TabIndex = 0
        Me.lblNameTitle.Text = "Player :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "5. "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "4. "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "3. "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "2. "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "1. "
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(263, 215)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.Visible = False
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(360, 249)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.fraScores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HighScores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "High Scores"
        Me.fraScores.ResumeLayout(False)
        Me.fraScores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents fraScores As System.Windows.Forms.GroupBox
    Friend WithEvents lblNameTitle As System.Windows.Forms.Label
    Friend WithEvents lblScoreTitle As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button

End Class
