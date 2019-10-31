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
                    new Dino { DinoId = 1, Name = "Ammosaurus", Type = "Sauropod", Mood = "Arrogant", Habitat = "Dense marsh lands", Diet = "Herbivorous", AsKnownAs = "Sand Lizard", Strength = "Long arms, able to walk on two feet", Weakness = "Not able to walk on four legs so there are issues when running away", PhotoPath = "wwwroot/uploads/Ammosaurus.jpg"},

                    new Dino { DinoId = 2, Name = "Huayangosaurus", Type = "Armoured Dinosour", Mood = "Relaxed", Habitat = "Forest, center island", Diet = "Herbivorous", AsKnownAs = "Huayang lizard'", Strength = "Spiky spine leading to a long thick tail with aspikes coming out.", Weakness = "Under side of the dinosour. If the dinosour gets knocked off balance he has no hope.", PhotoPath = "wwwroot/uploads/huayango.jpg"},

                    new Dino { DinoId = 3, Name = "Tyrannosaurus", Type = "Large theropod", Mood = "Consistantly raging", Habitat = "Outskirts of the Island", Diet = "Carnivorous", AsKnownAs = "T-rex or Tyrant lizard", Strength = "Strong legs, huge mouth with large sharp teeth", Weakness = "short arms, cant swim", PhotoPath = "wwwroot/uploads/Tyrannosaurus.jpg"},

                    new Dino { DinoId = 4, Name = "Velociraptor", Type = "Small theropod", Mood = "Strategic", Habitat = "Grass Lands outskirt of the jungle", Diet = "Carnivorous", AsKnownAs = "quick plunderer or Raptor", Strength = "Very smart and fast", Weakness = "Smaller in size", PhotoPath = "wwwroot/uploads/Velociraptor.jpg"},

                    new Dino { DinoId = 5, Name = "Deinonychus", Type = "Small theropod", Mood = "mystical", Habitat = "Grass lands and jungle", Diet = "Carnivorous, mainly feeds on plant eating dinos", AsKnownAs = "terrible claw", Strength = "Huge claws, moved swiftly", Weakness = "smaller in size", PhotoPath = "wwwroot/uploads/Deinonychus.jpg"},

                    new Dino { DinoId = 6, Name = "Torosaurus", Type = "Ceratopsian", Mood = "Gentel", Habitat = "Mountain basin", Diet = "Herbivorous", AsKnownAs = "Triciratops, bull lizard", Strength = "Large strong crown with two large horns. Thick skin", Weakness = "Slow movement", PhotoPath = "wwwroot/uploads/Torosaurus.jpg"},

                    new Dino { DinoId = 7, Name = "brave monitor lizard", Type = "euornithopod", Mood = "Wise and aware", Habitat = "Beach side", Diet = "herbivorous", AsKnownAs = "brave monitor lizard", Strength = "Strong swimmer, great eye site, sense of smell and hearing", Weakness = "weak body armour and no real type of defense", PhotoPath = "wwwroot/uploads/Ouranosaurus.jpg"},

                    new Dino { DinoId = 8, Name = "Alamosaurus", Type = "Sauropod", Mood = "Wise and Chill", Habitat = "Swamp Land", Diet = "Herbivorous", AsKnownAs = "Alamo lizard or Longnecks", Strength = "Long limbs, hard to take down. Over 20 meters in length", Weakness = "slwow moving dinosour", PhotoPath = "wwwroot/uploads/Alamosaurus.jpg"},

                    new Dino { DinoId = 9, Name = "Bambiraptor", Type = "small theropod", Mood = "Mischievous", Habitat = "Jumgle", Diet = "Carnivorous", AsKnownAs = "Bambi plunderer", Strength = "Extremly fast, large claws and capable of flying", Weakness = "Very small, only 1 meter in length", PhotoPath = "wwwroot/uploads/Bambiraptor.jpg"},

                    new Dino { DinoId = 10, Name = "Maiasaura", Type = "euornithopod", Mood = "Very protective", Habitat = "Mountain vally", Diet = "Herbivorous", AsKnownAs = "Good mother lizard", Strength = "Very aware of their surroundings", Weakness = "no body armour or type of defense", PhotoPath = "wwwroot/uploads/Maiasaura.jpg"},

                    new Dino { DinoId = 11, Name = "Elaphrosaurus", Type = "large theropod", Mood = "Whitty", Habitat = "Plateau", Diet = "Carnivorous", AsKnownAs = "fleet lizard'", Strength = "Tall long limbs, quick moving", Weakness = "Not very strong", PhotoPath = "wwwroot/uploads/Elaphrosaurus.jpg"},
                    
                    new Dino { DinoId = 12, Name = "Mapusaurus", Type = "large theropod", Mood = "Timmid", Habitat = "Valley", Diet = "Carnivorous", AsKnownAs = "Earth Lizard", Strength = "Large mouth and fast", Weakness = "Slightly smaller that other preditors. Not as powerful", PhotoPath = "wwwroot/uploads/Mapusaurus.jpg"},

                    new Dino { DinoId = 13, Name = "Oviraptor", Type = "small theropod", Mood = "Mischievous", Habitat = "Dense Marsh Land", Diet = "Omnivourous", AsKnownAs = "Egg Thief", Strength = "Keen sense of smell and very sneaky", Weakness = "No real kind of defense", PhotoPath = "wwwroot/uploads/Oviraptor.jpg"},

                    new Dino { DinoId = 14, Name = "Procompsognathus", Type = "Small Theropod", Mood = "Mischievous", Habitat = "Jumgle", Diet = "Carnivorous", AsKnownAs = " Compso", Strength = "Fast and sneaky", Weakness = "timy in size, not dangerous alone", PhotoPath = "wwwroot/uploads/Procompsognathus.jpg"},

                    new Dino { DinoId = 15, Name = "Saurophaganax", Type = "Large theropod", Mood = "Independant jerk bird", Habitat = "Mountain Valley", Diet = "Carnivorous", AsKnownAs = "king of the lizard eaters'", Strength = "All around strong", Weakness = "None", PhotoPath = "wwwroot/uploads/Saurophaganax.jpg"}
                    

                    
                ); 




        }      
            
    }
}