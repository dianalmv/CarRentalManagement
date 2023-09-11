﻿using System.Linq.Expressions;

namespace CarRentalManagement.Server.IRepository
{
	public interface IGenericRepository<T> where T : class
	{
		Task<List<T>> GetAll(
			Expression<Func<T, bool>>? expression = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			List<string>? includes = null
			);
		Task<List<T>> Get(Expression<Func<T, bool>> expression, List<string>? includes = null);
		Task Insert(T entity);
		Task InsertRange(IEnumerable<T> entities);
		Task Delete(int id);
		void DeleteRange(IEnumerable<T> entities);
		void Update (T entity);
	}
}
