using System.Text.RegularExpressions;
namespace Test_Task1;
using mb;
using System.Numerics;
using System;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var A = new Vector2(0,0);
        var B = new Vector2(0,1);
        var C = new Vector2(1,1);

        var triangle = new Triangle(A,B,C);

        Assert.IsTrue(triangle.Square() == 0.5f);
    }

    [TestMethod]
    public void TestMethod2()
    {
        var A = new Vector2(0,0);
        var B = new Vector2(0,1);
        var C = new Vector2(1,1);

        var triangle = new Triangle(A,B,C);

        Assert.IsTrue(triangle.IsRight() == true);
    }

    [TestMethod]
    public void TestMethod3()
    {
        var circle = new Circle(new Vector2(0,0), 1);

        Assert.IsTrue(circle.Square() == (float)Math.PI);
    }
}