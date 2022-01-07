using System.Collections.Generic;
using System.Threading.Tasks;
using VSM.Models;

namespace VSM.Repository
{
    public interface IEmployeesRepository
    {
       Task<IEnumerable<GetEmployeesDTO>> GetEmployeesAsync();
       Task<AddEmployeesDTO> AddEmployeesAsync(AddEmployeesDTO model); 
       Task<UpdateEmployeesDTO> UpdateEmployeesAsync(UpdateEmployeesDTO model);
       Task<DeleteEmployeesDTO> DeleteEmployeesAsync(DeleteEmployeesDTO model);
    }
}