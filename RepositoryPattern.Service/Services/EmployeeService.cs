using RepositoryPattern.Data.Models;
using RepositoryPattern.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryPattern.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Fields

        private readonly IRepository<Employee> _repository;

        #endregion

        #region Ctor

        public EmployeeService(IRepository<Employee> repository) =>
            _repository = repository;

        #endregion

        #region Methods

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync() =>
            await _repository.GetAllAsync();

        public async Task<Employee> GetEmployeeByIdAsync(Guid id) =>
            await _repository.GetAsync(id);

        public async Task<IEnumerable<Employee>> GetWhereEmployeesAsync(Expression<Func<Employee, bool>> predicate) =>
            await _repository.GetWhereAsync(predicate);

        public async Task AddEmployeeAsync(Employee newEmployee) =>
            await _repository.AddAsync(newEmployee);

        public async Task UpdateEmployeeAsync(Employee updateEmployee) =>
            await _repository.UpdateAsync(updateEmployee);

        public async Task DeleteEmployeeAsync(Employee deleteEmployee) =>
            await _repository.DeleteAsync(deleteEmployee);

        #endregion
    }
}
