using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
    public interface IFooterRepository : IRespository<Footer>
    {
    }

    public class FooterRepository: RespositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbfactory):base(dbfactory)
        {

        }
    }
}
