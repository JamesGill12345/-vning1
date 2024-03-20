
//övning 1 skrev bara fel


// punkt 1
using System.Runtime.CompilerServices;

if (6>=3)
{
    Console.WriteLine("Hello World");
}

// punkt 2 och 3

string username = Console.ReadLine(); 
string password = Console.ReadLine();
if (username == "noname" && password == "nopass")
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong username or password");
}

// punkt 4
int count;
count = 0;

while (count < 32)
{
    Console.WriteLine("Hello, World");
    count ++;
}

//punkt 5

string passcorr;
string passtry;
passcorr = "Pass";
passtry = Console.ReadLine();
while (passcorr != passtry)
{
    Console.WriteLine("Wrong Password, try again");
    passtry = Console.ReadLine();
}
    
// punkt 6


int run;
run = 0;

while (run < 5)
{
    run ++;
    string numberinput;
    numberinput = Console.ReadLine();
    int numberinputint;
    int.TryParse(numberinput, out numberinputint);
    if (numberinputint > 5)
    {
        Console.WriteLine("Högre än 5!");
    }
}


// punkt 7
string input;
input = Console.ReadLine();
int output;
int.TryParse(input, out output);
if(output >0  || output > 999)
{

}
else
{
    Console.WriteLine("loop");
}

// slutövning

Console.WriteLine("gissa på ett tal mellan 1 och 10");

Random randomnumber = new Random();
int correctnumber = randomnumber.Next(1,11);

Start:
string numberguess;
numberguess = Console.ReadLine();

int numberguessA;
int.TryParse(numberguess, out numberguessA);

if (numberguessA == correctnumber)
{
    Console.WriteLine("Grattis du hade rätt");
}
else if(numberguessA < correctnumber)
{
    Console.WriteLine("du gissade för lågt, försök igen");
    goto Start;
}
else if(numberguessA > correctnumber)
{
    Console.WriteLine("du gissade för högt, försök igen");
    goto Start;
}
else
{
    Console.WriteLine("det funkade inte, testa att skriva in ett tal");
    goto Start;
}