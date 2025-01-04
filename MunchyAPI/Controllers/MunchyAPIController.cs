using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MunchyAPI.Models;

namespace MunchyAPI.Controllers
{
    [Route("api/munch")]
    [ApiController]
    public class MunchyAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MunchDTO> getMunch()
        {
            return new List<MunchDTO>
            {
                new MunchDTO{Id=1, Name="Itallic"},
                new MunchDTO{Id=2, Name="Indian"}
            };

        }
    }
}
