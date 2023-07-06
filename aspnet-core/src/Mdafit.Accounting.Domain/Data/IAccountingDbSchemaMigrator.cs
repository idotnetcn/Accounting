using System.Threading.Tasks;

namespace Mdafit.Accounting.Data;

public interface IAccountingDbSchemaMigrator
{
    Task MigrateAsync();
}
