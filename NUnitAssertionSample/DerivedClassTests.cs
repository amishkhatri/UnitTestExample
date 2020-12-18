using CodeSamplesForAssertion;
using NUnit.Framework;
using System;

namespace NUnitAssertionSamples
{


    public class DerivedClassTests
    {

        //Assert on two objects with the same class (Singleton Pattern)
        [Test]
        public void CompareTwoSameClassInstances()
        {
                object derivedClass1 = new object();
                object derivedClass2 = new object();

                try
                {
                    derivedClass1 = DerivedClass.GetInstance();
                    derivedClass2 = DerivedClass.GetInstance();

                    Assert.IsInstanceOf(typeof(DerivedClass), derivedClass1);
                    Assert.IsInstanceOf(typeof(DerivedClass), derivedClass2);
                }
                catch (System.Exception ex)
                {
                    Assert.Fail();
                    throw ex;
                }
                finally
                {
                    if (derivedClass1 != null)
                        derivedClass1 = null;

                    if (derivedClass2 != null)
                        derivedClass2 = null;
            }
                        
        }

        //Eqality Assert on two objects (Singleton Pattern)
        [Test]
        public void CompareTwoObjects()
        {

            object derivedClass1 = new object();
            object derivedClass2 = new object();

            try
            {
                derivedClass1 = DerivedClass.GetInstance();
                derivedClass2 = DerivedClass.GetInstance();

                if (derivedClass1 == derivedClass2)
                    Assert.AreEqual(derivedClass1, derivedClass2);
                else
                    Assert.Fail();

            }
            catch (System.Exception ex)
            {
                Assert.Fail();
                throw ex;
            }
            finally
            {
                if (derivedClass1 != null)
                    derivedClass1 = null;

                if (derivedClass2 != null)
                    derivedClass2 = null;
            }
        }


    }



}