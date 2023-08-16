using System;
using GestionDepense.Models;

namespace GestionDepense.Data;

public interface IDataBase
{
    Task<int> CreateTransactAsync(Transaction transaction);
    Task <Transaction> GetTransactionAsync(Transaction transaction);
    Task<List<Transaction>> GetTransactionsAsync();
    Task<List<Transaction>> GetTransactionsCurrentMonthAsync();
}

