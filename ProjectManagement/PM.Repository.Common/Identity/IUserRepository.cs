using PagedList;
using PM.Common;
using PM.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PM.Repository.Common
{
    /// <summary>
    /// User repository contract.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Creates the instance of the <see cref="IUserPoco"/> class.
        /// </summary>
        /// <returns>The instance of the <see cref="IUserPoco"/> class.</returns>
        IUserPoco CreateUser();

        /// <summary>
        /// Creates the claim asynchronous.
        /// </summary>
        /// <returns><see cref="IClaim"/>.</returns>
        System.Threading.Tasks.Task<IClaimPoco> CreateClaimAsync();

        /// <summary>
        /// Gets a list of all <see cref="IUserPoco"/> models.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IUserPoco"/> models.</returns>
        IEnumerable<IUserPoco> GetAll(ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a list of all <see cref="IUserPoco"/> models asynchronously.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IUserPoco"/> models asynchronously.</returns>
        Task<IEnumerable<IUserPoco>> GetAllAsync(ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a paged list of all <see cref="IUserPoco"/> models.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of all <see cref="IUserPoco"/> models.</returns>
        IPagedList<IUserPoco> GetAllPaged(IPagingParameters pagingParameters, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a paged list of all <see cref="IUserPoco"/> models asynchronously.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of all <see cref="IUserPoco"/> models asynchronously.</returns>
        Task<IPagedList<IUserPoco>> GetAllPagedAsync(IPagingParameters pagingParameters, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the one <see cref="IUserPoco"/> model asynchronously.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>One <see cref="IUserPoco"/> asynchronously.</returns>
        Task<IUserPoco> GetOneAsync(Expression<Func<IUserPoco, bool>> filter = null, params string[] includeProperties);

        /// <summary>
        /// Gets the one <see cref="IUserPoco"/> model.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        IUserPoco GetOne(Expression<Func<IUserPoco, bool>> filter = null, params string[] includeProperties);

        /// <summary>
        /// Gets the list of <see cref="IUserPoco"/> models.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IUserPoco"/> models.</returns>
        IEnumerable<IUserPoco> Get(Expression<Func<IUserPoco, bool>> filter = null, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the list of <see cref="IUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IUserPoco"/> models asynchronous.</returns>
        Task<IEnumerable<IUserPoco>> GetAsync(Expression<Func<IUserPoco, bool>> filter = null, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the paged list of <see cref="IUserPoco"/> models.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of <see cref="IUserPoco"/> models.</returns>
        IPagedList<IUserPoco> GetPaged(IPagingParameters pagingParameters, Expression<Func<IUserPoco, bool>> filter = null, ISortingParameters orderBy = null, 
            params string[] includeProperties);

        /// <summary>
        /// Gets the paged list of <see cref="IUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of <see cref="IUserPoco"/> models asynchronous.</returns>
        Task<IPagedList<IUserPoco>> GetPagedAsync(IPagingParameters pagingParameters, Expression<Func<IUserPoco, bool>> filter = null,
            ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the <see cref="IUserPoco"/> model by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="IUserPoco"/>.</returns>
        IUserPoco GetById(Guid id);

        /// <summary>
        /// Gets the <see cref="IUserPoco"/> model by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="IUserPoco"/>.</returns>
        Task<IUserPoco> GetByIdAsync(Guid id);

        /// <summary>
        /// Gets the <see cref="IUserPoco"/> count.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns><see cref="IUserPoco"/> count.</returns>
        int GetCount(Expression<Func<IUserPoco, bool>> filter = null);

        /// <summary>
        /// Gets the <see cref="IUserPoco"/> count asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns><see cref="IUserPoco"/> count asynchronous.</returns>
        Task<int> GetCountAsync(Expression<Func<IUserPoco, bool>> filter = null);

        /// <summary>
        /// Checks if sequence in filter contains entities.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns>True if sequence contains at least one entity.</returns>
        bool GetIsExists(Expression<Func<IUserPoco, bool>> filter = null);

        /// <summary>
        /// Checks if sequence in filter contains entities asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns>True if sequence contains at least one entity.</returns>
        Task<bool> GetIsExistsAsync(Expression<Func<IUserPoco, bool>> filter = null);

        /// <summary>
        /// Inserts the specified <see cref="IUserPoco"/> model into the database.
        /// </summary>
        /// <param name="model">The model.</param>
        void Insert(IUserPoco model);

        /// <summary>
        /// Inserts the list of <see cref="IUserPoco"/> models into the database.
        /// </summary>
        /// <param name="models">The list of models.</param>
        void Insert(IList<IUserPoco> models);

        /// <summary>
        /// Inserts the specified <see cref="IUserPoco"/> model into the database asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task InsertAsync(IUserPoco model);

        /// <summary>
        /// Inserts the list of <see cref="IUserPoco"/> models into the database asynchronous.
        /// </summary>
        /// <param name="models">The list of models.</param>
        System.Threading.Tasks.Task InsertAsync(IList<IUserPoco> models);

        /// <summary>
        /// Updates the specified <see cref="IUserPoco"/> model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Update(IUserPoco model);

        /// <summary>
        /// Updates the list of <see cref="IUserPoco"/> models.
        /// </summary>
        /// <param name="model">The list of models.</param>
        void Update(IList<IUserPoco> models);

        /// <summary>
        /// Updates the specified <see cref="IUserPoco"/> model asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task UpdateAsync(IUserPoco model);

        /// <summary>
        /// Updates the list of <see cref="IUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="model">The list of models.</param>
        System.Threading.Tasks.Task UpdateAsync(IList<IUserPoco> models);

        /// <summary>
        /// Deletes model by id.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(Guid id);

        /// <summary>
        /// Deletes models by the list of ids.
        /// </summary>
        /// <param name="ids">The list of identifiers.</param>
        void Delete(IList<Guid> ids);

        /// <summary>
        /// Deletes model by id asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        System.Threading.Tasks.Task DeleteAsync(Guid id);

        /// <summary>
        /// Deletes models by the list of ids asynchronous.
        /// </summary>
        /// <param name="ids">The list of identifiers.</param>
        System.Threading.Tasks.Task DeleteAsync(IList<Guid> ids);

        /// <summary>
        /// Deletes the specified <see cref="IUserPoco"/> model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Delete(IUserPoco model);

        /// <summary>
        /// Deletes the list of models.
        /// </summary>
        /// <param name="models">The list of models.</param>
        void Delete(IList<IUserPoco> models);

        /// <summary>
        /// Deletes the specified <see cref="IUserPoco"/> model asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task DeleteAsync(IUserPoco model);

        /// <summary>
        /// Deletes the list of models.
        /// </summary>
        /// <param name="models">The list of models.</param>
        System.Threading.Tasks.Task DeleteAsync(IList<IUserPoco> models);

        /// <summary>
        /// Adds <see cref="IUserPoco"/> model for insert. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForInset(IUserPoco model);

        /// <summary>
        /// Adds <see cref="IUserPoco"/> model for update. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForUpdate(IUserPoco model);

        /// <summary>
        /// Adds <see cref="IUserPoco"/> model for delete. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForDelete(IUserPoco model);

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        void Save();

        /// <summary>
        /// Saves the context changes asynchronous.
        /// </summary>
        System.Threading.Tasks.Task SaveAsync();
    }
}