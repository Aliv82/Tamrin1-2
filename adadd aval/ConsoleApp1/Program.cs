
// Ali vahedi
// Adadd_Aval project

Console.WriteLine("please insert your first number : ");
int aval_Baze = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please insert your second number : ");
int akhar_Baze = Convert.ToInt32(Console.ReadLine());

for (int i = aval_Baze; i < akhar_Baze; i++)
{
    if (mohasebeh(i) && i>=2)
    {
        Console.WriteLine(i);
    }
}

static bool mohasebeh(int number)
{
    for (int j = 2; j < number; j++)
    {
        if (number % j == 0 && number != j)
        {
            return false;
        }

    }
    return true;
}
Console.ReadKey();











