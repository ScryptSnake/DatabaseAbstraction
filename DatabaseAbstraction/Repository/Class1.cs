using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstraction.Entities;

namespace DatabaseAbstraction.Repository
{
    public sealed class OrderRepository: IOrderRepository
    {
        public bool OrderExists(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> OrderExistsAsync(long id)
        {
            throw new NotImplementedException();
        }

        public SalesOrder CreateOrder(SalesOrder newOrder)
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrder> CreateOrderAsync(SalesOrder newOrder)
        {
            throw new NotImplementedException();
        }

        public SalesOrder GetOrder(long id)
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrder> GetOrderAsync(long id)
        {
            throw new NotImplementedException();
        }

        public SalesOrder UpdateOrder(SalesOrder location)
        {
            throw new NotImplementedException();
        }

        public Task<SalesOrder> UpdateOrderAsync(SalesOrder location)
        {
            throw new NotImplementedException();
        }
    }
}
