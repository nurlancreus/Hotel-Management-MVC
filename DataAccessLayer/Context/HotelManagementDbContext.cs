using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class HotelManagementDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<HotelAbout> HotelAbouts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
