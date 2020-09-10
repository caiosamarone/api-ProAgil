using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgilWebApi.Data;
using ProAgilWebApi.Model;

namespace _ProAgils.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
               
            try
            {
                var results = await _context.Eventos.ToListAsync(); 
                return Ok(results); //retorna status code 200
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou");
            } 
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var results = await _context.Eventos. FirstOrDefaultAsync(x => x.EventoId == id);
                return Ok(results); //retorna status code 200
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou");
            }   
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/56
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var res = 1;
            res ++;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
