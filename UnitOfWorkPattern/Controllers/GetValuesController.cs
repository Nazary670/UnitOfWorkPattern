using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPattern.Contracts.Common;
using UnitOfWorkPattern.Models.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitOfWorkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetValuesController(IUnitOfWork UnitOfWork) : ControllerBase
    {
        // GET: api/<GetValuesController>
        [HttpGet("GetCars")]
        public async Task<ActionResult<Car>> GetCars()
        {
            var query = await UnitOfWork.CarRepository.GetCarsAsync();
            return Ok(query);
        }

        // GET api/<GetValuesController>/5
        [HttpGet("GetConditions")]
        public async Task<ActionResult<Condition>> GetConditions()
        {
            return Ok(await UnitOfWork.conditionRepository.GetAllConditionsAsync());
        }

        
    }
}
