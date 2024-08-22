using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDAL<T> where T : BaseEntity
	{
        DbSet<T> Table { get; }
        void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetList();
		T GetById(int id);
	}
}
