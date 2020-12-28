using CodeSamplesForAssertion;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitAssertionSamples
{

    public class EqualitySampleTests
    {
        
        [Test]
        public void ShouldReturnAmishGetWelcomMessageTest()
        {
                string expected = "amish";

                var equalitySample = new EqualitySample();
                var actual = equalitySample.GetWelcomeMessage(expected);
            
                // string equality assertion
                StringAssert.AreEqualIgnoringCase("Welcome " + expected, actual);
                
        }

        [Test]
        public void GetTextAppendWithRandomNumberTest()
        {
                var equalitySample = new EqualitySample();
                string expected = "Hello";

                var actual = equalitySample.GetTextAppendWithRandomNumber(expected);

                // string non-equality assertion
                StringAssert.AreNotEqualIgnoringCase(expected, actual);
            
        }


        [Test]
        public void TwoNumberAdditonTest()
        {

                var equalitySample = new EqualitySample();

                var i = 10;  
                var j = 20;

                var actual = equalitySample.AddNumbers(i, j);

                //equality assertion
                Assert.AreEqual((i + j), actual);
            
        }

        [Test]
        public void GetMaturityAmountTest()
        {
                var equalitySample = new EqualitySample();
                var principal = 100;
                var interest = 8;

                var MaturityAmount = equalitySample.GetMaturityAmount(principal, interest);

                //delta assertion
                Assert.AreEqual(principal + interest, MaturityAmount);

                //equality assertion
                Assert.AreEqual(100 + (100 * 8 / 100), MaturityAmount);
            
        }

        [Test]
        public void WeekendDaysTest()
        {

            var equalitySample = new EqualitySample();

                IList<string> weekDays = equalitySample.WeekendDays();

                int countOfWeekDays = weekDays.Count();

                // non nullable assertion 
                Assert.IsNotNull(weekDays);

                weekDays.Add("monday");
                weekDays.Add("tuesday");
                weekDays.Add("wedensday");
                weekDays.Add("friday");

                // delta assertion 
                Assert.AreEqual(countOfWeekDays + 4, weekDays.Count());
            
        }

    }



}