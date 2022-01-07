using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Dapper;

using Microsoft.Data.SqlClient;
using VSM.Models;

namespace VSM.Repository
{
     public class EmployeesRepository : IEmployeesRepository
     {
          private string connectionString;
        public EmployeesRepository()
        {        
            connectionString = @"Server=DITSDEV46;Database=VSM;Trusted_Connection=true;";
        }
        // private string LocationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "ProductImage");
        public IDbConnection Connection
        {
        get
        {
        return new SqlConnection(connectionString);
        }  
    }
 public async Task<IEnumerable<GetEmployeesDTO>> GetEmployeesAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetEmployeesDTO>("sp_GetAllEmployeeDetails",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<AddEmployeesDTO> AddEmployeesAsync(AddEmployeesDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<AddEmployeesDTO>("sp_AddEmployees",model,commandType:CommandType.StoredProcedure);
                return (AddEmployeesDTO)result;
            }
        }
        public async Task<UpdateEmployeesDTO> UpdateEmployeesAsync(UpdateEmployeesDTO model)
        {
             using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<UpdateEmployeesDTO>("sp_UpdateEmployees",model,commandType:CommandType.StoredProcedure);
                return (UpdateEmployeesDTO)result;
            }
        }
        public async Task<DeleteEmployeesDTO> DeleteEmployeesAsync(DeleteEmployeesDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<DeleteEmployeesDTO>("sp_DeleteEmployee",model,commandType:CommandType.StoredProcedure);
                return (DeleteEmployeesDTO)result;
            }
        }
    }
}