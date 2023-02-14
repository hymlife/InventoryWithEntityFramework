using Inventory.Core.DataAccess;
using Inventory.Entities.Concrete;

namespace Inventory.DataAccess.Abstract
{
    public interface IDeviceInformationDal : IEntityRepository<DeviceInformation>
    {
    }
}
