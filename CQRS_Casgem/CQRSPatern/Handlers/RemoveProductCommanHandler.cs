using CQRS_Casgem.CQRSPatern.Commands;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPatern.Handlers
{
    public class RemoveProductCommanHandler
    {
        private readonly Context _context;

        public RemoveProductCommanHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = _context.Products.Find(command.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }

    }
}
