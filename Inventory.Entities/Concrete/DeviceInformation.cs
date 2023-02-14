using Inventory.Core.Entities;

namespace Inventory.Entities.Concrete
{
    public class DeviceInformation:IEntity
    {
        public int? Id { get; set; }
        public string HardwareNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string FaultStatus { get; set; }
        public string Date { get; set; }
    }
}
