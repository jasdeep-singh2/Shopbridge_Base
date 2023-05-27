using Domain;
using MediatR;
using Persistence;

namespace Application.Products
{
    public class Details
    {
        public class Query: IRequest<Product>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Product>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }
            public async Task<Product> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataContext.Products.FindAsync(request.Id);
            }
        }
    }
}
