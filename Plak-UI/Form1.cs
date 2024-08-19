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
        //Veri tabaný baðlantýsý:
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
            adminRepository = new AdminRepository(context); //Yeni admin repository oluþturuldu.
            adminlogged = adminRepository.GetKullaniciAdi(txtKullaniciAdi.Text); //admin giriþi esnasýnda kullanýcý adý kontrol ediliyor.


            if (adminlogged is null) //Admin giriþi doðru deðilse.
            {
                MessageBox.Show("Admin bulunamadý, tekrar deneyin!");
                return;
            }
            else
            {

                string girilenSifreHash = sha256_hash(txtSifre.Text); //Þifre kontrolü yapýlýyor.
                if (adminlogged.Sifre != girilenSifreHash)
                {
                    MessageBox.Show("Hatalý þifre, tekrar deneyin!");
                    return;

                }

                MessageBox.Show("Giriþ Baþarýlý");
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


            if (ilkSifre != sifreTekrar)  //Ýlk þifre kontrolü yapýlýyor.
            {
                MessageBox.Show("Þifreler ayný deðil, tekrar deneyiniz!");
                return;
            }

            if (!ValidatePassword(ilkSifre))
            {
                MessageBox.Show("Girdiðiniz þifre uygun formatta deðil, tekrar deneyiniz!");
                return;
            }

            if (adminRepository.GetKullaniciAdi(kullaniciAdi) != null)
            {
                MessageBox.Show("Bu kullanýcý adý zaten mevcut. Lütfen baþka bir kullanýcý adý girin.");
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
            MessageBox.Show("Kayýt baþarýlý!");

            txtKullaniciAdi.Clear();
            txtyeniSifre.Clear();
            txtTekrar.Clear();


            grpxGirisPanel.Enabled = true;
            grpxKayitPanel.Enabled = false;


        }

        private bool ValidatePassword(string sifre)  //Þifre Kontrolü
        {
            // En az 8 karakter uzunluðunda olmalý
            if (sifre.Length < 8)
                return false;
            // En az 2 büyük harf içermeli
            if (sifre.Count(char.IsUpper) < 2)
                return false;
            // En az 3 küçük harf içermeli
            if (sifre.Count(char.IsLower) < 3)
                return false;
            // Özel karakterler
            string specialChars = "!:+*";
            // En az 2 özel karakter içermeli
            if (sifre.Count(c => specialChars.Contains(c)) < 2)
                return false;
            return true;
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                // Þifreyi hash'leyip hexadecimal string'e çevir
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

