
using Cockles.Data;
using Cockles.Domain.Entity.SystemSecurity;

namespace Cockles.Domain.IRepository.SystemSecurity
{
    public interface IDbBackupRepository : IRepositoryBase<DbBackupEntity>
    {
        void DeleteForm(string keyValue);
        void ExecuteDbBackup(DbBackupEntity dbBackupEntity);
    }
}
