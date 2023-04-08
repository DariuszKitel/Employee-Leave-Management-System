using Employee_Leave_Management_System.Web.Contracts;
using Employee_Leave_Management_System.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace Employee_Leave_Management_System.Web.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext _dbContext;

		public GenericRepository(ApplicationDbContext dbContext)
        {
			_dbContext = dbContext;
		}
        public async Task<T> AddAsync(T entity)
		{
			await _dbContext.AddAsync(entity);
			SaveChangesAsync();
			return entity;
		}

		public async Task DeleteAsync(int id)
		{
			var entityRecord = await _dbContext.Set<T>().FindAsync(id);
			_dbContext.Set<T>().Remove(entityRecord);
			SaveChangesAsync();
		}

		public async Task<bool> Exists(int id)
		{
			var entityRecord = await GetAsync(id);
			return entityRecord != null;
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
		}

		public async Task<T?> GetAsync(int? id)
		{
			if (id == null)
			{
				return null;
			}
			return await _dbContext.Set<T>().FindAsync(id);
		}

		public async Task UpdateAsync(T entity)
		{
			_dbContext.Update(entity);
			SaveChangesAsync();
		}

		private async void SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
}
