namespace CodeSamplesForAssertion
{
    //Assert to verify the instance type of this class
    //Since this is a singleton, qualifies for another assert to two instances are same
    public class DerivedClass : IAnimal
    {
        private static readonly DerivedClass derivedClass_ = new DerivedClass();

        private DerivedClass()
        {
           
        }

        static DerivedClass()
        {

        }

        public static DerivedClass GetInstance()
        {
            return derivedClass_;
        }
        
        public void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}