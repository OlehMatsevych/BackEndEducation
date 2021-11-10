using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// expected = "Oleh is name My"
/// </summary>
/// 
StringBuilder str = new StringBuilder("My   name is Oleh");


Console.WriteLine("Version 1:");
Console.WriteLine(version1(str));

Console.WriteLine("Version 2:");
Console.WriteLine(version2(str));

return 0;

string version1(StringBuilder test)
{
    for (int i = 0, j = test.Length - 1; i < test.Length / 2 && j > 0; i++, j--)
    {
        int started_i = i, started_j = j;
        while (test[i] != ' ')
        {
            i++;
        }
        while (test[j] != ' ')
        {
            j--;
        }
        int first_lendth = i - started_i;
        int second_lendth = started_j - j;
        int biggest = first_lendth > second_lendth ? first_lendth : second_lendth;

        int tempi = first_lendth, temj = second_lendth;
        if (tempi > temj)
        {
            while (tempi > temj)
            {
                test.Insert(j + 1, ' ');
                temj++;
                i++;
                j--;
            }
        }
        else if (tempi < temj)
        {
            while (tempi < temj)
            {
                test.Insert(i + 1, ' ');
                tempi++;
                started_j++;
                i++;
                j++;
            }
        }
        int e = 0;
        while (biggest > 0)
        {
            char temp = test[started_i + e];
            test[started_i + e] = test[started_j - second_lendth + e + 1];
            test[started_j - second_lendth + e + 1] = temp;
            biggest--;
            e++;
        }

    }
    return Regex.Replace(test.ToString(), @"\s+", " ");
}

string version2(StringBuilder test)
{
    StringBuilder builder = new StringBuilder();
    string[] arr = test.ToString().Split(' ');
    arr = arr.Where(i => !string.IsNullOrWhiteSpace(i)).ToArray();

    for (int i = 0; i < arr.Length / 2; i++)
    {
        var temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    foreach (var item in arr)
    {
        builder.Append(item + " ");
    }
    return builder.ToString();
}