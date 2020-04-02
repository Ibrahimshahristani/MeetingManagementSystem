using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valuesController
    {
        
     private readonly DataContext _context;

    public valuesController(DataContext context)
    {
        _context = context;
    }

// GetAll() is automatically recognized as
// http://localhost:<port #>/api/todo
    [HttpGet]
    public  ActionResult<IEnumerable<value>> Get()
    {
        var values =  _context.values.ToList();
        return values; 
    }


 }

}