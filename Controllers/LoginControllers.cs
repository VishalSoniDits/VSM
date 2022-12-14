using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VSM.Models;
using VSM.Repository;
//test
namespace VSM.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
[HttpPost("CheckLogin")]
       public async Task<IActionResult> AddEmployees([FromBody]LoginDTO model)
        {
            return Ok(await _loginRepository.LoginAsync(model));
        }

    }
}