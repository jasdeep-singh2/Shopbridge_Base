﻿using Application.Core;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Products
{
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Product Product { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Product).SetValidator(new ProductValidator());
            }
        }
        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _dataContext;
            private readonly IMapper _mapper; 

            public Handler(DataContext dataContext, IMapper mapper)
            {
                _dataContext = dataContext;
                _mapper = mapper;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = await _dataContext.Products.FindAsync(request.Product.Id);
                if (product == null) return null;

                _mapper.Map(request.Product, product);

                var result = await _dataContext.SaveChangesAsync() > 0;
                if (!result) return Result<Unit>.Failure("Failed to update activity");

                return Result<Unit>.Success(Unit.Value);
   
            }
        }
    }
}
