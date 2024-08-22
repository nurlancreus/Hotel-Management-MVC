using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFReservationDAL : GenericRepository<Reservation>, IReservationDAL
    {
        public EFReservationDAL(HotelManagementDbContext context) : base(context)
        {
        }

        List<Reservation> IReservationDAL.GetReservationWithRoom()
        {
           
            return Table.Include(r => r.Room).ToList();
        }
    }
}
