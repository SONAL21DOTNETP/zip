
using System.Net;
using MediatR;

namespace RossBoiler.Application.Commands
{
    public record UpdateContactCentreCommand(int Id, int CustomerId, string POC, string PhoneNumber1, string PhoneNumber2, string PhoneNumber3) : IRequest<string>;
}