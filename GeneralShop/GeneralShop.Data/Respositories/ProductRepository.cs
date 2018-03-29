using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;

namespace GeneralShop.Data.Respositories
{
    public interface IProductRepository
    { }
    public class ProductRepository: RespositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory): base (dbFactory)
        {

        }
    }
}
