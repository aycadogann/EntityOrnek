
namespace EntityOrnek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_OgrenciListele = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OgrenciId = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fotograf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DersID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DersAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_NotGuncelle = new System.Windows.Forms.Button();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.txt_Durum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Ortalama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Sinav1 = new System.Windows.Forms.TextBox();
            this.txt_Sinav3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Sinav2 = new System.Windows.Forms.TextBox();
            this.btn_DersListesi = new System.Windows.Forms.Button();
            this.btn_NotListesi = new System.Windows.Forms.Button();
            this.btn_Prosedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_LinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_OgrenciListele
            // 
            this.btn_OgrenciListele.Location = new System.Drawing.Point(22, 207);
            this.btn_OgrenciListele.Name = "btn_OgrenciListele";
            this.btn_OgrenciListele.Size = new System.Drawing.Size(156, 29);
            this.btn_OgrenciListele.TabIndex = 1;
            this.btn_OgrenciListele.Text = "Öğrenci Listele";
            this.btn_OgrenciListele.UseVisualStyleBackColor = true;
            this.btn_OgrenciListele.Click += new System.EventHandler(this.btn_OgrenciListele_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(22, 252);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(156, 31);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(22, 296);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(156, 29);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(22, 337);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(156, 31);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(22, 378);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(156, 33);
            this.btn_Bul.TabIndex = 5;
            this.btn_Bul.Text = "Bul";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID :";
            // 
            // txt_OgrenciId
            // 
            this.txt_OgrenciId.Location = new System.Drawing.Point(105, 44);
            this.txt_OgrenciId.Name = "txt_OgrenciId";
            this.txt_OgrenciId.Size = new System.Drawing.Size(142, 22);
            this.txt_OgrenciId.TabIndex = 7;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(105, 72);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(142, 22);
            this.txt_Ad.TabIndex = 9;
            this.txt_Ad.TextChanged += new System.EventHandler(this.txt_Ad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "AD :";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(105, 100);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(142, 22);
            this.txt_Soyad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "SOYAD :";
            // 
            // txt_Fotograf
            // 
            this.txt_Fotograf.Location = new System.Drawing.Point(105, 128);
            this.txt_Fotograf.Name = "txt_Fotograf";
            this.txt_Fotograf.Size = new System.Drawing.Size(142, 22);
            this.txt_Fotograf.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "FOTOĞRAF :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Fotograf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_OgrenciId);
            this.groupBox1.Controls.Add(this.txt_Soyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Location = new System.Drawing.Point(262, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 202);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_DersID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_DersAd);
            this.groupBox2.Location = new System.Drawing.Point(262, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 115);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID :";
            // 
            // txt_DersID
            // 
            this.txt_DersID.Location = new System.Drawing.Point(105, 30);
            this.txt_DersID.Name = "txt_DersID";
            this.txt_DersID.Size = new System.Drawing.Size(142, 22);
            this.txt_DersID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "AD :";
            // 
            // txt_DersAd
            // 
            this.txt_DersAd.Location = new System.Drawing.Point(105, 58);
            this.txt_DersAd.Name = "txt_DersAd";
            this.txt_DersAd.Size = new System.Drawing.Size(142, 22);
            this.txt_DersAd.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_NotGuncelle);
            this.groupBox3.Controls.Add(this.btn_Hesapla);
            this.groupBox3.Controls.Add(this.txt_Durum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_Ortalama);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Sinav1);
            this.groupBox3.Controls.Add(this.txt_Sinav3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_Sinav2);
            this.groupBox3.Location = new System.Drawing.Point(608, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 333);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btn_NotGuncelle
            // 
            this.btn_NotGuncelle.Location = new System.Drawing.Point(91, 208);
            this.btn_NotGuncelle.Name = "btn_NotGuncelle";
            this.btn_NotGuncelle.Size = new System.Drawing.Size(156, 29);
            this.btn_NotGuncelle.TabIndex = 20;
            this.btn_NotGuncelle.Text = "Sınav Notu Güncelle";
            this.btn_NotGuncelle.UseVisualStyleBackColor = true;
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(91, 173);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(156, 29);
            this.btn_Hesapla.TabIndex = 19;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            // 
            // txt_Durum
            // 
            this.txt_Durum.Location = new System.Drawing.Point(105, 138);
            this.txt_Durum.Name = "txt_Durum";
            this.txt_Durum.Size = new System.Drawing.Size(142, 22);
            this.txt_Durum.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "DURUM :";
            // 
            // txt_Ortalama
            // 
            this.txt_Ortalama.Location = new System.Drawing.Point(105, 109);
            this.txt_Ortalama.Name = "txt_Ortalama";
            this.txt_Ortalama.Size = new System.Drawing.Size(142, 22);
            this.txt_Ortalama.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "SINAV1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "ORTALAMA :";
            // 
            // txt_Sinav1
            // 
            this.txt_Sinav1.Location = new System.Drawing.Point(105, 25);
            this.txt_Sinav1.Name = "txt_Sinav1";
            this.txt_Sinav1.Size = new System.Drawing.Size(142, 22);
            this.txt_Sinav1.TabIndex = 7;
            // 
            // txt_Sinav3
            // 
            this.txt_Sinav3.Location = new System.Drawing.Point(105, 81);
            this.txt_Sinav3.Name = "txt_Sinav3";
            this.txt_Sinav3.Size = new System.Drawing.Size(142, 22);
            this.txt_Sinav3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "SINAV2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "SINAV3 :";
            // 
            // txt_Sinav2
            // 
            this.txt_Sinav2.Location = new System.Drawing.Point(105, 53);
            this.txt_Sinav2.Name = "txt_Sinav2";
            this.txt_Sinav2.Size = new System.Drawing.Size(142, 22);
            this.txt_Sinav2.TabIndex = 9;
            // 
            // btn_DersListesi
            // 
            this.btn_DersListesi.Location = new System.Drawing.Point(22, 423);
            this.btn_DersListesi.Name = "btn_DersListesi";
            this.btn_DersListesi.Size = new System.Drawing.Size(156, 31);
            this.btn_DersListesi.TabIndex = 17;
            this.btn_DersListesi.Text = "Ders Listesi";
            this.btn_DersListesi.UseVisualStyleBackColor = true;
            this.btn_DersListesi.Click += new System.EventHandler(this.btn_DersListesi_Click);
            // 
            // btn_NotListesi
            // 
            this.btn_NotListesi.Location = new System.Drawing.Point(22, 465);
            this.btn_NotListesi.Name = "btn_NotListesi";
            this.btn_NotListesi.Size = new System.Drawing.Size(156, 29);
            this.btn_NotListesi.TabIndex = 18;
            this.btn_NotListesi.Text = "Not Listesi";
            this.btn_NotListesi.UseVisualStyleBackColor = true;
            this.btn_NotListesi.Click += new System.EventHandler(this.btn_NotListesi_Click);
            // 
            // btn_Prosedur
            // 
            this.btn_Prosedur.Location = new System.Drawing.Point(22, 500);
            this.btn_Prosedur.Name = "btn_Prosedur";
            this.btn_Prosedur.Size = new System.Drawing.Size(156, 29);
            this.btn_Prosedur.TabIndex = 19;
            this.btn_Prosedur.Text = "Prosedür";
            this.btn_Prosedur.UseVisualStyleBackColor = true;
            this.btn_Prosedur.Click += new System.EventHandler(this.btn_Prosedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(885, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 21);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala(A-->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_LinqEntity
            // 
            this.btn_LinqEntity.Location = new System.Drawing.Point(885, 489);
            this.btn_LinqEntity.Name = "btn_LinqEntity";
            this.btn_LinqEntity.Size = new System.Drawing.Size(171, 30);
            this.btn_LinqEntity.TabIndex = 21;
            this.btn_LinqEntity.Text = "Linq Entity";
            this.btn_LinqEntity.UseVisualStyleBackColor = true;
            this.btn_LinqEntity.Click += new System.EventHandler(this.btn_LinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(885, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(176, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala(Z-->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(885, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 21);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(885, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 21);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(885, 152);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(158, 21);
            this.radioButton5.TabIndex = 25;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı A İle Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(885, 179);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(132, 21);
            this.radioButton6.TabIndex = 26;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı A İle Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(885, 206);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(112, 21);
            this.radioButton7.TabIndex = 27;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var mı";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(885, 233);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(171, 21);
            this.radioButton8.TabIndex = 28;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Toplam Öğrenci Sayısı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(885, 262);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(164, 21);
            this.radioButton9.TabIndex = 29;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sınav 1 Toplam Puan";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(885, 289);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(178, 21);
            this.radioButton10.TabIndex = 30;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav 1 Ortalama Puanı";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(885, 316);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(147, 21);
            this.radioButton11.TabIndex = 31;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "En Yüksek Sınav 1";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(885, 347);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(141, 21);
            this.radioButton12.TabIndex = 32;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "En Düşük Sınav 1";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 581);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btn_LinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_Prosedur);
            this.Controls.Add(this.btn_NotListesi);
            this.Controls.Add(this.btn_DersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_OgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_OgrenciListele;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OgrenciId;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fotograf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DersID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DersAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_NotGuncelle;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.TextBox txt_Durum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Ortalama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Sinav1;
        private System.Windows.Forms.TextBox txt_Sinav3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Sinav2;
        private System.Windows.Forms.Button btn_DersListesi;
        private System.Windows.Forms.Button btn_NotListesi;
        private System.Windows.Forms.Button btn_Prosedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_LinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

