
using MediatR;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
    public record GetContactCentreByCustomerIdQuery(int CustomerId) : IRequest<ContactCentre>;
}