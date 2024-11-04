using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMapper.DataAccess
{
    /// <summary>
    /// Container to hold settings for a database.
    /// </summary>
    public sealed record DatabaseSettings(string Path)
    {

    }
}
