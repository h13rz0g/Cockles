
using Cockles.Data;
using Cockles.Domain.Entity.SystemManage;
using Cockles.Domain.IRepository.SystemManage;
using Cockles.Repository.SystemManage;
using System.Collections.Generic;

namespace Cockles.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
