using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Products
{
    public class Details
    {
        public class Query: IRequest<Result<Product>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Product>>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }
            public async Task<Result<Product>> Handle(Query request, CancellationToken cancellationToken)
            {
                var product =  await _dataContext.Products.FindAsync(request.Id);

                if (product == null) return null;

                return Result<Product>.Success(product);

            }
        }
    }
}
