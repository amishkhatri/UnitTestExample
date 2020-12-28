using CodeSamplesForAssertion;
using NUnit.Framework;

namespace NUnitAssertionSamples
{

    public class ClassWithExceptionsTests
    {

        [Test]
        public void ShouldReturnName()
        {
            var classWithException = new ClassWithExceptions();
                            
            var result = classWithException.SayHello("amish");

            Assert.IsNotNull(result);
            
        }

        [Test]
        public void ShouldReturnNullException()
        {
           
            var classWithException = new ClassWithExceptions();

            System.ArgumentNullException ex = Assert.Throws<System.ArgumentNullException>(() => classWithException.SayHello(null));

            Assert.AreEqual("Name cannot be null", ex.Message);
            
        }

    }



}