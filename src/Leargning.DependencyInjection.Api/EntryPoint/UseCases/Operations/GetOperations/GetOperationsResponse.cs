using System;

namespace Leargning.DependencyInjection.Api.EntryPoint.UseCases.Operations.GetOperations
{
    public class GetOperationsResponse
    {
        public Trascient Trascient { get; set; }
        public Scoped Scoped { get; set; }
        public Singleton Singleton { get; set; }
        public Operationservice OperationService { get; set; }
    }

    public class Trascient : InjectionType 
    {
        public Trascient(Guid id, string description) : base(id,description) { }

    }

    public class Scoped : InjectionType
    {
        public Scoped(Guid id, string description) : base(id, description) { }
    }

    public class Singleton : InjectionType
    {
        public Singleton(Guid id, string description) : base(id, description) { }
    }

    public class Operationservice
    {
        public Operationservice(Guid trascient, Guid scoped, Guid singleton)
        {
            Trascient = trascient;
            Scoped = scoped;
            Singleton = singleton;
        }

        public Guid Trascient { get; set; }
        public Guid Scoped { get; set; }
        public Guid Singleton { get; set; }
    }

    public class InjectionType
    {
        public InjectionType(Guid id, string description)
        {
            Id = id;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
    }

}
