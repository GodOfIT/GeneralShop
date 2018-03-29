using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
       private ShopDbContext dbContext;
        public ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new Data.ShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
