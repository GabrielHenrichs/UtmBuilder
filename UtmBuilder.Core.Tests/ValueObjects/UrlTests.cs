using UrlBuilder.Core.ValueObjects.Exceptions;
using UtmBuider.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "Invalid URL";
    private const string ValidUrl = "https://github.com";

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url(InvalidUrl);
    }

    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }

    [TestMethod]
    [DataRow(" ", true)]
    [DataRow("http", true)]
    [DataRow(InvalidUrl, true)]
    [DataRow(ValidUrl, false)]
    public void TestUrl(
        string link,
        bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            new Url(link);
            Assert.IsTrue(true);
        }
    }
}