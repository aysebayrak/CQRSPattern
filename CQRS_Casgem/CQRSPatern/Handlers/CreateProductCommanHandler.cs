using CQRS_Casgem.CQRSPatern.Commands;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPatern.Handlers
{
    public class CreateProductCommanHandler
    {
        private readonly Context _context;

        public CreateProductCommanHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Brand = command.Brand,
                Category = command.Category,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock

            });
            _context.SaveChanges();

        }
    }
}
