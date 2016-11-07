
using Cockles.Data;
using Cockles.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace Cockles.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
