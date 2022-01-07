using System;
using System.ComponentModel.DataAnnotations;

namespace VSM.Models
{
    public class UpdateEmployeesDTO
    {
        public int Emp_Id {get; set;}    
        public string First_Name {get; set;}
        public string Last_Name {get; set;}
        public string Father_Name {get; set;}
        public string Gender {get; set;}
        public string Current_Address {get; set;}
        public string City1 {get; set;}
        public string State1 {get; set;}
        public string Zip_Code1 {get; set;}
        public string Permanent_Address {get; set;}
        public string City2 {get; set;}
        public string State2 {get; set;}
        public string Zip_Code2 {get; set;}
        public string Email {get; set;}
        public string Office_Email {get; set;}
        public string Phone_Number {get; set;}        
        public string Profile_Name {get; set;}
        public DateTime Join_Date {get; set;}
        public decimal Salary {get; set;}
        public string Experience {get; set;}   
        public string Password {get; set;}        
        public bool IsActive {get; set;}
        public string ActionPerformedBy {get; set;}
        
        
    }
}