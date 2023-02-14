using Inventory.Business.Abstract;
using Inventory.DataAccess.Abstract;
using Inventory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Concrete
{
    public class DeviceInformationManager : IDeviceInformationService
    {
        private IDeviceInformationDal _deviceInformationDal;
        public DeviceInformationManager(IDeviceInformationDal deviceInformationDal)
        {
            _deviceInformationDal = deviceInformationDal;
        }

        public DeviceInformation Get(int entityId)
        {
            return _deviceInformationDal.Get(x => x.Id == entityId);
        }

        public List<DeviceInformation> GetAll()
        {
            return _deviceInformationDal.GetList();
        }

        public void Add(DeviceInformation entity)
        {
            _deviceInformationDal.Add(entity);
        }

        public void Delete(DeviceInformation entity)
        {
            _deviceInformationDal.Delete(entity);
        }

        public void Update(DeviceInformation entity)
        {
            _deviceInformationDal.Update(entity);
        }
    }
}
