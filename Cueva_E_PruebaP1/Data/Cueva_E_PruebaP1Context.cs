using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cueva_E_PruebaP1.Models;

namespace Cueva_E_PruebaP1.Data
{
    public class Cueva_E_PruebaP1Context : DbContext
    {
        public Cueva_E_PruebaP1Context (DbContextOptions<Cueva_E_PruebaP1Context> options)
            : base(options)
        {
        }

        public DbSet<Cueva_E_PruebaP1.Models.Doctor> Doctor { get; set; } = default!;
        public DbSet<Cueva_E_PruebaP1.Models.Pet> Pet { get; set; } = default!;
        public DbSet<Cueva_E_PruebaP1.Models.PetOwner> PetOwner { get; set; } = default!;
    }
}
