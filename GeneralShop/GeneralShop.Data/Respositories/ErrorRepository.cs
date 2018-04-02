using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
  
    public interface IErrorRepository : IRespository<Error>
    {
    }

    public class ErrorRepository : RespositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbfactory) : base(dbfactory)
        {

        }
    }
}
