namespace SpetificationPattern
{
    public abstract class CompositeSpecification : ISpecification
    {
        public abstract bool IsSatisfiedBy(object candidate);

        public ISpecification And(ISpecification other)
        {
            return new AndSpecification(this, other);
        }

        public ISpecification Or(ISpecification other)
        {
            return new OrSpecification(this, other);
        }

        public ISpecification Not()
        {
            return new NotSpecification(this);
        }
    }
}