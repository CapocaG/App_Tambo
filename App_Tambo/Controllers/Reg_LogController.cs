using App_Tambo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App_Tambo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reg_LogController : ControllerBase
    {
        private readonly BDTAMBOContext db;

        public Reg_LogController(BDTAMBOContext ctx) { 
            db= ctx;
        }


        // GET: api/<Reg_LogController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Reg_LogController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Reg_LogController>
        [HttpPost("PostUsuario")]
        public ActionResult<Ususario> PostUsuario([FromBody] Ususario users)
        {
            try { 
                db.Ususarios.Add(users);
                db.SaveChanges();
                return users;
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        // POST api/<Reg_LogController>
        [HttpPost("login")]
        public async Task<IActionResult> Login(login log)
        {
            var usuario = await db.Ususarios.FirstOrDefaultAsync(u => u.Nombre == log.nombre && u.Password == log.password);
            if (usuario == null)
            {
                return Unauthorized();
            }
            return Ok(new {Mensaje="sesion exitoso" });
        }

        // PUT api/<Reg_LogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Reg_LogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
