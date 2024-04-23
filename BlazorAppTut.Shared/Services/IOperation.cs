namespace BlazorApp1Tut.Shared.Services
{
    public interface IOperation
    {
        Guid Guid { get; }
    }
    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }
}
