﻿using PagedList;
using PM.Common;
using PM.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PM.Repository.Common
{
    /// <summary>
    /// ProjectUser repository contract.
    /// </summary>
    public interface IProjectUserRepository
    {
        /// <summary>
        /// Creates the project user in memory.
        /// </summary>
        /// <returns><see cref="IProjectUserPoco"/> model.</returns>
        IProjectUserPoco Create();

        /// <summary>
        /// Gets a list of all <see cref="IProjectUserPoco"/> models.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IProjectUserPoco"/> models.</returns>
        IEnumerable<IProjectUserPoco> GetAll(ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a list of all <see cref="IProjectUserPoco"/> models asynchronously.
        /// </summary>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IProjectUserPoco"/> models asynchronously.</returns>
        Task<IEnumerable<IProjectUserPoco>> GetAllAsync(ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a paged list of all <see cref="IProjectUserPoco"/> models.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of all <see cref="IProjectUserPoco"/> models.</returns>
        IPagedList<IProjectUserPoco> GetAllPaged(IPagingParameters pagingParameters, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets a paged list of all <see cref="IProjectUserPoco"/> models asynchronously.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of all <see cref="IProjectUserPoco"/> models asynchronously.</returns>
        Task<IPagedList<IProjectUserPoco>> GetAllPagedAsync(IPagingParameters pagingParameters, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the one <see cref="IProjectUserPoco"/> model asynchronously.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>One <see cref="IProjectUserPoco"/> asynchronously.</returns>
        Task<IProjectUserPoco> GetOneAsync(Expression<Func<IProjectUserPoco, bool>> filter = null, params string[] includeProperties);

        /// <summary>
        /// Gets the one <see cref="IProjectUserPoco"/> model.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        IProjectUserPoco GetOne(Expression<Func<IProjectUserPoco, bool>> filter = null, params string[] includeProperties);

        /// <summary>
        /// Gets the list of <see cref="IProjectUserPoco"/> models.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IProjectUserPoco"/> models.</returns>
        IEnumerable<IProjectUserPoco> Get(Expression<Func<IProjectUserPoco, bool>> filter = null, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the list of <see cref="IProjectUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>List of <see cref="IProjectUserPoco"/> models asynchronous.</returns>
        Task<IEnumerable<IProjectUserPoco>> GetAsync(Expression<Func<IProjectUserPoco, bool>> filter = null, ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the paged list of <see cref="IProjectUserPoco"/> models.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of <see cref="IProjectUserPoco"/> models.</returns>
        IPagedList<IProjectUserPoco> GetPaged(IPagingParameters pagingParameters, Expression<Func<IProjectUserPoco, bool>> filter = null, ISortingParameters orderBy = null,
            params string[] includeProperties);

        /// <summary>
        /// Gets the paged list of <see cref="IProjectUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="pagingParameters">The paging parameters.</param>
        /// <param name="filter">The filter expression.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns>Paged list of <see cref="IProjectUserPoco"/> models asynchronous.</returns>
        Task<IPagedList<IProjectUserPoco>> GetPagedAsync(IPagingParameters pagingParameters, Expression<Func<IProjectUserPoco, bool>> filter = null,
            ISortingParameters orderBy = null, params string[] includeProperties);

        /// <summary>
        /// Gets the <see cref="IProjectUserPoco"/> model by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="IProjectUserPoco"/>.</returns>
        IProjectUserPoco GetById(Guid id);

        /// <summary>
        /// Gets the <see cref="IProjectUserPoco"/> model by identifier asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns><see cref="IProjectUserPoco"/>.</returns>
        Task<IProjectUserPoco> GetByIdAsync(Guid id);

        /// <summary>
        /// Gets the <see cref="IProjectUserPoco"/> count.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns><see cref="IProjectUserPoco"/> count.</returns>
        int GetCount(Expression<Func<IProjectUserPoco, bool>> filter = null);

        /// <summary>
        /// Gets the <see cref="IProjectUserPoco"/> count asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns><see cref="IProjectUserPoco"/> count asynchronous.</returns>
        Task<int> GetCountAsync(Expression<Func<IProjectUserPoco, bool>> filter = null);

        /// <summary>
        /// Checks if sequence in filter contains entities.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns>True if sequence contains at least one entity.</returns>
        bool GetIsExists(Expression<Func<IProjectUserPoco, bool>> filter = null);

        /// <summary>
        /// Checks if sequence in filter contains entities asynchronous.
        /// </summary>
        /// <param name="filter">The filter expression.</param>
        /// <returns>True if sequence contains at least one entity.</returns>
        Task<bool> GetIsExistsAsync(Expression<Func<IProjectUserPoco, bool>> filter = null);

        /// <summary>
        /// Inserts the specified <see cref="IProjectUserPoco"/> model into the database.
        /// </summary>
        /// <param name="model">The model.</param>
        void Insert(IProjectUserPoco model);

        /// <summary>
        /// Inserts the list of <see cref="IProjectUserPoco"/> models into the database.
        /// </summary>
        /// <param name="models">The list of models.</param>
        void Insert(IList<IProjectUserPoco> models);

        /// <summary>
        /// Inserts the specified <see cref="IProjectUserPoco"/> model into the database asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task InsertAsync(IProjectUserPoco model);

        /// <summary>
        /// Inserts the list of <see cref="IProjectUserPoco"/> models into the database asynchronous.
        /// </summary>
        /// <param name="models">The list of models.</param>
        System.Threading.Tasks.Task InsertAsync(IList<IProjectUserPoco> models);

        /// <summary>
        /// Updates the specified <see cref="IProjectUserPoco"/> model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Update(IProjectUserPoco model);

        /// <summary>
        /// Updates the list of <see cref="IProjectUserPoco"/> models.
        /// </summary>
        /// <param name="model">The list of models.</param>
        void Update(IList<IProjectUserPoco> models);

        /// <summary>
        /// Updates the specified <see cref="IProjectUserPoco"/> model asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task UpdateAsync(IProjectUserPoco model);

        /// <summary>
        /// Updates the list of <see cref="IProjectUserPoco"/> models asynchronous.
        /// </summary>
        /// <param name="model">The list of models.</param>
        System.Threading.Tasks.Task UpdateAsync(IList<IProjectUserPoco> models);

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
        /// Deletes the specified <see cref="IProjectUserPoco"/> model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Delete(IProjectUserPoco model);

        /// <summary>
        /// Deletes the list of models.
        /// </summary>
        /// <param name="models">The list of models.</param>
        void Delete(IList<IProjectUserPoco> models);

        /// <summary>
        /// Deletes the specified <see cref="IProjectUserPoco"/> model asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        System.Threading.Tasks.Task DeleteAsync(IProjectUserPoco model);

        /// <summary>
        /// Deletes the list of models.
        /// </summary>
        /// <param name="models">The list of models.</param>
        System.Threading.Tasks.Task DeleteAsync(IList<IProjectUserPoco> models);

        /// <summary>
        /// Adds <see cref="IProjectUserPoco"/> model for insert. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForInset(IProjectUserPoco model);

        /// <summary>
        /// Adds <see cref="IProjectUserPoco"/> model for update. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForUpdate(IProjectUserPoco model);

        /// <summary>
        /// Adds <see cref="IProjectUserPoco"/> model for delete. This will not call Save() method.
        /// </summary>
        /// <param name="model">The model.</param>
        void AddForDelete(IProjectUserPoco model);

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