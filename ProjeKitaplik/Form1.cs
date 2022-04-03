using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjeKitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8AC1K1B;Initial Catalog=Kitaplik;Integrated Security=True");
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand(" insert into kitaplar (kitapAd,kitapYazar,kitapTürü,kitapDurum) values (@p1,@p2,@p3,@p4)", baglanti);
            kaydet.Parameters.AddWithValue("@p1", kitapAd.Text);
            kaydet.Parameters.AddWithValue("@p2", kitapYazar.Text);
            kaydet.Parameters.AddWithValue("@p3", kitapTür.Text);
            kaydet.Parameters.AddWithValue("@p4", durum);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sisteme kaydedildi");
            listele();
        }

        private void alinmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void alinabilir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            kitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kitapTür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[4].Value.ToString() == "True")
            {
                alinmis.Checked = true;
            }
            else
            {
                alinabilir.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From kitaplar where kitapId=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", kitapid.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sistemden silindi");
            listele();
        }
       
        private void btnGuncel_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gun = new SqlCommand("update kitaplar set kitapAd=@p1 , kitapYazar=@p2 , kitapTür=@p3 , kitapDurum=@p4 where kitapId=@p5", baglanti);
            gun.Parameters.AddWithValue("@p1", kitapAd.Text);
            gun.Parameters.AddWithValue("@p2", kitapYazar.Text);
            gun.Parameters.AddWithValue("@p3", kitapTür.Text);
            if(alinmis.Checked == true)
            {
                gun.Parameters.AddWithValue("@p4", durum);
            }
            else
            {
                gun.Parameters.AddWithValue("@p4", "false");
            }
            if (alinabilir.Checked == true)
            {
                gun.Parameters.AddWithValue("@p4", durum);
            }
            else
            {
                gun.Parameters.AddWithValue("@p4", "false");
            }
            gun.Parameters.AddWithValue("@p5", kitapid.Text);
            gun.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap güncelleme başarılı");
            listele();
        }
    }
}
