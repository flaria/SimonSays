<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimonGame
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimonGame))
        Me.imgLstLuces = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblMensaje = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblPoints = New System.Windows.Forms.ToolStripStatusLabel
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgLstLuces
        '
        Me.imgLstLuces.ImageStream = CType(resources.GetObject("imgLstLuces.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLstLuces.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLstLuces.Images.SetKeyName(0, "blankImage.png")
        Me.imgLstLuces.Images.SetKeyName(1, "ledOrangeOn.png")
        Me.imgLstLuces.Images.SetKeyName(2, "ledOrangeOff.png")
        Me.imgLstLuces.Images.SetKeyName(3, "ledGreenOn.png")
        Me.imgLstLuces.Images.SetKeyName(4, "ledGreenOff.png")
        Me.imgLstLuces.Images.SetKeyName(5, "ledRedOn.png")
        Me.imgLstLuces.Images.SetKeyName(6, "ledRedOff.png")
        Me.imgLstLuces.Images.SetKeyName(7, "ledWhiteOn.png")
        Me.imgLstLuces.Images.SetKeyName(8, "ledWhiteOff.png")
        Me.imgLstLuces.Images.SetKeyName(9, "ledYellowOn.png")
        Me.imgLstLuces.Images.SetKeyName(10, "ledYellowOff.png")
        Me.imgLstLuces.Images.SetKeyName(11, "ledCyanOn.png")
        Me.imgLstLuces.Images.SetKeyName(12, "ledCyanOff.png")
        Me.imgLstLuces.Images.SetKeyName(13, "ledPinkOn.png")
        Me.imgLstLuces.Images.SetKeyName(14, "ledPinkOff.png")
        Me.imgLstLuces.Images.SetKeyName(15, "ledBlueOn.png")
        Me.imgLstLuces.Images.SetKeyName(16, "ledBlueOff.png")
        Me.imgLstLuces.Images.SetKeyName(17, "ledPurpleOn.png")
        Me.imgLstLuces.Images.SetKeyName(18, "ledPurpleOff.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(319, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMensaje, Me.lblPoints})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 279)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(319, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = False
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.Menu
        Me.lblMensaje.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblMensaje.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(237, 17)
        Me.lblMensaje.Spring = True
        Me.lblMensaje.Text = "Press F2 to start a new game."
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = False
        Me.lblPoints.BackColor = System.Drawing.SystemColors.Menu
        Me.lblPoints.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblPoints.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(67, 17)
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.DifficultyToolStripMenuItem, Me.ScoresToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HardToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DifficultyToolStripMenuItem.Text = "&Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Checked = True
        Me.EasyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EasyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EasyToolStripMenuItem.Tag = "0"
        Me.EasyToolStripMenuItem.Text = "&Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.MediumToolStripMenuItem.Tag = "1"
        Me.MediumToolStripMenuItem.Text = "&Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.HardToolStripMenuItem.Tag = "2"
        Me.HardToolStripMenuItem.Text = "&Hard"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Image = CType(resources.GetObject("NewGameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewGameToolStripMenuItem.Text = "&New game"
        '
        'ScoresToolStripMenuItem
        '
        Me.ScoresToolStripMenuItem.Image = Global.SimonSays.My.Resources.Resources.scores
        Me.ScoresToolStripMenuItem.Name = "ScoresToolStripMenuItem"
        Me.ScoresToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ScoresToolStripMenuItem.Text = "&Scores"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.SimonSays.My.Resources.Resources.help1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SimonGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(319, 301)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SimonGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simon Says"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLstLuces As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblMensaje As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPoints As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
