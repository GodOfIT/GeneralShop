using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
    public interface IPageRepository : IRespository<Page>
    {
    }

    public class PageRepository : RespositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
