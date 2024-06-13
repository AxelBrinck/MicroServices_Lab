namespace MicroServices.Framework.Entities;

public abstract record Entity(
    Guid Id,
    Guid CreatedByProcessId,
    DateTime CreationTimestamp
);