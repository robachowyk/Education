Public Class Console

    'GRAPHISME

    Private Sub btncreerboids_Click(sender As Object, e As EventArgs) Handles btncreerboids.Click
        Dim n As Integer
        n = Val(hsnbboids.Value)
        creerboids(n)
        FormPlateau.Refresh()
    End Sub

    Private Sub btncreerarbres_Click(sender As Object, e As EventArgs) Handles btncreerarbres.Click
        Dim n As Integer
        n = Val(hsnbarbres.Value)
        creerarbres(n)
        FormPlateau.Refresh()
    End Sub

    Private Sub btncreerobstacles_Click(sender As Object, e As EventArgs) Handles btncreerobstacles.Click
        Dim n As Integer
        n = Val(hsnbobstacles.Value)
        creerobstacles(n)
        FormPlateau.Refresh()
    End Sub

    Private Sub btnrapaces_Click(sender As Object, e As EventArgs) Handles btnrapaces.Click
        Dim n As Integer
        n = Val(hsnbrapaces.Value)
        Dim v As Double
        v = Val(hsvrapaces.Value)
        creerrapaces(n, v)
        FormPlateau.Refresh()
    End Sub

    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormPlateau.Show()
    End Sub



    'FIN GRAPHISME

    Private Sub Timer_pas_Tick(sender As Object, e As EventArgs) Handles Timer_pas.Tick

        Dim i As Integer
        For i = 0 To nbboids - 1
            boids(i).acc.x = (Val(hssep.Value) * separation(boids(i)).x + Val(hsco.Value) * cohesion(boids(i)).x + Val(hsali.Value) * alignement(boids(i)).x + Val(hsrep.Value) * repulsion(boids(i)).x) / boids(i).masse
            boids(i).acc.y = (Val(hssep.Value) * separation(boids(i)).y + Val(hsco.Value) * cohesion(boids(i)).y + Val(hsali.Value) * alignement(boids(i)).y + Val(hsrep.Value) * repulsion(boids(i)).y) / boids(i).masse

            Dim B As boid
            B.d.x = boids(i).d.x + boids(i).acc.x
            B.d.y = boids(i).d.y + boids(i).acc.y
            normaliser(B.d)
            boids(i).d = B.d

            boids(i).vitesse = vitesse(boids(i))
            boids(i).p = mouvement(boids(i))
            Dim k As Integer
            For k = 0 To nbarbres - 1
                mange(boids(i), arbres(k))
            Next
            mort_repas(boids(i))

            lblboidsmorts.Text = Str(boidsmorts)
            lblnbboids.Text = Str(hsnbboids.Value)
            lblboids.Text = Str(hsnbboids.Value - boidsmorts)
        Next

        Dim j As Integer
        For j = 0 To nbrapaces - 1
            rapaces(j).acc.x = (Val(hssep.Value) * separationR(rapaces(j)).x + Val(hsrep.Value) * repulsionR(rapaces(j)).x + Val(hsali.Value) * alignementR(rapaces(j)).x) / rapaces(j).masse
            rapaces(j).acc.y = (Val(hssep.Value) * separationR(rapaces(j)).y + Val(hsrep.Value) * repulsionR(rapaces(j)).y + Val(hsali.Value) * alignementR(rapaces(j)).y) / rapaces(j).masse

            Dim R As rapace
            R.d.x = comportementcible(rapaces(j)).x + rapaces(j).acc.x
            R.d.y = comportementcible(rapaces(j)).y + rapaces(j).acc.y
            normaliser(R.d)
            rapaces(j).d = R.d
            rapaces(j).p = mouvementR(rapaces(j))
            mangeboid(rapaces(j), boids)

            lblboidsmorts.Text = Str(boidsmorts)
            lblnbboids.Text = Str(hsnbboids.Value)
            lblboids.Text = Str(hsnbboids.Value - boidsmorts)
        Next


        FormPlateau.Refresh()
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        Timer_pas.Interval = 5
        Timer_pas.Enabled = True
        Timer_pas.Start()
    End Sub


End Class