using Xunit;
using Src;
using System.Collections.Generic;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<int> { 2, 3, 5, 4, 1 };

        var expected = "BOB";
        var actual = Result.gamingArray(arr);

        Assert.Equal(expected, actual);
    }
}