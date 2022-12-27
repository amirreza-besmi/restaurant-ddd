using MediatR;

namespace RestaurantDDD.Application.Foods.Commands;

internal class FoodCreateCommandHandler : IRequestHandler<FoodCreateCommand, long>
{
    public Task<long> Handle(FoodCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
