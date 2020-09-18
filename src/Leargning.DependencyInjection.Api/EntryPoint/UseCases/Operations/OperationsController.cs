using Leargning.DependencyInjection.Api.Domain.Entities;
using Leargning.DependencyInjection.Api.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Leargning.DependencyInjection.Api.EntryPoint.UseCases.Operations
{

    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("[controller]")]
    [ApiController]
    public partial class OperationsController : Controller
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
    }
}
