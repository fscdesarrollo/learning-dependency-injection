using Leargning.DependencyInjection.WebApi.Interfaces;
using Leargning.DependencyInjection.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Leargning.DependencyInjection.WebApi.Controllers
{
    public class OperationsController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;

        public OperationsController(OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
        }

        public IActionResult Index()
        {
            // ViewBag contains controller-requested services
            ViewBag.Transient = _transientOperation.OperationId;
            ViewBag.Scoped = _scopedOperation.OperationId;
            ViewBag.Singleton = _singletonOperation.OperationId;

            ViewBag.ServiceTransient = _operationService.TransientOperation.OperationId;
            ViewBag.ServiceScoped = _operationService.ScopedOperation.OperationId; ;
            ViewBag.ServiceSingleton = _operationService.SingletonOperation.OperationId;

            // Operation service has its own requested services
            ViewBag.Service = _operationService;
            return View();
        }
    }
}