using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_urun_ekle : Form
    {
        public frm_urun_ekle()
        {
            InitializeComponent();
        }

        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");
        bool durum;

        private void barkodKontrol()
        {
            durum = true;
            pgSqlConnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM urun", pgSqlConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (txt_barkod.Text == dr["barkodno"].ToString() || txt_barkod.Text == "")
                {
                    durum = false;
                }
            }

            pgSqlConnection.Close();
        }

        private void kategori_getir()
        {
            pgSqlConnection.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM kategoribilgileri", pgSqlConnection);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                combo_kategori.Items.Add(reader["kategori"].ToString());
            }

            pgSqlConnection.Close();
        }

        private void frm_urun_ekle_Load(object sender, EventArgs e)
        {
            kategori_getir();
        }

        private void combo_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_marka.Items.Clear();
            combo_marka.Text = "";
            pgSqlConnection.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM markabilgileri WHERE kategori='" + combo_kategori.SelectedItem + "'", pgSqlConnection);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                combo_marka.Items.Add(reader["marka"].ToString());
            }

            pgSqlConnection.Close();
        }
        //**
        private void button1_Click(object sender, EventArgs e)
        {
            barkodKontrol();

            if (durum == true)
            {
                try
                {
                    pgSqlConnection.Open();
                    NpgsqlCommand komut = new NpgsqlCommand("insert_product", pgSqlConnection);
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("p_barkodno", txt_barkod.Text);
                    komut.Parameters.AddWithValue("p_kategori", combo_kategori.Text);
                    komut.Parameters.AddWithValue("p_marka", combo_marka.Text);
                    komut.Parameters.AddWithValue("p_urunadi", txt_urun.Text);
                    komut.Parameters.AddWithValue("p_miktari", int.Parse(txt_miktar.Text));
                    komut.Parameters.AddWithValue("p_alisfiyati", double.Parse(txt_alıs.Text));
                    komut.Parameters.AddWithValue("p_satisfiyati", double.Parse(txt_satıs.Text));

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ürün eklendi");
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    pgSqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Böyle bir barkod no var");
            }

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }


        private void txt_barkod1_TextChanged(object sender, EventArgs e)
        {
            if (txt_barkod1.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            pgSqlConnection.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM urun WHERE barkodno LIKE '" + txt_barkod1.Text + "'", pgSqlConnection);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                txt_kategori.Text = reader["kategori"].ToString();
                txt_marka.Text = reader["marka"].ToString();
                txt_urun1.Text = reader["urunadi"].ToString();
                lbl_miktar.Text = reader["miktari"].ToString();
                txt_alıs1.Text = reader["alisfiyati"].ToString();
                txt_satıs1.Text = reader["satisfiyati"].ToString();
            }

            pgSqlConnection.Close();
        }
        //**
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand komut = new NpgsqlCommand("urun_guncelle", pgSqlConnection))
                {
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("p_barkodno", txt_barkod1.Text);
                    komut.Parameters.AddWithValue("p_miktar", int.Parse(txt_miktar1.Text));

                    komut.ExecuteNonQuery();
                }

                pgSqlConnection.Close();
                lbl_miktar.Text = "";

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

                MessageBox.Show("Var olan ürüne ekleme yapıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void combo_marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
