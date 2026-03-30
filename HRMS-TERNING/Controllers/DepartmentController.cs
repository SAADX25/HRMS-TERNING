using HRMS_TERNING.Dtos;
using HRMS_TERNING.Dtos.Employees;
using HRMS_TERNING.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using HRMS_TERNING.Dtos.DepartmentDto;
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
        FloorNumber = "IT-001",
        Description = "Information Technology",
        
        },
    new Department {
        Id = 2,
        Name = "HR",
        FloorNumber = "HR-002",
        Description = "Human Resources",

        },


     new Department
{
        Id = 3,
        Name = "Marketing",
        FloorNumber = "MKT-201",
        Description = "Marketing and Digital Advertising",

        }

     };


        [HttpGet("GetByCriteria")]
        public IActionResult GetByCriteria([FromQuery] FilterDepartmentsDto filterDto)
        {

            var result = from department in departments
                         where (filterDto.Name == null || department.Name.ToUpper().Contains(filterDto.Name.ToUpper()))
                            && (filterDto.FloorNumber == null || department.FloorNumber == filterDto.FloorNumber)
                         orderby department.Id descending
                         select new DepartmentDto
                         {
                             Id = department.Id,
                             Name = department.Name,
                             FloorNumber = department.FloorNumber,
                             Description = department.Description
                         };

            return Ok(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(long id)
        {
            var department = departments
                .Where(x => x.Id == id)
                .Select(x => new DepartmentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    FloorNumber = x.FloorNumber
                })
                .FirstOrDefault();

            if (department == null)
            {
                return NotFound("Department Does Not Exist");
            }

            return Ok(department);
        }


    }
}

