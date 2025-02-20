﻿using RossBoiler.Application.Models;
using MediatR;

namespace RossBoiler.Application.Queries
{
    public record GetCustomerPricingByIdQuery(int Id) : IRequest<CustomerPricing>;

}
