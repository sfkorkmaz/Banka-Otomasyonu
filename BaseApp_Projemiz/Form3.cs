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
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();  

        }

        public String kullaniciAdi;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select isim, hesap_no, bakiye,banka From kullanici_bilgileri where kullanici_adi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_isim.Text = "" + dr[0];
                label_hesapNo.Text = "" + dr[1];
                label_bakiye.Text = "" + dr[2];            
                label_banka.Text = "" + dr[3];
            }
            bgl.baglanti().Close();



            //datagrid işlemleri
            DataTable dt1 = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select islem_tarih, aciklama, tutar, bakiye from hesap_hareketleri where kullanici_adi='" + kullaniciAdi + "'", bgl.baglanti());
            da.Fill(dt1);
            
            dataGridView2.DataSource = dt1;


            dataGridView2.Columns[0].HeaderText = " İşlem Tarihi";
            dataGridView2.Columns[1].HeaderText = "   Açıklama";
            dataGridView2.Columns[2].HeaderText = "   Tutar";
            dataGridView2.Columns[3].HeaderText = "   Bakiye";


            //sadece son 5 satırı/işlemi gösterme
            dataGridView2.CurrentCell = null;

            if (Convert.ToInt32(dataGridView2.RowCount) > 5)
            {
                for (int i = 0; i < Convert.ToInt32(dataGridView2.RowCount) - 5; i++)
                {
                    dataGridView2.Rows[i].Visible=false;
                }
            }



            //avatar işlemi
            if ( kullaniciAdi.Equals("asiye") || kullaniciAdi.Equals("leyla"))
            { 
            picture_erkek.Visible = false;
            }

            //banka lokasyon
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

 

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz ?", "Çıkılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                //işlem yok
            }
        }

        private void label_paraYatir_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (label_bakiye.Text.Equals("6000"))
            {
                MessageBox.Show("Bakiyeniz 6000 TL , daha fazla para yatıramazsınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();

                Form4 form4 = new Form4();
                form4.kullaniciAdi = kullaniciAdi;
                form4.Show();
            }
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label_banka_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label_bakiye.Text.Equals("0"))
            {
                MessageBox.Show("Bakiyeniz 0 TL , para çekemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                Form5 frm = new Form5();
                frm.kullaniciAdi = kullaniciAdi;
                frm.Show();
            }
        }

        private void label_paraCek_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label_bakiye.Text.Equals("0"))
            {
                MessageBox.Show("Bakiyeniz 0 TL , Havale gönderemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();

                Form6 form6 = new Form6();
                form6.kullaniciAdi = kullaniciAdi;
                form6.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            int day = (int)dt.DayOfWeek;
            int hour = (int)dt.Hour;
            
            if ( day == 6 || day == 0 || hour < 9 || hour > 16)           
            {
                MessageBox.Show("EFT işlemi hafta içi 09.00 - 17.00 saatleri arasında yapılmaktadır.\nHafta sonları ve resmi tatillerde para tranferi yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
           
            else if (label_bakiye.Text.Equals("0"))
            {
                MessageBox.Show("Bakiyeniz 0 TL , EFT gönderemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();

                Form7 form7 = new Form7();
                form7.kullaniciAdi = kullaniciAdi;
                form7.Show();
            }
        }

        private void gösterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            this.Size = new Size(665, 683);
            dataGridView2.Size = new Size(619, 169);

            gizleToolStripMenuItem.Checked = false;
            gösterToolStripMenuItem1.Checked = true;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(665, 500);

            gizleToolStripMenuItem.Checked = true;
            gösterToolStripMenuItem1.Checked = false;
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
