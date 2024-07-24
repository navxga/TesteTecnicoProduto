namespace TesteTecnicoProduto.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        #region CRUD

        void Criar(TEntity entity, bool EntityStateAdded = false);
        List<TEntity>? ObterTodos();
        TEntity? ObterPorId(Guid id);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);

        #endregion
    }
}
