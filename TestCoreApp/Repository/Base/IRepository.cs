namespace TestCoreApp.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);

        IEnumerable<T> FindAll();
    }
}
