using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_Urun_listeleme : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");
        DataSet dataset = new DataSet();

        public frm_Urun_listeleme()
        {
            InitializeComponent();
        }

        private void kategori_getir()
        {
            pgSqlConnection.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from kategoribilgileri", pgSqlConnection);
            NpgsqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                combo_kategori.Items.Add(reader["kategori"].ToString());
            }

            pgSqlConnection.Close();
        }

        private void frm_Urun_listeleme_Load(object sender, EventArgs e)
        {
            urunListele();
            kategori_getir();
        }
        //**
        private void urunListele()
        {
            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("sp_urun_listele", pgSqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        dataset.Clear(); 

                        adapter.Fill(dataset, "urun");

                        dataGridView1.DataSource = dataset.Tables["urun"];
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("hata");
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_barkod1.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txt_kategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txt_marka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txt_urun1.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txt_miktar1.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txt_alıs1.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txt_satıs1.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }
        
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_barkod1.Text != "")
            {
                try
                {
                    pgSqlConnection.Open();

                    string updateQuery = "UPDATE urun SET urunadi = @urunadi, miktari = @miktari, alisfiyati = @alisfiyati, satisfiyati = @satisfiyati WHERE barkodno = @barkodno";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, pgSqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@barkodno", txt_barkod1.Text);
                        cmd.Parameters.AddWithValue("@urunadi", txt_urun1.Text);
                        cmd.Parameters.AddWithValue("@miktari", int.Parse(txt_miktar1.Text));
                        cmd.Parameters.AddWithValue("@alisfiyati", double.Parse(txt_alıs1.Text));
                        cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(txt_satıs1.Text));

                        cmd.ExecuteNonQuery();
                    }

                    pgSqlConnection.Close();

                    urunListele(); 
                    MessageBox.Show("Güncelleme yapıldı");

                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    pgSqlConnection.Close();
                }
            }
        }

        //**
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_barkod1.Text != "")
            {
                try
                {
                    pgSqlConnection.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand("update_urun", pgSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_barkodno", txt_barkod1.Text);
                    cmd.Parameters.AddWithValue("@p_kategori", combo_kategori.Text);
                    cmd.Parameters.AddWithValue("@p_marka", combo_marka.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Güncelleme yapıldı");

                    dataset.Tables["urun"].Clear();
                    urunListele(); 

                    foreach (Control item in this.Controls)
                    {
                        if (item is ComboBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    pgSqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Barkod no yazılı değil");
            }
        }


        private void combo_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_marka.Items.Clear();
            combo_marka.Text = "";

            try
            {
                pgSqlConnection.Open();
                NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM markabilgileri WHERE kategori = @kategori", pgSqlConnection);
                komut.Parameters.AddWithValue("@kategori", combo_kategori.SelectedItem.ToString());

                NpgsqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    combo_marka.Items.Add(reader["marka"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }
        //**
        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (dataset != null && dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["barkodno"].Value != null)
            {
                try
                {
                    pgSqlConnection.Open();

                    NpgsqlCommand sqlCommand = new NpgsqlCommand("delete_urun", pgSqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@p_barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());

                    sqlCommand.ExecuteNonQuery();

                    pgSqlConnection.Close();

                    if (dataset.Tables.Contains("urun"))
                    {
                        dataset.Tables["urun"].Clear();
                        urunListele();
                    }
                    else
                    {
                        MessageBox.Show("Dataset does not contain table named 'urun'.");
                    }

                    MessageBox.Show("Kayıt silindi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir satır seçili değil.");
            }
        }


        private void txt_barkodno_ara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            pgSqlConnection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("select * from urun where barkodno like '%" + txt_barkodno_ara.Text + "%' ", pgSqlConnection);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            pgSqlConnection.Close();
        }
        private void combo_marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void frm_Urun_listeleme_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
