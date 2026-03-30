using HRMS_TERNING.Dtos.Employees;
using HRMS_TERNING.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HRMS_TERNING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Data Annotations
    public class EmployeesController : ControllerBase
    {
        public static List<Employee> employees = new List<Employee>() {
            new Employee(){ID = 4,FirstName="Saad", LastName = "ABED" ,Position="Developer", BirthDate=new DateTime(2004,1,16)},
            new Employee(){ID = 3,FirstName="Ali",  LastName = "ABED" ,Position="Manager", BirthDate=new DateTime(2003,1,18)},
            new Employee(){ID = 2,FirstName="Sara", LastName = "POOKE",Position="RTX", BirthDate=new DateTime(2001,1,19)},
            new Employee(){ID = 1,FirstName="Nadia",LastName = "SEED" ,Email ="Nadia@314", BirthDate=new DateTime(2003,1,20)},
        };


        [HttpGet("GetEmployees")]//api/Employees/GetEmployee

        public ActionResult<Employee> GetEmployees(string? position)
        {
            var result = from employee in employees
                         where (position == null || employee.Position == position)
                         orderby employee.ID descending
                         select new EemployeesDto
                         {
                             ID = employee.ID,
                             FirstName = employee.FirstName,
                             LastName = employee.LastName,
                             BirthDate = employee.BirthDate,
                             Email = employee.Email,
                             Position = employee.Position


                         };

            return Ok(result);

            //return Ok(new { Name =  });
        }
        [HttpGet("GetById")]
        public IActionResult GetById(long id)
        {
            var result = employees.Select(x => new EmployeeDto
            {
                ID = x.ID,
                Name = x.FirstName + " " + x.LastName,
                Position = x.Position,
                Email = x.Email
            }).FirstOrDefault(x => x.ID == id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut("Update")]
        public IActionResult Update(SaveEmployeeDto employeeDto)
        {
            var employee = employees.FirstOrDefault(x => x.ID == employeeDto.ID);

            if (employee == null)
                return NotFound("Employee Does Not Exist");

            employee.FirstName = employeeDto.FirstName;
            employee.LastName = employeeDto.LastName;
            employee.Email = employeeDto.Email;
            employee.BirthDate = employeeDto.BirthDate;
            employee.Position = employeeDto.Position;

            return Ok(employee);


        }


        [HttpPost("Add")] // Create
        public IActionResult Add([FromBody] long ID, [FromQuery] SaveEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                ID = (employees.LastOrDefault()?.ID ?? 0) + 1,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                BirthDate = employeeDto.BirthDate,
                Position = employeeDto.Position
            };

            employees.Add(employee);

            return Ok(employee);
        }
        

        [HttpDelete("Delete")]

        public IActionResult Delete(long Id)
        {
            var employee = employees.FirstOrDefault(x => x.ID == Id);

            if (employee == null)
            {
                return NotFound("Department Does Not Exist"); //400

            }
            employees.Remove(employee);

            return Ok();
        }
    
    }

}