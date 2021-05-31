using CastCourses.Domain.Entities;
using CastCourses.Domain.Interfaces;
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
        private readonly ICourse _ICourse;

        public CoursesController(ICourse ICourse)
        {
            _ICourse = ICourse;
        }

        // GET: api/Courses/listCourses
        [HttpGet("listCourses")]
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
            var retorno = new BaseReturnMessage();

            try
            {

                //var courses = await _ICourse.ListCourses();
                //var isValid = courses.FirstOrDefault(x => course.Start >= x.Start && course.Start <= x.Termination);
                //if (Verifica)
                //{
                //    return true;
                //    retorno.Sucess = false;
                //    retorno.Errors.Add(string.Concat("Existe(m) curso(s) planejados(s) dentro do período informado."));
                //}

                if (course.Start < DateTime.Now)
                {

                    retorno.Sucess = false;
                    retorno.Errors.Add(string.Concat("Data de Inicio Não pode ser menor que a data de hoje"));
                }

                else
                {
                    retorno.Sucess = true;
                    retorno.Errors.Add(string.Concat("Tudo certo por aqui!"));
                }
                return retorno;

            }
            catch (Exception erro)
            {

                retorno.Sucess = false;
                retorno.Errors.Add(erro.Message);
            }
            
            await _ICourse.AddCourse(course);
            return retorno;

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
