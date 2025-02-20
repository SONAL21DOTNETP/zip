using RossBoiler.Application.Models;
using MediatR;

namespace RossBoiler.Application.Queries
{
    public record GetAdressByCustomerIdQuery(int CustomerId) : IRequest<Address>;
}