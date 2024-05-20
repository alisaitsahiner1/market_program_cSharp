using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_marka : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");
        bool durum;

        public frm_marka()
        {
            InitializeComponent();
        }

        private void markaEngelle()
        {
            durum = true;
            pgSqlConnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori AND marka = @marka", pgSqlConnection);
            cmd.Parameters.AddWithValue("@kategori", comboBox1.Text);
            cmd.Parameters.AddWithValue("@marka", textBox1.Text);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                durum = false;
            }

            pgSqlConnection.Close();
        }
        //**
        private void button1_Click(object sender, EventArgs e)
        {
            markaEngelle();
            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("sp_EkleMarkaBilgileri", pgSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_kategori", comboBox1.Text);
                    cmd.Parameters.AddWithValue("p_marka", textBox1.Text);

                    cmd.ExecuteNonQuery();
                }

                pgSqlConnection.Close();
                MessageBox.Show("Marka eklendi");

                textBox1.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


        private void kategori_getir()
        {
            pgSqlConnection.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM kategoribilgileri", pgSqlConnection);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kategori"].ToString());
            }

            pgSqlConnection.Close();
        }

        private void frm_marka_Load(object sender, EventArgs e)
        {
            kategori_getir();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
