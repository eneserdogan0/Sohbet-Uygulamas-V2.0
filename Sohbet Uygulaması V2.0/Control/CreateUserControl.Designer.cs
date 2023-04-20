namespace Sohbet_Uygulaması_V2._0.Control
{
    partial class CreateUserControl
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdiTB2 = new System.Windows.Forms.TextBox();
            this.SifreTB2 = new System.Windows.Forms.TextBox();
            this.HesapOlusturBtn = new System.Windows.Forms.Button();
            this.SifreOnayTB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GösterCB2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // KullaniciAdiTB2
            // 
            this.KullaniciAdiTB2.Location = new System.Drawing.Point(224, 61);
            this.KullaniciAdiTB2.Name = "KullaniciAdiTB2";
            this.KullaniciAdiTB2.Size = new System.Drawing.Size(124, 20);
            this.KullaniciAdiTB2.TabIndex = 2;
            // 
            // SifreTB2
            // 
            this.SifreTB2.Location = new System.Drawing.Point(224, 107);
            this.SifreTB2.Name = "SifreTB2";
            this.SifreTB2.Size = new System.Drawing.Size(124, 20);
            this.SifreTB2.TabIndex = 3;
            // 
            // HesapOlusturBtn
            // 
            this.HesapOlusturBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HesapOlusturBtn.Location = new System.Drawing.Point(224, 176);
            this.HesapOlusturBtn.Name = "HesapOlusturBtn";
            this.HesapOlusturBtn.Size = new System.Drawing.Size(124, 23);
            this.HesapOlusturBtn.TabIndex = 4;
            this.HesapOlusturBtn.Text = "Hesap Oluştur";
            this.HesapOlusturBtn.UseVisualStyleBackColor = true;
            // 
            // SifreOnayTB2
            // 
            this.SifreOnayTB2.Location = new System.Drawing.Point(224, 133);
            this.SifreOnayTB2.Name = "SifreOnayTB2";
            this.SifreOnayTB2.Size = new System.Drawing.Size(124, 20);
            this.SifreOnayTB2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar";
            // 
            // GösterCB2
            // 
            this.GösterCB2.AutoSize = true;
            this.GösterCB2.Location = new System.Drawing.Point(364, 122);
            this.GösterCB2.Name = "GösterCB2";
            this.GösterCB2.Size = new System.Drawing.Size(57, 17);
            this.GösterCB2.TabIndex = 7;
            this.GösterCB2.Text = "Göster";
            this.GösterCB2.UseVisualStyleBackColor = true;
            // 
            // CreateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GösterCB2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreOnayTB2);
            this.Controls.Add(this.HesapOlusturBtn);
            this.Controls.Add(this.SifreTB2);
            this.Controls.Add(this.KullaniciAdiTB2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserControl";
            this.Size = new System.Drawing.Size(550, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdiTB2;
        private System.Windows.Forms.TextBox SifreTB2;
        private System.Windows.Forms.Button HesapOlusturBtn;
        private System.Windows.Forms.TextBox SifreOnayTB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox GösterCB2;
    }
}
