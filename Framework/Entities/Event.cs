namespace MicroServices.Framework.Entities;

public abstract record Event : Entity
{
    public Guid AggregateId { get; }
    public int Version { get; }

    protected Event(
        Guid id,
        Guid aggregateId,
        Guid createdByProcessId,
        int version,
        DateTime creationTimestamp
    ) : base(id, createdByProcessId, creationTimestamp)
    {
        AggregateId = aggregateId;
        Version = version;
    }
}
