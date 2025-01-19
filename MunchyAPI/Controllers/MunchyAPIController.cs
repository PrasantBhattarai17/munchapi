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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MunchDTO>> getMunch()
        {
            return Ok(MunchStore.MunchList);

        }

        [HttpGet("{id:int}",Name="GetMunchy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MunchDTO> getmunchy(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var munch = Ok(MunchStore.MunchList.FirstOrDefault(u => u.Id == id));

            if (munch == null)
            {

                return NotFound();
            }

            return Ok(munch);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<MunchDTO> CreateMunchy([FromBody] MunchDTO munchDTO)
        {
            if (munchDTO == null)
            {
                return BadRequest(munchDTO);
            }
            if (munchDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            munchDTO.Id = MunchStore.MunchList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            MunchStore.MunchList.Add(munchDTO);

            return CreatedAtRoute("GetMunchy",new {id=munchDTO.Id},munchDTO);
        }
    }
}
