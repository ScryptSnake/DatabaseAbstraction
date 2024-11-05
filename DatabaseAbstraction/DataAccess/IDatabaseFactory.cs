﻿using CashMapper.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAbstraction.DataAccess
{
    public interface IDatabaseFactory
    {
        public Task<IDatabase> GetDatabase();
    }
}
