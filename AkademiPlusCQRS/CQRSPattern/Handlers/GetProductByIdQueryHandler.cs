using AkademiPlusCQRS.CQRSPattern.Queries;
using AkademiPlusCQRS.CQRSPattern.Results;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;
        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Set<Product>().Find(query.ID);
            return new GetProductByIdQueryResult
            {
                Brand = values.Brand,
                Name = values.Name,
                ProductID = values.ProductID
            };
        }
    }
}
