using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        private const int BufferSize = 8192;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_FilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private async void btn_Encrypt_Click(object sender, EventArgs e)
        {
            await ProcessFileAsync(isEncrypting: true);
        }

        private async Task ProcessFileAsync(bool isEncrypting)
        {
            string filePath = tb_FilePath.Text;
            string key = tb_Key.Text;

            if (string.IsNullOrWhiteSpace(filePath) || string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Please select a file and enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await Task.Run(() => ProcessFile(filePath, key));

                MessageBox.Show($"Encryption completed successfully for:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the operation:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessFile(string filePath, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            string tempFile = Path.GetTempFileName();

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                long totalBytes = inputStream.Length;
                long processedBytes = 0;

                ProcessAndWriteData(inputStream, tempStream, keyBytes, totalBytes, ref processedBytes);
            }

            File.Copy(tempFile, filePath, overwrite: true);
            File.Delete(tempFile);
        }

        private void ProcessAndWriteData(FileStream inputStream, FileStream tempStream, byte[] keyBytes, long totalBytes, ref long processedBytes)
        {
            byte[] buffer = new byte[BufferSize];
            int bytesRead;

            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                EncryptBuffer(buffer, bytesRead, keyBytes);
                tempStream.Write(buffer, 0, bytesRead);

                processedBytes += bytesRead;
                ReportProgress(processedBytes, totalBytes);
            }
        }

        private void EncryptBuffer(byte[] buffer, int bytesRead, byte[] keyBytes)
        {
            for (int i = 0; i < bytesRead; i++)
            {
                buffer[i] ^= keyBytes[i % keyBytes.Length];
            }
        }

        private void ReportProgress(long processedBytes, long totalBytes)
        {
            int progressPercentage = (int)((processedBytes * 100) / totalBytes);
        }
    }
}
