Imports System.ComponentModel
Imports System.Threading
Imports System.IO
Imports System.IO.Ports

Public Class Form1
    Dim myPen As New Pen(Color.Green, 2)
    Dim g As Graphics

    Dim counter As Integer = 1

    Dim dataInCount As Integer = 0

    Dim radius As Integer
    Dim x As Integer
    Dim y As Integer

    Dim j As Integer
    Dim i As Integer

    Dim RealDistance(80) As Double
    Dim FilterDistance(80) As Double
    'Dim Distance(80) As Double
    Dim Distance As Double
    Dim Angle As Double

    Dim random As New Random()

    Dim SerialPort1 As New SerialPort

    Dim strFile As String = "C:\Users\rmstw\Desktop\ToF_Data_" & DateTime.Today.ToString("dd-MM-yyyy") & "_" & Date.Now.ToString("hh-mm-ss") & ".txt"
    Dim sw As System.IO.StreamWriter

    Dim Zk As Double
    Dim Pk As Double = 0
    Dim Xk As Double
    Dim Kk As Double
    Dim xt As Double
    Dim R As Double = 10
    Dim Q As Double = 1

    Dim buff_xk(5) As Double
    Dim buff_zk(5) As Double

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

    'Private Function KalmanFilter(ByVal i As Integer, ByVal RawDis As Double, ByVal R As Double, ByVal Q As Double) As Double
    '    Zk(i) = RawDis
    '    Pk(i) = Pk(i) + Q
    '    Kk(i) = Pk(i) / (Pk(i) + R)
    '    Xk(i) = Xk(i) + (Kk(i) * (Zk(i) - Xk(i)))
    '    Pk(i) = (1 - Kk(i)) * Pk(i)

    '    Return Xk(i)
    'End Function

    Private Sub DrawDataPos(ByVal data As String, ByVal ratio As Integer)
        PictureBox2.Refresh()
        g = PictureBox2.CreateGraphics()

        Dim result As String() = data.Split(New String() {","}, StringSplitOptions.None)

        'For i = 0 To 79
        '    RealDistance(i) = Convert.ToInt32(result(i)) \ 10
        '    FilterDistance(i) = KalmanFilter(i, RealDistance(i), 10, 1)

        '    Distance(i) = (FilterDistance(i) * 2) * ratio

        '    Angle = (i * -4.5) - 360

        '    Dim Point As New Point(Convert.ToInt32(PictureBox2.Size.Width \ 2) + Distance(i) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox2.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

        '    DrawPoint(Point, g, Color.Red)
        'Next

        For i = 0 To 15
            xt = Convert.ToInt32(result(1 + (i * 5))) \ 10
            For j = 1 To 5
                Zk = Convert.ToInt32(result(j + (i * 5))) \ 10
                Pk = Pk + Q
                Kk = Pk / (Pk + R)
                Xk = Xk + (Kk * (Zk - Xk))
                Pk = (1 - Kk) * Pk

                buff_xk(j) = Xk

                Distance = (Xk * 2) * ratio

                Angle = (((j - 1) + (i * 5)) * -4.5) - 360

                Dim Point As New Point(Convert.ToInt32(PictureBox2.Size.Width \ 2) + Distance * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox2.Size.Height \ 2) + Distance * Math.Sin(Angle * Math.PI / 180))

                DrawPoint(Point, g, Color.Red)
            Next

            'For k = 1 To 5
            '    Angle = (k * -4.5) - 360

            '    Dim Point As New Point(Convert.ToInt32(PictureBox2.Size.Width \ 2) + Distance(k) * Math.Cos(Angle * Math.PI / 180), Convert.ToInt32(PictureBox2.Size.Height \ 2) + Distance(i) * Math.Sin(Angle * Math.PI / 180))

            '    DrawPoint(Point, g, Color.Red)
            'Next
        Next

        'PictureBox2.Invalidate()
    End Sub

    Private Sub ScanPort()
        CBoxCOMPort.Items.Clear()
        CBoxCOMPort.Items.AddRange(Ports.SerialPort.GetPortNames())
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

        Call ScanPort()

        CBoxBAUDRate.Items.Add("2400")
        CBoxBAUDRate.Items.Add("4800")
        CBoxBAUDRate.Items.Add("9600")
        CBoxBAUDRate.Items.Add("115200")
        CBoxBAUDRate.Items.Add("1000000")

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

    Private Sub BtnScanPORT_Click(sender As Object, e As EventArgs) Handles BtnScanPORT.Click
        Call ScanPort()
    End Sub

    Private Sub BtnOpenPORT_Click(sender As Object, e As EventArgs) Handles BtnOpenPORT.Click
        If BtnOpenPORT.Text = "Open Port" Then
            BtnOpenPORT.Text = "Close Port"
            Try
                If Not SerialPort1.IsOpen Then
                    With SerialPort1
                        .PortName = CBoxCOMPort.Text
                        .BaudRate = CBoxBAUDRate.Text
                        .Parity = IO.Ports.Parity.None
                        .DataBits = 8
                        .StopBits = IO.Ports.StopBits.Two
                        .Open()
                    End With

                    If (Not File.Exists(strFile)) Then
                        sw = File.CreateText(strFile)
                    End If

                    BackgroundWorker1.RunWorkerAsync()

                End If
            Catch ex As Exception

            End Try

        ElseIf BtnOpenPORT.Text = "Close Port" Then
            BackgroundWorker1.CancelAsync()
            BtnOpenPORT.Text = "Open Port"

            SerialPort1.Close()
            sw.Close()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim readBuffer As String

        TextBox.CheckForIllegalCrossThreadCalls = False

        Do
            'System.Threading.Thread.Sleep(10)
            Application.DoEvents()

            Try
                dataInCount += 1

                TextBox3.Text = dataInCount.ToString

                'If dataInCount = 501 Then
                '    Call BtnOpenPORT.PerformClick()
                'End If

                readBuffer = SerialPort1.ReadLine()

                Call DrawDataPos(readBuffer, counter)

                TextBox2.Text = readBuffer

                Try
                    sw.WriteLine(readBuffer)
                Catch ex As IOException
                    MessageBox.Show("Error writing to log file.")
                End Try
            Catch ex As Exception

            End Try
        Loop
    End Sub
End Class
