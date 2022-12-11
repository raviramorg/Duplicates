using DuplicatesLib;

namespace DuplicatesTest
{
    [TestFixture]
    public class Tests
    {       
        [Test]
        public void TwoElementsMustBeTrue()
        {
            int[] array = { 2, 2 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }

        [Test]
        public void TwoElementsMustBeFalse()
        {
            int[] array = { 1, 2 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.False);
        }

        [Test]
        public void ThreeElementsMustBeTrue_1()
        {
            int[] array = { 1, 2, 1 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ThreeElementsMustBeTrue_2()
        {
            int[] array = { 1, 1, 2 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ThreeElementsMustBeTrue_3()
        {
            int[] array = { 1, 1, 2 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ThreeElementsMustBeFalse()
        {
            int[] array = { 1, 2, 3 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.False);
        }

        [Test]
        public void ManyElementsMustBeFalse()
        {
            int[] array = { 1, 2, 3, 4, 5, 55, 555 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.False);
        }

        [Test]
        public void ManyElementsMustBeTrue_1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 5 };
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }

        public void ManyElementsMustBeTrue_2()
        {
            int[] array = { 1, 2, 3, 1, 5, 6, 1};
            var result = Duplicate.Present(array);
            Assert.That(result, Is.True);
        }
    }
}