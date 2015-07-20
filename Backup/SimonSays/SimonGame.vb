Imports SoundPlayer

Public Class SimonGame
    Dim player As MIDIPlayer = New MIDIPlayer
    Dim cuadrados(10) As System.Drawing.Rectangle
    Dim fotos(10) As PictureBox
    Dim cuadroSobre As Integer
    Dim gameOn As Boolean
    Dim points As Integer
    Dim playedNotes As ArrayList = New ArrayList()
    Dim playerNotes As ArrayList = New ArrayList()
    Dim Speed As Integer = 1000
    Dim handicap As Integer = 1

    Dim posicionParaThread As Integer
    Dim proceso As System.Threading.Thread

    Private juego As System.Threading.Thread
    Dim pictureBoxTemp As PictureBox
    Delegate Sub SetBoolCallback(ByVal [bool] As Boolean)
    Dim pressedKey As Boolean = False

    Private Sub SimonGame_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If gameOn Or IsNothing(juego) = False Then
            If MsgBox("Game in progress." & Microsoft.VisualBasic.vbCrLf & "Are you sure you want to quit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simon says...") = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        If IsNothing(proceso) = False Then
            If proceso.IsAlive Then
                proceso.Abort()
                proceso = Nothing
            End If
        End If
        If IsNothing(juego) = False Then
            If juego.IsAlive Then
                juego.Abort()
                juego = Nothing
            End If
        End If
    End Sub

    Private Sub SimonGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If pressedKey = False Then
            pressedKey = True
            Dim numFoto As Integer = 0
            Select Case e.KeyCode
                Case Keys.NumPad7
                    numFoto = 1
                Case Keys.NumPad8
                    numFoto = 2
                Case Keys.NumPad9
                    numFoto = 3
                Case Keys.NumPad4
                    numFoto = 4
                Case Keys.NumPad5
                    numFoto = 5
                Case Keys.NumPad6
                    numFoto = 6
                Case Keys.NumPad1
                    numFoto = 7
                Case Keys.NumPad2
                    numFoto = 8
                Case Keys.NumPad3
                    numFoto = 9
            End Select
            If numFoto >= 1 And numFoto <= 9 Then
                Dim evento As System.Windows.Forms.MouseEventArgs = New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, fotos(numFoto).Left + (fotos(numFoto).Width / 2), fotos(numFoto).Top + (fotos(numFoto).Height / 2), 0)
                Me.fotos_MouseDown(fotos(numFoto), evento)
            End If
        End If
    End Sub

    Private Sub SimonGame_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim numFoto As Integer = 0
        Select Case e.KeyCode
            Case Keys.NumPad7
                numFoto = 1
            Case Keys.NumPad8
                numFoto = 2
            Case Keys.NumPad9
                numFoto = 3
            Case Keys.NumPad4
                numFoto = 4
            Case Keys.NumPad5
                numFoto = 5
            Case Keys.NumPad6
                numFoto = 6
            Case Keys.NumPad1
                numFoto = 7
            Case Keys.NumPad2
                numFoto = 8
            Case Keys.NumPad3
                numFoto = 9
        End Select
        If numFoto >= 1 And numFoto <= 9 Then
            Dim evento As System.Windows.Forms.MouseEventArgs = New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 1, fotos(numFoto).Left + (fotos(numFoto).Width / 2), fotos(numFoto).Top + (fotos(numFoto).Height / 2), 0)
            Me.fotos_MouseUp(fotos(numFoto), evento)
        End If
        pressedKey = False
    End Sub

    Private Sub SimonGame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ResizeRedraw = True
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(Me.Width, Me.Height)
        cuadrados.Initialize()
        For i As Integer = 1 To 9
            fotos(i) = New PictureBox()
            CType(fotos(i), System.ComponentModel.ISupportInitialize).BeginInit()
            fotos(i).Image = Me.imgLstLuces.Images(i * 2)
            fotos(i).Location = New System.Drawing.Point(0, 0)
            fotos(i).Name = i
            fotos(i).Size = New System.Drawing.Size(1, 1)
            fotos(i).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            fotos(i).TabIndex = i + 100
            fotos(i).TabStop = False
            fotos(i).BorderStyle = BorderStyle.FixedSingle
            fotos(i).Enabled = False
            AddHandler fotos(i).MouseDown, AddressOf fotos_MouseDown
            AddHandler fotos(i).MouseUp, AddressOf fotos_MouseUp
            AddHandler fotos(i).MouseLeave, AddressOf fotos_MouseLeave
            Me.Controls.Add(fotos(i))
            CType(fotos(i), System.ComponentModel.ISupportInitialize).BeginInit()
        Next
        gameOn = False
        Me.lblMensaje.Text = "Press F2 to start a new game."
    End Sub

    Private Sub SimonGame_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        For i As Integer = 1 To 9
            cuadrado(i)
        Next
    End Sub

    Private Sub SimonGame_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        For i As Integer = 1 To 9
            cuadrado(i)
        Next
    End Sub

    Private Sub SimonGame_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Normal Then
            If (Me.Height - Me.StatusStrip1.Height - Me.MenuStrip1.Height) <> Me.Width Then
                If (Me.Height - Me.StatusStrip1.Height - Me.MenuStrip1.Height) < Me.Width Then
                    Me.Height = Me.Width + Me.StatusStrip1.Height + Me.MenuStrip1.Height
                Else
                    Me.Width = (Me.Height - Me.StatusStrip1.Height - Me.MenuStrip1.Height)
                End If
            End If
        End If
        'If Me.WindowState = FormWindowState.Maximized Then
        'ToDo: Make squares the size of the heigth, not the width
        'End If
    End Sub

    Private Sub cuadrado(ByVal cuadrante As Integer)

        Dim posicion As System.Drawing.Point
        Dim x As Integer
        Dim y As Integer
        If cuadrante >= 1 And cuadrante <= 3 Then
            x = (((Me.Width - 20) / 3) * (1 * cuadrante)) + 5 - ((Me.Width - 20) / 3)
            y = (((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) * (1)) + 5 - ((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) + Me.MenuStrip1.Height
        ElseIf cuadrante >= 4 And cuadrante <= 6 Then
            x = (((Me.Width - 20) / 3) * (1 * cuadrante - 3)) + 5 - ((Me.Width - 20) / 3)
            y = (((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) * (2)) + 5 - ((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) + Me.MenuStrip1.Height
        ElseIf cuadrante >= 7 And cuadrante <= 9 Then
            x = (((Me.Width - 20) / 3) * (1 * cuadrante - 6)) + 5 - ((Me.Width - 20) / 3)
            y = (((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) * (3)) + 5 - ((Me.Height - Me.MenuStrip1.Height - Me.StatusStrip1.Height - 50) / 3) + Me.MenuStrip1.Height
        Else
            Exit Sub
        End If
        posicion.X = x
        posicion.Y = y
        cuadrados(cuadrante) = New Rectangle(x, y, CInt((Me.Width - 10) / 3), CInt((Me.Height - Me.MenuStrip1.Height - 50) / 3))
        If cuadrante <= 9 Then
            fotos(cuadrante).Size = cuadrados(cuadrante).Size
            fotos(cuadrante).Location = cuadrados(cuadrante).Location
        End If

    End Sub


    Private Sub fotos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cuadrante As Integer = Integer.Parse(sender.Name)
        sender.Image = Me.imgLstLuces.Images.Item((cuadrante * 2) - 1)
        posicionParaThread = cuadrante
        proceso = New System.Threading.Thread(AddressOf tocarLaMusica)
        proceso.IsBackground = True
        proceso.Start()
    End Sub
    
    Private Sub tocarLaMusica()
        playerNotes.Add(posicionParaThread)
        player.PlaySound(Instruments.Acoustic_Grand_Piano, 30 + (posicionParaThread * 6), Speed)

    End Sub
    Private Sub fotos_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        sender.Image = Me.imgLstLuces.Images.Item(Integer.Parse(sender.Name) * 2)
        For i As Integer = 0 To playerNotes.Count - 1
            If playedNotes(i).Equals(playerNotes(i)) = False Then
                Threading.Thread.Sleep(500)
                endGame()
                Exit Sub
            End If
        Next
        points += handicap
        Me.lblPoints.Text = "Points: " & Space(4 - points.ToString.Length) & points
        If playedNotes.Count = playerNotes.Count Then
            proceso = Nothing
            proceso = New Threading.Thread(AddressOf tocarSecuencia)
            proceso.Start()
            Exit Sub
        End If
    End Sub
    Private Sub fotos_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.imgLstLuces.Images.Count > 0 Then
            If sender.Equals(Me.imgLstLuces.Images.Item((Integer.Parse(sender.Name) * 2) - 1)) Then
                sender.Image = Me.imgLstLuces.Images.Item(Integer.Parse(sender.Name) * 2)
                For i As Integer = 0 To playerNotes.Count - 1
                    If playedNotes(i).Equals(playerNotes(i)) = False Then
                        Threading.Thread.Sleep(500)
                        endGame()
                        Exit Sub
                    End If
                Next
                points += handicap
                Me.lblPoints.Text = "Points: " & Space(4 - points.ToString.Length) & points
                If playedNotes.Count = playerNotes.Count Then
                    proceso = Nothing
                    proceso = New Threading.Thread(AddressOf tocarSecuencia)
                    proceso.Start()
                    Exit Sub
                End If
            End If
        End If
    End Sub


    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem.Click, MediumToolStripMenuItem.Click, HardToolStripMenuItem.Click
        If sender.checkstate = CheckState.Unchecked Then
            If gameOn Then
                If MsgBox("This will end the current game." & Microsoft.VisualBasic.vbCrLf & "Are you sure you want to " & Microsoft.VisualBasic.vbCrLf & "change the difficulty level?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Simon Says...") = MsgBoxResult.Yes Then
                    For Each difficulty As ToolStripMenuItem In Me.DifficultyToolStripMenuItem.DropDownItems
                        difficulty.CheckState = CheckState.Unchecked
                    Next
                    sender.checkstate = CheckState.Checked
                    Select Case sender.tag
                        Case 0
                            Speed = 1000
                        Case 1
                            Speed = 500
                        Case 2
                            Speed = 100
                    End Select
                    endGame()
                Else
                    Exit Sub
                End If
            Else
                For Each difficulty As ToolStripMenuItem In Me.DifficultyToolStripMenuItem.DropDownItems
                    difficulty.CheckState = CheckState.Unchecked
                Next
                sender.checkstate = CheckState.Checked
                Select Case sender.tag
                    Case 0
                        Speed = 1000
                        handicap = 1
                    Case 1
                        Speed = 500
                        handicap = 5
                    Case 2
                        Speed = 100
                        handicap = 10
                End Select
            End If
        End If

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        juego = New System.Threading.Thread(AddressOf newGame)
        juego.Start()
    End Sub

    Private Sub newGame()
        Me.lblMensaje.Text = "New game started..."
        Threading.Thread.Sleep(1000)
        Me.lblMensaje.Text = "Ready?"
        Threading.Thread.Sleep(1000)
        Me.lblMensaje.Text = "Go!"
        tocarSecuencia()
    End Sub

    Private Sub tocarSecuencia()
        activarTeclas(False)
        Me.lblMensaje.Text = "Playing. Wait..."
        If Me.gameOn = False Then
            Me.gameOn = True
            points = 0
            Me.lblPoints.Text = "Points: " & Space(4 - points.ToString.Length) & points
        Else
            Threading.Thread.Sleep(1000)
        End If
        Me.playerNotes.Clear()
        Randomize()
        Dim numero As Integer
        numero = CInt(Int((9 * Rnd()) + 1))
        For i As Integer = 0 To playedNotes.Count - 1
            Dim nota As Integer = Integer.Parse(playedNotes(i).ToString)
            fotos(nota).Image = Me.imgLstLuces.Images.Item((nota * 2) - 1)
            posicionParaThread = nota
            proceso = New Threading.Thread(AddressOf tocarSonido)
            proceso.Start()
            Threading.Thread.Sleep(Speed)
            fotos(nota).Image = Me.imgLstLuces.Images.Item((nota * 2 + 1) - 1)
            proceso = Nothing
        Next
        fotos(numero).Image = Me.imgLstLuces.Images.Item((numero * 2) - 1)
        posicionParaThread = numero
        proceso = New Threading.Thread(AddressOf tocarSonido)
        proceso.Start()
        Threading.Thread.Sleep(Speed)
        fotos(numero).Image = Me.imgLstLuces.Images.Item((numero * 2 + 1) - 1)
        proceso = Nothing
        playedNotes.Add(numero)
        activarTeclas(True)
        Me.lblMensaje.Text = "Go!"
    End Sub


    Private Sub activarTeclas(ByVal activar As Boolean)
        For Each p As PictureBox In fotos
            If IsNothing(p) Then
                Continue For
            End If
            pictureBoxTemp = p
            Me.SetPBoxEnabled(activar)
        Next
        pictureBoxTemp = Nothing
    End Sub

    Private Sub SetPBoxEnabled(ByVal [bool] As Boolean)
        If Me.pictureBoxTemp.InvokeRequired Then
            Dim d As New SetBoolCallback(AddressOf SetPBoxEnabled)
            Me.Invoke(d, New Object() {[bool]})
        Else
            Me.pictureBoxTemp.Enabled = [bool]
        End If
    End Sub

    Public Sub endGame()
        MsgBox("Game over!" & Microsoft.VisualBasic.vbCrLf & "You made " & points & IIf(points = 1, " point.", " points."), MsgBoxStyle.ApplicationModal + MsgBoxStyle.Information, "Simon Says...")
        Me.playedNotes.Clear()
        Me.playerNotes.Clear()
        revisarScores(points)
        points = 0
        gameOn = False
        Me.lblPoints.Text = ""
        Me.lblMensaje.Text = "Press F2 to start a new game."
        activarTeclas(False)
    End Sub

    Public Sub revisarScores(ByVal points As Integer)
        Dim tempPoints As Integer = 0
        Dim tempName As String = ""
        Dim name As String = ""
        If (My.Settings.Score1 <= points) Then
            tempPoints = My.Settings.Score1
            My.Settings.Score1 = points
            points = tempPoints
            tempName = My.Settings.Player1
            If name = "" Then
                name = InputBox("Please enter your name for the record:", "Congratulations!")
            End If
            My.Settings.Player1 = name
            name = tempName
        End If
        If (My.Settings.Score2 <= points) Then
            tempPoints = My.Settings.Score2
            My.Settings.Score2 = points
            points = tempPoints
            tempName = My.Settings.Player2
            If name = "" Then
                name = InputBox("Please enter your name for the record:", "Congratulations!")
            End If
            My.Settings.Player2 = name
            name = tempName
        End If
        If (My.Settings.Score3 <= points) Then
            tempPoints = My.Settings.Score3
            My.Settings.Score3 = points
            points = tempPoints
            tempName = My.Settings.Player3
            If name = "" Then
                name = InputBox("Please enter your name for the record:", "Congratulations!")
            End If
            My.Settings.Player3 = name
            name = tempName
        End If
        If (My.Settings.Score4 <= points) Then
            tempPoints = My.Settings.Score4
            My.Settings.Score4 = points
            points = tempPoints
            tempName = My.Settings.Player4
            If name = "" Then
                name = InputBox("Please enter your name for the record:", "Congratulations!")
            End If
            My.Settings.Player4 = name
            name = tempName
        End If
        If (My.Settings.Score5 <= points) Then
            tempPoints = My.Settings.Score5
            My.Settings.Score5 = points
            points = tempPoints
            tempName = My.Settings.Player5
            If name = "" Then
                name = InputBox("Please enter your name for the record:", "Congratulations!")
            End If
            My.Settings.Player5 = name
            name = tempName
        End If
        My.Settings.Save()
    End Sub

    Private Sub tocarSonido()
        player.PlaySound(Instruments.Acoustic_Grand_Piano, 30 + (posicionParaThread * 6), Speed)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.proceso = Nothing
        Me.juego = Nothing
        Me.Close()
    End Sub

    Private Sub ScoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScoresToolStripMenuItem.Click
        My.Forms.HighScores.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.AboutBox.ShowDialog()
    End Sub
End Class