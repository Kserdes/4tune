using _4tune.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _4tune.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetAll()
        {
            var data = GetYouTubeData.GetFromFewPages();
            return Ok(data);
        }

    }
}
