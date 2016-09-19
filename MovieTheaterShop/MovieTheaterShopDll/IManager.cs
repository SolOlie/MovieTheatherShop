using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterShopDll
{
    
        public interface IManager<T>
        {
            T Create(T t);
            void Delete(T t);
            T Update(T t);

            List<T> ReadAll();
            T ReadOne(int id);
    }
}
