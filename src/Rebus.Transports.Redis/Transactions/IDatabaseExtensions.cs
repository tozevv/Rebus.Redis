﻿using System;
using StackExchange.Redis;

namespace Rebus.Transports.Redis
{
    public static class IDatabaseExtensions
    {
        public static CompensatingTransaction BeginCompensatingTransaction(this IDatabase database)
        {
            CompensatingTransactionManager manager = new CompensatingTransactionManager(database);
            return manager.BeginTransaction();
        }

        public static void RollbackTimeoutCompensatingTransactions(this IDatabase database) 
        {
            CompensatingTransactionManager manager = new CompensatingTransactionManager(database);
            manager.RollbackTimeoutTransactions();
        }
    }
}

