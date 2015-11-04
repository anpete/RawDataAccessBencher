using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace RawBencher.Benchers
{
    public class EF7Bencher : BencherBase<SalesOrderHeader>
    {
        private readonly string _connectionString;
        private readonly IServiceProvider _serviceProvider;
        private readonly MyContext _ctx;

        public EF7Bencher(string connectionString)
            : base(e => e.SalesOrderId, false, false)
        {
            _connectionString = connectionString;

            _serviceProvider
                = new ServiceCollection()
                    .AddEntityFramework()
                    .AddSqlServer()
                    .GetInfrastructure()
                    .BuildServiceProvider();

            _ctx = new MyContext(_serviceProvider, _connectionString);
        }

        public override SalesOrderHeader FetchIndividual(int key)
        {
            //using (var ctx = new MyContext(_serviceProvider, _connectionString))
            //{
            return _ctx.SalesOrderHeaders.AsNoTracking().FirstOrDefault(e => e.SalesOrderId == key);
            //}
        }

        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (var ctx = new MyContext(_serviceProvider, _connectionString))
            {
                return ctx.SalesOrderHeaders.AsNoTracking().ToList();
            }
        }

        protected override string CreateFrameworkNameImpl()
        {
            return "EF7";
        }

        private class MyContext : DbContext
        {
            private readonly string _connectionString;

            public MyContext(IServiceProvider serviceProvider, string connectionString)
                : base(serviceProvider)
            {
                _connectionString = connectionString;
            }

            public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<SalesOrderHeader>()
                    .HasKey(s => s.SalesOrderId);

                modelBuilder.Entity<SalesOrderHeader>()
                    .ToTable("SalesOrderHeader", "Sales");
            }
        }
    }
}
