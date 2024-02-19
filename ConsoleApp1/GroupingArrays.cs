using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class GroupingArrays
{
    public static int groupingNumbersInAnArray(List<int> arr)
    {
        var groupedNumbers = arr.GroupBy(x => x)
                                .Select(group => new
                                {
                                    Number = group.Key,
                                    Count = group.Count()
                                })
                                .OrderByDescending(x => x.Count);

        return groupedNumbers.First().Number;
    }
}
