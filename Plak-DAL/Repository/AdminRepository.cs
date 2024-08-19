using Microsoft.EntityFrameworkCore;
using Plak_DAL.Context;
using Plak_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DAL.Repository
{
    public class AdminRepository : GenericRepository<Admin>
    {
        public readonly AppDbContext _context;

        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }

        public void InsertAdmin(Admin admin)
        {

            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public Admin GetKullaniciAdi(string kullaniciAdi)
        {
            return _context.Admins.FirstOrDefault(ad => ad.Ad == kullaniciAdi);
        }


    }
}
