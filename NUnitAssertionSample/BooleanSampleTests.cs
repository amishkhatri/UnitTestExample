using NUnit.Framework;
using CodeSamplesForAssertion;

namespace NUnitAssertionSamples
{

    public class BooleanSampleTests
    {
        
        //weekend
        [Test]
        public void ShouldReturnFalseWhenSaturday()
        {

            var booleanSample = new BooleanSample();
            var result = booleanSample.IsWeekDay("Saturday");

            Assert.IsFalse(result);
        }

        //validation
        [Test]
        public void ShouldReturnFalseWhenWrongInput()
        {
            
            var booleanSample = new BooleanSample();
            var result = booleanSample.IsWeekDay("ABC");

            Assert.IsFalse(result);
        }

        //weekedays
        [Test]
        public void ShouldReturnFalseWhenMonday()
        {
            
            var booleanSample = new BooleanSample();
            var result = booleanSample.IsWeekDay("MONDAY");

            Assert.IsTrue(result);
        }

    }



}