<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CBoxCOMPort = New System.Windows.Forms.ComboBox()
        Me.BtnOpenPORT = New System.Windows.Forms.Button()
        Me.CBoxBAUDRate = New System.Windows.Forms.ComboBox()
        Me.BtnScanPORT = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1345, 814)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 31)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1345, 814)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'CBoxCOMPort
        '
        Me.CBoxCOMPort.FormattingEnabled = True
        Me.CBoxCOMPort.Location = New System.Drawing.Point(15, 70)
        Me.CBoxCOMPort.Margin = New System.Windows.Forms.Padding(4)
        Me.CBoxCOMPort.Name = "CBoxCOMPort"
        Me.CBoxCOMPort.Size = New System.Drawing.Size(155, 33)
        Me.CBoxCOMPort.TabIndex = 3
        '
        'BtnOpenPORT
        '
        Me.BtnOpenPORT.Location = New System.Drawing.Point(15, 179)
        Me.BtnOpenPORT.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOpenPORT.Name = "BtnOpenPORT"
        Me.BtnOpenPORT.Size = New System.Drawing.Size(118, 36)
        Me.BtnOpenPORT.TabIndex = 4
        Me.BtnOpenPORT.Text = "Open Port"
        Me.BtnOpenPORT.UseVisualStyleBackColor = True
        '
        'CBoxBAUDRate
        '
        Me.CBoxBAUDRate.FormattingEnabled = True
        Me.CBoxBAUDRate.Location = New System.Drawing.Point(15, 125)
        Me.CBoxBAUDRate.Margin = New System.Windows.Forms.Padding(4)
        Me.CBoxBAUDRate.Name = "CBoxBAUDRate"
        Me.CBoxBAUDRate.Size = New System.Drawing.Size(155, 33)
        Me.CBoxBAUDRate.TabIndex = 5
        '
        'BtnScanPORT
        '
        Me.BtnScanPORT.Location = New System.Drawing.Point(179, 69)
        Me.BtnScanPORT.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnScanPORT.Name = "BtnScanPORT"
        Me.BtnScanPORT.Size = New System.Drawing.Size(118, 36)
        Me.BtnScanPORT.TabIndex = 6
        Me.BtnScanPORT.Text = "Scan Port"
        Me.BtnScanPORT.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 13)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1005, 31)
        Me.TextBox2.TabIndex = 7
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 810)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BtnScanPORT)
        Me.Controls.Add(Me.CBoxBAUDRate)
        Me.Controls.Add(Me.BtnOpenPORT)
        Me.Controls.Add(Me.CBoxCOMPort)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "TOF GUI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CBoxCOMPort As ComboBox
    Friend WithEvents BtnOpenPORT As Button
    Friend WithEvents CBoxBAUDRate As ComboBox
    Friend WithEvents BtnScanPORT As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
