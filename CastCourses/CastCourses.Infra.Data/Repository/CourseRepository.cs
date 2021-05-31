using CastCourses.Domain.Entities;
using CastCourses.Domain.Interfaces;
using CastCourses.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CastCourses.Infra.Data.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly DbContextOptions<ContextBase> _context;

        public CourseRepository()
        {
            _context = new DbContextOptions<ContextBase>();
        }
    }
}
