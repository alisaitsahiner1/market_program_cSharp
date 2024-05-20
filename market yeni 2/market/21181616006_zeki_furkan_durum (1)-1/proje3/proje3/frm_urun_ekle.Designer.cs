namespace proje3
{
    partial class frm_urun_ekle
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txt_satıs = new TextBox();
            txt_alıs = new TextBox();
            txt_miktar = new TextBox();
            txt_urun = new TextBox();
            combo_marka = new ComboBox();
            combo_kategori = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txt_barkod = new TextBox();
            groupBox2 = new GroupBox();
            lbl_miktar = new Label();
            button2 = new Button();
            txt_barkod1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_satıs1 = new TextBox();
            txt_alıs1 = new TextBox();
            txt_miktar1 = new TextBox();
            txt_urun1 = new TextBox();
            txt_marka = new TextBox();
            txt_kategori = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_satıs);
            groupBox1.Controls.Add(txt_alıs);
            groupBox1.Controls.Add(txt_miktar);
            groupBox1.Controls.Add(txt_urun);
            groupBox1.Controls.Add(combo_marka);
            groupBox1.Controls.Add(combo_kategori);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_barkod);
            groupBox1.Location = new Point(78, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 339);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "yeni ürün";
            // 
            // button1
            // 
            button1.Location = new Point(137, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_satıs
            // 
            txt_satıs.Location = new Point(112, 248);
            txt_satıs.Name = "txt_satıs";
            txt_satıs.Size = new Size(100, 23);
            txt_satıs.TabIndex = 25;
            // 
            // txt_alıs
            // 
            txt_alıs.Location = new Point(112, 219);
            txt_alıs.Name = "txt_alıs";
            txt_alıs.Size = new Size(100, 23);
            txt_alıs.TabIndex = 24;
            // 
            // txt_miktar
            // 
            txt_miktar.Location = new Point(112, 192);
            txt_miktar.Name = "txt_miktar";
            txt_miktar.Size = new Size(100, 23);
            txt_miktar.TabIndex = 23;
            // 
            // txt_urun
            // 
            txt_urun.Location = new Point(112, 161);
            txt_urun.Name = "txt_urun";
            txt_urun.Size = new Size(100, 23);
            txt_urun.TabIndex = 22;
            // 
            // combo_marka
            // 
            combo_marka.FormattingEnabled = true;
            combo_marka.Location = new Point(112, 132);
            combo_marka.Name = "combo_marka";
            combo_marka.Size = new Size(100, 23);
            combo_marka.TabIndex = 21;
            combo_marka.SelectedIndexChanged += combo_marka_SelectedIndexChanged;
            // 
            // combo_kategori
            // 
            combo_kategori.FormattingEnabled = true;
            combo_kategori.Location = new Point(112, 103);
            combo_kategori.Name = "combo_kategori";
            combo_kategori.Size = new Size(100, 23);
            combo_kategori.TabIndex = 20;
            combo_kategori.SelectedIndexChanged += combo_kategori_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 79);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 19;
            label14.Text = "barkod no";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 108);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 18;
            label13.Text = "kategori";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 137);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 17;
            label12.Text = "marka";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 166);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 16;
            label11.Text = "ürün adı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 195);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 16;
            label10.Text = "miktarı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 224);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 15;
            label9.Text = "alış fiyatı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 253);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 14;
            label8.Text = "satış fiyatı";
            // 
            // txt_barkod
            // 
            txt_barkod.Location = new Point(112, 74);
            txt_barkod.Name = "txt_barkod";
            txt_barkod.Size = new Size(100, 23);
            txt_barkod.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_miktar);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txt_barkod1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_satıs1);
            groupBox2.Controls.Add(txt_alıs1);
            groupBox2.Controls.Add(txt_miktar1);
            groupBox2.Controls.Add(txt_urun1);
            groupBox2.Controls.Add(txt_marka);
            groupBox2.Controls.Add(txt_kategori);
            groupBox2.Location = new Point(456, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 339);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "var olan ürün";
            // 
            // lbl_miktar
            // 
            lbl_miktar.AutoSize = true;
            lbl_miktar.Location = new Point(46, 300);
            lbl_miktar.Name = "lbl_miktar";
            lbl_miktar.Size = new Size(0, 15);
            lbl_miktar.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(152, 296);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_barkod1
            // 
            txt_barkod1.Location = new Point(127, 74);
            txt_barkod1.Name = "txt_barkod1";
            txt_barkod1.Size = new Size(100, 23);
            txt_barkod1.TabIndex = 27;
            txt_barkod1.TextChanged += txt_barkod1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 77);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 26;
            label1.Text = "barkod no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 25;
            label2.Text = "kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 135);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 24;
            label3.Text = "marka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 164);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 22;
            label4.Text = "ürün adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 193);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 23;
            label5.Text = "miktarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 222);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 21;
            label6.Text = "alış fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 251);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 20;
            label7.Text = "satış fiyatı";
            // 
            // txt_satıs1
            // 
            txt_satıs1.Location = new Point(127, 250);
            txt_satıs1.Name = "txt_satıs1";
            txt_satıs1.Size = new Size(100, 23);
            txt_satıs1.TabIndex = 7;
            // 
            // txt_alıs1
            // 
            txt_alıs1.Location = new Point(127, 221);
            txt_alıs1.Name = "txt_alıs1";
            txt_alıs1.Size = new Size(100, 23);
            txt_alıs1.TabIndex = 11;
            // 
            // txt_miktar1
            // 
            txt_miktar1.Location = new Point(127, 192);
            txt_miktar1.Name = "txt_miktar1";
            txt_miktar1.Size = new Size(100, 23);
            txt_miktar1.TabIndex = 10;
            // 
            // txt_urun1
            // 
            txt_urun1.Location = new Point(127, 163);
            txt_urun1.Name = "txt_urun1";
            txt_urun1.Size = new Size(100, 23);
            txt_urun1.TabIndex = 9;
            // 
            // txt_marka
            // 
            txt_marka.Location = new Point(127, 134);
            txt_marka.Name = "txt_marka";
            txt_marka.Size = new Size(100, 23);
            txt_marka.TabIndex = 8;
            // 
            // txt_kategori
            // 
            txt_kategori.Location = new Point(127, 105);
            txt_kategori.Name = "txt_kategori";
            txt_kategori.Size = new Size(100, 23);
            txt_kategori.TabIndex = 6;
            // 
            // frm_urun_ekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frm_urun_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ürün ekleme sayfası";
            Load += frm_urun_ekle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txt_barkod;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox8;
        private TextBox txt_satıs1;
        private TextBox txt_alıs1;
        private TextBox txt_miktar1;
        private TextBox txt_urun1;
        private TextBox txt_marka;
        private TextBox txt_kategori;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private ComboBox combo_kategori;
        private TextBox txt_barkod1;
        private TextBox txt_satıs;
        private TextBox txt_alıs;
        private TextBox txt_miktar;
        private TextBox txt_urun;
        private ComboBox combo_marka;
        private Label lbl_miktar;
    }
}