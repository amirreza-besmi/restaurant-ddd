using MediatR;
using RestaurantDDD.Domain.Entities;
using RestaurantDDD.Infrastructure.Data;

namespace RestaurantDDD.Application.Foods.Commands;

class FoodCreateCommandHandler : IRequestHandler<FoodCreateCommand, long>
{
    private readonly ApplicationDbContext _dbContext; // TODO: Use repository!

    public FoodCreateCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<long> Handle(FoodCreateCommand request, CancellationToken cancellationToken)
    {
        var food = new Food()
        {
            Title = request.Title,
            Price = request.Price,
            Description = request.Description,
            IsActive = request.IsActive
        };

        var result = _dbContext.Food.Add(food);
        
        await _dbContext.SaveChangesAsync();

        return food.Id; // Or: result.Entity.Id
    }
}
