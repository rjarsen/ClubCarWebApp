using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace ClubCar.Models
{
    public class Car
    {

        [Key]
        public int Id { get; set; }
        public string? CarType { get; set; }
        public string? ProjectName { get; set; }
        public int CarReuestedMiles { get; set; }
        public decimal MaxHoursDay { get; set; }
        public string? Status { get; set; }
        public string? Requestor { get; set; }
        public string? RequestorEmail { get; set; }

        public Car()
        {
            
        }
    }

    public class Employee
    { 
        public int EmployeeID { get; set;}
        public string? EmployeeName { get; set; }
        public string? EmployeeType { get; set;}

        public Employee()
        {
            
        }
    }
}

