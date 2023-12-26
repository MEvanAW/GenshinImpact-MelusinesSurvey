using Microsoft.AspNetCore.Mvc;

namespace MelusinesSurvey.Controllers
{
    public class HoyoverseController : Controller
    {
        [Route("common/badge/v1/login/info")]
        public IActionResult Info()
        {
            return Ok(new Dictionary<string,object?>
            {
                { "data", null },
                { "message", string.Empty },
                { "retcode", -100 }
            });
        }
    }
}
