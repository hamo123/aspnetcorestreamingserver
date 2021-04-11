using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcorestreamingserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCORSPolicy")]
    public class VideoStreamController : ControllerBase
    {
        [HttpGet]
        [Route("GetFile")]
        public FileResult GetFile()
        {
            return PhysicalFile("C:\\x\\Sample_Video.mp4", "application/octet-stream", enableRangeProcessing: true);
        }

    }
}
