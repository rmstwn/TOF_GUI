Imports System.ComponentModel

Public Class Form1
    Dim myPen As New Pen(Color.Green, 2)
    Dim g As Graphics

    Private Img1 As Image = Image.FromFile("D:\Kuliah\ROISC\TOF Sensor\GUI\projects\TOF_GUI\TOF_GUI\Resources\clear.png")

    Dim counter As Integer = 1

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

        Dim radius As Integer = 100
        Dim x As Integer
        Dim y As Integer

        Dim i As Integer
        Dim j As Integer = 10

        Dim thmb = New Bitmap(CInt(PictureBox1.Width), CInt(PictureBox1.Height))
        Dim graph As Graphics = Graphics.FromImage(thmb)

        graph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        graph.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

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

        Dim RealDistance(80) As Double
        Dim Distance(80) As Double
        Dim Angle As Double

        For i = 0 To 79
            RealDistance(i) = 90

            Distance(i) = (RealDistance(i) * 2)

            Angle = (i * 4.5) - 360

            Dim Point As New Point(Convert.ToInt32(PictureBox1.Size.Width \ 2) + Distance(i) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox1.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

            DrawPoint(Point, graph, Color.Red)
        Next

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
        PictureBox1.Refresh()

        g = PictureBox1.CreateGraphics()

        DrawCircle(g, 1)

        Panel1.BackColor = Color.Transparent
        Panel1.Parent = PictureBox1
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox1.Size = New Size(Me.Width, Me.Height)
        PictureBox1.Image = Nothing

        PictureBox1.Refresh()

        g = PictureBox1.CreateGraphics()

        DrawCircle(g, counter)

    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        PictureBox1.Refresh()

        g = PictureBox1.CreateGraphics()

        If counter >= 1 Then
            If e.Delta > 0 Then
                counter += 1
                g = PictureBox1.CreateGraphics()
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
End Class
