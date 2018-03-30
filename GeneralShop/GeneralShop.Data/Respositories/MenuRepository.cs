using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
    public interface IMenuRepository : IRespository<Menu>
    {
    }
    public class MenuRepository:RespositoryBase<Menu>,IMenuRepository
    {
        public MenuRepository(IDbFactory dbfactory):base(dbfactory)
        {

        }
    }
}
