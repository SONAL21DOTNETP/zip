using System.Net;
using MediatR;

namespace RossBoiler.Application.Commands
{
    public record CreatePartsCommand(
         int PartNumber,
         string Name,
         string? Description,
         int UnitId,
         int GSTId,
         int HSNDetailsId,
         string SupplyType,
         decimal SellingPrice,
         decimal? Weight,
         string? Dimensions,
         int PackingId,
         int? Id,
         string? MaterialOfConstruction) : IRequest<int>;
}