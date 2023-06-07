Console.WriteLine("CALCULATOR");
Console.WriteLine("Enter First Number : ");
string firstNumber = Console.ReadLine();
int firstNumberConvert = int.Parse(firstNumber);
Console.WriteLine("Enter Second Number : ");
string secondNumber = Console.ReadLine();
int secondNumberConvert = int.Parse(secondNumber);
Console.WriteLine("What Do You Want To Do ?");
Console.WriteLine("[A]dd Number.");
Console.WriteLine("[S]ubtract Number.");
Console.WriteLine("[M]ultiply Number.");
string userChoice = Console.ReadLine();
if (userChoice == "A" || userChoice == "a")
{
    Console.WriteLine(firstNumberConvert + " + " + secondNumberConvert + " = " + addNumber(firstNumberConvert, secondNumberConvert));
}
else if (userChoice == "S" || userChoice == "s")
{
    Console.WriteLine(firstNumberConvert + " - " + secondNumberConvert + " = " + subtractNumber(firstNumberConvert, secondNumberConvert));
}
else if (userChoice == "M" || userChoice == "m")
{
    Console.WriteLine(firstNumberConvert + " * " + secondNumberConvert + " = " + multipltNumber(firstNumberConvert, secondNumberConvert));
}
else
{
    Console.WriteLine("Invalid!");
}

//Mathemetical Function 
int addNumber(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
int subtractNumber(int firstNumber, int secondNumber)
{
    return secondNumber - firstNumber;
}
int multipltNumber(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}
Console.ReadKey();

