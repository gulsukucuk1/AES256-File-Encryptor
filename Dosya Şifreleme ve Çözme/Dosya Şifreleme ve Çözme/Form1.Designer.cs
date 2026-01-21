namespace Dosya_Şifreleme_ve_Çözme
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sifre = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSelectEncrypt = new System.Windows.Forms.Button();
            this.btnSelectDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sifre.Location = new System.Drawing.Point(30, 30);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(139, 20);
            this.sifre.TabIndex = 0;
            this.sifre.Text = "Güvenlik Anahtarı:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(175, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(245, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // btnSelectEncrypt
            // 
            this.btnSelectEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnSelectEncrypt.Location = new System.Drawing.Point(34, 80);
            this.btnSelectEncrypt.Name = "btnSelectEncrypt";
            this.btnSelectEncrypt.Size = new System.Drawing.Size(185, 45);
            this.btnSelectEncrypt.TabIndex = 2;
            this.btnSelectEncrypt.Text = "DOSYA ŞİFRELE";
            this.btnSelectEncrypt.UseVisualStyleBackColor = false;
            this.btnSelectEncrypt.Click += new System.EventHandler(this.BtnSelectEncrypt_Click);
            // 
            // btnSelectDecrypt
            // 
            this.btnSelectDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSelectDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnSelectDecrypt.Location = new System.Drawing.Point(235, 80);
            this.btnSelectDecrypt.Name = "btnSelectDecrypt";
            this.btnSelectDecrypt.Size = new System.Drawing.Size(185, 45);
            this.btnSelectDecrypt.TabIndex = 3;
            this.btnSelectDecrypt.Text = "ŞİFRE ÇÖZ";
            this.btnSelectDecrypt.UseVisualStyleBackColor = false;
            this.btnSelectDecrypt.Click += new System.EventHandler(this.BtnSelectDecrypt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 150);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 15);
            this.progressBar1.TabIndex = 4;
            // 
            // lstLogs
            // 
            this.lstLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lstLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLogs.Font = new System.Drawing.Font("Consolas", 8F);
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.ItemHeight = 15;
            this.lstLogs.Location = new System.Drawing.Point(34, 185);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(386, 105);
            this.lstLogs.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(30, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Durum: Bekleniyor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 340);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSelectDecrypt);
            this.Controls.Add(this.btnSelectEncrypt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoLock v1.0 - Profesyonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSelectEncrypt;
        private System.Windows.Forms.Button btnSelectDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Label lblStatus;
    }
}