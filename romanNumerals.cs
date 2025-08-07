using System;

int main()
{
    string letters = "XXXIX";
    int number = romanNumerals(letters);
    Console.WriteLine(number);    
}


int romanNumerals(string roman)
{
    int sum = 0;

    for (int i = 0; i < roman.length(); i++)
    {
        char c = roman[i];
        int add = 0;
        switch (c)
        {
            case 'I': add = 1; break;
            case 'V': add = 5; break;
            case 'X': add = 10; break;
            case 'L': add = 50; break;
            case 'C': add = 100; break;
            case 'D': add = 500; break;
            case 'M': add = 1000; break;
        }

        int next = 0;
        if (i + 1 != roman.length())
        {
            switch (roman[i + 1])
            {
                case 'I': next = 1; break;
                case 'V': next = 5; break;
                case 'X': next = 10; break;
                case 'L': next = 50; break;
                case 'C': next = 100; break;
                case 'D': next = 500; break;
                case 'M': next = 1000; break;
            }

            if (add < next)
            {
                add *= -1;
            }
        }
        sum += add;
    }
    return sum;
}