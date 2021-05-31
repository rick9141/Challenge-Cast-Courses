using CastCourses.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using CastCourses.Domain.Interfaces.Services;
using CastCourses.Domain.Interfaces.Repositories;

namespace CastCourses.Service.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _ICourse;

        public CourseService(ICourseRepository ICourse)
        {
            _ICourse = ICourse;
        }

        public async Task AddCourse(Course course)
        {
            await _ICourse.Add(course);
        }


        public async Task DeleteCourse(Course Object)
        {
            await _ICourse.Delete(Object);
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _ICourse.GetEntityById(id);
        }

        public async Task<List<Course>> ListCourses()
        {
            return await _ICourse.List();
        }

        public async Task UpdateCourse(Course course)
        {
            await _ICourse.Update(course);
        }
    }
}