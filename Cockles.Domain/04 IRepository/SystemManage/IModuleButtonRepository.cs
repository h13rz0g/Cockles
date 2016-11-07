
using Cockles.Data;
using Cockles.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace Cockles.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}
