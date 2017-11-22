using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuzeyYeli.ORM.Models;

namespace KuzeyYeli
{
    public class RepositoryBase<T> where  T:class
    {
        private static NorthwindContext _context;

        public static NorthwindContext Context
        {
            get { if (_context == null) { _context = new NorthwindContext(); } return _context; }
            set { _context = value; }
        }


        public List<T> Listele() 
        {
            return Context.Set<T>().ToList();
        }

        public bool Ekle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Bu metod SaveChanges yapmadan eleman ekler. Döngülerde Ekle(T) yerine bunu kullanınca performans saglar
        /// </summary>
        /// <param name="entity">single item of your entity</param>
        /// <returns>true if success.</returns>
        public bool SeriEkle(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Guncelle(T entity)
        {
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Sil(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Bu metod SaveChanges yapmadan eleman siler. Döngülerde Sil(T) yerine bunu kullanınca performans saglar
        /// </summary>
        /// <param name="entity">single item of your entity</param>
        /// <returns>true if success.</returns>
        public bool SeriSil(T entity)
        {
            try
            {
                Context.Set<T>().Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
