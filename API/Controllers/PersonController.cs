

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DbContexts;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PersonController : ControllerBase
  {
    private readonly ILogger<PersonController> _logger;
    private readonly MyDBContext _context;
    public PersonController(ILogger<PersonController> logger, MyDBContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet()]
    public IList<Person> getAll()
    {
        var result = _context.Persons.ToList();
        return result;
    }
  }
}