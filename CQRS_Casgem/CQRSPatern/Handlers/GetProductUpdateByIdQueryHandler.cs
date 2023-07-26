using CQRS_Casgem.CQRSPatern.Queries;
using CQRS_Casgem.CQRSPatern.Results;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPatern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateByIdQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateByIdQueryResult
            {
                Brand = value.Brand,
                Category = value.Category,
                Name = value.Name,
                Price = value.Price,
                ProductID = value.ProductID,
                Stock = value.Stock
            };
        }
    }
}
