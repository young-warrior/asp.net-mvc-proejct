using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    /*Класс, который использует интерфейс IProductRepository, 
     * может получить объекты Product, не зная того, 
     * где они содержатся или каким образом будут ему поставлены. 
     * Это и есть суть шаблона хранилища.*/
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
