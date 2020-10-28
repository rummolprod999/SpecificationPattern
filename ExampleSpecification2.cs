namespace SpecificationPattern
{
    public class ExampleSpecification2 : CompositeSpecification
    {
        public override bool IsSatisfiedBy(object candidate)
        {
            return false;
        }
    }
}