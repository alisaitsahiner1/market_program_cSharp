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
    public partial class frm_login : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            if (AdminGiris(kullaniciAdi, sifre))
            {
                frm_ana_sayfa anaSayfa = new frm_ana_sayfa();
                anaSayfa.Show();
            }
            else if (MusteriGiris(kullaniciAdi, sifre))
            {
                frm_ana_sayfa anaSayfa = new frm_ana_sayfa();
                anaSayfa.SetMusteriHaklari();  //BURADA MÜŞTERİYE KISIT GETİRLECEK METOT GELECEK
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private bool AdminGiris(string kullaniciAdi, string sifre)
        {
            pgSqlConnection.Open();
            NpgsqlCommand pgSqlCommand = new NpgsqlCommand("SELECT * FROM admin_giris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre", pgSqlConnection);
            pgSqlCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
            pgSqlCommand.Parameters.AddWithValue("@sifre", sifre);
            NpgsqlDataReader reader = pgSqlCommand.ExecuteReader();

            bool isAdmin = reader.HasRows;
            pgSqlConnection.Close();

            return isAdmin;
        }

        

        private bool MusteriGiris(string kullaniciAdi, string sifre)
        {
            pgSqlConnection.Open();
            NpgsqlCommand pgSqlCommand = new NpgsqlCommand("SELECT * FROM musteri_giris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre", pgSqlConnection);
            pgSqlCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
            pgSqlCommand.Parameters.AddWithValue("@sifre", sifre);
            NpgsqlDataReader reader = pgSqlCommand.ExecuteReader();

            bool isMusteri = reader.HasRows;
            pgSqlConnection.Close();

            return isMusteri;
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand kontrolCommand = new NpgsqlCommand("SELECT COUNT(*) FROM admin_giris WHERE kullaniciadi = @kullaniciadi", pgSqlConnection);
                kontrolCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                int kullaniciSayisi = Convert.ToInt32(kontrolCommand.ExecuteScalar());

                if (kullaniciSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen farklı bir kullanıcı adı seçin.");
                    return;
                }

                // Yeni kullanıcı ekle
                NpgsqlCommand eklemeCommand = new NpgsqlCommand("INSERT INTO admin_giris (kullaniciadi, sifre) VALUES (@kullaniciadi, @sifre)", pgSqlConnection);
                eklemeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                eklemeCommand.Parameters.AddWithValue("@sifre", sifre);
                eklemeCommand.ExecuteNonQuery();

                MessageBox.Show("Yeni kullanıcı başarıyla oluşturuldu.");
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

        private void btn_kayitOl1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand kontrolCommand = new NpgsqlCommand("SELECT COUNT(*) FROM musteri_giris WHERE kullaniciadi = @kullaniciadi", pgSqlConnection);
                kontrolCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                int kullaniciSayisi = Convert.ToInt32(kontrolCommand.ExecuteScalar());

                if (kullaniciSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen farklı bir kullanıcı adı seçin.");
                    return;
                }

                NpgsqlCommand eklemeCommand = new NpgsqlCommand("INSERT INTO musteri_giris (kullaniciadi, sifre) VALUES (@kullaniciadi, @sifre)", pgSqlConnection);
                eklemeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                eklemeCommand.Parameters.AddWithValue("@sifre", sifre);
                eklemeCommand.ExecuteNonQuery();

                MessageBox.Show("Yeni kullanıcı başarıyla oluşturuldu.");
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

        private void btn_adminSil_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand silmeCommand = new NpgsqlCommand("DELETE FROM admin_giris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre", pgSqlConnection);
                silmeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                silmeCommand.Parameters.AddWithValue("@sifre", sifre);

                int affectedRows = silmeCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Admin kullanıcı başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
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

        private void btn_musteriSil_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand silmeCommand = new NpgsqlCommand("DELETE FROM musteri_giris WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre", pgSqlConnection);
                silmeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                silmeCommand.Parameters.AddWithValue("@sifre", sifre);

                int affectedRows = silmeCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Müşteri kullanıcı başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
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

        private void btn_adminGuncelle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve yeni şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                // Kullanıcı adına göre admin şifresini güncelle
                NpgsqlCommand guncellemeCommand = new NpgsqlCommand("UPDATE admin_giris SET sifre = @sifre WHERE kullaniciadi = @kullaniciadi", pgSqlConnection);
                guncellemeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                guncellemeCommand.Parameters.AddWithValue("@sifre", sifre);

                int affectedRows = guncellemeCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Admin şifre başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı hatalı.");
                }
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

        private void btn_musteriGuncelle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve yeni şifre boş olamaz.");
                return;
            }

            try
            {
                pgSqlConnection.Open();

                NpgsqlCommand guncellemeCommand = new NpgsqlCommand("UPDATE musteri_giris SET sifre = @sifre WHERE kullaniciadi = @kullaniciadi", pgSqlConnection);
                guncellemeCommand.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                guncellemeCommand.Parameters.AddWithValue("@sifre", sifre);

                int affectedRows = guncellemeCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Müşteri şifre başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı hatalı.");
                }
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

        private void btn_adminListele_Click(object sender, EventArgs e)
        {
            frm_admin_listele adminListeleForm = new frm_admin_listele();
            adminListeleForm.Show();
        }

        private void btn_musteriListele_Click(object sender, EventArgs e)
        {
            frm_musteri_listele_giris musteriListeleForm = new frm_musteri_listele_giris();
            musteriListeleForm.Show();
        }
    }

    
    
}
