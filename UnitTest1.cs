using NUnit.Framework;

namespace FirstUnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void IsNull()
        {
            object obj = null;
            Assert.That(obj, Is.Null);
        }

        [Test]
        public void IsNotNull()
        {

#pragma warning disable NUnit2023
            Assert.That(42, Is.Not.Null);
#pragma warning restore NUnit2023
        }

        [Test]
        public void IsTrue()
        {
            Assert.That(2 + 2 == 4, Is.True);
        }

        [Test]
        [Ignore("I want to ignore for testing purpose.")]
        public void IsFalse()
        {
            Assert.That(2 + 2 == 5, Is.False);
        }

        [Test]
        public void IsNaN()
        {
            double d = double.NaN;
            Assert.That(d, Is.NaN);
        }

        [Test]
        public void CollectionContainsTests()
        {
            int[] iarray = new int[] {
                1, 2, 3
            };

            Assert.That(iarray, Has.Member(3));
            Assert.That(iarray, Has.All.LessThan(10));
        }

        [Test]
        public void PositiveWarning()
        {
            Warn.If(true, "This will emit a warning");
            Warn.Unless(false, "This will emit a warning");
            Assert.Pass("This test passes despite the warnings.");
        }
    }
}