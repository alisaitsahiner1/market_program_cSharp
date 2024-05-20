namespace proje3
{
    partial class frm_Urun_listeleme
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
            lbl_miktar = new Label();
            btn_guncelle = new Button();
            txt_barkod1 = new TextBox();
            label1 = new Label();
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
            btn_sil = new Button();
            txt_barkodno_ara = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            btn_marka_guncelle = new Button();
            combo_kategori = new ComboBox();
            combo_marka = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(485, 263);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lbl_miktar
            // 
            lbl_miktar.AutoSize = true;
            lbl_miktar.Location = new Point(29, 310);
            lbl_miktar.Name = "lbl_miktar";
            lbl_miktar.Size = new Size(0, 15);
            lbl_miktar.TabIndex = 44;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(135, 306);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(75, 23);
            btn_guncelle.TabIndex = 29;
            btn_guncelle.Text = "güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // txt_barkod1
            // 
            txt_barkod1.Location = new Point(110, 84);
            txt_barkod1.Name = "txt_barkod1";
            txt_barkod1.Size = new Size(100, 23);
            txt_barkod1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 42;
            label1.Text = "barkod no";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 38;
            label4.Text = "ürün adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 39;
            label5.Text = "miktarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 37;
            label6.Text = "alış fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 261);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 36;
            label7.Text = "satış fiyatı";
            // 
            // txt_satıs1
            // 
            txt_satıs1.Location = new Point(110, 260);
            txt_satıs1.Name = "txt_satıs1";
            txt_satıs1.Size = new Size(100, 23);
            txt_satıs1.TabIndex = 31;
            // 
            // txt_alıs1
            // 
            txt_alıs1.Location = new Point(110, 231);
            txt_alıs1.Name = "txt_alıs1";
            txt_alıs1.Size = new Size(100, 23);
            txt_alıs1.TabIndex = 35;
            // 
            // txt_miktar1
            // 
            txt_miktar1.Location = new Point(110, 202);
            txt_miktar1.Name = "txt_miktar1";
            txt_miktar1.Size = new Size(100, 23);
            txt_miktar1.TabIndex = 34;
            // 
            // txt_urun1
            // 
            txt_urun1.Location = new Point(110, 173);
            txt_urun1.Name = "txt_urun1";
            txt_urun1.Size = new Size(100, 23);
            txt_urun1.TabIndex = 33;
            // 
            // txt_marka
            // 
            txt_marka.Location = new Point(110, 144);
            txt_marka.Name = "txt_marka";
            txt_marka.ReadOnly = true;
            txt_marka.Size = new Size(100, 23);
            txt_marka.TabIndex = 32;
            // 
            // txt_kategori
            // 
            txt_kategori.Location = new Point(110, 115);
            txt_kategori.Name = "txt_kategori";
            txt_kategori.ReadOnly = true;
            txt_kategori.Size = new Size(100, 23);
            txt_kategori.TabIndex = 30;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(637, 36);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(75, 23);
            btn_sil.TabIndex = 45;
            btn_sil.Text = "sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // txt_barkodno_ara
            // 
            txt_barkodno_ara.Location = new Point(518, 37);
            txt_barkodno_ara.Name = "txt_barkodno_ara";
            txt_barkodno_ara.Size = new Size(100, 23);
            txt_barkodno_ara.TabIndex = 46;
            txt_barkodno_ara.TextChanged += txt_barkodno_ara_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 40);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 47;
            label8.Text = "barkod no ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 118);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 51;
            label9.Text = "kategori";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 147);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 50;
            label10.Text = "marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 367);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 40;
            label3.Text = "marka";
            label3.Click += label3_Click;
            // 
            // btn_marka_guncelle
            // 
            btn_marka_guncelle.Location = new Point(591, 393);
            btn_marka_guncelle.Name = "btn_marka_guncelle";
            btn_marka_guncelle.Size = new Size(121, 33);
            btn_marka_guncelle.TabIndex = 52;
            btn_marka_guncelle.Text = "marka güncelle";
            btn_marka_guncelle.UseVisualStyleBackColor = true;
            btn_marka_guncelle.Click += button1_Click;
            // 
            // combo_kategori
            // 
            combo_kategori.FormattingEnabled = true;
            combo_kategori.Location = new Point(591, 335);
            combo_kategori.Name = "combo_kategori";
            combo_kategori.Size = new Size(121, 23);
            combo_kategori.TabIndex = 48;
            combo_kategori.SelectedIndexChanged += combo_kategori_SelectedIndexChanged;
            // 
            // combo_marka
            // 
            combo_marka.FormattingEnabled = true;
            combo_marka.Location = new Point(591, 364);
            combo_marka.Name = "combo_marka";
            combo_marka.Size = new Size(121, 23);
            combo_marka.TabIndex = 49;
            combo_marka.SelectedIndexChanged += combo_marka_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 338);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 41;
            label2.Text = "kategori";
            label2.Click += label2_Click;
            // 
            // frm_Urun_listeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_marka_guncelle);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(combo_marka);
            Controls.Add(combo_kategori);
            Controls.Add(label8);
            Controls.Add(txt_barkodno_ara);
            Controls.Add(btn_sil);
            Controls.Add(lbl_miktar);
            Controls.Add(btn_guncelle);
            Controls.Add(txt_barkod1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_satıs1);
            Controls.Add(txt_alıs1);
            Controls.Add(txt_miktar1);
            Controls.Add(txt_urun1);
            Controls.Add(txt_marka);
            Controls.Add(txt_kategori);
            Controls.Add(dataGridView1);
            Name = "frm_Urun_listeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ürün listeleme";
            Load += frm_Urun_listeleme_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_miktar;
        private Button btn_guncelle;
        private TextBox txt_barkod1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_satıs1;
        private TextBox txt_alıs1;
        private TextBox txt_miktar1;
        private TextBox txt_urun1;
        private TextBox txt_marka;
        private TextBox txt_kategori;
        private Button btn_sil;
        private TextBox txt_barkodno_ara;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label3;
        private Button btn_marka_guncelle;
        private ComboBox combo_kategori;
        private ComboBox combo_marka;
        private Label label2;
    }
}