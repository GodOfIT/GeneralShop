using GeneralShop.Data.Infrastructure;
using GeneralShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralShop.Data.Respositories
{
    public interface IOrderDetailRepository : IRespository<OrderDetail>
    {
    }
    public class OrderDetailRepository : RespositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbf) :base(dbf)
        {

        }
    }
}
