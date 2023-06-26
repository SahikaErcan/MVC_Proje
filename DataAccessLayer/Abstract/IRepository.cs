using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        // CRUD
        // Listeleme, Ekleme, Güncelleme, Silme
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        // Şartlı listeleme - Yazar adı Ali olanları getir gibi..
        List<T> List(Expression<Func<T, bool>> expression);
    }
}
