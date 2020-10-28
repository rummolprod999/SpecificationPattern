namespace SpetificationPattern
{
    public class ExampleSpecification1 : CompositeSpecification
    {
        public override bool IsSatisfiedBy(object candidate)
        {
            return true;
        }
    }
}