using CQRS_Casgem.CQRSPatern.Queries;
using CQRS_Casgem.CQRSPatern.Results;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPatern.Handlers
{
    public class GetProductGetByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductGetByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductGetByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = values.ProductID,
                ProductMark = values.Brand,
                ProductName = values.Name
            };
        }
    }
}
