using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace proje3
{
    public partial class frm_satis_listele : Form
    {
        NpgsqlConnection pgSqlConnection = new NpgsqlConnection("Host=localhost;Username=market;Password=123;Database=market");
        DataSet ds = new DataSet();

        public frm_satis_listele()
        {
            InitializeComponent();
        }

        private void satisListele()
        {
            pgSqlConnection.Open();
            NpgsqlDataAdapter sqlDataAdapter = new NpgsqlDataAdapter("select * from satis", pgSqlConnection);
            sqlDataAdapter.Fill(ds, "satis");
            dataGridView1.DataSource = ds.Tables["satis"];
            pgSqlConnection.Close();
        }

        private void frm_satis_listele_Load(object sender, EventArgs e)
        {
            satisListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pgSqlConnection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from satis where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", pgSqlConnection);
            cmd.ExecuteNonQuery();
            pgSqlConnection.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            ds.Tables["satis"].Clear();
            satisListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
