using System;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Wrappers;

namespace ProductApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}