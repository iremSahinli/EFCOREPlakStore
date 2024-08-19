namespace Plak_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpxGirisPanel = new GroupBox();
            btnIlkKayitOl = new Button();
            btnGiris = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            grpxKayitPanel = new GroupBox();
            btnKayit = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTekrar = new TextBox();
            txtyeniSifre = new TextBox();
            txtYeniAd = new TextBox();
            btnGirisPaneli = new Button();
            grpxGirisPanel.SuspendLayout();
            grpxKayitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // grpxGirisPanel
            // 
            grpxGirisPanel.Controls.Add(btnIlkKayitOl);
            grpxGirisPanel.Controls.Add(btnGiris);
            grpxGirisPanel.Controls.Add(label2);
            grpxGirisPanel.Controls.Add(label1);
            grpxGirisPanel.Controls.Add(txtSifre);
            grpxGirisPanel.Controls.Add(txtKullaniciAdi);
            grpxGirisPanel.Location = new Point(52, 49);
            grpxGirisPanel.Margin = new Padding(4);
            grpxGirisPanel.Name = "grpxGirisPanel";
            grpxGirisPanel.Padding = new Padding(4);
            grpxGirisPanel.Size = new Size(329, 311);
            grpxGirisPanel.TabIndex = 0;
            grpxGirisPanel.TabStop = false;
            grpxGirisPanel.Text = "Admin Giriş Paneli";
            // 
            // btnIlkKayitOl
            // 
            btnIlkKayitOl.Location = new Point(25, 242);
            btnIlkKayitOl.Margin = new Padding(4);
            btnIlkKayitOl.Name = "btnIlkKayitOl";
            btnIlkKayitOl.Size = new Size(262, 41);
            btnIlkKayitOl.TabIndex = 4;
            btnIlkKayitOl.Text = "İLK KAYIT";
            btnIlkKayitOl.UseVisualStyleBackColor = true;
            btnIlkKayitOl.Click += btnIlkKayitOl_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(25, 193);
            btnGiris.Margin = new Padding(4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(262, 41);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(105, 131);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(182, 23);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(105, 83);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(182, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // grpxKayitPanel
            // 
            grpxKayitPanel.Controls.Add(btnGirisPaneli);
            grpxKayitPanel.Controls.Add(btnKayit);
            grpxKayitPanel.Controls.Add(label5);
            grpxKayitPanel.Controls.Add(label3);
            grpxKayitPanel.Controls.Add(label4);
            grpxKayitPanel.Controls.Add(txtTekrar);
            grpxKayitPanel.Controls.Add(txtyeniSifre);
            grpxKayitPanel.Controls.Add(txtYeniAd);
            grpxKayitPanel.Location = new Point(438, 49);
            grpxKayitPanel.Margin = new Padding(4);
            grpxKayitPanel.Name = "grpxKayitPanel";
            grpxKayitPanel.Padding = new Padding(4);
            grpxKayitPanel.Size = new Size(329, 311);
            grpxKayitPanel.TabIndex = 0;
            grpxKayitPanel.TabStop = false;
            grpxKayitPanel.Text = "Admin Kayıt Paneli";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(35, 217);
            btnKayit.Margin = new Padding(4);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(262, 41);
            btnKayit.TabIndex = 4;
            btnKayit.Text = "KAYIT OL";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 127);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 3;
            label5.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Şifre Tekrarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Kullanıcı Adı:";
            // 
            // txtTekrar
            // 
            txtTekrar.Location = new Point(119, 176);
            txtTekrar.Margin = new Padding(4);
            txtTekrar.Name = "txtTekrar";
            txtTekrar.Size = new Size(182, 23);
            txtTekrar.TabIndex = 1;
            // 
            // txtyeniSifre
            // 
            txtyeniSifre.Location = new Point(119, 127);
            txtyeniSifre.Margin = new Padding(4);
            txtyeniSifre.Name = "txtyeniSifre";
            txtyeniSifre.Size = new Size(182, 23);
            txtyeniSifre.TabIndex = 1;
            // 
            // txtYeniAd
            // 
            txtYeniAd.Location = new Point(119, 79);
            txtYeniAd.Margin = new Padding(4);
            txtYeniAd.Name = "txtYeniAd";
            txtYeniAd.Size = new Size(182, 23);
            txtYeniAd.TabIndex = 0;
            // 
            // btnGirisPaneli
            // 
            btnGirisPaneli.Location = new Point(35, 266);
            btnGirisPaneli.Margin = new Padding(4);
            btnGirisPaneli.Name = "btnGirisPaneli";
            btnGirisPaneli.Size = new Size(262, 41);
            btnGirisPaneli.TabIndex = 5;
            btnGirisPaneli.Text = "GİRİŞ SAYFASINA GİT";
            btnGirisPaneli.UseVisualStyleBackColor = true;
            btnGirisPaneli.Click += btnGirisPaneli_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(826, 455);
            Controls.Add(grpxKayitPanel);
            Controls.Add(grpxGirisPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpxGirisPanel.ResumeLayout(false);
            grpxGirisPanel.PerformLayout();
            grpxKayitPanel.ResumeLayout(false);
            grpxKayitPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpxGirisPanel;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private GroupBox grpxKayitPanel;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtTekrar;
        private TextBox txtyeniSifre;
        private TextBox txtYeniAd;
        private Button btnGiris;
        private Button btnKayit;
        private Button btnIlkKayitOl;
        private Button btnGirisPaneli;
    }
}
