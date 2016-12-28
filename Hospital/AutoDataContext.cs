using Hospital.SQL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class AutoDataContext : DbContext
    {
        private static string DBConnectionString = "Hospital";

        public AutoDataContext(string ConnectionString)
            : base(ConnectionString)
        { }

        public AutoDataContext()
            : base(DBConnectionString)//задаем название бд вместо AutoDataContext
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // TODO: любое конфигурирование
            // через текучий API делается здесь!
        }

        public DbSet<Doctors> Doctor { get; set; }
        public DbSet<Patients> Patient { get; set; }
        public DbSet<Receptions> Reception { get; set; }
    }
}
