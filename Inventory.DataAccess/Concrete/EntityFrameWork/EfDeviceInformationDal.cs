using Inventory.Core.DataAccess.EntityFrameWork;
using Inventory.DataAccess.Abstract;
using Inventory.Entities.Concrete;

namespace Inventory.DataAccess.Concrete.EntityFrameWork
{
    public class EfDeviceInformationDal : EfEntityRepositoryBase<DeviceInformation, DeviceInformationContext>, IDeviceInformationDal
    {
    }
}
