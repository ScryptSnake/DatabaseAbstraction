using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAbstraction.Entities;

namespace DatabaseAbstraction.Repository;

/// <summary>
/// Defines a contract for which any Order Repository should use. 
/// </summary>
public interface IOrderRepository{

    public bool OrderExists(long id);
    public Task<bool> OrderExistsAsync(long id);

    public SalesOrder CreateOrder(SalesOrder newOrder);
    public Task<SalesOrder> CreateOrderAsync(SalesOrder newOrder);

    public SalesOrder GetOrder(long id);
    public Task<SalesOrder> GetOrderAsync(long id);

    public SalesOrder UpdateOrder(SalesOrder location);
    public Task<SalesOrder> UpdateOrderAsync(SalesOrder location);
}