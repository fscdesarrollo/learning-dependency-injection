using Leargning.DependencyInjection.Api.EntryPoint.UseCases.Operations.GetOperations;
using Microsoft.AspNetCore.Mvc;

namespace Leargning.DependencyInjection.Api.EntryPoint.UseCases.Operations
{

    public partial class OperationsController
    {

        private const string TRANSCIENT_DEFINITION = "Transient objects are always different; a new instance is provided to every controller and every service";
        private const string SCOPED_DEFINITION = "Scoped objects are the same within a request, but different across different requests";
        private const string SINGLETON_DEFINITION = "Singleton objects are the same for every object and every request";

        [HttpGet]
        public IActionResult GetOpeartions()
        {
            var result = new GetOperationsResponse
            {
                Trascient = new Trascient(_transientOperation.OperationId, TRANSCIENT_DEFINITION),
                Scoped = new Scoped(_scopedOperation.OperationId, SCOPED_DEFINITION),
                Singleton = new Singleton(_singletonOperation.OperationId, SINGLETON_DEFINITION),
                OperationService = new Operationservice(
                    trascient: _operationService.TransientOperation.OperationId,
                    scoped: _operationService.ScopedOperation.OperationId,
                    singleton: _operationService.SingletonOperation.OperationId
                    )
            };

            return new OkObjectResult(result);
        }

    }
}
