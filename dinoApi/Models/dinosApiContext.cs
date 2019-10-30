using Microsoft.EntityFrameworkCore;

namespace dinoApi.Models
{
    public class dinoApiContext : DbContext
    {
        public dinoApiContext(DbContextOptions<dinoApiContext> options)
            : base(options)
        {
        }

        public DbSet<Dino> Dinos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Dino>()
                .HasData(
                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", },

                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", },

                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", },

                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", },

                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", },

                    new Dino { DinoId = , Name = "", Type = "", Mood = "", Habitat = "", Diet = "", Friends = "", Strength = "", Weakness = "", }


                    
                ); 




        }      
            
    }
}