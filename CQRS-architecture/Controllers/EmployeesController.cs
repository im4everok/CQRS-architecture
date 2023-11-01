using BusinessLogic.Commands.Employees.CreateEmployee;
using BusinessLogic.Queries.Employees.GetAll;
using BusinessLogic.Queries.Employees.GetById;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace CQRS_architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EmployeesController : ControllerBase
    {
        private readonly ISender _mediator;

        public EmployeesController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TestGet()
        {
            var employees = await _mediator.Send(new GetEmployeesQuery());

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> TestPost([FromBody] string name)
        {
            var addedEmployee = await _mediator.Send(new CreateEmployeeCommand(new() { Name = name }));
            
            return Ok(addedEmployee);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery(id));

            return Ok(employee);
        }
    }
}
