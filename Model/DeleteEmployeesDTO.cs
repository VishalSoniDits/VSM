using System.ComponentModel.DataAnnotations;

namespace VSM.Models
{
    public class DeleteEmployeesDTO
    {
        [Required]
        public int Emp_Id {get; set;}
        [Required]
        public string ActionPerformedBy {get; set;}
        
    }
}