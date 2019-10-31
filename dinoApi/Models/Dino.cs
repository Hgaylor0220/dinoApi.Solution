using System.Collections.Generic;

namespace dinoApi.Models
{
    public class Dino
    {
        public int DinoId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Mood { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public string AsKnownAs { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }
        public string PhotoPath {get; set;}
    }
}