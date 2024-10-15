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
                        select new
                        {
                            item.NotId,
                            item.Ogrenci.OgrAd,
                            item.Ogrenci.OgrSoyad,
                            item.Dersler.DersAd,
                            item.Sinav1,
                            item.Sinav2,
                            item.Sinav3,
                            item.Ortalama,
                            item.Durum
                        };
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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_OgrenciId.Text);
            var guncellenecekId = okulEntities.Ogrenci.Find(id);
            guncellenecekId.OgrAd = txt_Ad.Text;
            guncellenecekId.OgrSoyad = txt_Soyad.Text;
            guncellenecekId.Fotograf = txt_Fotograf.Text;
            okulEntities.SaveChanges();
        }

        private void btn_Prosedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = okulEntities.NotListesi();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = okulEntities.Ogrenci.Where(o => o.OgrAd == txt_Ad.Text | o.OgrSoyad == txt_Soyad.Text).ToList();
        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_Ad.Text;
            var degerler = from item in okulEntities.Ogrenci
                           where item.OgrAd.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btn_LinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<Ogrenci> ogrenciListe = okulEntities.Ogrenci.OrderBy(o => o.OgrAd).ToList();
                dataGridView1.DataSource = ogrenciListe;
            }
            if (radioButton2.Checked == true)
            {
                List<Ogrenci> ogrenciListe2 = okulEntities.Ogrenci.OrderByDescending(o => o.OgrAd).ToList();
                dataGridView1.DataSource = ogrenciListe2;
            }
            if (radioButton3.Checked == true)
            {
                List<Ogrenci> ogrenciListe3 = okulEntities.Ogrenci.OrderBy(o => o.OgrAd).Take(3).ToList();
                dataGridView1.DataSource = ogrenciListe3;
            }
            if (radioButton4.Checked == true)
            {
                List<Ogrenci> ogrenciListe4 = okulEntities.Ogrenci.Where(o => o.Id == 5).ToList();
                dataGridView1.DataSource = ogrenciListe4;
            }
            if (radioButton5.Checked == true)
            {
                List<Ogrenci> ogrenciListe5 = okulEntities.Ogrenci.Where(o => o.OgrAd.StartsWith("a")).ToList();
                dataGridView1.DataSource = ogrenciListe5;
            }
            if (radioButton6.Checked == true)
            {
                List<Ogrenci> ogrenciListe6 = okulEntities.Ogrenci.Where(o => o.OgrAd.EndsWith("a")).ToList();
                dataGridView1.DataSource = ogrenciListe6;
            }
            if (radioButton7.Checked == true)
            {
                bool deger = okulEntities.Ogrenci.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
                int toplam = okulEntities.Ogrenci.Count();
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton9.Checked == true)
            {
                var toplam = okulEntities.Notlar.Sum(s => s.Sinav1);
                MessageBox.Show("Toplam Sınav 1 Puanı: " + toplam.ToString());
            }
            if (radioButton10.Checked == true)
            {
                var ortalama = okulEntities.Notlar.Average(n => n.Sinav1);
                MessageBox.Show("1. Sınav Ortalaması: " + ortalama.ToString());
            }
            if (radioButton11.Checked == true)
            {
                var enYuksek = okulEntities.Notlar.Max(n => n.Sinav1);
                var ogrenci = from item in okulEntities.NotListesi()
                              where item.Sinav1 == enYuksek
                              select new { item.Ad_Soyad, item.Sinav1 };
                dataGridView1.DataSource = ogrenci.ToList();
                //MessageBox.Show("1. sınavın en yüksek notu: " + enYuksek);
            }
            if (radioButton12.Checked == true)
            {
                var enDusuk = okulEntities.Notlar.Min(n => n.Sinav1);
                MessageBox.Show("1. sınavın en yüksek notu: " + enDusuk);
            }
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            var sorgu = from item in okulEntities.Notlar
                        join item2 in okulEntities.Ogrenci
                        on item.Ogr equals item2.Id
                        join item3 in okulEntities.Dersler
                        on item.Ders equals item3.DersId
                        select new
                        {
                            //Ad = item2.OgrAd,
                            //Soyad = item2.OgrSoyad,
                            Öğrenci=item2.OgrAd + " " +item2.OgrSoyad,
                            Ders=item3.DersAd,
                            Sınav1 = item.Sinav1,
                            Sınav2 = item.Sinav2,
                            Sınav3 = item.Sinav3,
                            Ortalama = item.Ortalama
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
