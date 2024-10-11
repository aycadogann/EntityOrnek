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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OkulEntities okulEntities = new OkulEntities();
        private void btn_DersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Okul;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Dersler", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_OgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = okulEntities.Ogrenci.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btn_NotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in okulEntities.Notlar
                        join item2 in okulEntities.Ogrenci
                        on item.Ogr equals item2.Id
                        select new { item.NotId, item2.OgrAd, item.Ders, item.Sinav1, item.Sinav2, item.Sinav3, item.Ortalama, item.Durum };
            dataGridView1.DataSource = query.ToList();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrAd = txt_Ad.Text;
            ogrenci.OgrSoyad = txt_Soyad.Text;
            okulEntities.Ogrenci.Add(ogrenci);
            okulEntities.SaveChanges();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_OgrenciId.Text);
            var silinecekId = okulEntities.Ogrenci.Find(id);
            okulEntities.Ogrenci.Remove(silinecekId);
            okulEntities.SaveChanges();
        }
    }
}
