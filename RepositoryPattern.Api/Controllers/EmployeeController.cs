using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Data.Models;
using RepositoryPattern.Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Fields

        private readonly IEmployeeService _employeeService;

        #endregion

        #region Ctor

        public EmployeeController(IEmployeeService employeeService) =>
            _employeeService = employeeService;

        #endregion

        #region Methods

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync() =>
            await _employeeService.GetAllEmployeesAsync();

        [HttpGet]
        public async Task<Employee> GetEmployeeByIdAsync(Guid id) =>
            await _employeeService.GetEmployeeByIdAsync(id);

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetDepartmentEmployeesAsync(string department) =>
            await _employeeService.GetWhereEmployeesAsync(x => x.Department.Contains(department));

        [HttpPost]
        public async Task AddEmployeeAsync(Employee newEmployee) =>
            await _employeeService.AddEmployeeAsync(newEmployee);

        [HttpPut]
        public async Task UpdateEmployeeAsync(Employee updateEmployee) =>
            await _employeeService.UpdateEmployeeAsync(updateEmployee);

        [HttpDelete]
        public async Task DeleteEmployeeAsync(Employee deleteEmployee) =>
            await _employeeService.DeleteEmployeeAsync(deleteEmployee);

        #endregion

    }
}
