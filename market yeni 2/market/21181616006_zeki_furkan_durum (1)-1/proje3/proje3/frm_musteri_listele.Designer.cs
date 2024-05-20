namespace proje3
{
    partial class frm_musteri_listele
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
            dataGridView1 = new DataGridView();
            btn_guncelle = new Button();
            adres = new TextBox();
            email = new TextBox();
            tel = new TextBox();
            adsoyad = new TextBox();
            tc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_sil = new Button();
            tc_ara = new Label();
            txt_tc_ara = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(531, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(132, 263);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(75, 23);
            btn_guncelle.TabIndex = 22;
            btn_guncelle.Text = "güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // adres
            // 
            adres.Location = new Point(107, 181);
            adres.Name = "adres";
            adres.Size = new Size(100, 23);
            adres.TabIndex = 21;
            // 
            // email
            // 
            email.Location = new Point(107, 217);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 20;
            // 
            // tel
            // 
            tel.Location = new Point(107, 150);
            tel.Name = "tel";
            tel.Size = new Size(100, 23);
            tel.TabIndex = 19;
            // 
            // adsoyad
            // 
            adsoyad.Location = new Point(107, 119);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(100, 23);
            adsoyad.TabIndex = 18;
            // 
            // tc
            // 
            tc.Location = new Point(107, 85);
            tc.Name = "tc";
            tc.Size = new Size(100, 23);
            tc.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 216);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 16;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 181);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 15;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 150);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 119);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 88);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 12;
            label1.Text = "TC";
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(132, 311);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(75, 23);
            btn_sil.TabIndex = 23;
            btn_sil.Text = "sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // tc_ara
            // 
            tc_ara.AutoSize = true;
            tc_ara.Location = new Point(495, 33);
            tc_ara.Name = "tc_ara";
            tc_ara.Size = new Size(41, 15);
            tc_ara.TabIndex = 25;
            tc_ara.Text = "TC Ara";
            tc_ara.Click += label6_Click;
            // 
            // txt_tc_ara
            // 
            txt_tc_ara.Location = new Point(557, 33);
            txt_tc_ara.Name = "txt_tc_ara";
            txt_tc_ara.Size = new Size(100, 23);
            txt_tc_ara.TabIndex = 26;
            txt_tc_ara.TextChanged += txt_tc_ara_TextChanged;
            // 
            // frm_musteri_listele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_tc_ara);
            Controls.Add(tc_ara);
            Controls.Add(btn_sil);
            Controls.Add(btn_guncelle);
            Controls.Add(adres);
            Controls.Add(email);
            Controls.Add(tel);
            Controls.Add(adsoyad);
            Controls.Add(tc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frm_musteri_listele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "müşteri listeleme sayfası";
            Load += frm_musteri_listele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_guncelle;
        private TextBox adres;
        private TextBox email;
        private TextBox tel;
        private TextBox adsoyad;
        private TextBox tc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_sil;
        private Label tc_ara;
        private TextBox txt_tc_ara;
    }
}