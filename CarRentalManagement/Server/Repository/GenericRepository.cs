using System.Linq.Expressions;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using IdentityModel;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<T> _db;
		private ApplicationDbContext context;

		public GenericRepository(ApplicationDbContext context)
		{
			this.context = context;
		}

		public GenericRepository(ApplicationDbContext context, DbSet<T> db)
		{
			_context = context;
			_db = _context.Set<T>();
		}

		public async Task Delete(int id)
		{
			var record= await _db.FindAsync(id);
			_db.Remove(record);
		}

		public void DeleteRange(IEnumerable<T> entities)
		{
			_db.RemoveRange(entities);
		}

		public async Task<T> Get(Expression<Func<T, bool>> expression, List<string>? includes = null)
		{
			IQueryable<T> query = _db;
			if(includes != null)
			{
				foreach(var prop in includes)
				{
					query = query.Include(prop);
				}
			}
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
			return await query.AsNoTracking().FirstOrDefaultAsync(expression);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
		}

		public async Task<IList<T>> GetAll(Expression<Func<T, bool>>? expression = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			List<string>? includes = null)
		
		{
			IQueryable<T> query = _db;

			if (expression != null)
			{
				query=query.Where(expression);
			}

			if (includes != null)
			{
				foreach (var prop in includes)
				{
					query = query.Include(prop);
				}
			}

			if(orderBy != null)
			{
				query=orderBy(query);
			}
			return await query.AsNoTracking().ToListAsync();

		}

		public async Task Insert(T entity)
		{
			await _db.AddAsync(entity);
		}

		public async Task InsertRange(IEnumerable<T> entities)
		{
			await _db.AddRangeAsync(entities);
		}

		public void Update(T entity)
		{
			_db.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
		}

		Task<List<T>> IGenericRepository<T>.Get(Expression<Func<T, bool>> expression, List<string>? includes)
		{
			throw new NotImplementedException();
		}

		Task<List<T>> IGenericRepository<T>.GetAll(Expression<Func<T, bool>>? expression, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy, List<string>? includes)
		{
			throw new NotImplementedException();
		}
	}
}
