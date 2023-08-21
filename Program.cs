int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SortingDigits(int num)
{
    int right = 0;
    int left = 0;
    int evens = 0;
    int odds = 0;
    while (num != 0)
    {
        int digit = num % 10;
        if (num % 2 == 0)
        {
            evens += digit * (int)Math.Pow(10, right);
            right++;
        }
        else
        {
            odds += digit * (int)Math.Pow(10, left);;
            left++;
        }
        num /= 10;
    }
    int res = odds * (int)Math.Pow(10, right) + evens;
    return res;
}

int num = InputNum("Введите число: ");
System.Console.WriteLine(SortingDigits(num));