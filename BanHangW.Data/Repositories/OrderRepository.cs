using BanHangW.Data.Infrastructure;
using BanHangW.Model.Models;
using System.Collections.Generic;

namespace BanHangW.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}