using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.PictureDb
{
    public class ImagesDb : DbContext
    {
        public ImagesDb() { }
        public DbSet<ImagesClass> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string config = File.ReadAllText(@"../../../../Infrastructure/DB/ConfigForDb.txt");
            optionsBuilder.UseNpgsql(config);
        }
    }
}
