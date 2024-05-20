using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_musteri_listele : Form
    {
        public frm_musteri_listele()
        {
            InitializeComponent();
        }

        // PostgreSQL bağlantı bilgileri
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        DataSet dataSet = new DataSet();

        private void frm_musteri_listele_Load(object sender, EventArgs e)
        {
            kayitGoster();
        }

        private void kayitGoster()
        {
            pgSqlConnection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM musteri", pgSqlConnection);
            adapter.Fill(dataSet, "musteri");
            dataGridView1.DataSource = dataSet.Tables["musteri"];
            pgSqlConnection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            adsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            tel.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            adres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }
        //**
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand pgSqlCommand = new NpgsqlCommand("update_musteri", pgSqlConnection);
                pgSqlCommand.CommandType = CommandType.StoredProcedure;

                pgSqlCommand.Parameters.AddWithValue("p_tc", tc.Text);
                pgSqlCommand.Parameters.AddWithValue("p_adsoyad", adsoyad.Text);
                pgSqlCommand.Parameters.AddWithValue("p_tel", tel.Text);
                pgSqlCommand.Parameters.AddWithValue("p_adres", adres.Text);
                pgSqlCommand.Parameters.AddWithValue("p_email", email.Text);

                pgSqlCommand.ExecuteNonQuery();

                MessageBox.Show("Müşteri kaydı güncellendi");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
                dataSet.Tables["musteri"].Clear();
                kayitGoster();
            }
        }

        //**
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand pgSqlCommand = new NpgsqlCommand("delete_musteri", pgSqlConnection))
                {
                    pgSqlCommand.CommandType = CommandType.StoredProcedure;
                    pgSqlCommand.Parameters.AddWithValue("@tc_param", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());

                    pgSqlCommand.ExecuteNonQuery();
                }

                pgSqlConnection.Close();
                dataSet.Tables["musteri"].Clear();
                kayitGoster();
                MessageBox.Show("Kayıt silindi");
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



        private void txt_tc_ara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            pgSqlConnection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM musteri WHERE tc LIKE '%" + txt_tc_ara.Text + "%'", pgSqlConnection);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            pgSqlConnection.Close();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }
    }
}
