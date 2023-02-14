using Inventory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Abstract
{
    public interface IServices<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int entityId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
