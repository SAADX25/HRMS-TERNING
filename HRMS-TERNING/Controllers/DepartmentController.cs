using HRMS_TERNING.Dtos;
using HRMS_TERNING.Dtos.Employees;
using HRMS_TERNING.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace HRMS_TERNING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        public static List<Department> departments = new List<Department>()
{
    new Department {
        Id = 1,
        Name = "IT",
        FlorNumber = "IT-001",
        Description = "Information Technology",
        Employee = new List<string> { "Ahmad", "Mona", "Ali" } 
    },
    new Department {
        Id = 2,
        Name = "HR",
        FlorNumber = "HR-002",
        Description = "Human Resources",
        Employee = new List<string> { "Sara", "Sami" }
    },

     new Department
{
        Id = 3,
        Name = "Marketing",
        FlorNumber = "MKT-201",
        Description = "Marketing and Digital Advertising",
        Employee = new List<string> { "Laila", "Zaid" }
        }
     };

        [HttpGet]

        public ActionResult<Department> GetBYName(String Name)
        {
            var result = from Department in departments
                         where (Name == null || Department.Name == Name)

                         select new DepartmentDto
                         {
                             Id = Department.Id,
                             Name = Department.Name,
                             FlorNumber = Department.FlorNumber,
                             Description = Department.Description,
                             Employee = Department.Employee


                         };

            return Ok(result);
        }


        [HttpDelete("ClearEmployeesByDept")]
        public IActionResult ClearEmployeesByDept([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Department name is required.");

            var targets = departments
                .Where(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!targets.Any())
                return NotFound($"Department '{name}' not found.");

            foreach (var dept in targets)
            {
                
                dept.Employee.Clear();
            }

            return Ok($"All employees have been removed from the {name} department.");
        }


        [HttpGet("Search")]
        public IActionResult GetByName([FromQuery] string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest("Please provide a name to search.");

            var result = departments.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (result == null)
                return NotFound($"No department found with name: {name}");

            return Ok(result);
        }

        [HttpPut("UpdateDepartment")]
        public IActionResult UpdateDepartment([FromBody] Department updatedDept)
        {
            
            var existingDept = departments.FirstOrDefault(x => x.Id == updatedDept.Id);

            if (existingDept == null)
                return NotFound("Department not found to update.");

            existingDept.Name = updatedDept.Name;
            existingDept.FlorNumber = updatedDept.FlorNumber;
            existingDept.Description = updatedDept.Description;

            return Ok(new { Message = "Updated Successfully!", Data = existingDept });
        }


    }
}

