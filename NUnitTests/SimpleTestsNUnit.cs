using System.Numerics;
using NUnit.Framework;

namespace NUnitTests;

public class SimpleTestsNUnit
{
    [Test]
    public void VerifyPass()
    {
        Assert.Pass();
    }

    [Test]
    public void VerifyFail()
    {
        Assert.Fail();
    }

    [Test]
    public void VerifyTrue()
    {
        Assert.That(false, Is.True);
        // or: Assert.True(false);
    }

    [Test]
    public void VerifyFalse()
    {
        Assert.That(true, Is.False);
        // or: Assert.False(true);
    }

    [Test]
    public void VerifyNull()
    {
        Assert.That("test", Is.Null);
        // or: Assert.Null("test");
    }

    [Test]
    public void VerifyNotNull()
    {
        Assert.That(null, Is.Not.Null);
        // or: Assert.NotNull(null);
        // or: Assert.IsNotNull(null);
    }

    [Test]
    public void VerifyEqual()
    {
        const int expected = 1;
        const int actual = 2;

        Assert.That(actual, Is.EqualTo(expected));
        // or: Assert.AreEqual(expected, actual);
    }

    [Test]
    public void VerifyNotEqual()
    {
        const int expected = 1;
        const int actual = 1;

        Assert.That(actual, Is.Not.EqualTo(expected));
        // or: Assert.AreNotEqual(expected, actual);
    }

    [Test]
    public void VerifySame()
    {
        var expected = new
        {
            Message = "hello"
        };
        var actual = new
        {
            Message = "hello"
        };

        Assert.That(actual, Is.SameAs(expected));
        // or: Assert.AreSame(expected, actual);
    }

    [Test]
    public void VerifyNotSame()
    {
        var expected = new
        {
            Message = "hello"
        };
        var actual = expected;
        
        Assert.That(actual, Is.Not.SameAs(expected));
        // or: Assert.AreNotEqual(expected, actual);
    }
}
