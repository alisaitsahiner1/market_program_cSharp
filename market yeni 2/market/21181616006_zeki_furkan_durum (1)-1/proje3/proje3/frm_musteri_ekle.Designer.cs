namespace proje3
{
    partial class frm_musteri_ekle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tc = new TextBox();
            adsoyad = new TextBox();
            tel = new TextBox();
            email = new TextBox();
            adres = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 112);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 143);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 178);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // tc
            // 
            tc.Location = new Point(156, 47);
            tc.Name = "tc";
            tc.Size = new Size(100, 23);
            tc.TabIndex = 6;
            // 
            // adsoyad
            // 
            adsoyad.Location = new Point(156, 81);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(100, 23);
            adsoyad.TabIndex = 7;
            // 
            // tel
            // 
            tel.Location = new Point(156, 112);
            tel.Name = "tel";
            tel.Size = new Size(100, 23);
            tel.TabIndex = 8;
            // 
            // email
            // 
            email.Location = new Point(156, 179);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 9;
            // 
            // adres
            // 
            adres.Location = new Point(156, 143);
            adres.Name = "adres";
            adres.Size = new Size(100, 23);
            adres.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(181, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frm_musteri_ekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(380, 349);
            Controls.Add(button1);
            Controls.Add(adres);
            Controls.Add(email);
            Controls.Add(tel);
            Controls.Add(adsoyad);
            Controls.Add(tc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_musteri_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ekleme sayfası";
            Load += frm_musteri_ekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tc;
        private TextBox adsoyad;
        private TextBox tel;
        private TextBox email;
        private TextBox adres;
        private Button button1;
    }
}