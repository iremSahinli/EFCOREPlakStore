using Plak_DAL.Context;
using Plak_DATA.Entity;
using Plak_UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plak_UI
{
    public partial class GuncellemePanel : Form
    {
        private readonly AppDbContext _context; //Context yapısı, Güncellemek için album verileri ve yapılan işlemler listeye yansısın diye global alanadahil ettik.
        private Album _album;
        private ListView _listView;

        public GuncellemePanel(AppDbContext context, Album album, ListView listView)
        {
            InitializeComponent();
            _context = context;
            _album = album;
            _listView = listView;
        }

        private void GuncellemePanel_Load(object sender, EventArgs e)
        {
            // Formdaki alanlara verileri doldur
            txtAlbumAdi.Text = _album.AlbumAdi;
            txtSanatci.Text = _album.Sanatci;
            dateTimePicker1.Value = _album.CikisTarihi;
            txtFiyat.Text = _album.Fiyat.ToString();
            txtIndirim.Text = _album.IndirimOrani.HasValue ? _album.IndirimOrani.Value.ToString() : string.Empty;
            cmxSatisDurum.Text = _album.SatisDurumu ? "Stokta Var" : "Stokta Yok";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _album.AlbumAdi = txtAlbumAdi.Text;
            _album.Sanatci = txtSanatci.Text;
            _album.CikisTarihi = dateTimePicker1.Value;
            _album.Fiyat = decimal.Parse(txtFiyat.Text);
            _album.IndirimOrani = !string.IsNullOrEmpty(txtIndirim.Text) ? double.Parse(txtIndirim.Text) : (double?)null;
            _album.SatisDurumu = cmxSatisDurum.Text == "Stokta Var";

            _context.Albums.Update(_album);
            _context.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");

            FormUtilities.ListeyiGüncelle(_listView, _context);
            this.Close();
        }





        private void btnAlbumPanelDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
