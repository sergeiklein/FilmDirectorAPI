using FilmDirectorAPI.Context;
using FilmDirectorAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FilmDirectorAPI.Repository     // Repository holds CRUD oparations. 
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MovieContext context;// readonly means no one can change this except constructor
        public Repository(MovieContext dBcontext)
        {
            context = dBcontext;
        }

        protected DbContext Context { get { return context; } }// we made all the methods virtual
        public virtual async Task<TEntity> AddAsync(TEntity entity)//Added Async to this 
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            TEntity? entity = await GetByIdAsync(id);
            if (entity != null)
            {
                Context.Remove(entity);
                await Context.SaveChangesAsync();
            }
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            TEntity? entity = await Context.Set<TEntity>()
                .Where(w => EF.Property<int>(w, "Id") == id)
                .FirstOrDefaultAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            Context.Entry<TEntity>(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}

