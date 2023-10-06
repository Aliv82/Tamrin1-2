//Ali Vahedi
//Mirror_Number
Console.WriteLine("please insert your first number : ");
int firstnumber = int.Parse(Console.ReadLine());

Console.WriteLine("please insert your second number : ");
int secondnumber = int.Parse(Console.ReadLine());

for (int i = firstnumber; i <= secondnumber; i++)
{
    if (i.ToString().Equals(Reverse(i.ToString())) && 11 <= i)
        Console.WriteLine(i);

}
Console.ReadLine();

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}