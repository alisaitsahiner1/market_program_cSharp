using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_musteri_ekle : Form
    {
        public frm_musteri_ekle()
        {
            InitializeComponent();
        }

        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        private void frm_musteri_ekle_Load(object sender, EventArgs e)
        {

        }
        //**
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand pgSqlCommand = new NpgsqlCommand("insert_musteri", pgSqlConnection))
                {
                    pgSqlCommand.CommandType = CommandType.StoredProcedure;

                    pgSqlCommand.Parameters.AddWithValue("@p_tc", tc.Text);
                    pgSqlCommand.Parameters.AddWithValue("@p_adsoyad", adsoyad.Text);
                    pgSqlCommand.Parameters.AddWithValue("@p_tel", tel.Text);
                    pgSqlCommand.Parameters.AddWithValue("@p_adres", adres.Text);
                    pgSqlCommand.Parameters.AddWithValue("@p_email", email.Text);

                    pgSqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri eklendi");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }


        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
