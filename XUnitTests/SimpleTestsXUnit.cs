using Xunit;

namespace XUnitTests;

public class SimpleTestsXUnit
{
    [Fact]
    public void VerifyPass()
    {
        Assert.True(true);
    }

    [Fact]
    public void VerifyFail()
    {
        Assert.True(false);
    }

    [Fact]
    public void VerifyTrue()
    {
        Assert.True(false);
    }

    [Fact]
    public void VerifyFalse()
    {
        Assert.False(true);
    }
    
    [Fact]
    public void VerifyNull()
    {
        Assert.Null("test");
    }
    
    [Fact]
    public void VerifyNotNull()
    {
        Assert.NotNull(null);
    }
    
    [Fact]
    public void VerifyEqual()
    {
        const int expected = 1;
        const int actual = 2;
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyNotEqual()
    {
        const int expected = 1;
        const int actual = 1;
        
        Assert.NotEqual(expected, actual);
    }

    [Fact]
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
        
        Assert.Same(expected, actual);
    }

    [Fact]
    public void VerifyNotSame()
    {
        var expected = new
        {
            Message = "hello"
        };
        var actual = expected;
        
        Assert.NotSame(expected, actual);
    }
}
