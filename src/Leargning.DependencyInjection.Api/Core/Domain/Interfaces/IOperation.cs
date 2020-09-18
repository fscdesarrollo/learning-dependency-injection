using System;

namespace Leargning.DependencyInjection.Api.Domain.Interfaces
{
    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }
}
