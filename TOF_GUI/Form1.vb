Imports System.ComponentModel

Public Class Form1
    Dim myPen As New Pen(Color.Green, 2)
    Dim g As Graphics

    Dim counter As Integer = 1

    Dim radius As Integer
    Dim x As Integer
    Dim y As Integer

    Dim j As Integer
    Dim i As Integer

    Dim RealDistance(80) As Double
    Dim Distance(80) As Double
    Dim Angle As Double

    Dim random As New Random()

    'Private Sub DrawCircle(ByVal gr As Graphics, ByVal ratio As Integer)

    '    Dim radius As Integer = 100
    '    Dim x As Integer
    '    Dim y As Integer

    '    Dim i As Integer
    '    Dim j As Integer = 10

    '    For i = 20 To 900 Step 40
    '        radius = i * ratio

    '        x = Convert.ToInt32(PictureBox1.Size.Width \ 2) - radius
    '        y = Convert.ToInt32(PictureBox1.Size.Height \ 2) - radius

    '        gr.DrawEllipse(myPen, x, y,
    '                               radius * 2, radius * 2)

    '        If j >= 100 Then
    '            'Label Horizontal
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 32, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius) - 1, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

    '            'Label Vertical
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, y - 17)
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
    '        Else
    '            'Label Horizontal
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 21, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius), Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

    '            'Label Vertical
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, y - 17)
    '            g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
    '        End If
    '        j += 20
    '    Next

    '    Dim RealDistance(80) As Double
    '    Dim Distance(80) As Double
    '    Dim Angle As Double

    '    For i = 0 To 79
    '        RealDistance(i) = 90

    '        Distance(i) = (RealDistance(i) * 2)

    '        Angle = (i * 4.5) - 360

    '        Dim Point As New Point(Convert.ToInt32(PictureBox1.Size.Width \ 2) + Distance(i) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox1.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

    '        DrawPoint(Point, gr, Color.Red)
    '    Next

    '    'PictureBox1.Invalidate()
    '    'myPen.Dispose()

    '    gr.Dispose()
    'End Sub

    Private Sub DrawCircle(ByVal gr As Graphics, ByVal ratio As Integer)

        radius = 100
        j = 10

        Dim thmb = New Bitmap(CInt(PictureBox1.Width), CInt(PictureBox1.Height))
        Dim graph As Graphics = Graphics.FromImage(thmb)

        'graph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        'graph.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        For i = 20 To 900 Step 40
            radius = i * ratio

            x = Convert.ToInt32(PictureBox1.Size.Width \ 2) - radius
            y = Convert.ToInt32(PictureBox1.Size.Height \ 2) - radius

            graph.DrawEllipse(myPen, x, y,
                                   radius * 2, radius * 2)

            If j >= 100 Then
                'Label Horizontal
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 32, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius) - 1, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

                'Label Vertical
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, y - 17)
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
            Else
                'Label Horizontal
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 21, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius), Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

                'Label Vertical
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, y - 17)
                graph.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
            End If
            j += 20
        Next

        'Dim RealDistance(80) As Double
        'Dim Distance(80) As Double
        'Dim Angle As Double

        'For i = 0 To 79
        '    RealDistance(i) = 90

        '    Distance(i) = (RealDistance(i) * 2)

        '    Angle = (i * 4.5) - 360

        '    Dim Point As New Point(Convert.ToInt32(PictureBox1.Size.Width \ 2) + Distance(i) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox1.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

        '    DrawPoint(Point, graph, Color.Red)
        'Next

        PictureBox1.Image = thmb
        'PictureBox1.Invalidate()
        'myPen.Dispose()

        gr.Dispose()
    End Sub

    Private Sub DrawPoint(ByVal pt As Point, ByVal G As Graphics, ByVal clr As Color)
        Dim rc As New Rectangle(pt, New Size(1, 1))
        rc.Inflate(3, 3)
        Using brsh As New SolidBrush(clr)
            G.FillEllipse(brsh, rc)
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Size = New Size(Me.Width, Me.Height)
        PictureBox1.Image = Nothing

        g = PictureBox1.CreateGraphics()

        DrawCircle(g, 1)

        PictureBox2.Size = New Size(Me.Width, Me.Height)
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Parent = PictureBox1

        SetStyle(ControlStyles.DoubleBuffer, True)
        Me.DoubleBuffered = True

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox1.Size = New Size(Me.Width, Me.Height)
        PictureBox1.Image = Nothing

        g = PictureBox1.CreateGraphics()
        DrawCircle(g, counter)

        PictureBox2.Size = New Size(Me.Width, Me.Height)
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        g = PictureBox1.CreateGraphics()

        If counter >= 1 Then
            If e.Delta > 0 Then
                counter += 1
                DrawCircle(g, counter)
                TextBox1.Text = counter
            Else
                If counter = 1 Then
                    counter += 1
                    DrawCircle(g, counter)
                    TextBox1.Text = counter
                Else
                    counter -= 1
                    DrawCircle(g, counter)
                    TextBox1.Text = counter
                End If
            End If
        Else
            counter = 1
            DrawCircle(g, counter)
            TextBox1.Text = counter
        End If
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        g = PictureBox2.CreateGraphics()

        For i = 0 To 79
            RealDistance(i) = Random.Next(10, 200)
            'RealDistance(i) = 50

            Distance(i) = (RealDistance(i) * 2)

            Angle = (i * 4.5) - 360

            Dim Point As New Point(Convert.ToInt32(PictureBox2.Size.Width \ 2) + Distance(i) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox2.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

            DrawPoint(Point, g, Color.Red)
        Next

        'bg.Dispose()
        PictureBox2.Invalidate()

        'Threading.Thread.Sleep(50)
    End Sub

End Class
