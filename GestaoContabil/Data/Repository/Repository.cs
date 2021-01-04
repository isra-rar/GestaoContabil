
using GestaoContabil.Data.Context;
using GestaoContabil.Interfaces;
using GestaoContabil.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestaoContabil.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly GestaoContabilContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(GestaoContabilContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> expression)
        {
            return await DbSet.AsNoTracking().Where(expression).ToListAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Remove(Guid id)
        {
            DbSet.Remove(new TEntity() {Id = id});
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            DbSet.Update(entity); 
            await SaveChanges();
        }
    }
}
