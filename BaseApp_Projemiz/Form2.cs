using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseApp_Projemiz
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;


        public int a=0;
       
        
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void Form2_Load(object sender, EventArgs e)
        {         
            this.Text = "Sayın," + " " + kullaniciAdi;           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "1";
                a++;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "2";
                a++;
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "3";
                a++;
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "4";
                a++;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "5";
                a++;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "6";
                a++;
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "7";
                a++;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "8";
                a++;
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "9";
                a++;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (a != 6)
            {
                textBox_GK_yazma.Text = textBox_GK_yazma.Text + "0";
                a++;
            }
        }


        private void button_GK_giris_Click(object sender, EventArgs e)
        {
            if (labelKod.Visible == false)
            {
                MessageBox.Show("Lütfen güvenlik kodu alınız.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_GK_yazma.Text = "";
                a=0;
            }

            else if (textBox_GK_yazma.Text.Equals(""))
            {
                MessageBox.Show("Güvenlik alanı boş bırakılamaz, lütfen tuşları kullanarak güvenlik kodunu giriniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(textBox_GK_yazma.Text.Equals(labelKod.Text)))
            {
                MessageBox.Show("Eksik ya da hatalı giriş! Lütfen tekrar deneyiniz", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_GK_yazma.Text = "";
                a = 0;
            }
            else if (textBox_GK_yazma.Text.Equals(labelKod.Text))
            {
                MessageBox.Show("Bankamıza Hoş Geldiniz :)", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();

                Form3 form3 = new Form3();
                form3.kullaniciAdi = kullaniciAdi;
                form3.Show();
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

      

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            labelKod.Visible = true;

            if (sayac <= 5)
            {
                timer1.Start();

                progressBar1.Value = 100;
            }
        }
        int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 5)
            {
                Random random = new Random();
                int sayi = random.Next(100000, 999999);
                labelKod.Text = sayi.ToString();            
                timer1.Stop();
                progressBar1.Value = 0;

            }              
                sayac++;           
        }

        private void textBox_GK_yazma_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
