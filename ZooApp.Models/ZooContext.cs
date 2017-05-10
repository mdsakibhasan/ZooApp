using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
    public class ZooContext : DbContext
    {
        public ZooContext() : base("ZooContext")
        {
            
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalFood> AnimalFoods { get; set; }
        public DbSet<Food> Foods { get; set; }

        //public System.Data.Entity.DbSet<ZooApp.ViewModels.ViewAnimal> ViewAnimals { get; set; }
    }
}
