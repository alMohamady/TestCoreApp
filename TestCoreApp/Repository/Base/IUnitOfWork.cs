using TestCoreApp.Models;

namespace TestCoreApp.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> categories { get;  }
        IRepository<Item> items { get; }
        IEmpRepo emplyees { get;  }
        int CommitChanges();
    }
}
