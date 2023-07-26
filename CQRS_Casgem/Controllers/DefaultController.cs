using CQRS_Casgem.CQRSPatern.Commands;
using CQRS_Casgem.CQRSPatern.Handlers;
using Microsoft.AspNetCore.Mvc;


namespace CQRS_Casgem.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommanHandler _createProductCommandHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommanHandler createProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand createProductComman)
        {
            _createProductCommandHandler.Handle(createProductComman);    
            return RedirectToAction("Index");   
        }

        public IActionResult DeleteProduct(RemoveProductCommand  command)
        {
            _removeProductCommandHandler.command);
            return RedirectToAction("Index");
        }


    }
}
