﻿namespace Sohbet_Uygulaması_V2._0
{
    partial class Login
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
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.HspOlusturBtn = new System.Windows.Forms.Button();
            this.DENEME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.GirisYapBtn.Location = new System.Drawing.Point(71, 21);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(123, 32);
            this.GirisYapBtn.TabIndex = 0;
            this.GirisYapBtn.Text = "Giris Yap";
            this.GirisYapBtn.UseVisualStyleBackColor = true;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // HspOlusturBtn
            // 
            this.HspOlusturBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HspOlusturBtn.Location = new System.Drawing.Point(284, 21);
            this.HspOlusturBtn.Name = "HspOlusturBtn";
            this.HspOlusturBtn.Size = new System.Drawing.Size(128, 32);
            this.HspOlusturBtn.TabIndex = 1;
            this.HspOlusturBtn.Text = "Hesap Olustur";
            this.HspOlusturBtn.UseVisualStyleBackColor = true;
            // 
            // DENEME
            // 
            this.DENEME.Location = new System.Drawing.Point(347, 226);
            this.DENEME.Name = "DENEME";
            this.DENEME.Size = new System.Drawing.Size(75, 23);
            this.DENEME.TabIndex = 2;
            this.DENEME.Text = "DeneBakalım";
            this.DENEME.UseVisualStyleBackColor = true;
            this.DENEME.Click += new System.EventHandler(this.DENEME_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.DENEME);
            this.Controls.Add(this.HspOlusturBtn);
            this.Controls.Add(this.GirisYapBtn);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.Button HspOlusturBtn;
        private System.Windows.Forms.Button DENEME;
    }
}

