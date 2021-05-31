using CastCourses.Domain.Entities;
using CastCourses.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CastCourses.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly ICourseService _ICourse;

        public CoursesController(ICourseService ICourse)
        {
            _ICourse = ICourse;
        }

        // GET: api/Courses/listCourses
        [HttpGet("getListCourses")]
        public async Task<IActionResult> ListCourses()
        {
            return Json(await _ICourse.ListCourses());
        }

        // GET: api/Courses/getCourseById
        [HttpGet("getCourseById")]
        public async Task<IActionResult> GetCourseById(int Id)
        {
            return Json(await _ICourse.GetCourseById(Id));
        }

        // POST: api/Courses/newCourse
        [HttpPost("newCourse")]
        public async Task<BaseReturnMessage> AddCourse(Course course)
        {
            var returnMsg = new BaseReturnMessage();

            try
            {
                var courses = await _ICourse.ListCourses();
                var isValid = courses.FirstOrDefault(x => course.Start >= x.Start && course.Start <= x.Termination);

                if (isValid != null)
                {
                    returnMsg.Sucess = false;
                    returnMsg.Errors.Add(string.Concat("Existe(m) curso(s) planejados(s) dentro do período informado."));
                }

                else if(course.Start < DateTime.Now)
                {
                    returnMsg.Sucess = false;
                    returnMsg.Errors.Add(string.Concat("Data de Inicio Não pode ser menor que a data de hoje"));
                }
                else
                {
                    returnMsg.Sucess = true;
                    returnMsg.Errors.Add(string.Concat("Curso cadastrado com sucesso!"));
                    await _ICourse.AddCourse(course);
                }
                return returnMsg;

            }
            catch (Exception error)
            {
                returnMsg.Sucess = false;
                returnMsg.Errors.Add(error.Message);
            }
            return returnMsg;
        }

        // PUT: api/Courses/updateCourse
        [HttpPut("updateCourse")]
        public async Task UpdateCourse(Course course)
        {
            await _ICourse.UpdateCourse(course);
        }

        // DELETE: api/Courses/removeCourse
        [HttpDelete("removeCourse")]
        public async Task RemoveCourse(Course course)
        {
            await _ICourse.DeleteCourse(course);
        }
    }
}

