namespace proje3
{
    partial class frm_ana_sayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txt_tel = new TextBox();
            txt_ad = new TextBox();
            txt_tc = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_top_fiyat = new TextBox();
            txt_satıs_fiyat = new TextBox();
            txt_miktar = new TextBox();
            txt_ürün_ad = new TextBox();
            txt_barkod = new TextBox();
            btn_sil = new Button();
            btn_satıs_iptal = new Button();
            btn_ekle = new Button();
            btn_satıs_yap = new Button();
            label10 = new Label();
            lblGenelToplam = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(455, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_tel);
            groupBox1.Controls.Add(txt_ad);
            groupBox1.Controls.Add(txt_tc);
            groupBox1.Location = new Point(18, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri işlemleri ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 77);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 11;
            label8.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 45);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Ad Soyad";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 19);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 9;
            label6.Text = "TC";
            label6.Click += label6_Click;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(94, 74);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(100, 23);
            txt_tel.TabIndex = 4;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(94, 45);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(100, 23);
            txt_ad.TabIndex = 5;
            txt_ad.TextChanged += textBox3_TextChanged;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(94, 16);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(100, 23);
            txt_tc.TabIndex = 6;
            txt_tc.TextChanged += txt_tc_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_top_fiyat);
            groupBox2.Controls.Add(txt_satıs_fiyat);
            groupBox2.Controls.Add(txt_miktar);
            groupBox2.Controls.Add(txt_ürün_ad);
            groupBox2.Controls.Add(txt_barkod);
            groupBox2.Location = new Point(18, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 182);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün işlemleri ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 141);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 12;
            label5.Text = "toplam fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 112);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "satış fiyatı";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 80);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "ürün adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 8;
            label1.Text = "Barkod No";
            // 
            // txt_top_fiyat
            // 
            txt_top_fiyat.Location = new Point(94, 138);
            txt_top_fiyat.Name = "txt_top_fiyat";
            txt_top_fiyat.Size = new Size(100, 23);
            txt_top_fiyat.TabIndex = 7;
            // 
            // txt_satıs_fiyat
            // 
            txt_satıs_fiyat.Location = new Point(94, 109);
            txt_satıs_fiyat.Name = "txt_satıs_fiyat";
            txt_satıs_fiyat.Size = new Size(100, 23);
            txt_satıs_fiyat.TabIndex = 6;
            // 
            // txt_miktar
            // 
            txt_miktar.Location = new Point(94, 80);
            txt_miktar.Name = "txt_miktar";
            txt_miktar.Size = new Size(100, 23);
            txt_miktar.TabIndex = 5;
            txt_miktar.Text = "1";
            txt_miktar.TextAlign = HorizontalAlignment.Center;
            txt_miktar.TextChanged += txt_miktar_TextChanged;
            // 
            // txt_ürün_ad
            // 
            txt_ürün_ad.Location = new Point(94, 51);
            txt_ürün_ad.Name = "txt_ürün_ad";
            txt_ürün_ad.Size = new Size(100, 23);
            txt_ürün_ad.TabIndex = 4;
            // 
            // txt_barkod
            // 
            txt_barkod.Location = new Point(94, 22);
            txt_barkod.Name = "txt_barkod";
            txt_barkod.Size = new Size(100, 23);
            txt_barkod.TabIndex = 3;
            txt_barkod.TextChanged += txt_barkod_TextChanged;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(685, 106);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(75, 23);
            btn_sil.TabIndex = 3;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_satıs_iptal
            // 
            btn_satıs_iptal.Location = new Point(685, 144);
            btn_satıs_iptal.Name = "btn_satıs_iptal";
            btn_satıs_iptal.Size = new Size(75, 23);
            btn_satıs_iptal.TabIndex = 4;
            btn_satıs_iptal.Text = "Satış iptal";
            btn_satıs_iptal.UseVisualStyleBackColor = true;
            btn_satıs_iptal.Click += btn_satıs_iptal_Click;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(224, 396);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(75, 23);
            btn_ekle.TabIndex = 5;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += button3_Click;
            // 
            // btn_satıs_yap
            // 
            btn_satıs_yap.Location = new Point(591, 396);
            btn_satıs_yap.Name = "btn_satıs_yap";
            btn_satıs_yap.Size = new Size(75, 23);
            btn_satıs_yap.TabIndex = 6;
            btn_satıs_yap.Text = "Satıs yap";
            btn_satıs_yap.UseVisualStyleBackColor = true;
            btn_satıs_yap.Click += btn_satıs_yap_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 400);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 12;
            label10.Text = "genel toplam ";
            label10.Click += label10_Click;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(537, 400);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 15);
            lblGenelToplam.TabIndex = 13;
            lblGenelToplam.Click += lblGenelToplam_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(-6, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 86);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(644, 28);
            button2.Name = "button2";
            button2.Size = new Size(95, 36);
            button2.TabIndex = 21;
            button2.Text = "Kategori";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(543, 28);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 20;
            button1.Text = "Marka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(442, 28);
            button9.Name = "button9";
            button9.Size = new Size(95, 36);
            button9.TabIndex = 19;
            button9.Text = "Satışları Listele";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(347, 28);
            button8.Name = "button8";
            button8.Size = new Size(89, 36);
            button8.TabIndex = 18;
            button8.Text = "Ürün Listele";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(253, 28);
            button7.Name = "button7";
            button7.Size = new Size(88, 36);
            button7.TabIndex = 17;
            button7.Text = "Ürün Ekle ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(146, 28);
            button6.Name = "button6";
            button6.Size = new Size(101, 36);
            button6.TabIndex = 16;
            button6.Text = "Müşteri Listele";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(53, 28);
            button5.Name = "button5";
            button5.Size = new Size(87, 36);
            button5.TabIndex = 15;
            button5.Text = "Müşteri Ekle";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblGenelToplam);
            Controls.Add(label10);
            Controls.Add(btn_satıs_yap);
            Controls.Add(btn_ekle);
            Controls.Add(btn_satıs_iptal);
            Controls.Add(btn_sil);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "satis sayfası ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txt_tc;
        private GroupBox groupBox2;
        private TextBox txt_barkod;
        private TextBox txt_tel;
        private TextBox txt_ad;
        private TextBox txt_miktar;
        private TextBox txt_ürün_ad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_top_fiyat;
        private TextBox txt_satıs_fiyat;
        private Label label8;
        private Button btn_sil;
        private Button btn_satıs_iptal;
        private Button btn_ekle;
        private Button btn_satıs_yap;
        private Label label10;
        private Label lblGenelToplam;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
    }
}