using RossBoiler.Application.Models;
using MediatR;

namespace RossBoiler.Application.Queries
{
    public record GetAllPartsQuery() : IRequest<List<Parts>>;
}