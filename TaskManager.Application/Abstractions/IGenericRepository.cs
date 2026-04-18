namespace TaskManager.Application.Abstractions;

public interface IGenericRepository<T> where T : class
{
    public Task CreateAsync(T item);
    public void Update(T item);
    public void Delete(T item);
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T?> GetByIdAsync(Guid id);
    public Task AddRangeAsync(IEnumerable<T> item);
    public Task<bool> SaveChangesAsync();
}