using Common.DTO;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeekBankBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationHistoryController : ControllerBase
    {
        protected readonly ICalculationHistoryService _service;
        public CalculationHistoryController(ICalculationHistoryService service)
        {
            _service = service;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("[action]")]
        public ActionResult<IEnumerable<CalculationHistoryContract>> Get()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }            
        }
    }
}
