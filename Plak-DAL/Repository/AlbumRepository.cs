using Plak_DAL.Context;
using Plak_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DAL.Repository
{
    public class AlbumRepository : GenericRepository<Album>
    {
        public readonly AppDbContext _context;

        public AlbumRepository(AppDbContext context)
        {
            _context = context;
        }

        

        //Satışı durmuş albümler:
        public IQueryable<Album> GetSatisiOlmayanAlbumler()
        {
            return _context.Albums
                .Where(a => a.SatisDurumu == false)
                .Select(a => new Album
                {
                    AlbumId = a.AlbumId,
                    AlbumAdi = a.AlbumAdi,
                    Sanatci = a.Sanatci,
                    CikisTarihi = a.CikisTarihi,
                    Fiyat = a.Fiyat,
                    IndirimOrani = a.IndirimOrani,
                    SatisDurumu = a.SatisDurumu
                });


        }


        //Satışı devam eden albumler:
        public IQueryable<Album> GetSatisiOlanAlbumler()
        {
            return _context.Albums
            .Where(a => a.SatisDurumu)
            .Select(a => new Album
            {
                AlbumId = a.AlbumId,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu


            });

        }

        //Sisteme eklenen son 10 album:

        public IQueryable<Album> GetSonEklenenOnAlbum()
        {
            return _context.Albums
            .OrderBy(a => a.AlbumId)
            .Take(10)
            .Select(a => new Album
            {
                AlbumId = a.AlbumId,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu

            });

        }


        //İndirimdeki Albümleri Getir:
        public IQueryable<Album> getIndirimliAlbum()
        {
            return _context.Albums
            .Where(a => a.IndirimOrani.HasValue && a.IndirimOrani > 0)
            .Select(a => new Album
            {
                AlbumId = a.AlbumId,
                AlbumAdi = a.AlbumAdi,
                Sanatci = a.Sanatci,
                CikisTarihi = a.CikisTarihi,
                Fiyat = a.Fiyat,
                IndirimOrani = a.IndirimOrani,
                SatisDurumu = a.SatisDurumu
            });

        }


    }
}
