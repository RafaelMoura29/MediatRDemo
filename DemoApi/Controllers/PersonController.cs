using DemoLibrary.Commands;
using DemoLibrary.DataAccess.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        [HttpGet("{id}")]
        public async Task<PersonModel> DetailsAsync(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        [HttpPost]
        public async Task<PersonModel> CreateAsync([FromBody] PersonModel value)
        {
            var command = new InsertPersonCommand(value.FirstName, value.LastName);
            return await _mediator.Send(command);
        }
    }
}
