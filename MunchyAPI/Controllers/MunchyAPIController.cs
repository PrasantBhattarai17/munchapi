using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MunchyAPI.Data;
using MunchyAPI.logging;
using MunchyAPI.Models;

namespace MunchyAPI.Controllers
{
    [Route("api/munch")]
    [ApiController]


    public class MunchyAPIController : ControllerBase
    {
        //private readonly ILogger<MunchyAPIController> _logger; //used only on using the default or external logging library
        //public  MunchyAPIController(ILogger<MunchyAPIController> logger)
        //{
        //    _logger = logger;
        //}


        // For using the custom LOG method for logging 
        private readonly ILogging _logger;
        public MunchyAPIController(ILogging logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MunchDTO>> getMunch()
        {

            _logger.Log("Getting ready for the munch!!","");
            return Ok(MunchStore.MunchList);

        }

        [HttpGet("{id:int}", Name = "GetMunchy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MunchDTO> getmunchy(int id)
        {
            if (id == 0)
            {
                _logger.Log("Sorry the id is Invallid!! Id: " + id,"error");
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

            if (MunchStore.MunchList.FirstOrDefault(u => u.Name.ToLower() == munchDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Already Exists!!");
                return BadRequest(ModelState);
            }

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

            return CreatedAtRoute("GetMunchy", new { id = munchDTO.Id }, munchDTO);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteMunch(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var munch = MunchStore.MunchList.FirstOrDefault(u => u.Id == id);

            if (munch == null)
            {
                return NotFound();
            }
            MunchStore.MunchList.Remove(munch);
            return NoContent();

        }

        [HttpPut("{id:int}",Name= "UpdateMunch")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<MunchDTO> UpdateMunch(int id,[FromBody]MunchDTO munchDTO)
        {
            if(id!=munchDTO.Id || munchDTO == null)
            {
                return BadRequest();
            }
            var munch = MunchStore.MunchList.FirstOrDefault(u => u.Id == id);

            munch.Name = munchDTO.Name;
            munch.Price=munchDTO.Price;
            munch.Rating=munchDTO.Rating;

            return NoContent();

        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialMunch(int id ,JsonPatchDocument<MunchDTO> Patchy)
        {
            if (Patchy == null || id ==0)
            {
                return BadRequest();
            }
            var munch = MunchStore.MunchList.FirstOrDefault(u => u.Id == id);
            if (munch == null){
                return BadRequest();
            }
            Patchy.ApplyTo(munch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
