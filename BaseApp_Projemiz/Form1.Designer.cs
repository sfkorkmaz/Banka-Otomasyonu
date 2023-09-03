namespace BaseApp_Projemiz
{
    partial class Banka_Otomasyonu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banka_Otomasyonu));
            this.timersaat = new System.Windows.Forms.Timer(this.components);
            this.timerzaman = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelzaman = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.checkBoxGoster = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelHak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_tarihSaat = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timersaat
            // 
            this.timersaat.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerzaman
            // 
            this.timerzaman.Tick += new System.EventHandler(this.timerzaman_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.labelzaman);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.textBoxSifre);
            this.groupBox3.Controls.Add(this.checkBoxGoster);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBox3.Controls.Add(this.labelHak);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonCikis);
            this.groupBox3.Controls.Add(this.buttonGiris);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // labelzaman
            // 
            resources.ApplyResources(this.labelzaman, "labelzaman");
            this.labelzaman.BackColor = System.Drawing.SystemColors.Control;
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Click += new System.EventHandler(this.labelzaman_Click_1);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox7.Image = global::BaseApp_Projemiz.Properties.Resources.padlock;
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // textBoxSifre
            // 
            resources.ApplyResources(this.textBoxSifre, "textBoxSifre");
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged_1);
            // 
            // checkBoxGoster
            // 
            resources.ApplyResources(this.checkBoxGoster, "checkBoxGoster");
            this.checkBoxGoster.Name = "checkBoxGoster";
            this.checkBoxGoster.UseVisualStyleBackColor = true;
            this.checkBoxGoster.CheckedChanged += new System.EventHandler(this.checkBoxGoster_CheckedChanged_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxKullaniciAdi, "textBoxKullaniciAdi");
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.TextChanged += new System.EventHandler(this.textBoxKullaniciAdi_TextChanged);
            // 
            // labelHak
            // 
            resources.ApplyResources(this.labelHak, "labelHak");
            this.labelHak.BackColor = System.Drawing.SystemColors.Control;
            this.labelHak.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHak.Name = "labelHak";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonCikis, "buttonCikis");
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click_1);
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonGiris, "buttonGiris");
            this.buttonGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click_1);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label_tarihSaat);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label_tarihSaat
            // 
            resources.ApplyResources(this.label_tarihSaat, "label_tarihSaat");
            this.label_tarihSaat.BackColor = System.Drawing.SystemColors.Control;
            this.label_tarihSaat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_tarihSaat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_tarihSaat.Name = "label_tarihSaat";
            // 
            // Banka_Otomasyonu
            // 
            this.AcceptButton = this.buttonGiris;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Banka_Otomasyonu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BaseApp_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timersaat;
        private System.Windows.Forms.Timer timerzaman;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelzaman;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.CheckBox checkBoxGoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_tarihSaat;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
    }
}

