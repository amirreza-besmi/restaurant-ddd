using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantDDD.Application.Foods.Commands;
using RestaurantDDD.Application.Foods.Models;

namespace RestaurantDDD.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<FoodController> _logger;

        public FoodController(IMediator mediator, ILogger<FoodController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FoodAddInfo model)
        {
            long foodId = await _mediator.Send(new FoodCreateCommand() {
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                IsActive = model.IsActive
            });

            return Ok(foodId);
        }
    }
}