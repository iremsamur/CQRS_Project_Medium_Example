
using CQRS_Design_Pattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Design_Pattern.DAL.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-ISO96UVH\\SQLEXPRESS;Database=CQRSDb;integrated security=True;");//DataSource='de kullanılabilir.


        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    

    }
}
