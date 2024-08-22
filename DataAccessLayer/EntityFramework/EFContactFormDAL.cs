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
    public class EFContactFormDAL : GenericRepository<ContactForm>, IContactFormDAL
    {
        public EFContactFormDAL(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
