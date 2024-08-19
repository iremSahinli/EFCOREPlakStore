using Plak_DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DAL.Repository
{
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        public AppDbContext context;

        public GenericRepository()
        {
            context = new AppDbContext();
        }

        //Temel CRUD İşlemleri:
        //Albüm listesini getir:
        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();

        }


        //Id ye göre bilgileri getir:
        public TEntity GetById(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);

            }
            catch (Exception ex)
            {

                throw new Exception("İşlem başarısız");
            }

        }

        //Ekleme İşlemi:
        public int Add(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Add(entity);

                Console.WriteLine(" Ekleme İşlem Başarılı");
                return context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Ekleme işlemi başarısız");
            }

        }


        //Güncelleme işlemi: 
        public int Update(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Update(entity);

                Console.WriteLine("Güncelleme işlemi başarılı");
                return context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Güncelleme işlemi başarısız");
            }

        }

        //Silme İşlemi:
        public int Delete(int id)
        {
            try
            {
                TEntity entity = GetById(id);
                context.Set<TEntity>().Remove(entity);

                Console.WriteLine("Silme işlemi başarılı");
                return context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Silme işlemi başarısız");
            }
        }

    }
}
