using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> GetById(int id);

        Task<List<T>> GetAllAsync();

        Task<T> AddAsync(T entity);
    }
}
