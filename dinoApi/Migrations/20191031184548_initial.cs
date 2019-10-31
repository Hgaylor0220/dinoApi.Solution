using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dinoApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dinos",
                columns: table => new
                {
                    DinoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Mood = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    AsKnownAs = table.Column<string>(nullable: true),
                    Strength = table.Column<string>(nullable: true),
                    Weakness = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinos", x => x.DinoId);
                });

            migrationBuilder.InsertData(
                table: "Dinos",
                columns: new[] { "DinoId", "AsKnownAs", "Diet", "Habitat", "Mood", "Name", "PhotoPath", "Strength", "Type", "Weakness" },
                values: new object[,]
                {
                    { 1, "Sand Lizard", "Herbivorous", "Dense marsh lands", "Arrogant", "Ammosaurus", "wwwroot/uploads/Ammosaurus.jpg", "Long arms, able to walk on two feet", "Sauropod", "Not able to walk on four legs so there are issues when running away" },
                    { 2, "Huayang lizard'", "Herbivorous", "Forest, center island", "Relaxed", "Huayangosaurus", "wwwroot/uploads/huayango.jpg", "Spiky spine leading to a long thick tail with aspikes coming out.", "Armoured Dinosour", "Under side of the dinosour. If the dinosour gets knocked off balance he has no hope." },
                    { 3, "T-rex or Tyrant lizard", "Carnivorous", "Outskirts of the Island", "Consistantly raging", "Tyrannosaurus", "wwwroot/uploads/Tyrannosaurus.jpg", "Strong legs, huge mouth with large sharp teeth", "Large theropod", "short arms, cant swim" },
                    { 4, "quick plunderer or Raptor", "Carnivorous", "Grass Lands outskirt of the jungle", "Strategic", "Velociraptor", "wwwroot/uploads/Velociraptor.jpg", "Very smart and fast", "Small theropod", "Smaller in size" },
                    { 5, "terrible claw", "Carnivorous, mainly feeds on plant eating dinos", "Grass lands and jungle", "mystical", "Deinonychus", "wwwroot/uploads/Deinonychus.jpg", "Huge claws, moved swiftly", "Small theropod", "smaller in size" },
                    { 6, "Triciratops, bull lizard", "Herbivorous", "Mountain basin", "Gentel", "Torosaurus", "wwwroot/uploads/Torosaurus.jpg", "Large strong crown with two large horns. Thick skin", "Ceratopsian", "Slow movement" },
                    { 7, "brave monitor lizard", "herbivorous", "Beach side", "Wise and aware", "brave monitor lizard", "wwwroot/uploads/Ouranosaurus.jpg", "Strong swimmer, great eye site, sense of smell and hearing", "euornithopod", "weak body armour and no real type of defense" },
                    { 8, "Alamo lizard or Longnecks", "Herbivorous", "Swamp Land", "Wise and Chill", "Alamosaurus", "wwwroot/uploads/Alamosaurus.jpg", "Long limbs, hard to take down. Over 20 meters in length", "Sauropod", "slwow moving dinosour" },
                    { 9, "Bambi plunderer", "Carnivorous", "Jumgle", "Mischievous", "Bambiraptor", "wwwroot/uploads/Bambiraptor.jpg", "Extremly fast, large claws and capable of flying", "small theropod", "Very small, only 1 meter in length" },
                    { 10, "Good mother lizard", "Herbivorous", "Mountain vally", "Very protective", "Maiasaura", "wwwroot/uploads/Maiasaura.jpg", "Very aware of their surroundings", "euornithopod", "no body armour or type of defense" },
                    { 11, "fleet lizard'", "Carnivorous", "Plateau", "Whitty", "Elaphrosaurus", "wwwroot/uploads/Elaphrosaurus.jpg", "Tall long limbs, quick moving", "large theropod", "Not very strong" },
                    { 12, "Earth Lizard", "Carnivorous", "Valley", "Timmid", "Mapusaurus", "wwwroot/uploads/Mapusaurus.jpg", "Large mouth and fast", "large theropod", "Slightly smaller that other preditors. Not as powerful" },
                    { 13, "Egg Thief", "Omnivourous", "Dense Marsh Land", "Mischievous", "Oviraptor", "wwwroot/uploads/Oviraptor.jpg", "Keen sense of smell and very sneaky", "small theropod", "No real kind of defense" },
                    { 14, " Compso", "Carnivorous", "Jumgle", "Mischievous", "Procompsognathus", "wwwroot/uploads/Procompsognathus.jpg", "Fast and sneaky", "Small Theropod", "timy in size, not dangerous alone" },
                    { 15, "king of the lizard eaters'", "Carnivorous", "Mountain Valley", "Independant jerk bird", "Saurophaganax", "wwwroot/uploads/Saurophaganax.jpg", "All around strong", "Large theropod", "None" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dinos");
        }
    }
}
