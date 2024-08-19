using Plak_DAL.Context;
using Plak_DAL.Repository;
using Plak_DATA.Entity;
using Plak_UI.Utilities;


namespace Plak_UI
{
    public partial class AlbumPanel : Form
    {

        private readonly AppDbContext _context; //Db context örneği saklanacak.
        private AdminRepository _adminRepository;
        private AlbumRepository _albumRepository;
        private Admin _adminlogged;


        public AlbumPanel(AppDbContext context, AdminRepository adminRepository, Admin adminlogged, AlbumRepository albumRepository)
        {
            InitializeComponent();
            _context = context;
            _adminRepository = adminRepository;
            _adminlogged = adminlogged;
            if (albumRepository == null)
                throw new ArgumentNullException(nameof(albumRepository));

            _albumRepository = albumRepository;

            if (adminlogged == null) //sistemde login olmuş admin varmı kontrol edilir.
            {
                MessageBox.Show("Giriş yapmış admin bulunamadı!");
            }
            lstListe.FullRowSelect = true;
            lstListe.View = View.Details;
        }



        private void AlbumPanel_Load(object sender, EventArgs e)
        {

            bool albumVarmı = _context.Albums.Any();  //Databasede kayıtlı album varmı kontrol eder ve panelleri kapatıp açar.
            if (albumVarmı)
            {
                grpxAlbum.Enabled = true;
                grpxYeniAlbum.Enabled = true;
            }
            else
            {
                grpxAlbum.Enabled = false;
                grpxYeniAlbum.Enabled = true;
                MessageBox.Show("Sistemde kayıtlı album yok, lütfen ekleyiniz!");
            }
            FormUtilities.ListeyiGüncelle(lstListe, _context); //Utilities metotlarını kullanmak için ekledim.



        }
        private void btnAlbumKayit_Click(object sender, EventArgs e)
        {


            string albumAdi = txtAlbumAdi.Text;
            string sanatci = txtSanatci.Text;
            DateTime cikisTarihi = dateTimePicker1.Value;
            decimal fiyat = decimal.Parse(txtFiyat.Text);
            double? indirimOrani = null;  //Boşsa 0 olarak aldık.
            if (!string.IsNullOrEmpty(txtIndirim.Text))
            {
                double parsedIndirim;
                if (double.TryParse(txtIndirim.Text, out parsedIndirim))
                {
                    indirimOrani = parsedIndirim;
                }


            }
            bool satisDurumu = cmxSatisDurum.Text == "Stokta Var" ? true : false;

            if (string.IsNullOrEmpty(albumAdi) || string.IsNullOrEmpty(sanatci) || fiyat <= 0) //Değerler doğrumu girildi kontrol ediyoruz
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }




            Album yeniAlbum = new Album()  //Listview kısmına albumu ekle.
            {
                AlbumAdi = albumAdi,
                Sanatci = sanatci,
                CikisTarihi = cikisTarihi,
                Fiyat = fiyat,
                IndirimOrani = indirimOrani,
                SatisDurumu = satisDurumu,
                AdminId = _adminlogged.AdminId  //Ekleyen adminId verilmeli.
            };

            _context.Albums.Add(yeniAlbum);
            _context.SaveChanges();
            MessageBox.Show("Album Kaydı Başarılı");
            FormUtilities.GirilenVerileriTemizle(grpxYeniAlbum, _context);

            FormUtilities.ListeyiGüncelle(lstListe, _context);

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (lstListe.SelectedItems.Count > 0)
            {
                var secilenAlbum = lstListe.SelectedItems[0];
                int albumId = int.Parse(secilenAlbum.Text);

                var silinenAlbum = _albumRepository.Delete(albumId);
                if (silinenAlbum != null)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                    FormUtilities.ListeyiGüncelle(lstListe, _context);
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız");
                }

            }
        }



        private void btnGetir_Click(object sender, EventArgs e)
        {
            FormUtilities.ListeyiGüncelle(lstListe, _context);
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItems.Count > 0) // Eğer bir item seçildiyse
            {
                var selectedItem = lstListe.SelectedItems[0]; // Seçilen item'i al
                int albumId = int.Parse(selectedItem.Text); // İlk sütundaki ID'yi al

                var albumToUpdate = _context.Albums.Find(albumId); // Veritabanından albümü bul

                if (albumToUpdate != null)
                {
                    GuncellemePanel guncellemePanel = new GuncellemePanel(_context, albumToUpdate, lstListe);
                    guncellemePanel.Show();

                }
                else
                {
                    MessageBox.Show("Güncellenecek albümü yok");
                }

            }
            else
            {
                MessageBox.Show("Güncelleme işlemi için listeden bir veri seçin");
            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            grpxYeniAlbum.Enabled = true;
            txtAlbumAdi.Focus();
        }

        private void btnSatistakiAlbumler_Click(object sender, EventArgs e)
        {

            if (_albumRepository != null)
            {
                var satisiOlanUrunler = _albumRepository.GetSatisiOlanAlbumler();


                lstListe.Items.Clear();
                foreach (var album in satisiOlanUrunler)
                {
                    ListViewItem item = new ListViewItem(album.AlbumId.ToString());
                    item.SubItems.Add(album.AlbumAdi);
                    item.SubItems.Add(album.Sanatci);
                    item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                    item.SubItems.Add(album.Fiyat.ToString("C"));
                    item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                    item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");
                    lstListe.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı albüm yok, lütfen albüm kayıt ekleyiniz.");
            }





        }

        private void btnSatisiDuranAlbumler_Click(object sender, EventArgs e)
        {
            if (_albumRepository != null)
            {
                var satisiOlmayanUrunler = _albumRepository.GetSatisiOlmayanAlbumler();


                lstListe.Items.Clear();
                foreach (var album in satisiOlmayanUrunler)
                {
                    ListViewItem item = new ListViewItem(album.AlbumId.ToString());
                    item.SubItems.Add(album.AlbumAdi);
                    item.SubItems.Add(album.Sanatci);
                    item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                    item.SubItems.Add(album.Fiyat.ToString("C"));
                    item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                    item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");
                    lstListe.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı albüm yok, lütfen albüm kayıt ekleyiniz.");
            }

        }

        private void btnIndirimdekiAlbumler_Click(object sender, EventArgs e)
        {
            if (_albumRepository != null)
            {
                var indirimliAlbumler = _albumRepository.getIndirimliAlbum();
                lstListe.Items.Clear();
                foreach (var album in indirimliAlbumler)
                {
                    ListViewItem item = new ListViewItem(album.AlbumId.ToString());
                    item.SubItems.Add(album.AlbumAdi);
                    item.SubItems.Add(album.Sanatci);
                    item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                    item.SubItems.Add(album.Fiyat.ToString("C"));
                    item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                    item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");
                    lstListe.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı albüm yok, lütfen albüm kayıt ekleyiniz.");
            }
        }

        private void btnEklenenSonOnAlbum_Click(object sender, EventArgs e)
        {
            if (_albumRepository != null)
            {
                var sonOnAlbum = _albumRepository.GetSonEklenenOnAlbum();
                lstListe.Items.Clear();
                foreach (var album in sonOnAlbum)
                {
                    ListViewItem item = new ListViewItem(album.AlbumId.ToString());
                    item.SubItems.Add(album.AlbumAdi);
                    item.SubItems.Add(album.Sanatci);
                    item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                    item.SubItems.Add(album.Fiyat.ToString("C"));
                    item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                    item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");
                    lstListe.Items.Add(item);
                }


            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı albüm yok, lütfen albüm kayıt ekleyiniz.");
            }
        }

        
    }
}



