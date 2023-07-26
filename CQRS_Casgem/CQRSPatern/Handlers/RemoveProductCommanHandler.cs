using CQRS_Casgem.CQRSPatern.Commands;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPatern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context __context;

        public RemoveProductCommandHandler(Context context)
        {
            __context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = __context.Products.Find(command.Id);
            __context.Products.Remove(values);
            __context.SaveChanges();
        }
    }
}
