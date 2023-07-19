using UrlBuilder.Core.ValueObjects.Exceptions;
using UtmBuider.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class CampaignTests
{
    [TestMethod]
    [DataRow("", "", "", true)]
    [DataRow("src", "", "", true)]
    [DataRow("src", "med", "", true)]
    [DataRow("src", "med", "nme", false)]
    public void TestCampaign(
        string source,
        string medium,
        string name,
        bool expectException)
    {
        if (expectException)
        {
            Assert.ThrowsException<InvalidCampaignException>(() => new Campaign(source, medium, name));
        }
        else
        {
            new Campaign(source, medium, name);
            Assert.IsTrue(true);
        }
    }
}