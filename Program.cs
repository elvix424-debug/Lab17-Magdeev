int[] scores = { 60, 80, 40, 80, 90 };



// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }

// Console.WriteLine(SumArray(new int[]{ 5, -2, 7 }));



// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count += 1;
//         }
//     }

//     return count;
// }

// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));



int FindMax(int[] scores)
{
    int max = scores[0];

    for (int i = 1; i < scores.Length; i++)
    {
        if (scores[i] > max)
        {
            max = scores[i];
        }
    }

    return max;
}


int FindMin(int[] numbers)
{
    int min = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}

Console.WriteLine(FindMin(new int[] { 12, 4, 9 ,1}));
Console.WriteLine(FindMax(scores));
