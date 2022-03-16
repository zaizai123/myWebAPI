using Microsoft.AspNetCore.Mvc;

namespace myWebAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class DeviceController : ControllerBase
    {

        public ActionResult<IEnumerable<DeviceType>> Index()
        {
            return Ok(DeviceData.Current.myDevice);
        }

        [HttpGet("{id}")]
        public ActionResult getDeviceById(int id)
        {
            var device = DeviceData.Current.myDevice.FirstOrDefault(device => device.Id == id);
            if (device == null) 
                return NotFound();
            return Ok(device);
        }
    }
}
