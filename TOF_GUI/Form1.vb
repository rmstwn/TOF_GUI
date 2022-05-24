Imports System.ComponentModel

Public Class Form1
    Dim myPen As New Pen(Color.Green, 2)
    Dim g As Graphics

    Dim counter As Integer = 1

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox1.Size = New Size(Me.Width, Me.Height)
        PictureBox1.Image = Nothing

        PictureBox1.Refresh()

        g = PictureBox1.CreateGraphics()

        DrawCircle(g, counter)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Size = New Size(Me.Width, Me.Height)

        PictureBox1.Image = Nothing
        PictureBox1.Refresh()

        g = PictureBox1.CreateGraphics()

        DrawCircle(g, 1)

    End Sub

    Private Sub DrawCircle(ByVal gr As Graphics, ByVal ratio As Integer)

        Dim radius As Integer = 100
        Dim x As Integer
        Dim y As Integer

        Dim i As Integer
        Dim j As Integer = 10

        For i = 20 To 900 Step 25
            radius = i * ratio

            x = Convert.ToInt32(PictureBox1.Size.Width \ 2) - radius
            y = Convert.ToInt32(PictureBox1.Size.Height \ 2) - radius

            gr.DrawEllipse(myPen, x, y,
                                   radius * 2, radius * 2)

            If j >= 100 Then
                'Label Horizontal
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 32, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius) - 1, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

                'Label Vertical
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, y - 17)
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 16, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
            Else
                'Label Horizontal
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, x - 21, Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, (Convert.ToInt32(PictureBox1.Size.Width \ 2) + radius), Convert.ToInt32(PictureBox1.Size.Height \ 2) - 10)

                'Label Vertical
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, y - 17)
                g.DrawString(Convert.ToString(j), New Font("Arial", 11), Brushes.Green, Convert.ToInt32(PictureBox1.Size.Width \ 2) - 11, Convert.ToInt32(PictureBox1.Size.Height \ 2) + radius)
            End If

            j += 20

        Next

        'PictureBox1.Invalidate()
        'myPen.Dispose()

        gr.Dispose()
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
