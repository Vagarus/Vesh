using MySqlConnector;

using System.Data.Common;

namespace Vesher.Api.Information;

public class DbManager : IDisposable
{
    private DbConnection Connection { get; init; }

    public DbManager()
    {
        Connection = new MySqlConnection("server=localhost;uid=vector;pwd=K/]zjUT)({?Xbdy?<+YEpsNzB38,*0$rc7DiAqvL;database=vesh");

        if (Connection.State == System.Data.ConnectionState.Closed)
        {
            Connection.Open();
        }
    }

    public async IAsyncEnumerable<TEntity> Get<TEntity>(string query)
        where TEntity : IDatabaseReadable<TEntity>
    {
        using DbCommand command = Connection.CreateCommand();
        command.CommandText = query;

        using DbDataReader reader = await command.ExecuteReaderAsync();

        while (await reader.NextResultAsync())
        {
            yield return TEntity.FromDatabase(reader);
        }
    }

    private async Task<bool> ExecuteNonQuery(string query)
    {
        using DbCommand command = Connection.CreateCommand();
        command.CommandText = query;

        int result = await command.ExecuteNonQueryAsync();
        return result > 0;
    }

    public async Task<bool> Create<TCreate>(TCreate entry)
        where TCreate : IDatabaseCreatable =>
        await ExecuteNonQuery(entry.CreateQuery);

    public async Task<bool> Update<TUpdate>(TUpdate entry)
        where TUpdate : IDatabaseUpdatable =>
        await ExecuteNonQuery(entry.UpdateQuery);

    public async Task<bool> Delete<TDelete>(TDelete entry)
        where TDelete : IDatabaseDeletable =>
        await ExecuteNonQuery(entry.DeleteQuery);

    public void Dispose()
    {
        Connection.Dispose();
    }
}
