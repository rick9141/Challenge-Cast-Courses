using CastCourses.Domain.Entities;
using FluentValidation;
using System.Collections.Generic;

namespace CastCourses.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Delete(int id);

        IList<TEntity> Get();

        TEntity GetById(int id);

        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
