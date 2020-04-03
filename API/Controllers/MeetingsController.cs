using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application;
using Application.Meetings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
    public class MeetingsController : ControllerBase
    {
       
           private readonly IMediator _mediator;
            public MeetingsController(IMediator mediator)
            {
                _mediator = mediator;
            }
        
        [HttpGet]
        public async Task<ActionResult<List<Meeting>>> List() 
        {

            return await _mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Meeting>> Details(Guid id)
        {
            return await _mediator.Send(new Details.Query{Id = id});
        }
        [HttpPost]
        public async Task<ActionResult<Unit>>Create(Create.Command command)
        {
                return await _mediator.Send(command);
        }

        }
    }
