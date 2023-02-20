using TestCoreApp.Data;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        public MainRepository(AppDbContext context) 
        {
           this.context = context;
        }

        protected AppDbContext context;

        public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
