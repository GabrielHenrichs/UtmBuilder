using System.Text.RegularExpressions;
using UrlBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuider.ValueObjects;

public class Url : ValueObject
{
    /// <summary>
    /// Creates a new Url
    /// </summary>
    /// <param name="address">Address of URL (Website link)</param>
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }

    /// <summary>
    /// Address of URL (Website link)
    /// </summary>
    public string Address { get; }
}