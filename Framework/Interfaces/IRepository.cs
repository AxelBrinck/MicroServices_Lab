using MicroServices.Framework.Entities;

namespace MicroServices.Framework.Interfaces;

public interface IRepository<TAggregate> where TAggregate : Aggregate
{
    void Save<TEvent>(
        TEvent aggregate,
        Action onAlreadyExists
    );
}