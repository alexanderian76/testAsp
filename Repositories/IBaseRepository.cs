using System;

public interface IBaseRepository<T>
{
    Task<T> Get(int id);
    Task<IEnumerable<T>> GetAll();
}


