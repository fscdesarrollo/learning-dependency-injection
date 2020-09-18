using Leargning.DependencyInjection.Api.Domain.Interfaces;
using System;

namespace Leargning.DependencyInjection.Api.Domain.Entities
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        Guid _guid;

        public Operation() : this(Guid.NewGuid())
        {

        }

        public Operation(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;
    }
}
