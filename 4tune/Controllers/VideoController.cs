using _4tune.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4tune.Controllers
{
    [Route("api/video")]
    [ApiController]
    public class VideoController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetAll()
        {
            var data = GetYouTubeData.GetVideos();
            return Ok(data);
        }
    }
}
