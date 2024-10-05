using sni;

namespace FF4FE.Tracker.Services
{
    public class DeviceService
    {
        public async Task<DevicesResponse> GetDevicesListAsync()
        {
            var channel = GrpcChannelService.GetGrpcChannel();
            var devicesClient = new Devices.DevicesClient(channel);

            return await devicesClient.ListDevicesAsync(new DevicesRequest());
        }
    }
}
