using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Şifreleme_ve_Çözme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddLog(string message)
        {
            lstLogs.Items.Add($"[{DateTime.Now:HH:mm:ss}] {message}");
            lstLogs.SelectedIndex = lstLogs.Items.Count - 1;
        }

        private async Task ProcessFile(string inputFile, string password, bool isEncrypt)
        {
            string outputFile = isEncrypt ? inputFile + ".enc" : inputFile.Replace(".enc", "_dec");
            byte[] salt = Encoding.UTF8.GetBytes("PRO_SALT_2026");

            try
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                lblStatus.Text = isEncrypt ? "Şifreleniyor..." : "Çözülüyor...";

                await Task.Run(() =>
                {
                    using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                    {
                        aes.KeySize = 256;
                        aes.BlockSize = 128;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        var keyGen = new Rfc2898DeriveBytes(password, salt, 2000);
                        aes.Key = keyGen.GetBytes(32);

                        if (isEncrypt)
                        {
                            aes.GenerateIV();
                            using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                            {
                                fsOut.Write(aes.IV, 0, aes.IV.Length);
                                using (CryptoStream cs = new CryptoStream(fsOut, aes.CreateEncryptor(), CryptoStreamMode.Write))
                                using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                                {
                                    fsIn.CopyTo(cs);
                                }
                            }
                        }
                        else
                        {
                            using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                            {
                                byte[] iv = new byte[16];
                                fsIn.Read(iv, 0, 16);
                                aes.IV = iv;
                                using (CryptoStream cs = new CryptoStream(fsIn, aes.CreateDecryptor(), CryptoStreamMode.Read))
                                using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                                {
                                    cs.CopyTo(fsOut);
                                }
                            }
                        }
                    }
                });

                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
                lblStatus.Text = "İşlem Tamamlandı.";
                AddLog((isEncrypt ? "Şifrelendi: " : "Çözüldü: ") + Path.GetFileName(inputFile));
                MessageBox.Show("İşlem başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                lblStatus.Text = "Hata oluştu.";
                AddLog("HATA: " + ex.Message);
                MessageBox.Show("Bir hata oluştu: Şifre yanlış olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSelectEncrypt_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 4) { MessageBox.Show("Güvenlik için en az 4 karakter girin."); return; }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                await ProcessFile(openFileDialog1.FileName, txtPassword.Text, true);
            }
        }

        private async void BtnSelectDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)) { return; }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                await ProcessFile(openFileDialog1.FileName, txtPassword.Text, false);
            }
        }
    }
}