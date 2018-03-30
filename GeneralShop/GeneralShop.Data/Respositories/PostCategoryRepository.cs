using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
    public interface IPostCategoryRepository : IRespository<PostCategory>
    {
    }

    public class PostCategoryRepository : RespositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
