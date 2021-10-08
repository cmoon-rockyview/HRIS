using HRIS.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading.Tasks;


namespace HRIS.Data.Perisistance
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;
        //protected IEnumerable<TEntity> _Entity;

        public Repository(DbContext context)
        {
            _Context = context;
            //_Entity = _Context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _Context.Set<TEntity>().ToListAsync();
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _Context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _Context.Set<TEntity>().AddRangeAsync(entities);
            return entities;
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _Context.Set<TEntity>().Where(predicate).ToListAsync();            
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return  await _Context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
            
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _Context.Set<TEntity>().Where(predicate).SingleOrDefaultAsync();
        }   

        public bool Remove(TEntity entity)
        {
            
            try
            {
                _Context.Set<TEntity>().Remove(entity);
                return true;
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }            

        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        public bool Update(TEntity entity)
        {
            try
            {
                var updatedEntity = _Context.Set<TEntity>().Update(entity);
                _Context.Entry(entity).State = EntityState.Modified;
                return true;
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                try
                {
                    _Context.Entry(entity).State = EntityState.Modified;

                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }

     
            });

            return false;
        }
    }
}
