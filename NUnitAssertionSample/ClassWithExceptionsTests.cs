using CodeSamplesForAssertion;
using NUnit.Framework;

namespace NUnitAssertionSamples
{

    public class ClassWithExceptionsTests
    {

        private void ObjectDispose(object obj)
        {
            if (obj is ClassWithExceptions)
                obj = null;
        }


        [Test]
        public void ShouldReturnName()
        {
            var classWithException = new ClassWithExceptions();
            try
            {                
                var result = classWithException.SayHello("amish");

                Assert.IsNotNull(result);
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(classWithException);
            }

        }

        [Test]
        public void ShouldReturnNullException()
        {
            var classWithException = new ClassWithExceptions();

            try
            {
             
                var result = classWithException.SayHello(null);

                //if (result == null)
                //    Assert.Pass();
                //else
                //    Assert.Fail();
                //Assert.IsNotNull(classWithException.SayHello(null));
            }
            catch (System.Exception ex)
            {
                Assert.Pass();
                throw ex;
            }
            finally
            {
                
                ObjectDispose(classWithException);
            }


        }

    }



}