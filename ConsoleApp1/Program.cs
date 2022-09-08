// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

int[] Array = { -2, 11, -4, 13, -5, 2 };

int MSCC(int[] Array)
{
    int Max = 0;
    int sum = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = i; j < Array.Length; j++)
        {
            int thisSum = 0;
            for (int k = i; k <= j; k++)
            {
                thisSum += Array[k];
            }

            if (thisSum > Max)
            {
                Max = thisSum;
            }
        }
    }

    return Max;
}

Console.WriteLine(MSCC(Array));
