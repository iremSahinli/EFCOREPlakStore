namespace Plak_UI
{
    partial class AlbumPanel
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
            grpxAlbum = new GroupBox();
            btnGuncelle = new Button();
            btnSatisiDuranAlbumler = new Button();
            btnIndirimdekiAlbumler = new Button();
            btnSil = new Button();
            btnSatistakiAlbumler = new Button();
            btnEklenenSonOnAlbum = new Button();
            btnEkle = new Button();
            btnGetir = new Button();
            lstListe = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            grpxYeniAlbum = new GroupBox();
            cmxSatisDurum = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAlbumKayit = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIndirim = new TextBox();
            txtFiyat = new TextBox();
            txtSanatci = new TextBox();
            txtAlbumAdi = new TextBox();
            grpxAlbum.SuspendLayout();
            grpxYeniAlbum.SuspendLayout();
            SuspendLayout();
            // 
            // grpxAlbum
            // 
            grpxAlbum.Controls.Add(btnGuncelle);
            grpxAlbum.Controls.Add(btnSatisiDuranAlbumler);
            grpxAlbum.Controls.Add(btnIndirimdekiAlbumler);
            grpxAlbum.Controls.Add(btnSil);
            grpxAlbum.Controls.Add(btnSatistakiAlbumler);
            grpxAlbum.Controls.Add(btnEklenenSonOnAlbum);
            grpxAlbum.Controls.Add(btnEkle);
            grpxAlbum.Controls.Add(btnGetir);
            grpxAlbum.Controls.Add(lstListe);
            grpxAlbum.Location = new Point(47, 48);
            grpxAlbum.Name = "grpxAlbum";
            grpxAlbum.Size = new Size(814, 566);
            grpxAlbum.TabIndex = 0;
            grpxAlbum.TabStop = false;
            grpxAlbum.Text = "Album Panel";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(301, 278);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(204, 49);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSatisiDuranAlbumler
            // 
            btnSatisiDuranAlbumler.Location = new Point(52, 441);
            btnSatisiDuranAlbumler.Name = "btnSatisiDuranAlbumler";
            btnSatisiDuranAlbumler.Size = new Size(204, 46);
            btnSatisiDuranAlbumler.TabIndex = 0;
            btnSatisiDuranAlbumler.Text = "SATIŞI OLMAYAN ALBÜMLERİ GÖSTER";
            btnSatisiDuranAlbumler.UseVisualStyleBackColor = true;
            btnSatisiDuranAlbumler.Click += btnSatisiDuranAlbumler_Click;
            // 
            // btnIndirimdekiAlbumler
            // 
            btnIndirimdekiAlbumler.Location = new Point(301, 441);
            btnIndirimdekiAlbumler.Name = "btnIndirimdekiAlbumler";
            btnIndirimdekiAlbumler.Size = new Size(204, 46);
            btnIndirimdekiAlbumler.TabIndex = 0;
            btnIndirimdekiAlbumler.Text = "İNDİRİMDEKİ ALBUMLERİ GETİR";
            btnIndirimdekiAlbumler.UseVisualStyleBackColor = true;
            btnIndirimdekiAlbumler.Click += btnIndirimdekiAlbumler_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(301, 362);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(204, 49);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnSatistakiAlbumler
            // 
            btnSatistakiAlbumler.Location = new Point(563, 356);
            btnSatistakiAlbumler.Name = "btnSatistakiAlbumler";
            btnSatistakiAlbumler.Size = new Size(203, 55);
            btnSatistakiAlbumler.TabIndex = 0;
            btnSatistakiAlbumler.Text = "SATIŞTAKİ ALBÜMLERİ GETİR";
            btnSatistakiAlbumler.UseVisualStyleBackColor = true;
            btnSatistakiAlbumler.Click += btnSatistakiAlbumler_Click;
            // 
            // btnEklenenSonOnAlbum
            // 
            btnEklenenSonOnAlbum.Location = new Point(563, 278);
            btnEklenenSonOnAlbum.Name = "btnEklenenSonOnAlbum";
            btnEklenenSonOnAlbum.Size = new Size(203, 49);
            btnEklenenSonOnAlbum.TabIndex = 0;
            btnEklenenSonOnAlbum.Text = "SON EKLENEN 10 ALBUMU GETİR";
            btnEklenenSonOnAlbum.UseVisualStyleBackColor = true;
            btnEklenenSonOnAlbum.Click += btnEklenenSonOnAlbum_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(52, 362);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(204, 49);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(52, 278);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(204, 49);
            btnGetir.TabIndex = 1;
            btnGetir.Text = "GETİR";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // lstListe
            // 
            lstListe.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstListe.GridLines = true;
            lstListe.Location = new Point(52, 29);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(714, 219);
            lstListe.TabIndex = 0;
            lstListe.UseCompatibleStateImageBehavior = false;
            lstListe.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "AlbumId";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Album Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sanatçı";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Çıkış Tarihi";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fiyat";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İndirim Oranı";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Satış Durumu";
            columnHeader7.Width = 100;
            // 
            // grpxYeniAlbum
            // 
            grpxYeniAlbum.Controls.Add(cmxSatisDurum);
            grpxYeniAlbum.Controls.Add(dateTimePicker1);
            grpxYeniAlbum.Controls.Add(btnAlbumKayit);
            grpxYeniAlbum.Controls.Add(label6);
            grpxYeniAlbum.Controls.Add(label5);
            grpxYeniAlbum.Controls.Add(label3);
            grpxYeniAlbum.Controls.Add(label4);
            grpxYeniAlbum.Controls.Add(label2);
            grpxYeniAlbum.Controls.Add(label1);
            grpxYeniAlbum.Controls.Add(txtIndirim);
            grpxYeniAlbum.Controls.Add(txtFiyat);
            grpxYeniAlbum.Controls.Add(txtSanatci);
            grpxYeniAlbum.Controls.Add(txtAlbumAdi);
            grpxYeniAlbum.Location = new Point(929, 48);
            grpxYeniAlbum.Name = "grpxYeniAlbum";
            grpxYeniAlbum.Size = new Size(419, 566);
            grpxYeniAlbum.TabIndex = 1;
            grpxYeniAlbum.TabStop = false;
            grpxYeniAlbum.Text = "Yeni Album Kayıt";
            // 
            // cmxSatisDurum
            // 
            cmxSatisDurum.FormattingEnabled = true;
            cmxSatisDurum.Items.AddRange(new object[] { "Stokta Var", "Stokta Yok" });
            cmxSatisDurum.Location = new Point(191, 311);
            cmxSatisDurum.Name = "cmxSatisDurum";
            cmxSatisDurum.Size = new Size(179, 23);
            cmxSatisDurum.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAlbumKayit
            // 
            btnAlbumKayit.Location = new Point(116, 370);
            btnAlbumKayit.Name = "btnAlbumKayit";
            btnAlbumKayit.Size = new Size(254, 55);
            btnAlbumKayit.TabIndex = 2;
            btnAlbumKayit.Text = "SİSTEME KAYDET";
            btnAlbumKayit.UseVisualStyleBackColor = true;
            btnAlbumKayit.Click += btnAlbumKayit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 312);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 1;
            label6.Text = "Satış Durum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 257);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 1;
            label5.Text = "İndirim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 155);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 209);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Fiyat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 100);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 52);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Album Adı:";
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(191, 257);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(179, 23);
            txtIndirim.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(191, 201);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(179, 23);
            txtFiyat.TabIndex = 0;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(191, 97);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(179, 23);
            txtSanatci.TabIndex = 0;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(191, 49);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(179, 23);
            txtAlbumAdi.TabIndex = 0;
            // 
            // AlbumPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1376, 673);
            Controls.Add(grpxYeniAlbum);
            Controls.Add(grpxAlbum);
            Name = "AlbumPanel";
            Text = "AlbumPanel";
            Load += AlbumPanel_Load;
            grpxAlbum.ResumeLayout(false);
            grpxYeniAlbum.ResumeLayout(false);
            grpxYeniAlbum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpxAlbum;
        private Button btnSatisiDuranAlbumler;
        private Button btnSatistakiAlbumler;
        private Button btnEklenenSonOnAlbum;
        private Button btnIndirimdekiAlbumler;
        private ListView lstListe;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGetir;
        private GroupBox grpxYeniAlbum;
        private TextBox txtFiyat;
        private TextBox txtSanatci;
        private TextBox txtAlbumAdi;
        private Button btnAlbumKayit;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtIndirim;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmxSatisDurum;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}