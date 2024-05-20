using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_musteri_listele_giris : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        public frm_musteri_listele_giris()
        {
            InitializeComponent();
        }


        private void frm_musteri_listele_giris_Load(object sender, EventArgs e)
        {
            ListeleMusteri();
        }

        //**
        private void ListeleMusteri()
        {
            try
            {
                pgSqlConnection.Open();

                NpgsqlDataAdapter pgSqlDataAdapter = new NpgsqlDataAdapter("SELECT * FROM musteri_giris", pgSqlConnection);
                DataTable dt = new DataTable();
                pgSqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }



    }
}
