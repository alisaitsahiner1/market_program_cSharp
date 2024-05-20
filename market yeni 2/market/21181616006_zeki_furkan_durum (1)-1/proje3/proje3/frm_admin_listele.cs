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
    public partial class frm_admin_listele : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");

        public frm_admin_listele()
        {
            InitializeComponent();
        }

        private void ListeleAdmin()
        {
            try
            {
                pgSqlConnection.Open();

                NpgsqlDataAdapter pgSqlDataAdapter = new NpgsqlDataAdapter("SELECT * FROM admin_giris", pgSqlConnection);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_admin_listele_Load_1(object sender, EventArgs e)
        {
            ListeleAdmin();
        }
    }
}
