using System;

namespace CodeSamplesForAssertion
{
    public class ClassWithExceptions
    {
        //This could qualify for two exception tests. 
        //1. Assert it throws the correct exception. 
        // 2. Assert correct exception message
        public string SayHello(string yourName)
        {
            if (yourName == null)
            {
                throw new ArgumentNullException(yourName, "Name cannot be null");
            }
            return "Hello " + yourName;

        }
    }
}