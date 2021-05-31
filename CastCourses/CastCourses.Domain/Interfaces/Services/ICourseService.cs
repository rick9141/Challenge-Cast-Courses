using CastCourses.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CastCourses.Domain.Interfaces.Services
{
    public interface ICourseService
    {
        Task AddCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(Course course);
        Task<Course> GetCourseById(int id);
        Task<List<Course>> ListCourses();
    }
}
