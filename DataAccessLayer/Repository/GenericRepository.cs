using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : BaseEntity
	{
		private readonly HotelManagementDbContext _context;

        public GenericRepository(HotelManagementDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public void Delete(T t)
		{
			Table.Remove(t);
			_context.SaveChanges();
		}

		public List<T> GetList()
		{
			return Table.ToList();
		}

		public T GetById(int id)
		{
			return Table.Find(id);
		}

		public void Insert(T t)
		{
			Table.Add(t);
			_context.SaveChanges();
		}

		public void Update(T t)
		{
			Table.Update(t);
			_context.SaveChanges();
		}
	}
}
