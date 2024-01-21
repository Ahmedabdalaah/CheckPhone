// See https://aka.ms/new-console-template for more information
using CheckPhone;
CheckP phone = new CheckP();
Console.WriteLine("Enter phone number");
string input = Console.ReadLine();
try
{
    bool res = phone.checkL(input);
    bool result = phone.check(input);
    if (res==true)
    {
        if (result == true)
        {
            Console.WriteLine("coreect number");
        }
        else 
        {
            Console.WriteLine("incorrect number");
        }
    }
    else if(res==false)
    {
        Console.WriteLine("incorrect number");
    }
    else
    {
        Console.WriteLine("incorrect number");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}