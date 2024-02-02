using System.Data.Common;

namespace Vesher.Api.Information;

public interface IDatabaseReadable<TEntity>
{
    public static abstract TEntity FromDatabase(DbDataReader reader);
}

public interface IDatabaseCreatable
{
    public string CreateQuery { get; }
}

public interface IDatabaseUpdatable
{
    public string UpdateQuery { get; }
}

public interface IDatabaseDeletable
{
    public string DeleteQuery { get; }
}