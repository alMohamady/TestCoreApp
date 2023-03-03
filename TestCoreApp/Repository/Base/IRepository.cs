namespace TestCoreApp.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T FindById(int id);

        IEnumerable<T> FindAll();

        Task<T> FindByIdAsync(int id);

        Task<IEnumerable<T>> FindAllAsync();
    }
}
