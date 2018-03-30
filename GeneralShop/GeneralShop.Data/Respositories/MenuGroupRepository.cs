using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;

namespace GeneralShop.Data.Respositories
{
    public interface IMenuGroupRepository : IRespository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RespositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
