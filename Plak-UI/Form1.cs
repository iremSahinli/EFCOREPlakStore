using Plak_DAL.Repository;
using Plak_DATA.Entity;
using System.Text;
using System.Security.Cryptography;
using Plak_DAL.Context;


namespace Plak_UI
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        //Veri taban� ba�lant�s�:
        private AdminRepository adminRepository;
        private AlbumRepository albumRepository;
        private Admin adminlogged;


        public Form1(AppDbContext context, AlbumRepository albumRepository, AdminRepository adminRepository, Admin adminlogged)
        {
            InitializeComponent();
            _context = context;
            this.albumRepository = albumRepository;
            this.adminRepository = adminRepository;
            this.adminlogged = adminlogged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpxGirisPanel.Enabled = true;
            grpxKayitPanel.Enabled = false;

        }







        private void btnGiris_Click(object sender, EventArgs e)
        {

            var context = new AppDbContext();
            adminRepository = new AdminRepository(context); //Yeni admin repository olu�turuldu.
            adminlogged = adminRepository.GetKullaniciAdi(txtKullaniciAdi.Text); //admin giri�i esnas�nda kullan�c� ad� kontrol ediliyor.


            if (adminlogged is null) //Admin giri�i do�ru de�ilse.
            {
                MessageBox.Show("Admin bulunamad�, tekrar deneyin!");
                return;
            }
            else
            {

                string girilenSifreHash = sha256_hash(txtSifre.Text); //�ifre kontrol� yap�l�yor.
                if (adminlogged.Sifre != girilenSifreHash)
                {
                    MessageBox.Show("Hatal� �ifre, tekrar deneyin!");
                    return;

                }

                MessageBox.Show("Giri� Ba�ar�l�");
                AlbumPanel albumPanel = new AlbumPanel(context, adminRepository, adminlogged, albumRepository);
                albumPanel.Show();
                this.Hide();

            }
        }

        private void btnIlkKayitOl_Click(object sender, EventArgs e)
        {
            if (!grpxKayitPanel.Enabled)
            {

                grpxGirisPanel.Enabled = false;
                grpxKayitPanel.Enabled = true;
                txtKullaniciAdi.Focus();
                return;
            }

        }


        private void btnKayit_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            adminRepository = new AdminRepository(context);

            string kullaniciAdi = txtYeniAd.Text;
            string ilkSifre = txtyeniSifre.Text;
            string sifreTekrar = txtTekrar.Text;


            if (ilkSifre != sifreTekrar)  //�lk �ifre kontrol� yap�l�yor.
            {
                MessageBox.Show("�ifreler ayn� de�il, tekrar deneyiniz!");
                return;
            }

            if (!ValidatePassword(ilkSifre))
            {
                MessageBox.Show("Girdi�iniz �ifre uygun formatta de�il, tekrar deneyiniz!");
                return;
            }

            if (adminRepository.GetKullaniciAdi(kullaniciAdi) != null)
            {
                MessageBox.Show("Bu kullan�c� ad� zaten mevcut. L�tfen ba�ka bir kullan�c� ad� girin.");
                return;
            }



            string passwordHash = sha256_hash(ilkSifre);

            Admin newAdmin = new Admin
            {
                Ad = kullaniciAdi,
                Sifre = passwordHash
            };

            adminRepository.InsertAdmin(newAdmin);
            context.SaveChanges();
            MessageBox.Show("Kay�t ba�ar�l�!");

            txtKullaniciAdi.Clear();
            txtyeniSifre.Clear();
            txtTekrar.Clear();


            grpxGirisPanel.Enabled = true;
            grpxKayitPanel.Enabled = false;


        }

        private bool ValidatePassword(string sifre)  //�ifre Kontrol�
        {
            // En az 8 karakter uzunlu�unda olmal�
            if (sifre.Length < 8)
                return false;
            // En az 2 b�y�k harf i�ermeli
            if (sifre.Count(char.IsUpper) < 2)
                return false;
            // En az 3 k���k harf i�ermeli
            if (sifre.Count(char.IsLower) < 3)
                return false;
            // �zel karakterler
            string specialChars = "!:+*";
            // En az 2 �zel karakter i�ermeli
            if (sifre.Count(c => specialChars.Contains(c)) < 2)
                return false;
            return true;
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                // �ifreyi hash'leyip hexadecimal string'e �evir
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnGirisPaneli_Click(object sender, EventArgs e)
        {
            grpxGirisPanel.Enabled = true;
            grpxKayitPanel.Enabled = false;
        }
    }
}

