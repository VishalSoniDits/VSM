using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VSM.Models;
using VSM.Repository;

namespace VSM.Controllers
{
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetCustomerAsync()
        {
            return Ok( await _employeesRepository.GetEmployeesAsync());
        }
        [HttpPost("AddEmployees")]
        public async Task<IActionResult> AddEmployees([FromBody]AddEmployeesDTO model)
        {
            return Ok(await _employeesRepository.AddEmployeesAsync(model));
        }

        [HttpPut("UpdateEmployees")]
        public async Task<IActionResult> UpdateEmployees([FromBody]UpdateEmployeesDTO model)
        {
            return Ok(await _employeesRepository.UpdateEmployeesAsync(model));
        }

        [HttpDelete("DeleteEmployees")]
        public async Task<IActionResult> DeleteEmployees([FromQuery]DeleteEmployeesDTO model)
        {
            return Ok(await _employeesRepository.DeleteEmployeesAsync(model));
        }
    }
}