using DanielDevDojo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielDevDojo.Server
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly AppDbContext _context;

        public PersonController(ILogger<PersonController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            var result = _context.Persons.ToList();
            return Ok(result);
        }

        [HttpGet("last")]
        public async Task<IActionResult> GetPerson()
        {
            var result = _context.Persons.LastOrDefault();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Result result)
        {
            Person person = new Person()
            {
                FirstName = result.name.first,
                LastName = result.name.last,
                Age = result.dob.age,
                Location = result.location.city,
            };
           
            var personadded = await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
            return Ok("");
        }


    }
}
