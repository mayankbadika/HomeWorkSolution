using System;
using System.Collections.Generic;
using System.Linq;

public class FindMissingClass
{
    public IEnumerable<int> FindMissing(IEnumerable<int> numbers)
    {
        if (numbers == null || numbers.GetEnumerator().MoveNext() == false)
        {
            throw new ArgumentNullException(nameof(numbers));
        }
    
        var list = new List<int>();
        var orderedNumbers = numbers.OrderBy(n => n);
        var max = orderedNumbers.Max();
        var min = orderedNumbers.Min();
        var allNumbers = Enumerable.Range(min, max);
        foreach (var number in allNumbers)
        {
            if (!orderedNumbers.Any(n => n == number))
            {
                list.Add(number);
            }
        }
        return list;
    }
}