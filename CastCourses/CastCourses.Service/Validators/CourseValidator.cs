using CastCourses.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastCourses.Service.Validators
{
    class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Por favor, insira o nome do curso.")
                .NotNull().WithMessage("Por favor, insira o nome do curso.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Por favor, insira uma descrição.")
                .NotNull().WithMessage("Por favor, insira uma descrição.");

            RuleFor(c => c.Start)
                .NotEmpty().WithMessage("Por favor, insira uma data de inicio.")
                .NotNull().WithMessage("Por favor, insira uma data de inicio.");

            RuleFor(c => c.Start)
                .NotEmpty().WithMessage("Por favor, insira uma data de inicio.")
                .NotNull().WithMessage("Por favor, insira uma data de inicio.");

            RuleFor(c => c.Start)
                .NotEmpty().WithMessage("Por favor, insira uma data de inicio.")
                .NotNull().WithMessage("Por favor, insira uma data de inicio.");

            RuleFor(c => c.Start)
                .NotEmpty().WithMessage("Por favor, insira uma data de inicio.")
                .NotNull().WithMessage("Por favor, insira uma data de inicio.");

            RuleFor(c => c.Start)
                .NotEmpty().WithMessage("Por favor, insira uma data de inicio.")
                .NotNull().WithMessage("Por favor, insira uma data de inicio.");
        }
    }
}
