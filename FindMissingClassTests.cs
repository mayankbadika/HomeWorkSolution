using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FindMissingClassTests : FindMissingClass
{
    [TestMethod]
    public void FindMissingTest1()
    {
        IEnumerable<int> actual = FindMissing(new List<int> { 7, 3 });

        IEnumerable<int> expected = new List<int> { 4, 5, 6, 8, 9 };

        Assert.IsTrue(Enumerable.SequenceEqual(actual, expected));
    }

    [TestMethod]
    public void FindMissingTest2()
    {
        IEnumerable<int> actual = FindMissing(new List<int> { 1, 5 });

        IEnumerable<int> expected = new List<int> { 2, 3, 4 };

        Assert.IsTrue(Enumerable.SequenceEqual(actual, expected));
    }

    [TestMethod]
    public void FindMissingTest3()
    {
        IEnumerable<int> actual = FindMissing(new List<int> { -5, -3, -2, -1, 0, 2, 3, 5, 6, 7, 8, 10 });

        IEnumerable<int> expected = new List<int> { -4, 1, 4 };

        Assert.IsTrue(Enumerable.SequenceEqual(actual, expected));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void FindMissingTest4()
    {
        IEnumerable<int> actual = FindMissing(null);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void FindMissingTest5()
    {
        IEnumerable<int> actual = FindMissing(new List<int>{});
    }
}