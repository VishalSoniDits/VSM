using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using VSM.Models;
using VSM.Repository;

namespace VSM.Repository
{
     public class LoginRepository : ILoginRepository
     {
          private string connectionString;
        public LoginRepository()
        {        
            connectionString = @"Server=DITSDEV46;Database=VSM;Trusted_Connection=true;";
        }
        public IDbConnection Connection
        {
        get
        {
        return new SqlConnection(connectionString);
        }  
    }

        public async Task<ResponseDTO> LoginAsync(LoginDTO model)
        {           
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_Login",model,commandType:CommandType.StoredProcedure);
                return (ResponseDTO)result;
            }       
        }
    }
}
