using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_ana_sayfa : Form
    {
       public frm_ana_sayfa()
        {
            InitializeComponent();
        }

        // NpgsqlConnection kullanarak SqlConnection'ý deðiþtiriyoruz
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        DataSet ds = new DataSet();

        private bool isMusteri = false; // Müþteri giriþi kontrolü


        private void sepetListele()
        {
            try
            {
                if (pgSqlConnection.State != ConnectionState.Open)
                {
                    pgSqlConnection.Open();
                }

                NpgsqlDataAdapter pgSqlDataAdapter = new NpgsqlDataAdapter("select * from sepet", pgSqlConnection);
                ds.Clear(); // DataSet'i temizle
                pgSqlDataAdapter.Fill(ds, "sepet");
                dataGridView1.DataSource = ds.Tables["sepet"];
                //dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false; // Ýlk sütunu gizle
                //dataGridView1.Columns[2].Visible = false; // Ýkinci sütunu gizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            finally
            {
                if (pgSqlConnection.State == ConnectionState.Open)
                {
                    pgSqlConnection.Close();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        bool durum;
        private void barkodKontrol()
        {
            durum = true;

            try
            {
                if (pgSqlConnection.State == ConnectionState.Closed)
                {
                    pgSqlConnection.Open();
                }

                NpgsqlCommand pgSqlCommand = new NpgsqlCommand("SELECT * FROM sepet", pgSqlConnection);
                NpgsqlDataReader reader = pgSqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    if (txt_barkod.Text == reader["barkodno"].ToString())
                    {
                        durum = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            finally
            {
                if (pgSqlConnection.State == ConnectionState.Open)
                {
                    pgSqlConnection.Close();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                barkodKontrol();

                if (durum)
                {
                    pgSqlConnection.Open();

                    using (NpgsqlCommand pgSqlCommand = new NpgsqlCommand("INSERT INTO sepet(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyat, tarih) VALUES(@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyat, @tarih) RETURNING sepetid", pgSqlConnection))
                    {
                        pgSqlCommand.Parameters.AddWithValue("@tc", txt_tc.Text);
                        pgSqlCommand.Parameters.AddWithValue("@adsoyad", txt_ad.Text);
                        pgSqlCommand.Parameters.AddWithValue("@telefon", txt_tel.Text);
                        pgSqlCommand.Parameters.AddWithValue("@barkodno", txt_barkod.Text);
                        pgSqlCommand.Parameters.AddWithValue("@urunadi", txt_ürün_ad.Text);
                        pgSqlCommand.Parameters.AddWithValue("@miktari", int.Parse(txt_miktar.Text));
                        pgSqlCommand.Parameters.AddWithValue("@satisfiyati", double.Parse(txt_satýs_fiyat.Text));
                        pgSqlCommand.Parameters.AddWithValue("@toplamfiyat", double.Parse(txt_top_fiyat.Text));
                        pgSqlCommand.Parameters.AddWithValue("@tarih", DateTime.Now);

                        // Yeni eklenen kaydýn sepetid'sini al
                        int sepetId = Convert.ToInt32(pgSqlCommand.ExecuteScalar());
                    }

                    pgSqlConnection.Close();
                }
                else
                {
                    pgSqlConnection.Open();

                    using (NpgsqlCommand pgSqlCommand1 = new NpgsqlCommand("UPDATE sepet SET miktari = miktari + @miktar WHERE barkodno = @barkodno", pgSqlConnection))
                    {
                        pgSqlCommand1.Parameters.AddWithValue("@miktar", int.Parse(txt_miktar.Text));
                        pgSqlCommand1.Parameters.AddWithValue("@barkodno", txt_barkod.Text);
                        pgSqlCommand1.ExecuteNonQuery();
                    }

                    using (NpgsqlCommand pgSqlCommand2 = new NpgsqlCommand("UPDATE sepet SET toplamfiyat = miktari * satisfiyati WHERE barkodno = @barkodno", pgSqlConnection))
                    {
                        pgSqlCommand2.Parameters.AddWithValue("@barkodno", txt_barkod.Text);
                        pgSqlCommand2.ExecuteNonQuery();
                    }

                    pgSqlConnection.Close();
                }

                txt_miktar.Text = "1";
                ds.Tables["sepet"].Clear();
                sepetListele();
                hesapla();

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox && item != txt_miktar)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            frm_musteri_ekle ekle = new frm_musteri_ekle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_musteri_listele listele = new frm_musteri_listele();
            listele.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            frm_urun_ekle listele = new frm_urun_ekle();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_kategori kategori = new frm_kategori();
            kategori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_marka marka = new frm_marka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Urun_listeleme listeleme = new frm_Urun_listeleme();
            listeleme.ShowDialog();

        }
        private void hesapla()
        {
            try
            {
                using (NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market"))
                {
                    pgSqlConnection.Open();
                    NpgsqlCommand pgCmd = new NpgsqlCommand("SELECT sum(toplamfiyat) FROM sepet", pgSqlConnection);
                    object result = pgCmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblGenelToplam.Text = result.ToString() + "TL";
                    }
                    else
                    {
                        lblGenelToplam.Text = "0TL";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama hatasý: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            if (txt_tc.Text == "")
            {
                txt_ad.Text = "";
                txt_tel.Text = "";
                return;
            }

            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand pgCmd = new NpgsqlCommand("SELECT * FROM musteri WHERE tc = @tc", pgSqlConnection))
                {
                    pgCmd.Parameters.AddWithValue("@tc", txt_tc.Text);

                    using (NpgsqlDataReader reader = pgCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt_ad.Text = reader["adsoyad"].ToString();
                            txt_tel.Text = reader["tel"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }



        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {
            temizle();

            try
            {
                pgSqlConnection.Open();

                using (NpgsqlCommand pgCmd = new NpgsqlCommand("SELECT * FROM urun WHERE barkodno = @barkod", pgSqlConnection))
                {
                    pgCmd.Parameters.AddWithValue("@barkod", txt_barkod.Text);

                    using (NpgsqlDataReader reader = pgCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt_ürün_ad.Text = reader["urunadi"].ToString();
                            txt_satýs_fiyat.Text = reader["satisfiyati"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }


        private void temizle()
        {
            if (txt_barkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txt_miktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void txt_miktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_top_fiyat.Text = (double.Parse(txt_miktar.Text) * double.Parse(txt_satýs_fiyat.Text)).ToString();

            }
            catch (Exception)
            {
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (pgSqlConnection.State == ConnectionState.Closed)
                {
                    pgSqlConnection.Open();
                }

                using (NpgsqlCommand pgCmd = new NpgsqlCommand("DELETE FROM sepet WHERE barkodno = @barkodno", pgSqlConnection))
                {
                    pgCmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                    pgCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ürün sepetten çýkarýldý");
                ds.Tables["sepet"].Clear();
                sepetListele();
                hesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajý: " + ex.Message + "\n\nStackTrace: " + ex.StackTrace);
            }
            finally
            {
                if (pgSqlConnection.State == ConnectionState.Open)
                {
                    pgSqlConnection.Close();
                }
            }
        }


        private void btn_satýs_iptal_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market"))
                {
                    pgSqlConnection.Open();

                    using (NpgsqlCommand pgCmd = new NpgsqlCommand("DELETE FROM sepet", pgSqlConnection))
                    {
                        pgCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Satýþ iptal edildi");
                    ds.Tables["sepet"].Clear();
                    sepetListele();
                    hesapla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            frm_satis_listele listele = new frm_satis_listele();
            listele.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGenelToplam_Click(object sender, EventArgs e)
        {

        }

        private void btn_satýs_yap_Click(object sender, EventArgs e)
        {
            try
            {
                pgSqlConnection.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    using (NpgsqlCommand pgCmd = new NpgsqlCommand("INSERT INTO satis(tc, adsoyad, telefon, barkodno, urunadi, miktari, satisfiyati, toplamfiyat, tarih) " +
                                              "VALUES (@tc, @adsoyad, @telefon, @barkodno, @urunadi, @miktari, @satisfiyati, @toplamfiyat, @tarih)", pgSqlConnection))
                    {
                        pgCmd.Parameters.AddWithValue("@tc", txt_tc.Text);
                        pgCmd.Parameters.AddWithValue("@adsoyad", txt_ad.Text);
                        pgCmd.Parameters.AddWithValue("@telefon", txt_tel.Text);
                        pgCmd.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                        pgCmd.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                        pgCmd.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                        pgCmd.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                        pgCmd.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                        pgCmd.Parameters.AddWithValue("@tarih", DateTime.Now.Date); // Sadece tarih kýsmýný kullan

                        pgCmd.ExecuteNonQuery();
                    }


                    using (NpgsqlCommand pgCmd2 = new NpgsqlCommand("UPDATE urun SET miktari = miktari - @miktar WHERE barkodno = @barkodno", pgSqlConnection))
                    {
                        pgCmd2.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                        pgCmd2.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());

                        pgCmd2.ExecuteNonQuery();
                    }
                }

                using (NpgsqlCommand pgCmd3 = new NpgsqlCommand("DELETE FROM sepet", pgSqlConnection))
                {
                    pgCmd3.ExecuteNonQuery();
                }

                MessageBox.Show("Satýþ tamamlandý");
                ds.Tables["sepet"].Clear();
                sepetListele();
                hesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            finally
            {
                pgSqlConnection.Close();
            }
        }

        public void SetMusteriHaklari()
        {
            isMusteri = true;

            // Kullanýlabilirliði kýsýtlamak istediðiniz kontrolleri belirtin
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

    }
}