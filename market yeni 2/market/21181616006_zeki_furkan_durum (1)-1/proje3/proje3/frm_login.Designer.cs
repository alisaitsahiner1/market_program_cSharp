namespace proje3
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.btn_kayitOl1 = new System.Windows.Forms.Button();
            this.btn_adminSil = new System.Windows.Forms.Button();
            this.btn_musteriSil = new System.Windows.Forms.Button();
            this.btn_adminGuncelle = new System.Windows.Forms.Button();
            this.btn_musteriGuncelle = new System.Windows.Forms.Button();
            this.btn_adminListele = new System.Windows.Forms.Button();
            this.btn_musteriListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARKET PROGRAMINA HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(291, 92);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(125, 26);
            this.txt_kullaniciAdi.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sifre.Location = new System.Drawing.Point(291, 136);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(125, 26);
            this.txt_sifre.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(276, 186);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(78, 50);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Giriş";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kayitOl.Location = new System.Drawing.Point(220, 258);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(84, 50);
            this.btn_kayitOl.TabIndex = 6;
            this.btn_kayitOl.Text = "Admin Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // btn_kayitOl1
            // 
            this.btn_kayitOl1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kayitOl1.Location = new System.Drawing.Point(331, 258);
            this.btn_kayitOl1.Name = "btn_kayitOl1";
            this.btn_kayitOl1.Size = new System.Drawing.Size(85, 50);
            this.btn_kayitOl1.TabIndex = 7;
            this.btn_kayitOl1.Text = "Müşteri Kayıt Ol";
            this.btn_kayitOl1.UseVisualStyleBackColor = true;
            this.btn_kayitOl1.Click += new System.EventHandler(this.btn_kayitOl1_Click);
            // 
            // btn_adminSil
            // 
            this.btn_adminSil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminSil.Location = new System.Drawing.Point(220, 324);
            this.btn_adminSil.Name = "btn_adminSil";
            this.btn_adminSil.Size = new System.Drawing.Size(84, 50);
            this.btn_adminSil.TabIndex = 8;
            this.btn_adminSil.Text = "Admin Sil";
            this.btn_adminSil.UseVisualStyleBackColor = true;
            this.btn_adminSil.Click += new System.EventHandler(this.btn_adminSil_Click);
            // 
            // btn_musteriSil
            // 
            this.btn_musteriSil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_musteriSil.Location = new System.Drawing.Point(332, 324);
            this.btn_musteriSil.Name = "btn_musteriSil";
            this.btn_musteriSil.Size = new System.Drawing.Size(84, 50);
            this.btn_musteriSil.TabIndex = 9;
            this.btn_musteriSil.Text = "Müşteri Sil";
            this.btn_musteriSil.UseVisualStyleBackColor = true;
            this.btn_musteriSil.Click += new System.EventHandler(this.btn_musteriSil_Click);
            // 
            // btn_adminGuncelle
            // 
            this.btn_adminGuncelle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminGuncelle.Location = new System.Drawing.Point(220, 389);
            this.btn_adminGuncelle.Name = "btn_adminGuncelle";
            this.btn_adminGuncelle.Size = new System.Drawing.Size(84, 50);
            this.btn_adminGuncelle.TabIndex = 10;
            this.btn_adminGuncelle.Text = "Admin Güncelle";
            this.btn_adminGuncelle.UseVisualStyleBackColor = true;
            this.btn_adminGuncelle.Click += new System.EventHandler(this.btn_adminGuncelle_Click);
            // 
            // btn_musteriGuncelle
            // 
            this.btn_musteriGuncelle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_musteriGuncelle.Location = new System.Drawing.Point(332, 389);
            this.btn_musteriGuncelle.Name = "btn_musteriGuncelle";
            this.btn_musteriGuncelle.Size = new System.Drawing.Size(84, 50);
            this.btn_musteriGuncelle.TabIndex = 11;
            this.btn_musteriGuncelle.Text = "Müşteri Güncelle";
            this.btn_musteriGuncelle.UseVisualStyleBackColor = true;
            this.btn_musteriGuncelle.Click += new System.EventHandler(this.btn_musteriGuncelle_Click);
            // 
            // btn_adminListele
            // 
            this.btn_adminListele.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminListele.Location = new System.Drawing.Point(220, 454);
            this.btn_adminListele.Name = "btn_adminListele";
            this.btn_adminListele.Size = new System.Drawing.Size(84, 50);
            this.btn_adminListele.TabIndex = 12;
            this.btn_adminListele.Text = "Admin Listele";
            this.btn_adminListele.UseVisualStyleBackColor = true;
            this.btn_adminListele.Click += new System.EventHandler(this.btn_adminListele_Click);
            // 
            // btn_musteriListele
            // 
            this.btn_musteriListele.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_musteriListele.Location = new System.Drawing.Point(332, 454);
            this.btn_musteriListele.Name = "btn_musteriListele";
            this.btn_musteriListele.Size = new System.Drawing.Size(84, 50);
            this.btn_musteriListele.TabIndex = 13;
            this.btn_musteriListele.Text = "Müşteri Listele";
            this.btn_musteriListele.UseVisualStyleBackColor = true;
            this.btn_musteriListele.Click += new System.EventHandler(this.btn_musteriListele_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 511);
            this.Controls.Add(this.btn_musteriListele);
            this.Controls.Add(this.btn_adminListele);
            this.Controls.Add(this.btn_musteriGuncelle);
            this.Controls.Add(this.btn_adminGuncelle);
            this.Controls.Add(this.btn_musteriSil);
            this.Controls.Add(this.btn_adminSil);
            this.Controls.Add(this.btn_kayitOl1);
            this.Controls.Add(this.btn_kayitOl);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_kullaniciAdi;
        private TextBox txt_sifre;
        private Button btn_login;
        private Button btn_kayitOl;
        private Button btn_kayitOl1;
        private Button btn_adminSil;
        private Button btn_musteriSil;
        private Button btn_adminGuncelle;
        private Button btn_musteriGuncelle;
        private Button btn_adminListele;
        private Button btn_musteriListele;
    }
}