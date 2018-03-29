using System;


namespace GeneralShop.Data.Infrastructure
{
   public interface IDbFactory:IDisposable
    {
        ShopDbContext Init();
    }

}
