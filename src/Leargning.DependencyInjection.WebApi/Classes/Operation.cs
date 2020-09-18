using Leargning.DependencyInjection.WebApi.Interfaces;
using System;

namespace Leargning.DependencyInjection.WebApi.Classes
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
