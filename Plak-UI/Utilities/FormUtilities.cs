using Microsoft.EntityFrameworkCore;
using Plak_DAL.Context;
using Plak_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plak_UI.Utilities
{
    public static class FormUtilities
    {

        public static void ListeyiGüncelle(ListView lstliste, AppDbContext context)
        {
            var albums = context.Albums.ToList();


            lstliste.Items.Clear();  //Listedeki verileri temizle.

            // Albümleri ListView'a ekle
            foreach (var album in albums)
            {
                ListViewItem item = new ListViewItem(album.AlbumId.ToString());
                item.SubItems.Add(album.AlbumAdi);
                item.SubItems.Add(album.Sanatci);
                item.SubItems.Add(album.CikisTarihi.ToShortDateString());
                item.SubItems.Add(album.Fiyat.ToString("C"));
                item.SubItems.Add(album.IndirimOrani.HasValue ? (album.IndirimOrani.Value / 100).ToString("P2") : "%0");
                item.SubItems.Add(album.SatisDurumu ? "Stokta Var" : "Stokta Yok");

                lstliste.Items.Add(item);
            }
        }
        public static void GirilenVerileriTemizle(GroupBox groupBox, AppDbContext context)
        {
            // GroupBox içindeki tüm kontrolleri dolaşır
            foreach (Control control in groupBox.Controls)
            {
                // Kontrollerin türüne göre veri temizleme işlemlerini gerçekleştirir
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                // Diğer kontrol türleri için benzer işlemler eklenebilir
            }



        }
    }
}
