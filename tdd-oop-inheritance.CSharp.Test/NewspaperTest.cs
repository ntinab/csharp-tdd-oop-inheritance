﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    [TestFixture]
    public class NewspaperTest
    {
        [Test]
        public void ShouldBeUnavailableForCheckIn()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");

            Assert.AreEqual("Newspapers are not available for loan!", newspaper.CheckIn());
        }

        [Test]
        public void ShouldBeUnavailableForCheckOut()
        {
            Newspaper newspaper = new Newspaper("The Daily Java");

            Assert.AreEqual("Newspapers are not available for loan!", newspaper.CheckOut());
        }
    }
}