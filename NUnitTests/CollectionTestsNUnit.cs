using System;
using NUnit.Framework;

namespace NUnitTests;

[TestFixture]
public class CollectionTestsNUnit
{
    [Test]
    public void VerifyCollectionIsEmpty()
    {
        var collection = new[] { "banana" };
        
        Assert.That(collection, Is.Empty);
    }

    [Test]
    public void VerifyCollectionIsNotEmpty()
    {
        var collection = Array.Empty<string>();
        
        Assert.That(collection, Is.Not.Empty);
    }

    [Test]
    public void VerifyCollectionHasTwoItems()
    {
        var collection = new[] { "banana" };
        
        Assert.That(collection, Has.Exactly(2).Items);
    }

    [Test]
    public void VerifyCollectionContainsItem()
    {
        var collection = Array.Empty<string>();
        
        Assert.That(collection, Does.Contain("hello"));
    }

    [Test]
    public void VerifyCollectionDoesNotContainItem()
    {
        var collection = new[] { "hello", "goodbye" };
        
        Assert.That(collection, Does.Not.Contain("hello"));
    }
}
