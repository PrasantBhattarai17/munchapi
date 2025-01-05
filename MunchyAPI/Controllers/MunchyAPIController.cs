using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MunchyAPI.Data;
using MunchyAPI.Models;

namespace MunchyAPI.Controllers
{
    [Route("api/munch")]
    [ApiController]
    public class MunchyAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<MunchDTO>> getMunch()
        {
            return Ok(MunchStore.MunchList);

        }

        [HttpGet("{id:int} ")]
        public ActionResult<MunchDTO> getMunchy(int id)
        {
            return Ok(MunchStore.MunchList.FirstOrDefault(u=>u.Id==id));

        }
    }
}
