using System.Threading.Tasks;
using VSM.Models;

namespace VSM.Repository
{
    public interface ILoginRepository
    {
        Task<ResponseDTO> LoginAsync(LoginDTO model); 
    }
}