using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashMapper.DataAccess;
using Microsoft.Extensions.Options;

namespace DatabaseAbstraction.DataAccess;
/// <summary>
/// A concrete type that returns a new SqliteDatabase
/// </summary>
public class SqliteDatabaseFactory : IDatabaseFactory
{
    private readonly IOptions<DatabaseSettings> options;

    private readonly Task migrationTask; // Allows us to run the migration task async in GetDatabase.
    public SqliteDatabaseFactory(IOptions<DatabaseSettings> dbSettings)
    {
        options = dbSettings;
        // start any migration tasks:
        // migrationTask = DatabaseMigrations.Migrate(dbSettings)
    }

    public async Task<IDatabase> GetDatabase()
    {

        await migrationTask;
        return new SqliteDatabase(options.Value);
    }
}
    

