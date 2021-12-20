using NUnit.Framework;
using PostCodeAPi;
using PostCodeAPi.Services;

namespace TestProject1
{
    public class Tests
    {

        IPostCodeSearch postcode;

        [SetUp]
        public void Setup(IPostCodeSearch code)
        {
            postcode = code;
        }

        [Test]
        public void Test1()
        {
            
            var test = postcode.test("test");

            Assert.AreEqual("",test);
        }
    }
}