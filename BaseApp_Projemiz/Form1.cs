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
    public partial class Banka_Otomasyonu : Form
    {   
        int zaman = 50;
        int hak = 3;
       
 
        public Banka_Otomasyonu()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();    
        private void BaseApp_Load(object sender, EventArgs e)
        {            
            timersaat.Start();
            timerzaman.Start();
            
        }
        private void kullaniciDenetim()
        {
            if (textBoxKullaniciAdi.Text.Equals("") && textBoxSifre.Text.Equals("")) 
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBoxKullaniciAdi.Text.Equals(""))
            {
                MessageBox.Show("Kullanıcı adı alanı boş bırakılamaz", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBoxSifre.Text.Equals(""))
            {
                MessageBox.Show("Şifre alanı boş bırakılamaz", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
        
                string a = textBoxKullaniciAdi.Text.ToLower();
                string b = textBoxSifre.Text.ToLower();

                
                SqlCommand komut = new SqlCommand("Select * from kullanici_bilgileri where kullanici_adi=@p1 and sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@P2", textBoxSifre.Text);
                
                SqlDataReader dr = komut.ExecuteReader();
              

                
                if (dr.Read() && a.Equals(textBoxKullaniciAdi.Text) && b.Equals(textBoxSifre.Text))
                {                
                    timerzaman.Stop();
                    buttonGiris.Enabled = false;
                    MessageBox.Show("Güvenlik doğrulaması alanına yönlendiriliyorsunuz.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.kullaniciAdi = textBoxKullaniciAdi.Text;
                    form2.Show();
                }
                else
                {
                    hak--;
                    labelHak.Text = hak.ToString();
                    if (hak == 0)
                    {
                        buttonGiris.Enabled = false;
                        timerzaman.Stop();
                    }
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                    if (hak == 0)
                    {
                        hakDenetim();
                    }
                }
            }
            bgl.baglanti().Close();
        }
        private void hakDenetim()
        {          
            DialogResult reset = new DialogResult();
            reset = MessageBox.Show("Giriş limitiniz dolmuştur, uygulamayı yeniden başlatmak ister misiniz ?", "Dikkat !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reset == DialogResult.Yes)
            {
                Application.Restart();
            }
            if (reset == DialogResult.No)
            {
                //işlem yok
            }
        }
        private void zamanDenetim()
        {
            DialogResult reset = new DialogResult();
            reset = MessageBox.Show("Süreniz dolmuştur, uygulamayı yeniden başlatmak ister misiniz ?", "Dikkat !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reset == DialogResult.Yes)
            {
                Application.Restart();
            }
            if (reset == DialogResult.No)
            {
                //işlem yok
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_tarihSaat.Text = DateTime.Now.ToString();
        }
        private void label_tarihSaat_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
        }
        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
           // textBoxSifre.PasswordChar = checkBoxGoster.Checked ? '\0' : '*';

            
            /* if (checkBoxGoster.Checked)
             {
                 textBoxSifre.PasswordChar = '\0';
                 checkBoxGoster.Text = "Gizle";
             }
             else
             {
                 textBoxSifre.PasswordChar = '*';
                 checkBoxGoster.Text = "Göster";
             }
             */
        }
        private void labelzaman_Click(object sender, EventArgs e)
        {
        }
        private void timerzaman_Tick(object sender, EventArgs e)
        {
            timerzaman.Enabled = true;
            timerzaman.Interval = 1000;
            timerzaman.Start();
            zaman--;
            labelzaman.Text = zaman.ToString();
            if (zaman == 0)
            {
                timerzaman.Stop();
                buttonGiris.Enabled = false;
                labelHak.Text = hak.ToString();
                zamanDenetim();
            }
        }
        private void labelHak_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void buttonCikis_Click_1(object sender, EventArgs e)
        {

            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Program kapatılsın mı ?", "Çıkılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                //işlem yok
            }
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            kullaniciDenetim();
        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = checkBoxGoster.Checked ? '\0' : '*';
        }

        private void labelzaman_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
