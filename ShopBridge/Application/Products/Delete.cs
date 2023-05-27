using MediatR;
using Persistence;

namespace Application.Products
{
    public class Delete
    {
        public class Command: IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = await _dataContext.Products.FindAsync(request.Id);

                 _dataContext.Products.Remove(product);
                
                await _dataContext.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
