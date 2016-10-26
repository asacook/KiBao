Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Define array of pits
        Dim PlayerX(15) As Label
        Dim PlayerY(15) As Label

        'Some Pit Properties
        Dim xBottomPos As New Point(32, 28)
        Dim xTopPos As New Point(32, 58)
        Dim yTopPos As New Point(32, 200)
        Dim yBottomPos As New Point(32, 230)
        Dim labelSize As New Size(45, 13)

        'Player X's pits
        placePits(PlayerX, xBottomPos, labelSize, 0, 7)
        placePits(PlayerX, xTopPos, labelSize, 8, 15)

        'Player Y's pits
        placePits(PlayerY, yTopPos, labelSize, 0, 7)
        placePits(PlayerY, yBottomPos, labelSize, 8, 15)


    End Sub


    Private Sub placePits(ByVal playerPitArray, ByVal loc, ByVal size, ByVal start, ByVal fin)
        For a As Integer = 0 To 7
            playerPitArray(a) = New Label
            playerPitArray(a).Location = loc
            playerPitArray(a).Size = size
            playerPitArray(a).Text = 0
            Me.Controls.Add(playerPitArray(a))
            loc.X = loc.X + 80
        Next

    End Sub


End Class
