using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(1, 2)]
        public static void Add_Tests(int a, int b)
        {
            int result = API.add(a, b);
            Assert.That(result, Is.EqualTo(a + b));
        }
        [Test]
        [TestCase(4, 2)]
        public static void Div_Test(int a, int b)
        {
            int result = API.div(a, b);
            Assert.That(result, Is.EqualTo(a / b));
        }
    }
}