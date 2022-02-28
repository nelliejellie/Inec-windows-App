using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IAsyncRepository<T>
    {

        Task<T> AddAsync(T entity);

        T GetById(string id);

        Task<T> GetByIdAsync(string id);

        IQueryable<T> GetAll();

        Task<IQueryable<T>> GetAllAsync();

        bool Update(T entity);

        Task<bool> UpdateAsync(T entity);

        bool Delete(T entity);

        Task<bool> DeleteAsync(T entity);
    } 
}
