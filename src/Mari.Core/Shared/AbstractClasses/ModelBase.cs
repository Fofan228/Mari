using Repo.Abstractions.AbstractClasses;

namespace Mari.Core.Shared.AbstractClasses;

public abstract class ModelBase<TId> : ModelWithId<TId> 
    where TId : IEquatable<TId>
{
    
}