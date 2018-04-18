﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItMastersPro.NoSql.Repository.Interfaces;
using MongoDB.Driver;

namespace ItMastersPro.NoSql.Repository.MongoDb.Interfaces
{
    public interface IMongoDbRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        /// <summary>
        /// Filters a sequence of values based on a filter definition. This method default no-tracking query.
        /// </summary>
        /// <param name="filter">Filter to test each element for a condition.</param>
        /// <returns>An <see cref="IQueryable{TEntity}"/> that contains elements that satisfy the condition specified by <paramref name="filter"/>.</returns>
        IQueryable<TEntity> Query(FilterDefinition<TEntity> filter);

        /// <summary>
        /// Filters a sequence of values based on a filter definition. This method default no-tracking query.
        /// </summary>
        /// <param name="filter">Filter to test each element for a condition.</param>
        /// <returns>An <see cref="IQueryable{TEntity}"/> that contains elements that satisfy the condition specified by <paramref name="filter"/>.</returns>
        Task<IQueryable<TEntity>> QueryAsync(FilterDefinition<TEntity> filter);
    }
}
