using System;
using Xunit;

namespace XUnitTests;

public class CollectionTestsXUnit
{
    [Fact]
    public void VerifyCollectionIsEmpty()
    {
        var collection = new[] { "banana" };
        
        Assert.Empty(collection);
    }

    [Fact]
    public void VerifyCollectionIsNotEmpty()
    {
        var collection = Array.Empty<string>();
        
        Assert.NotEmpty(collection);
    }

    [Fact]
    public void VerifyCollectionHasTwoItems()
    {
        var collection = new[] { "banana" };

        Assert.Equal(2, collection.Length);
    }

    [Fact]
    public void VerifyCollectionContainsItem()
    {
        var collection = Array.Empty<string>();

        Assert.Contains("hello", collection);
    }

    [Fact]
    public void VerifyCollectionDoesNotContainItem()
    {
        var collection = new[] { "hello", "goodbye" };

        Assert.DoesNotContain("hello", collection);
    }
}
