namespace myWebAPI
{
    public class DeviceData
    {
        public List<DeviceType> myDevice { get; set; }

        public static DeviceData Current { get; } = new DeviceData();
        public DeviceData()
        {
            myDevice = new List<DeviceType>()
            {
                new DeviceType()
                {
                    Id = 1,
                    deviceName = "Device 1"
                },
                new DeviceType()
                {
                    Id = 2,
                    deviceName = "Device 2"
                },
                                new DeviceType()
                {
                    Id = 3,
                    deviceName = "Device 3"
                }
            };
        }
    }
}
