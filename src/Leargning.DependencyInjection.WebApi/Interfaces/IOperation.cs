using System;

namespace Leargning.DependencyInjection.WebApi.Interfaces
{
    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }
}
