﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mdafit.Accounting.Data;

/* This is used if database provider does't define
 * IAccountingDbSchemaMigrator implementation.
 */
public class NullAccountingDbSchemaMigrator : IAccountingDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
