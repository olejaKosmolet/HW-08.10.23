Console.Clear();
int[] MakeArray1()
{
    Console.WriteLine("Введите числа через пробел: ");
    int[] number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    return number;
}

void MakeCount1(int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}


MakeCount1(MakeArray1());

