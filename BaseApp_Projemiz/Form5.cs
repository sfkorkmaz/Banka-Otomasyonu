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

namespace BaseApp_Projemiz
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

       
        public string kullaniciAdi;
        public int miktar = 0, artis5 = 0, artis10 = 0, artis20 = 0, artis50 = 0, artis100 = 0, artis200 = 0;
        public int adet5, adet10, adet20, adet50, adet100, adet200;
     

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select isim, hesap_no, bakiye, banka, para_miktar_5, para_miktar_10, para_miktar_20, para_miktar_50, para_miktar_100, para_miktar_200 From kullanici_bilgileri where kullanici_adi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_isim.Text = "" + dr[0];
                label_hesapNo.Text = "" + dr[1];
                label_bakiye.Text = "" + dr[2];
                label_banka.Text = "" + dr[3];


                label_adet_5.Text = "" + dr[4];
                label_adet_10.Text = "" + dr[5];
                label_adet_20.Text = "" + dr[6];
                label_adet_50.Text = "" + dr[7];
                label_adet_100.Text = "" + dr[8];
                label_adet_200.Text = "" + dr[9];
            }

            // kadın müşteride kadın, erkek müşteride erkek ikonu çıkması için.
            if (kullaniciAdi.Equals("asiye") || kullaniciAdi.Equals("leyla"))
            {
                picture_erkek.Visible = false;
            }

            {  // Banka isimleri fotoğrafın altında düzgün gözüksün diye lokasyon ayarlaması..
                if (label_banka.Text.Equals("VakıfBank") || label_banka.Text.Equals("İş Bankası"))
                {
                    label_banka.Location = new Point(480, 141);
                }
                else if (label_banka.Text.Equals("Ziraat Bankası"))
                {
                    label_banka.Location = new Point(462, 141);
                }
                else if (label_banka.Text.Equals("Garanti Bankası"))
                {
                    label_banka.Location = new Point(453, 141);
                }
            }

            bgl.baglanti().Close();
        }

        private void gösterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(667, 680);

            gizleToolStripMenuItem.Checked = false;
            gösterToolStripMenuItem.Checked = true;
        }
        private void gizleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(667, 539);

            gizleToolStripMenuItem.Checked = true;
            gösterToolStripMenuItem.Checked = false;
        }
            private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            form3.kullaniciAdi = kullaniciAdi;
            form3.Show();
        }
     


        private void button_5_Click(object sender, EventArgs e)
        {
            if (label_adet_5.Text.Equals("0"))
            {
                MessageBox.Show("5'lik banknotunuz bitmiştir. Daha fazla 5'lik banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_5.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_5.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_5.Visible = true;
                }

                miktar += 5;
                artis5 += 1;

                label_5.Text = artis5.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_5.Text = (Convert.ToInt32(label_adet_5.Text) - 1).ToString();

            }
        }


        private void button_10_Click(object sender, EventArgs e)
        {
            if (label_adet_10.Text.Equals("0"))
            {
                MessageBox.Show("10'luk banknotunuz bitmiştir. Daha fazla 10'luk banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_10.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_10.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_10.Visible = true;
                }

                miktar += 10;
                artis10 += 1;

                label_10.Text = artis10.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_10.Text = (Convert.ToInt32(label_adet_10.Text) - 1).ToString();

            }
        }


        private void button_20_Click(object sender, EventArgs e)
        {
            if (label_adet_20.Text.Equals("0"))
            {
                MessageBox.Show("20'lik banknotunuz bitmiştir. Daha fazla 20'lik banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_20.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_20.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_20.Visible = true;
                }

                miktar += 20;
                artis20 += 1;

                label_20.Text = artis20.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_20.Text = (Convert.ToInt32(label_adet_20.Text) - 1).ToString();

            }
        }


        private void button_50_Click(object sender, EventArgs e)
        {
            if (label_adet_50.Text.Equals("0"))
            {
                MessageBox.Show("50'lik banknotunuz bitmiştir. Daha fazla 50'lik banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_50.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_50.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_50.Visible = true;
                }

                miktar += 50;
                artis50 += 1;

                label_50.Text = artis50.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_50.Text = (Convert.ToInt32(label_adet_50.Text) - 1).ToString();

            }
        }

        private void button_100_Click(object sender, EventArgs e)
        {
            if (label_adet_100.Text.Equals("0"))
            {
                MessageBox.Show("100'lük banknotunuz bitmiştir. Daha fazla 100'lük banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_100.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_100.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_100.Visible = true;
                }

                miktar += 100;
                artis100 += 1;

                label_100.Text = artis100.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_100.Text = (Convert.ToInt32(label_adet_100.Text) - 1).ToString();

            }
        }
        private void button_200_Click(object sender, EventArgs e)
        {
            if (label_adet_200.Text.Equals("0"))
            {
                MessageBox.Show("200'lük banknotunuz bitmiştir. Daha fazla 200'lük banknot çekemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_200.Enabled = false;
            }

            else
            {
                if (label_miktar.Visible == false || label_200.Visible == false)
                {
                    label_miktar.Visible = true;
                    label_200.Visible = true;
                }

                miktar += 200;
                artis200 += 1;

                label_200.Text = artis200.ToString();
                label_miktar.Text = miktar.ToString();

                label_adet_200.Text = (Convert.ToInt32(label_adet_200.Text) - 1).ToString();

            }
        }

        private void button_onayla_Click(object sender, EventArgs e)
        {
            if (label_miktar.Text.Equals("0"))
            {
                MessageBox.Show("Lütfen çekilecek tutarı giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                label_bakiye.Text = ((Convert.ToInt32(label_bakiye.Text)) - (Convert.ToInt32(label_miktar.Text))).ToString();

                label_5.Visible = false;
                label_10.Visible = false;
                label_20.Visible = false;
                label_50.Visible = false;
                label_100.Visible = false;
                label_200.Visible = false;
                label_miktar.Visible = false;

                MessageBox.Show("Hesabınızdan " + label_miktar.Text + " TL para çekilmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand komut = new SqlCommand("Update kullanici_bilgileri set bakiye=@d1, para_miktar_5=@d2, para_miktar_10=@d3, para_miktar_20=@d4," +
                    "para_miktar_50=@d5, para_miktar_100=@d6, para_miktar_200=@d7 where kullanici_adi=@d8 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@d1", label_bakiye.Text);
                komut.Parameters.AddWithValue("@d2", label_adet_5.Text);
                komut.Parameters.AddWithValue("@d3", label_adet_10.Text);
                komut.Parameters.AddWithValue("@d4", label_adet_20.Text);
                komut.Parameters.AddWithValue("@d5", label_adet_50.Text);
                komut.Parameters.AddWithValue("@d6", label_adet_100.Text);
                komut.Parameters.AddWithValue("@d7", label_adet_200.Text);
                komut.Parameters.AddWithValue("@d8", kullaniciAdi);


                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                //hesap haraketleri işlemleri
                string gun = DateTime.Now.Day.ToString();
                string ay = DateTime.Now.Month.ToString();
                string saat = DateTime.Now.ToShortTimeString();

                if (Convert.ToInt32(ay) / 10 == 0)
                {
                    ay = "0" + ay;
                }
                if (Convert.ToInt32(gun) / 10 == 0)
                {
                    gun = "0" + gun;
                }

                string datetime = (gun + "." + ay + " - " + saat).ToString();

                SqlCommand komut2 = new SqlCommand("insert into hesap_hareketleri (kullanici_adi, islem_tarih, aciklama,"+
                    "tutar, bakiye) values (@p1, @p2, @p3, @p4, @p5) ", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", kullaniciAdi);
                komut2.Parameters.AddWithValue("@p2", datetime);
                komut2.Parameters.AddWithValue("@p3", "Para Çekme");
                komut2.Parameters.AddWithValue("@p4", "-" + label_miktar.Text);
                komut2.Parameters.AddWithValue("@p5", label_bakiye.Text);

                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
             

                this.Hide();

                Form3 form3 = new Form3();

                form3.Size = new Size(665, 683);
                form3.dataGridView2.Size = new Size(619, 169);
                form3.gizleToolStripMenuItem.Checked = false;
                form3.gösterToolStripMenuItem1.Checked = true;

                form3.kullaniciAdi = kullaniciAdi;
                form3.Show();
            }
        }
    }
}
