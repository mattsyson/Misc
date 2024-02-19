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


class MatrixResult
{
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count / 2;
        int maxSum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Select the maximum value among the symmetric elements
                int maxValue = Math.Max(matrix[i][j], Math.Max(matrix[2 * n - 1 - i][j], Math.Max(matrix[i][2 * n - 1 - j], matrix[2 * n - 1 - i][2 * n - 1 - j])));
                maxSum += maxValue;
            }
        }

        return maxSum;
    }
}
