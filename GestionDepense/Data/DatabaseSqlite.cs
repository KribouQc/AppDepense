using System;
using GestionDepense.Models;
using SQLite;

namespace GestionDepense.Data;

public class DatabaseSqlite : IDataBase
{
    private SQLiteAsyncConnection connection;

    public DatabaseSqlite()
	{
	}

    private async Task Initialize()
    {
        if (connection is not null)
            return;

        connection = new(Constantes.databaseName);

        await connection.CreateTableAsync<Transaction>();
    }

    public async Task<int> CreateTransactAsync(Transaction transaction)
    {
        await Initialize();
        return await connection.InsertAsync(transaction);
    }

    public Task<Transaction> GetTransactionAsync(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public Task<List<Transaction>> GetTransactionsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Transaction>> GetTransactionsCurrentMonthAsync()
    {
        throw new NotImplementedException();
    }
}

