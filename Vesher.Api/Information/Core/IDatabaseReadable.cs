using System.Data.Common;

namespace Vesher.Api.Information;

public interface IDatabaseReadable<TEntity>
{
    public static abstract TEntity FromDatabase(DbDataReader reader);
}
