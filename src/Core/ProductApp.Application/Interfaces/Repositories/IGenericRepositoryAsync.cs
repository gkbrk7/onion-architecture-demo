using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductApp.Domain.Common;

namespace ProductApp.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
