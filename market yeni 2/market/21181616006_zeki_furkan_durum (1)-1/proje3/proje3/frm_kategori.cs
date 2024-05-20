using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_kategori : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        bool durum;

        public frm_kategori()
        {
            InitializeComponent();
        }

        private void kategoriKontrol()
        {
            durum = true;

            pgSqlConnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM kategoribilgileri", pgSqlConnection);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (textBox1.Text == dr["kategori"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }
            }

            pgSqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriKontrol();

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("ekle_kategori", pgSqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_kategori", textBox1.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("İşlem başarıyla gerçekleşti");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }

            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void frm_kategori_Load(object sender, EventArgs e)
        {

        }
    }
}
