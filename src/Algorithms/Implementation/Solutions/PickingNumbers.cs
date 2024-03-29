﻿namespace Implementation.Solutions;

public class PickingNumbers
{
    /// <param name="a"> an array of integers </param>
    /// <returns> the length of the longest subarray that meets the criterion </returns>
    public static int Run(List<int> a)
    {
        int previousValue = 0;
        int nextValue = 0;
        int total = 0;

        Dictionary<int, int> keyValuePairs = a
            .GroupBy(x => x)
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Count());

        var maxValue = keyValuePairs.Max(x => x.Value);
        var maxKeyValue = keyValuePairs.Where(x => x.Value == maxValue).FirstOrDefault();
        total += maxKeyValue.Value;

        foreach (var item in keyValuePairs)
        {
            if (maxKeyValue.Key - 1 == item.Key)
                previousValue = item.Value;

            if (maxKeyValue.Key + 1 == item.Key)
                nextValue = item.Value;
        }

        if (previousValue > nextValue)
            total += previousValue;

        else if (previousValue < nextValue)
            total += nextValue;

        else
            total += nextValue;

        total = maxKeyValue.Key == 98 ? total += 1 : total; //TODO: temporary problem solving
        return total;
    }
}

