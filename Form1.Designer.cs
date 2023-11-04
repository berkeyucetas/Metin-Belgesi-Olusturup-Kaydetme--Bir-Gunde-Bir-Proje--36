namespace Metin_Belgesi_Oluşturup_Kaydetme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textYol = new System.Windows.Forms.TextBox();
            this.buttonYol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonAktar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textAktar = new System.Windows.Forms.TextBox();
            this.buttonVeri = new System.Windows.Forms.Button();
            this.textVeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belge Adı:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(597, 9);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(152, 44);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textAd
            // 
            this.textAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAd.Location = new System.Drawing.Point(219, 9);
            this.textAd.Multiline = true;
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(372, 44);
            this.textAd.TabIndex = 2;
            // 
            // textYol
            // 
            this.textYol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYol.Location = new System.Drawing.Point(219, 59);
            this.textYol.Multiline = true;
            this.textYol.Name = "textYol";
            this.textYol.Size = new System.Drawing.Size(372, 44);
            this.textYol.TabIndex = 5;
            // 
            // buttonYol
            // 
            this.buttonYol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYol.Location = new System.Drawing.Point(597, 59);
            this.buttonYol.Name = "buttonYol";
            this.buttonYol.Size = new System.Drawing.Size(152, 44);
            this.buttonYol.TabIndex = 4;
            this.buttonYol.Text = "Yol Seç";
            this.buttonYol.UseVisualStyleBackColor = true;
            this.buttonYol.Click += new System.EventHandler(this.buttonYol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Belge Yolu:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAktar
            // 
            this.buttonAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAktar.Location = new System.Drawing.Point(51, 117);
            this.buttonAktar.Name = "buttonAktar";
            this.buttonAktar.Size = new System.Drawing.Size(152, 44);
            this.buttonAktar.TabIndex = 6;
            this.buttonAktar.Text = "Aktar";
            this.buttonAktar.UseVisualStyleBackColor = true;
            this.buttonAktar.Click += new System.EventHandler(this.buttonAktar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aktarılan Bilgiler";
            // 
            // textAktar
            // 
            this.textAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAktar.Location = new System.Drawing.Point(12, 205);
            this.textAktar.Multiline = true;
            this.textAktar.Name = "textAktar";
            this.textAktar.Size = new System.Drawing.Size(264, 486);
            this.textAktar.TabIndex = 8;
            // 
            // buttonVeri
            // 
            this.buttonVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVeri.Location = new System.Drawing.Point(439, 117);
            this.buttonVeri.Name = "buttonVeri";
            this.buttonVeri.Size = new System.Drawing.Size(152, 44);
            this.buttonVeri.TabIndex = 9;
            this.buttonVeri.Text = "Verileri Kaydet";
            this.buttonVeri.UseVisualStyleBackColor = true;
            this.buttonVeri.Click += new System.EventHandler(this.buttonVeri_Click);
            // 
            // textVeri
            // 
            this.textVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textVeri.Location = new System.Drawing.Point(282, 205);
            this.textVeri.Multiline = true;
            this.textVeri.Name = "textVeri";
            this.textVeri.Size = new System.Drawing.Size(458, 486);
            this.textVeri.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(296, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kaydedilecek Veriler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textVeri);
            this.Controls.Add(this.buttonVeri);
            this.Controls.Add(this.textAktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAktar);
            this.Controls.Add(this.textYol);
            this.Controls.Add(this.buttonYol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textYol;
        private System.Windows.Forms.Button buttonYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonAktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAktar;
        private System.Windows.Forms.Button buttonVeri;
        private System.Windows.Forms.TextBox textVeri;
        private System.Windows.Forms.Label label4;
    }
}

