using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dinoApi.Models;
using Microsoft.EntityFrameworkCore;



namespace dinoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinosController : ControllerBase
    {

        private dinoApiContext _db;

        public DinosController(dinoApiContext db)
        {
            _db = db;
        }
        // GET api/values
            [HttpGet]
        public ActionResult<IEnumerable<Dino>> Get(string name , string type, string mood, string habitat, string diet, string friends, string strength, string weakness )
        {
            var query = _db.Dinos.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }
             if (type != null)
            {
                query = query.Where(entry => entry.Type.Contains(type));
            }
             if (mood != null)
            {
                query = query.Where(entry => entry.Mood.Contains(mood));
            }
             if (habitat != null)
            {
                query = query.Where(entry => entry.Habitat.Contains(habitat));
            }
             if (diet != null)
            {
                query = query.Where(entry => entry.Diet.Contains(diet));
            }
             if (friends != null)
            {
                query = query.Where(entry => entry.Friends.Contains(friends));
            }
             if (strength != null)
            {
                query = query.Where(entry => entry.Strength.Contains(strength));
            }
             if (weakness != null)
            {
                query = query.Where(entry => entry.Weakness.Contains(weakness));
            }
            


            return query.ToList();
        }

        // POST api/dinos
        [HttpPost]
        public void Post([FromBody] Dino dino)
        {
            _db.Dinos.Add(dino);
            _db.SaveChanges();
        }

        // GET api/dinos/5
        [HttpGet("{id}")]
        public ActionResult<Dino> Get(int id)
        {
            return _db.Dinos.FirstOrDefault(entry => entry.DinoId == id);
        }

        // PUT api/dinos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dino dino)
        {
            dino.DinoId = id;
            _db.Entry(dino).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/dinos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dinoToDelete = _db.Dinos.FirstOrDefault(entry => entry.DinoId == id);
            _db.Dinos.Remove(dinoToDelete);
            _db.SaveChanges();
        }
    }
}
