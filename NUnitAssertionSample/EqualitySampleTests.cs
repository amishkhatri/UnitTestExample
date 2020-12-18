using CodeSamplesForAssertion;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitAssertionSamples
{

    public class EqualitySampleTests
    {
        private readonly EqualitySample equalitySample;

        public EqualitySampleTests()
        {
            equalitySample = new EqualitySample();
        }

        private void ObjectDispose(object obj)
        {
            if (obj is EqualitySample)
                obj = null;
        }

        [Test]
        public void ShouldReturnAmishGetWelcomMessageTest()
        {
            try
            {
                string expected = "amish";

                var actual = equalitySample.GetWelcomeMessage(expected);

                Assert.IsNotNull(actual);

                // string equality assertion
                StringAssert.AreEqualIgnoringCase("Welcome " + expected, actual);
                
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(equalitySample);
            }
        }

        [Test]
        public void GetTextAppendWithRandomNumberTest()
        {
            try
            {
                string expected = "Hello";

                var actual = equalitySample.GetTextAppendWithRandomNumber(expected);

                // string non-equality assertion
                StringAssert.AreNotEqualIgnoringCase(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(equalitySample);
            }
        }


        [Test]
        public void TwoNumberAdditonTest()
        {
            var i = 10;  
            var j = 20;

            try
            {
                var actual = equalitySample.AddNumbers(i, j);

                //equality assertion
                Assert.AreEqual((i + j), actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(equalitySample);
            }
        }

        [Test]
        public void GetMaturityAmountTest()
        {
            var principal = 100;
            var interest = 8;

            try
            {
                var MaturityAmount = equalitySample.GetMaturityAmount(principal, interest);

                //delta assertion
                Assert.AreEqual(principal + interest, MaturityAmount);

                //equality assertion
                Assert.AreEqual(100 + (100 * 8 / 100), MaturityAmount);
            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(equalitySample);
            }
        }

        [Test]
        public void WeekendDaysTest()
        {

            try
            {
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
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                ObjectDispose(equalitySample);
            }
        }

    }



}