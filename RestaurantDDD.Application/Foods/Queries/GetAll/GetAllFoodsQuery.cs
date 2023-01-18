using MediatR;
using RestaurantDDD.Domain.Entities;

namespace RestaurantDDD.Application.Foods.Queries.GetAll;

public class GetAllFoodsQuery : IRequest<IEnumerable<Food>>
{
}
