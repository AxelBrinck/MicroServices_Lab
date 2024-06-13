namespace MicroServices.Framework.Entities;

public abstract record Aggregate : Entity
{
    public DateTime LastEventTimestamp { get; }

    protected Aggregate(
        Guid id,
        Guid createdByProcessId,
        DateTime creationTimestamp
    ) : base(id, createdByProcessId, creationTimestamp)
    {

    }
}
