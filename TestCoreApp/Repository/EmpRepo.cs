using TestCoreApp.Data;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Repository
{
    public class EmpRepo : MainRepository<Employee>, IEmpRepo
    {
        public EmpRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public decimal getSalary(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void setPayRoll(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
