using AvengersMVC.Data;
using AvengersMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersMVC.Controllers
{
    [ApiController]
    [Route("api/avengers")]
    public class AvengersController : Controller
    {
        private readonly AvengersContext db;
        public AvengersController(AvengersContext dbContext)
        {
            db = dbContext;
        }

        [Route("get")]
        [HttpGet]
        public async Task<IEnumerable<Avenger>> Get()
        {
            return await db.Avengers.ToListAsync();
        }

        [Route("save")]
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] Avenger avenger)
        {
            db.Avengers.Add(avenger);
            await db.SaveChangesAsync();
            return Ok("Saved");
        }

        [Route("delete")]
        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            Avenger avenger = db.Avengers.Where(av => av.Id == id).First();
            db.Avengers.Remove(avenger);
            await db.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
