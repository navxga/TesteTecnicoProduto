using TesteTecnicoProduto.Domain.Interfaces.Repositories;
using TesteTecnicoProduto.Infra.Data.Contexts;

namespace TesteTecnicoProduto.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        #region CRUD

        public virtual void Criar(TEntity entity, bool EntityStateAdded = false)
        {
            using (var dataContext = new DataContext())
            {
                if (EntityStateAdded)
                    dataContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                dataContext.Add(entity);
                dataContext.SaveChanges();
            }
        }
        public virtual TEntity? ObterPorId(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().Find(id);
            }
        }

        public virtual List<TEntity>? ObterTodos()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().ToList();
            }
        }

        public virtual void Atualizar(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(entity);
                dataContext.SaveChanges();
            }
        }

        public virtual void Deletar(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        #endregion
    }
}
