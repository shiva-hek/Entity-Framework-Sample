﻿using Domain.Repositories;
using Persistence.Repository.Exceptions;

namespace Persistence.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ProjectContext _context;

        public Repository(ProjectContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            var result = _context.Set<TEntity>().Find(id);

            if (result == null)
                throw new FailedToFindEntityByIdException("The entity is not found.", id);
            else
                return result;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }
    }
}
