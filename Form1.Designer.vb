Namespace URLHIVE
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            HOSTBYTES = New Windows.Forms.ListBox()
            progressBar1 = New Windows.Forms.ProgressBar()
            label1 = New Windows.Forms.Label()
            pictureBox1 = New Windows.Forms.PictureBox()
            label2 = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            pictureBox3 = New Windows.Forms.PictureBox()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' HOSTBYTES
            ' 
            HOSTBYTES.BackColor = Drawing.SystemColors.InactiveCaptionText
            HOSTBYTES.Font = New Drawing.Font("Felix Titling", 13.8F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            HOSTBYTES.ForeColor = Drawing.Color.FromArgb(192, 0, 0)
            HOSTBYTES.FormattingEnabled = True
            HOSTBYTES.ItemHeight = 27
            HOSTBYTES.Location = New Drawing.Point(11, 162)
            HOSTBYTES.Name = "HOSTBYTES"
            HOSTBYTES.Size = New Drawing.Size(214, 31)
            HOSTBYTES.TabIndex = 0
            HOSTBYTES.Tag = "Download"
            ' 
            ' progressBar1
            ' 
            progressBar1.Location = New Drawing.Point(11, 199)
            progressBar1.Name = "progressBar1"
            progressBar1.Size = New Drawing.Size(214, 20)
            progressBar1.TabIndex = 1
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Copperplate Gothic Bold", 19.8F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.FromArgb(192, 0, 0)
            label1.Location = New Drawing.Point(11, 235)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(0, 37)
            label1.TabIndex = 2
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(231, 162)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(59, 57)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 3
            pictureBox1.TabStop = False
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Microsoft Sans Serif", 10.8F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.ForeColor = Drawing.Color.FromArgb(192, 0, 0)
            label2.Location = New Drawing.Point(7, 11)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 22)
            label2.TabIndex = 4
            ' 
            ' pictureBox2
            ' 
            pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Drawing.Image)
            pictureBox2.Location = New Drawing.Point(14, 55)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(385, 101)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox2.TabIndex = 5
            pictureBox2.TabStop = False
            ' 
            ' pictureBox3
            ' 
            pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), Drawing.Image)
            pictureBox3.Location = New Drawing.Point(340, 162)
            pictureBox3.Name = "pictureBox3"
            pictureBox3.Size = New Drawing.Size(59, 57)
            pictureBox3.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox3.TabIndex = 6
            pictureBox3.TabStop = False
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8F, 16F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.SystemColors.ActiveCaptionText
            ClientSize = New Drawing.Size(411, 279)
            ControlBox = False
            Controls.Add(pictureBox3)
            Controls.Add(pictureBox2)
            Controls.Add(label2)
            Controls.Add(pictureBox1)
            Controls.Add(label1)
            Controls.Add(progressBar1)
            Controls.Add(HOSTBYTES)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Form1"
            ShowIcon = False
            ShowInTaskbar = False
            Text = "URL_HIVE"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox3, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private HOSTBYTES As Windows.Forms.ListBox
        Private progressBar1 As Windows.Forms.ProgressBar
        Private label1 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private label2 As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private pictureBox3 As Windows.Forms.PictureBox
    End Class
End Namespace
