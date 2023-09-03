﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string kullaniciAdi, kullaniciAdi2, banka2, bakiye2;
        public int maxHavale;
        public int miktar = 0, artis5 = 0, artis10 = 0, artis20 = 0, artis50 = 0, artis100 = 0, artis200 = 0;
        public int adet5, adet10, adet20, adet50, adet100, adet200;
        public string adet5_2, adet10_2, adet20_2, adet50_2, adet100_2, adet200_2;

        

        sqlbaglantisi bgl =new sqlbaglantisi();

        private void Form6_Load(object sender, EventArgs e)
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

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(667, 680);

            gizleToolStripMenuItem.Checked = false;
            gösterToolStripMenuItem.Checked = true;
        }
        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(667, 539);

            gizleToolStripMenuItem.Checked = true;
            gösterToolStripMenuItem.Checked = false;
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
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


        private void textBox_hesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void button_5_Click(object sender, EventArgs e)
        {
            if (label_adet_5.Text.Equals("0"))
            {
                MessageBox.Show("5'lik banknotunuz bitmiştir. Daha fazla 5'lik banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("10'luk banknotunuz bitmiştir. Daha fazla 10'luk banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("20'lik banknotunuz bitmiştir. Daha fazla 20'lik banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("50'lik banknotunuz bitmiştir. Daha fazla 50'lik banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("100'lük banknotunuz bitmiştir. Daha fazla 100'lük banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("200'lük banknotunuz bitmiştir. Daha fazla 200'lük banknot gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (label_miktar.Text.Equals("0") && textBox_hesapNo.Text.Length<6)
            {
                MessageBox.Show("Lütfen havale yapılacak tutarı ve havale yapılacak altı haneli hesap numarasını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (label_miktar.Text.Equals("0"))
            {
                MessageBox.Show("Lütfen havale yapılacak tutarı giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (textBox_hesapNo.Text.Length<6)
            {
                MessageBox.Show("Lütfen havale yapılacak altı haneli hesap numarasını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            else
            {
                SqlCommand komut2 = new SqlCommand("Select banka, bakiye, para_miktar_5, para_miktar_10, para_miktar_20, para_miktar_50,"+
                    " para_miktar_100, para_miktar_200, kullanici_adi From kullanici_bilgileri where hesap_no=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", textBox_hesapNo.Text);
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    banka2 = "" + dr[0];
                    bakiye2 = "" + dr[1];

                    adet5_2 = "" + dr[2];
                    adet10_2 = "" + dr[3];
                    adet20_2 = "" + dr[4];
                    adet50_2 = "" + dr[5];
                    adet100_2 = "" + dr[6];
                    adet200_2 = "" + dr[7];

                    kullaniciAdi2 = "" + dr[8]; 

                    maxHavale = 6000 - (Convert.ToInt32(bakiye2));
                }
                bgl.baglanti().Close();



                if (label_banka.Text.Equals(banka2) == false)
                {
                    MessageBox.Show("Girdiğiniz '" + textBox_hesapNo.Text + "' nolu hesap numarasına ait bankanızın kullanıcısı bulunmamaktadır."+ 
                        "Lütfen hesap numarasını kontrol edip tekrar deneyiniz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (textBox_hesapNo.Text.Equals(label_hesapNo.Text))
                {
                    MessageBox.Show("Girdiğiniz hesap numarası size ait, kendinize havale gönderemezsiniz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (Convert.ToInt32(label_miktar.Text) > maxHavale)
                {
                    MessageBox.Show(textBox_hesapNo.Text + " nolu hesaba;\nGönderebileceğiniz maksimum havale miktarı: " + maxHavale + 
                        " TL'dir.", "Havale Gönderimi Başarısız !", MessageBoxButtons.OK, MessageBoxIcon.Stop);



                    this.Hide();
                    Form6 form6 = new Form6();


                    if (gizleToolStripMenuItem.Checked)
                    {
                        form6.gizleToolStripMenuItem.Checked = true;
                        form6.gösterToolStripMenuItem.Checked = false;
                    }
                    else
                    {
                        form6.gösterToolStripMenuItem.Checked = true;
                        form6.gizleToolStripMenuItem.Checked = false;
                        form6.Size = new Size(667, 680);
                    }
                    form6.kullaniciAdi = kullaniciAdi;
                    form6.textBox_hesapNo.Text = textBox_hesapNo.Text.ToString();
                    form6.Show();
                }

                /*
                miktar = 0;
                artis5 = 0;
                artis10 = 0;
                artis20 = 0;
                artis50 = 0;
                artis100 = 0;
                artis200 = 0;

                label_5.Visible = false;
                label_10.Visible = false;
                label_20.Visible = false;
                label_50.Visible = false;
                label_100.Visible = false;
                label_200.Visible = false;
                label_miktar.Visible = false;

                button_5.Enabled = true;
                button_10.Enabled = true;
                button_20.Enabled = true;
                button_50.Enabled = true;
                button_100.Enabled = true;
                button_200.Enabled = true;


                SqlCommand komut3 = new SqlCommand("Select para_miktar_5, para_miktar_10, para_miktar_20, para_miktar_50, para_miktar_100, para_miktar_200 From kullanici_bilgileri where kullanici_adi=@p1", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", kullaniciAdi);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    label_adet_5.Text = "" + dr3[0];
                    label_adet_10.Text = "" + dr3[1];
                    label_adet_20.Text = "" + dr3[2];
                    label_adet_50.Text = "" + dr3[3];
                    label_adet_100.Text = "" + dr3[4];
                    label_adet_200.Text = "" + dr3[5];


                }
                bgl.baglanti().Close();


                */


                else
                {

                    int kalan = 0;
                    if (Convert.ToInt32(label_200.Text) > (5 - Convert.ToInt32(adet200_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_200.Text)) - (5 - Convert.ToInt32(adet200_2)))) * 200);
                        adet200_2 = 5.ToString();
                    }
                    else
                        adet200_2 = ((Convert.ToInt32(adet200_2)) + (Convert.ToInt32(label_200.Text))).ToString();



                    if (Convert.ToInt32(label_100.Text) > (10 - Convert.ToInt32(adet100_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_100.Text)) - (10 - Convert.ToInt32(adet100_2)))) * 100);
                        adet100_2 = 10.ToString();
                    }
                    else
                        adet100_2 = ((Convert.ToInt32(adet100_2)) + (Convert.ToInt32(label_100.Text))).ToString();



                    if (Convert.ToInt32(label_50.Text) > (20 - Convert.ToInt32(adet50_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_50.Text)) - (20 - Convert.ToInt32(adet50_2)))) * 50);
                        adet50_2 = 20.ToString();
                    }
                    else
                        adet50_2 = ((Convert.ToInt32(adet50_2)) + (Convert.ToInt32(label_50.Text))).ToString();



                    if (Convert.ToInt32(label_20.Text) > (50 - Convert.ToInt32(adet20_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_20.Text)) - (50 - Convert.ToInt32(adet20_2)))) * 20);
                        adet20_2 = 50.ToString();
                    }
                    else
                        adet20_2 = ((Convert.ToInt32(adet20_2)) + (Convert.ToInt32(label_20.Text))).ToString();



                    if (Convert.ToInt32(label_10.Text) > (100 - Convert.ToInt32(adet10_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_10.Text)) - (100 - Convert.ToInt32(adet10_2)))) * 10);
                        adet10_2 = 100.ToString();
                    }
                    else
                        adet10_2 = ((Convert.ToInt32(adet10_2)) + (Convert.ToInt32(label_10.Text))).ToString();



                    if (Convert.ToInt32(label_5.Text) > (200 - Convert.ToInt32(adet5_2)))
                    {
                        kalan += ((((Convert.ToInt32(label_5.Text)) - (200 - Convert.ToInt32(adet5_2)))) * 5);
                        adet5_2 = 200.ToString();
                    }
                    else
                        adet5_2 = ((Convert.ToInt32(adet5_2)) + (Convert.ToInt32(label_5.Text))).ToString();





                    if (kalan > 0)
                    {
                        if ((Convert.ToInt32(adet200_2)) < 5 && kalan >= 200)
                        {
                            while ((Convert.ToInt32(adet200_2)) < 5 && kalan >= 200)
                            {
                                adet200_2 = ((Convert.ToInt32(adet200_2)) + 1).ToString();
                                kalan -= 200;
                            }
                        }


                        if ((Convert.ToInt32(adet100_2)) < 10 && kalan >= 100)
                        {
                            while ((Convert.ToInt32(adet100_2)) < 10 && kalan >= 100)
                            {
                                adet100_2 = ((Convert.ToInt32(adet100_2)) + 1).ToString();
                                kalan -= 100;
                            }
                        }


                        if ((Convert.ToInt32(adet50_2)) < 20 && kalan >= 50)
                        {
                            while ((Convert.ToInt32(adet50_2)) < 20 && kalan >= 50)
                            {
                                adet50_2 = ((Convert.ToInt32(adet50_2)) + 1).ToString();
                                kalan -= 50;
                            }
                        }


                        if ((Convert.ToInt32(adet20_2)) < 50 && kalan >= 20)
                        {
                            while ((Convert.ToInt32(adet20_2)) < 50 && kalan >= 20)
                            {
                                adet20_2 = ((Convert.ToInt32(adet20_2)) + 1).ToString();
                                kalan -= 20;
                            }
                        }


                        if ((Convert.ToInt32(adet10_2)) < 100 && kalan >= 10)
                        {
                            while ((Convert.ToInt32(adet10_2)) < 100 && kalan >= 10)
                            {
                                adet10_2 = ((Convert.ToInt32(adet10_2)) + 1).ToString();
                                kalan -= 10;
                            }
                        }


                        if ((Convert.ToInt32(adet5_2)) < 200 && kalan >= 5)
                        {
                            while ((Convert.ToInt32(adet5_2)) < 200 && kalan >= 5)
                            {
                                adet5_2 = ((Convert.ToInt32(adet5_2)) + 1).ToString();
                                kalan -= 5;
                            }
                        }
                    }

                    if (kalan > 0)
                    {
                        if (kalan < 10)
                        {
                            if (Convert.ToInt32(adet10_2) < 100)
                            {
                                adet10_2 = (Convert.ToInt32(adet10_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 2).ToString();
                            }
                            else if (Convert.ToInt32(adet20_2) < 50)
                            {
                                adet20_2 = (Convert.ToInt32(adet20_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 2).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet50_2) < 20)
                            {
                                adet50_2 = (Convert.ToInt32(adet50_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet100_2) < 10)
                            {
                                adet100_2 = (Convert.ToInt32(adet100_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet200_2) < 5)
                            {
                                adet200_2 = (Convert.ToInt32(adet200_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                                adet100_2 = (Convert.ToInt32(adet100_2) - 1).ToString();
                            }
                        }

                        else if (kalan < 20)
                        {

                            if (Convert.ToInt32(adet20_2) < 50)
                            {
                                adet20_2 = (Convert.ToInt32(adet20_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 2).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet50_2) < 20)
                            {
                                adet50_2 = (Convert.ToInt32(adet50_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet100_2) < 10)
                            {
                                adet100_2 = (Convert.ToInt32(adet100_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet200_2) < 5)
                            {
                                adet200_2 = (Convert.ToInt32(adet200_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                                adet100_2 = (Convert.ToInt32(adet100_2) - 1).ToString();
                            }
                        }

                        else if (kalan < 50)
                        {

                            if (Convert.ToInt32(adet50_2) < 20)
                            {
                                adet50_2 = (Convert.ToInt32(adet50_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet100_2) < 10)
                            {
                                adet100_2 = (Convert.ToInt32(adet100_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet200_2) < 5)
                            {
                                adet200_2 = (Convert.ToInt32(adet200_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                                adet100_2 = (Convert.ToInt32(adet100_2) - 1).ToString();
                            }
                        }

                        else if (kalan < 100)
                        {


                            if (Convert.ToInt32(adet100_2) < 10)
                            {
                                adet100_2 = (Convert.ToInt32(adet100_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                            }
                            else if (Convert.ToInt32(adet200_2) < 5)
                            {
                                adet200_2 = (Convert.ToInt32(adet200_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                                adet100_2 = (Convert.ToInt32(adet100_2) - 1).ToString();
                            }
                        }

                        else if (kalan < 200)
                        {

                            if (Convert.ToInt32(adet200_2) < 5)
                            {
                                adet200_2 = (Convert.ToInt32(adet200_2) + 1).ToString();
                                adet5_2 = (Convert.ToInt32(adet5_2) - 4).ToString();
                                adet10_2 = (Convert.ToInt32(adet10_2) - 1).ToString();
                                adet20_2 = (Convert.ToInt32(adet20_2) - 1).ToString();
                                adet50_2 = (Convert.ToInt32(adet50_2) - 1).ToString();
                                adet100_2 = (Convert.ToInt32(adet100_2) - 1).ToString();
                            }
                        }


                        if ((Convert.ToInt32(adet200_2)) < 5 && kalan >= 200)
                        {
                            while ((Convert.ToInt32(adet200_2)) < 5 && kalan >= 200)
                            {
                                adet200_2 = ((Convert.ToInt32(adet200_2)) + 1).ToString();
                                kalan -= 200;
                            }
                        }


                        if ((Convert.ToInt32(adet100_2)) < 10 && kalan >= 100)
                        {
                            while ((Convert.ToInt32(adet100_2)) < 10 && kalan >= 100)
                            {
                                adet100_2 = ((Convert.ToInt32(adet100_2)) + 1).ToString();
                                kalan -= 100;
                            }
                        }


                        if ((Convert.ToInt32(adet50_2)) < 20 && kalan >= 50)
                        {
                            while ((Convert.ToInt32(adet50_2)) < 20 && kalan >= 50)
                            {
                                adet50_2 = ((Convert.ToInt32(adet50_2)) + 1).ToString();
                                kalan -= 50;
                            }
                        }


                        if ((Convert.ToInt32(adet20_2)) < 50 && kalan >= 20)
                        {
                            while ((Convert.ToInt32(adet20_2)) < 50 && kalan >= 20)
                            {
                                adet20_2 = ((Convert.ToInt32(adet20_2)) + 1).ToString();
                                kalan -= 20;
                            }
                        }


                        if ((Convert.ToInt32(adet10_2)) < 100 && kalan >= 10)
                        {
                            while ((Convert.ToInt32(adet10_2)) < 100 && kalan >= 10)
                            {
                                adet10_2 = ((Convert.ToInt32(adet10_2)) + 1).ToString();
                                kalan -= 10;
                            }
                        }


                        if ((Convert.ToInt32(adet5_2)) < 200 && kalan >= 5)
                        {
                            while ((Convert.ToInt32(adet5_2)) < 200 && kalan >= 5)
                            {
                                adet5_2 = ((Convert.ToInt32(adet5_2)) + 1).ToString();
                                kalan -= 5;
                            }
                        }

                    }


                    label_bakiye.Text = ((Convert.ToInt32(label_bakiye.Text)) - (Convert.ToInt32(label_miktar.Text))).ToString();     //girdiğimiz hesbın yeni bakiyesi            
                    bakiye2 = ((Convert.ToInt32(bakiye2)) + (Convert.ToInt32(label_miktar.Text))).ToString();                         // gönderdiğimiz hesabın yeni bakiyesi  

                    label_5.Visible = false;
                    label_10.Visible = false;
                    label_20.Visible = false;
                    label_50.Visible = false;
                    label_100.Visible = false;
                    label_200.Visible = false;
                    label_miktar.Visible = false;



                    SqlCommand komut = new SqlCommand("Update kullanici_bilgileri set bakiye=@d1, para_miktar_5=@d2, para_miktar_10=@d3, para_miktar_20=@d4, para_miktar_50=@d5,"+
                        "para_miktar_100=@d6, para_miktar_200=@d7 where kullanici_adi=@d8 ", bgl.baglanti());
                    komut.Parameters.AddWithValue("@d1", label_bakiye.Text);
                    komut.Parameters.AddWithValue("@d2", label_adet_5.Text);
                    komut.Parameters.AddWithValue("@d3", label_adet_10.Text);
                    komut.Parameters.AddWithValue("@d4", label_adet_20.Text);
                    komut.Parameters.AddWithValue("@d5", label_adet_50.Text);
                    komut.Parameters.AddWithValue("@d6", label_adet_100.Text);
                    komut.Parameters.AddWithValue("@d7", label_adet_200.Text);
                    komut.Parameters.AddWithValue("@d8", kullaniciAdi);




                    SqlCommand komut3 = new SqlCommand("Update kullanici_bilgileri set bakiye=@d1, para_miktar_5=@d2, para_miktar_10=@d3, para_miktar_20=@d4, para_miktar_50=@d5,"+
                        "para_miktar_100=@d6, para_miktar_200=@d7 where hesap_no=@d8 ", bgl.baglanti());
                    komut3.Parameters.AddWithValue("@d1", bakiye2);
                    komut3.Parameters.AddWithValue("@d2", adet5_2);
                    komut3.Parameters.AddWithValue("@d3", adet10_2);
                    komut3.Parameters.AddWithValue("@d4", adet20_2);
                    komut3.Parameters.AddWithValue("@d5", adet50_2);
                    komut3.Parameters.AddWithValue("@d6", adet100_2);
                    komut3.Parameters.AddWithValue("@d7", adet200_2);
                    komut3.Parameters.AddWithValue("@d8", textBox_hesapNo.Text);

                    komut.ExecuteNonQuery();
                    komut3.ExecuteNonQuery();
                    bgl.baglanti().Close();



                    //hesap haraketleri işlemleri
                    string gun = DateTime.Now.Day.ToString();
                    string ay = DateTime.Now.Month.ToString();
                    string saat = DateTime.Now.ToShortTimeString();

                    if (Convert.ToInt32(ay) / 10 == 0)
                    {
                        ay = "0" + ay;
                    }
                    if (Convert.ToInt32(gun) /10 ==0 )
                    {
                        gun = "0" + gun;
                    }

                    string datetime = (gun + "." + ay + " - " + saat).ToString();


                    SqlCommand komut4 = new SqlCommand("insert into hesap_hareketleri (kullanici_adi, islem_tarih, aciklama, tutar,"+
                        "bakiye) values (@p1, @p2, @p3, @p4, @p5) ", bgl.baglanti());

                    komut4.Parameters.AddWithValue("@p1", kullaniciAdi);
                    komut4.Parameters.AddWithValue("@p2", datetime);
                    komut4.Parameters.AddWithValue("@p3", "Havale");
                    komut4.Parameters.AddWithValue("@p4", "-" + label_miktar.Text);
                    komut4.Parameters.AddWithValue("@p5", label_bakiye.Text);

                    komut4.ExecuteNonQuery();
                    bgl.baglanti().Close();


                    SqlCommand komut5 = new SqlCommand("insert into hesap_hareketleri (kullanici_adi, islem_tarih, aciklama, tutar,"+
                        "bakiye) values (@p1, @p2, @p3, @p4, @p5) ", bgl.baglanti());

                    komut5.Parameters.AddWithValue("@p1", kullaniciAdi2);
                    komut5.Parameters.AddWithValue("@p2", datetime);
                    komut5.Parameters.AddWithValue("@p3", "Havale");
                    komut5.Parameters.AddWithValue("@p4", "+" + label_miktar.Text);
                    komut5.Parameters.AddWithValue("@p5", bakiye2);

                    komut5.ExecuteNonQuery();
                    bgl.baglanti().Close();



                    MessageBox.Show (" Hesabınızdan " + textBox_hesapNo.Text + " Nolu Hesaba " + label_miktar.Text +
                        " TL havale gerçekleştirilmiştir", "Havale Gönderimi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

    }

