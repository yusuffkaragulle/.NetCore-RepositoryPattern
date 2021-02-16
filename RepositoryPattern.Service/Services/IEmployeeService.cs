using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryPattern.Service.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(Guid id);
        Task<IEnumerable<Employee>> GetWhereEmployeesAsync(Expression<Func<Employee, bool>> predicate);
        Task AddEmployeeAsync(Employee newEmployee);
        Task UpdateEmployeeAsync(Employee updateEmployee);
        Task DeleteEmployeeAsync(Employee deleteEmployee);
    }
}
