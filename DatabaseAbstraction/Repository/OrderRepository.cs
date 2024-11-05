using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CashMapper.DataAccess;
using DatabaseAbstraction.DataAccess;
using DatabaseAbstraction.Entities;

namespace DatabaseAbstraction.Repository;


public sealed class OrderRepository: IOrderRepository
{

    public Task<IDatabase> GetDatabaseTask { get; } // Store the factory Get task.

    public OrderRepository(IDatabaseFactory databaseFactory)
    {
        GetDatabaseTask = databaseFactory.GetDatabase();
    }

    public bool OrderExists(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> OrderExistsAsync(long id)
    {
        throw new NotImplementedException();
    }

    public SalesOrder CreateOrder(SalesOrder newOrder)
    {

        throw new NotImplementedException();
    }

    public async Task<SalesOrder> CreateOrderAsync(SalesOrder newOrder)
    {
        // Await the database GET.
        var db = await GetDatabaseTask;
        // Perform a GetAsync operation with the DB, by passing the implementation method to the DB. 
        return await db.GetAsync(CreateOrderAsyncImplementation, newOrder);

    }

    private static async  Task<SalesOrder> CreateOrderAsyncImplementation(IDbConnection connection, SalesOrder newOrder)
    {
        // Do some stuff with the connection...
        // Return the order created with the DB....
        return new SalesOrder(10, "Customer", DateTime.MaxValue);
    }


    public SalesOrder GetOrder(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<SalesOrder> GetOrderAsync(long id)
    {
        throw new NotImplementedException();
    }

    public SalesOrder UpdateOrder(SalesOrder location)
    {
        throw new NotImplementedException();
    }

    public async Task<SalesOrder> UpdateOrderAsync(SalesOrder location)
    {
        throw new NotImplementedException();
    }
}

