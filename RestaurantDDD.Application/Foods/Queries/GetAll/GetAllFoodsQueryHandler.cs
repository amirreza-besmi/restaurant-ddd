using MediatR;
using Microsoft.EntityFrameworkCore;
using RestaurantDDD.Domain.Entities;
using RestaurantDDD.Infrastructure.Data;

namespace RestaurantDDD.Application.Foods.Queries.GetAll;

public class GetAllFoodsQueryHandler : IRequestHandler<GetAllFoodsQuery, IEnumerable<Food>>
{
    private readonly ApplicationDbContext _dbContext;

    public GetAllFoodsQueryHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Food>> Handle(GetAllFoodsQuery request, CancellationToken cancellationToken)
    {
        var foods = await _dbContext.Food.ToListAsync();
        return foods;
    }
}
