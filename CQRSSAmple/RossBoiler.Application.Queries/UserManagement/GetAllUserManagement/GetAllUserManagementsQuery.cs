using MediatR;
using RossBoiler.Application.Models;

namespace RossBoiler.Application.Queries
{
	public record GetAllUserManagementsQuery() : IRequest<List<UserManagement>>;
}
