namespace Plak_UI
{
    partial class GuncellemePanel
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
            grpxYeniAlbum = new GroupBox();
            cmxSatisDurum = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAlbumPanelDon = new Button();
            btnGuncelle = new Button();
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
            grpxYeniAlbum.SuspendLayout();
            SuspendLayout();
            // 
            // grpxYeniAlbum
            // 
            grpxYeniAlbum.Controls.Add(cmxSatisDurum);
            grpxYeniAlbum.Controls.Add(dateTimePicker1);
            grpxYeniAlbum.Controls.Add(btnAlbumPanelDon);
            grpxYeniAlbum.Controls.Add(btnGuncelle);
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
            grpxYeniAlbum.Location = new Point(39, 38);
            grpxYeniAlbum.Name = "grpxYeniAlbum";
            grpxYeniAlbum.Size = new Size(419, 566);
            grpxYeniAlbum.TabIndex = 2;
            grpxYeniAlbum.TabStop = false;
            grpxYeniAlbum.Text = "Album Güncelleme Paneli";
            // 
            // cmxSatisDurum
            // 
            cmxSatisDurum.FormattingEnabled = true;
            cmxSatisDurum.Items.AddRange(new object[] { "Stokta Var", "Stokta Yok" });
            cmxSatisDurum.Location = new Point(163, 298);
            cmxSatisDurum.Name = "cmxSatisDurum";
            cmxSatisDurum.Size = new Size(179, 23);
            cmxSatisDurum.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 142);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAlbumPanelDon
            // 
            btnAlbumPanelDon.Location = new Point(88, 430);
            btnAlbumPanelDon.Name = "btnAlbumPanelDon";
            btnAlbumPanelDon.Size = new Size(254, 55);
            btnAlbumPanelDon.TabIndex = 2;
            btnAlbumPanelDon.Text = "LİSTEYE GERİ DÖN";
            btnAlbumPanelDon.UseVisualStyleBackColor = true;
            btnAlbumPanelDon.Click += btnAlbumPanelDon_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(88, 357);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(254, 55);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE VE KAYDET";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 299);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 1;
            label6.Text = "Satış Durum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 244);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 1;
            label5.Text = "İndirim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 196);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Fiyat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 87);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Album Adı:";
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(163, 244);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(179, 23);
            txtIndirim.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(163, 188);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(179, 23);
            txtFiyat.TabIndex = 0;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(163, 84);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(179, 23);
            txtSanatci.TabIndex = 0;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(163, 36);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(179, 23);
            txtAlbumAdi.TabIndex = 0;
            // 
            // GuncellemePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 702);
            Controls.Add(grpxYeniAlbum);
            Name = "GuncellemePanel";
            Text = "GuncellemePanel";
            Load += GuncellemePanel_Load;
            grpxYeniAlbum.ResumeLayout(false);
            grpxYeniAlbum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpxYeniAlbum;
        private ComboBox cmxSatisDurum;
        private DateTimePicker dateTimePicker1;
        private Button btnAlbumPanelDon;
        private Button btnGuncelle;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtIndirim;
        private TextBox txtFiyat;
        private TextBox txtSanatci;
        private TextBox txtAlbumAdi;
    }
}