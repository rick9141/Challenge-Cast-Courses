using CastCourses.Domain.Entities;
using CastCourses.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CastCourses.Service.Services
{
    public class BaseService : ICourse
    {
        private readonly ICourseRepository _ICourse;

        public BaseService(ICourseRepository ICourse)
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