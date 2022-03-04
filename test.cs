private static void WriteOutJson(string rawString)
{​
            rawString = rawString.Replace("\"", ""); //remove quotes
    rawString = rawString.Replace("{​​​", "");
    rawString = rawString.Replace("}​​​", "");
    //break each element into a new row
    var split1 = rawString.Split(',');
    foreach (var row in split1)
    {​​​
        //break each property and separate the two into defined columns
        var split2 = row.Split(':');
        Console.WriteLine($"{​​​split2[0],-20}​​​ {​​​split2[1]}​​​");
    }​​​
        Console.WriteLine();//skip a line after printing
}​​​