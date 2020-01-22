using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WFA_WebClient
{
    public partial class Form1 : Form
    {

        WebClient webClient;
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ////this ok!
            //using (var client = new WebClient())
            //{
            //    client.DownloadFile("https://drive.google.com/uc?id=1rs1eSmNsO2BcQkyWWo3Ym-7YhixQcrMH&export=download", "a.png");
            //}

            ////this ok!
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("https://drive.google.com/uc?id=1DRBa1MWz8jEf-1cX_t9zyXvODgcuEczx&export=download"),
                    // Param2 = Path to save
                    @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Debug\test.png"
                );
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            }


        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void startDownload()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Linlijian/SDMST/master/DBConnectionBase/bin.rar"), @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Debug\test.rar");

            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                label2.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                label2.Text = "Completed";
            });
        }

        private void btnDownload2_Click(object sender, EventArgs e)
        {
            startDownload();
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("http://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar1.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        private void btnDownload3_Click(object sender, EventArgs e)
        {
            DownloadFile("https://raw.githubusercontent.com/Linlijian/SDMST/master/DBConnectionBase/bin.rar", @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Debug\A.rar");
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            string startPath = @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Debug";
            string zipPath = @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Release\tesaat.zip";
            string extractPath = @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Release\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath, System.IO.Compression.CompressionLevel.Fastest, true);

            ZipFile.ExtractToDirectory(zipPath, extractPath);

            //    SevenZipBase.SetLibraryPath(Path.Combine(
            //Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory,
            //"7za.dll"));

            //string dll = @"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Debug\x64\7z.dll";
            //SevenZipCompressor.SetLibraryPath(dll);
            //SevenZipCompressor compressor = new SevenZipCompressor();
            //compressor.EncryptHeaders = true;
            //compressor.CompressFilesEncrypted(zipPath, "aaa", extractPath);
        }

        private void btnZipPW_Click(object sender, EventArgs e)
        {
            //ZipFile.OpenRead(@"E:\WindownFormApplication\WFA-WebClient\WFA-WebClient\bin\Release\tesaat.zip");
            //using ()
            //{
            //    // add this map file into the "images" directory in the zip archive
            //    ZipFile.AddFile("c:\\images\\personal\\7440-N49th.png", "images");
            //    // add the report into a different directory in the archive
            //    zip.AddFile("c:\\Reports\\2008-Regional-Sales-Report.pdf", "files");
            //    zip.AddFile("ReadMe.txt");
            //    zip.Save("MyZipFile.zip");
            //}
        }
    }
}

