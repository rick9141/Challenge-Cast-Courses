using CastCourses.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CastCourses.Domain.Interfaces
{
    public interface IBaseGeneric<T> where T : class
    {
        Task Add(T Object);
        Task Update(T Object);
        Task Delete(T Object);
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
