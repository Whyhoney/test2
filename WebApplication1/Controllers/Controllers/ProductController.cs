using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.dta;
using WebApplication1.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       
        [HttpGet("Get")]
        public IActionResult Get()
        {
            var op = new DbContextOptionsBuilder<DbDataContext>().UseSqlServer("Data Source=DESKTOP-53N4E3T;Initial Catalog=Product; Integrated Security=true").Options;
            var db = new DbDataContext(op);
            var products = db.products.ToList();
            return Ok(products);
        }

        // PUT api/<ProductController>/5
        [HttpPut("/{id}/{name}/{desc}")]
        public IActionResult Put(int id, string name, string desc)
        {
            var op = new DbContextOptionsBuilder<DbDataContext>().UseSqlServer("Data Source=DESKTOP-53N4E3T;Initial Catalog=Product; Integrated Security=true").Options;
            var db = new DbDataContext(op);

            var add = new Product
            {
                Id = id,
                Name = name,
                Description = desc
            };
            db.products.Add(add);
            db.SaveChanges();
            return Ok(add);
        }
    }
}
