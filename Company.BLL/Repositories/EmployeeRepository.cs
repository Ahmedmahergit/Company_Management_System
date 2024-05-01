using Company.BLL.Interfaces;
using Company.DAL.Contexts;
using Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly CompanyDbContext dbContext;

        public EmployeeRepository(CompanyDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<Employee> GetEmployeesByAddress(string Address)
        =>  dbContext.Employees.Where(E=>E.Address==Address);

        public IQueryable<Employee> GetEmployeesByName(string SearchValue)
         => dbContext.Employees.Where(E => E.Name.ToLower().Contains(SearchValue.ToLower()));
        
    }
}
