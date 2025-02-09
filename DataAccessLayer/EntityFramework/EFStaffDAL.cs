﻿using DataAccessLayer.Abstract;
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
    public class EFStaffDAL : GenericRepository<Staff>, IStaffDAL
    {
        public EFStaffDAL(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
