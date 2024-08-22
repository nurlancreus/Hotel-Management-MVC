using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogDAL : GenericRepository<Blog>, IBlogDAL
    {
        public EFBlogDAL(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
