
using BlazorApp1Tut.Shared.Services;

namespace BlazorApp1Tut.Shared.Entity
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
    
        public Guid Guid => _guid;


    }
}
