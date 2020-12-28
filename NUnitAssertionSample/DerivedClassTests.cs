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

                derivedClass1 = DerivedClass.GetInstance();
                derivedClass2 = DerivedClass.GetInstance();

                Assert.IsInstanceOf(typeof(DerivedClass), derivedClass1);
                        
        }

        //Eqality Assert on two objects (Singleton Pattern)
        [Test]
        public void CompareTwoObjects()
        {

                object derivedClass1 = new object();
                object derivedClass2 = new object();

                derivedClass1 = DerivedClass.GetInstance();
                derivedClass2 = DerivedClass.GetInstance();

                Assert.AreEqual(derivedClass1, derivedClass2);
            
        }


    }



}