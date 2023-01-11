Public Class FormPlateau

    'GRAPHISME

    Private Sub PlateauPictureBox_Click(sender As Object, e As EventArgs) Handles PlateauPictureBox.Click
        Dim feuille As Bitmap = New Bitmap(plateauX, plateauY)
        Dim dessin As Graphics = Graphics.FromImage(feuille)
    End Sub

    Private Sub dessinerarbres(ByVal bmp As Bitmap)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using k As Graphics = Graphics.FromImage(bmp)

                Dim q As Pen
                q = New Pen(Brushes.DarkGreen)
                q.Width = 4

                Dim p As Pen
                p = New Pen(Brushes.DarkRed)
                p.Width = 1

                Dim t As SolidBrush
                t = New SolidBrush(Color.Green)

                Dim h As SolidBrush
                h = New SolidBrush(Color.Pink)

                Dim i As Integer
                Dim j As Integer
                Dim c As PointF
                Dim a As PointF


                For i = 0 To nbarbres - 1
                    arbres(i).rayon = 20
                    c.X = arbres(i).x - Math.Sqrt(arbres(i).rayon ^ 2)
                    c.Y = arbres(i).y - Math.Sqrt(arbres(i).rayon ^ 2)
                    g.FillEllipse(t, New RectangleF(New PointF(c.X, c.Y), New Size(2 * arbres(i).rayon, 2 * arbres(i).rayon)))
                    g.DrawEllipse(q, New RectangleF(New PointF(c.X, c.Y), New Size(2 * arbres(i).rayon, 2 * arbres(i).rayon)))
                    For j = 0 To arbres(i).nbcerises - 1
                        arbres(i).cerises(j).rayon = 5
                        a.X = arbres(i).cerises(j).x - Math.Sqrt(arbres(i).cerises(j).rayon ^ 2)
                        a.Y = arbres(i).cerises(j).y - Math.Sqrt(arbres(i).cerises(j).rayon ^ 2)
                        k.FillEllipse(h, New RectangleF(New PointF(a.X, a.Y), New Size(2 * arbres(i).cerises(j).rayon, 2 * arbres(i).cerises(j).rayon)))
                        k.DrawEllipse(p, New RectangleF(New PointF(a.X, a.Y), New Size(2 * arbres(i).cerises(j).rayon, 2 * arbres(i).cerises(j).rayon)))
                    Next
                Next

            End Using
        End Using
    End Sub

    Private Sub dessinerobstacles(ByVal bmp As Bitmap)
        Using g As Graphics = Graphics.FromImage(bmp)

            Dim b As SolidBrush
            b = New SolidBrush(Color.DarkRed)

            Dim i As Integer
            Dim c As PointF

            For i = 0 To nbobstacles - 1
                c.X = obstacles(i).x
                c.Y = obstacles(i).y
                g.FillRectangle(b, New RectangleF(New PointF(c.X, c.Y), New SizeF(35, 35)))
            Next

        End Using
    End Sub

    Private Sub dessinerboids(ByVal bmp As Bitmap)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim p As Pen
            p = New Pen(Brushes.Gray)
            p.Width = 0.5
            Dim b As SolidBrush
            b = New SolidBrush(Color.LightGoldenrodYellow)
            Dim i As Integer
            For i = 0 To nbboids - 1
                Dim Q As boid
                Q.d.x = boids(i).d.x + boids(i).acc.x
                Q.d.y = boids(i).d.y + boids(i).acc.y
                normaliser(Q.d)
                boids(i).d = Q.d
                Dim point1 = New PointF(boids(i).p.x + 10 * boids(i).d.x, boids(i).p.y + 10 * boids(i).d.y)
                Dim point2 = New PointF(boids(i).p.x + boids(i).masse * rotation(boids(i).d, -2 * PI / 3).x, boids(i).p.y + boids(i).masse * rotation(boids(i).d, -2 * PI / 3).y)
                Dim point3 = New PointF(boids(i).p.x, boids(i).p.y)
                Dim point4 = New PointF(boids(i).p.x + boids(i).masse * rotation(boids(i).d, 2 * PI / 3).x, boids(i).p.y + boids(i).masse * rotation(boids(i).d, 2 * PI / 3).y)
                Dim poly = {point1, point2, point3, point4}
                'on choisit de representer les boids plus gros en fonction de leur masse
                g.FillPolygon(b, poly)
                g.DrawPolygon(p, poly)
            Next
        End Using
    End Sub

    Private Sub dessinerrapaces(ByVal bmp As Bitmap)
        Using g As Graphics = Graphics.FromImage(bmp)

            Dim p As Pen
            p = New Pen(Brushes.Black)
            p.Width = 0.5

            Dim b As SolidBrush
            b = New SolidBrush(Color.DarkGray)

            Dim i As Integer

            For i = 0 To nbrapaces - 1
                Dim R As rapace
                R.d.x = comportementcible(rapaces(i)).x + rapaces(i).acc.x
                R.d.y = comportementcible(rapaces(i)).y + rapaces(i).acc.y
                normaliser(R.d)
                rapaces(i).d = R.d
                Dim point1 = New PointF(rapaces(i).p.x + 10 * rapaces(i).d.x, rapaces(i).p.y + 10 * rapaces(i).d.y)
                Dim point2 = New PointF(rapaces(i).p.x + rapaces(i).masse * rotation(rapaces(i).d, -2 * PI / 3).x, rapaces(i).p.y + rapaces(i).masse * rotation(rapaces(i).d, -2 * PI / 3).y)
                Dim point3 = New PointF(rapaces(i).p.x, rapaces(i).p.y)
                Dim point4 = New PointF(rapaces(i).p.x + rapaces(i).masse * rotation(rapaces(i).d, 2 * PI / 3).x, rapaces(i).p.y + rapaces(i).masse * rotation(rapaces(i).d, 2 * PI / 3).y)
                Dim poly = {point1, point2, point3, point4}
                'on choisit de representer les rapaces plus gros en fonction de leur masse

                g.FillPolygon(b, poly)
                g.DrawPolygon(p, poly)
            Next
        End Using
    End Sub


    Private Sub FormPlateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlateauPictureBox.Top = 0
        PlateauPictureBox.Left = 0
        PlateauPictureBox.Width = plateauX
        PlateauPictureBox.Height = plateauY
        Console.Show()
    End Sub

    Private Sub FormPlateau_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If PlateauPictureBox.Image IsNot Nothing Then
            PlateauPictureBox.Image.Dispose()
        End If

        Dim bmp As New Bitmap(PlateauPictureBox.Width, PlateauPictureBox.Height)
        dessinerobstacles(bmp)
        dessinerarbres(bmp)
        dessinerboids(bmp)
        dessinerrapaces(bmp)
        PlateauPictureBox.Image = bmp
    End Sub


    'FIN GRAPHISME



End Class
