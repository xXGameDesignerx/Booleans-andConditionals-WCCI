// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//variable declaration
int num;
//variable assignment
num = 3;
//variable declaration and assignment
int num2 = 2;
string str = "Hello" + ", World!";

num = num + 1;
num += 1;

num = num * 2;
num *= 2;

num = num / 2;
num /= 2;

num = num - 2;
num -= 2;

num++;
num--;

Console.WriteLine(num);
string input = Console.ReadLine();
int num3 = Int32.Parse(input);


// int input2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(num3);
input = Console.ReadLine();



//booleans
// ture or false statements
bool isSunny = true;
bool isCold = true;


// AND - &&
// hand us true if BOTH the value on the left and right of the && are true, false otherwise
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false
// true && (false && true) -> false
bool goOutside = isSunny && isCold;

// OR - ||
// hnad us true if either value on the left or right of the || are true, false otherwise
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false
// (true || false) || false -> true
bool mowTheLawn = isSunny || isCold;

// NOT - !
// hands us true if ther boolean after is false, and hands us false if the boolean after is true
//this does not reassign the value
// !true -> false
// !false -> true
// !(true || false) && true -> false
// !true) && true
// false && true
//      false
bool isRainy = !isSunny;


// Conditionals - if/else
// if something is true, preform an action. If the condition are all false, preform another action instead
// if(condition){
//  code we run if conditions is true
// }

// else if (condition){
// code we run if condition is true
// }
 // copying if multiple else if statements
// else {
//  code we run if previous condition are false
// }
isRainy = true;
isSunny = true;
if(isRainy)
{
    Console.WriteLine("Wow, it sure is rainy, today!");
}
else if (isSunny)
{
    Console.WriteLine("Don't look at the sun!");
}
else
{
    Console.WriteLine("There are some clouds in the sky!");
}

// comparison Operators
// Equivalence Operator - ==
// Hands you a value of true if the left and right values are equivalent (equal)
// 5 == 5 -> true
// 13 == 5 -> false
if (num == 3)
{
    Console.WriteLine("our number is 3!");
}
// == equivalance op (return true if two things are equal
// Inequality Operator = !=
// Hands you a value of true if the left and right values are NOT equivalent (not equal)
// 5 != 5-> false
// 13 != 5-> true
// a != b is the same as !(a == b)
if (num2 != 17)
{
    Console.WriteLine("Num2 is not equal to 17!");
}
// != (returns true if two things are not equal)

// Comparison Operators - ( > , > , >= , <= )
// a > b hands yopu a value of true if a is greater than b
// a < b hands yopu a value of true if a is less than b
// a >= b hands yopu a value of true if a is greater than OR EQUAL to b
// a <= b hands yopu a value of true if a is less than OR EQUAL to b

// user input example
Console.WriteLine("Is today your birthday? Y/N");
string conInput = Console.ReadLine();
conInput = conInput.ToUpper();
if(conInput == "Y")
{
    Console.WriteLine("Happy birthday!");
}
else if (conInput == "N")
{
    Console.WriteLine("Maybe tomorrow!");
}
else
{
    Console.WriteLine("Maybe did not know");
}
