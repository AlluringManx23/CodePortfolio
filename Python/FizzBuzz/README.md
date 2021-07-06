# FizzBuzz
This is simple game where you count from 1 to 100. If the number is divisible by 3 instead of saying the number you say Fizz, if its divisible by 5 you say Buzz and if its divisible by both you say FizzBuzz.
***
### Coding
This program is written in C#. It has 4 functions that can be called FizzBuzz_Worst(), FizzBuzz_Better(), FizzBuzz_Best() and Main().
>These naming conventions arn't ment to be absolute, Only relative to my Methods
___

### FizzBuzz_Worst():
This function is the bare minimum to compleate the task. It uses hard coded values and logic. With no room for expansion unless more else if statments are added, or configuration unless values are changed within all if statments.

```csharp
public static void FizzBuzz_Worst()
{
	string output = "";
	for (int i = 1; i <= 100; i++)
	{
		if (((i % 3) == 0) && ((i % 5) == 0))
		{
	                output = "FizzBuzz";
                }
                else if (((i % 3) == 0) && ((i % 5) != 0))
                {
	                output = "Fizz";
                }
                else if (((i % 3) != 0) && ((i % 5) == 0))
                {
	                output = "Buzz";
                }
                else
                {
	                output = i.ToString();
                }
                Console.WriteLine(output);
	}
	Console.WriteLine("Press Enter To Exit");
        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        {
	        //keep command prompt open
        }
}
``` 
___

### FizzBuzz_Better():
This function is an improvement on the last, I added variables to make configuring the divisible numbers easier and cleanded up the logic so it checks less values each itteration. It was a little quicker to code as i had **FizzBuzz_Worst()** to use as a base, thinking of the most efficient way to do the checks took the most time. Still has no room for expansion unless more if statments are added but this time around only one if statment is added and one condition needs to be added to the last if statment. Configuration is easier though with only the variables at the top needing to be changed.

```csharp
public static void FizzBuzz_Better()
{
	int x = 3;
	int y = 5;
	for (int i = 1; i <= 100; i++)
	{
		output = "";
		if ((i % x) == 0)
	        {
		        output += "Fizz";
	        }
	        if ((i % y) == 0)
	        {
		        output += "Buzz";
	        }
	        if (((i % x) != 0) && ((i % y) != 0))
	        {
		        output = i.ToString();
	        }
	        Console.WriteLine(output);
	}
	Console.WriteLine("Press Enter To Exit");
	while (Console.ReadKey().Key != ConsoleKey.Enter) ;
	{
		//keep command prompt open
        }
}
```
***
### FizzBuzz_Best():
This function is a leap forward in imporvement, Instead of having variables for each number and hard coding the words for each check I consolidated numbers and words into their respective arrays. When a number is generated in the first loop a second nested loop starts creating a second variable that I use to call the index of the numbers array. I then use that index to call the first number in the numbers array, Check that against the first number we generated. If it passes the check it will use the index number to call that same index in the words array and add that onto the output, then increment the number and try again.

This is the easiest one to configure and expand with only 2 arrays needing to be edited, There wasnt a measurable difference in time between writting this and writing **FizzBuzz_Worst()** my first time around.
```csharp
public static string[] words = { "fizz", "buzz" };
public static int[] numbers = { 3, 5 };

public static void FizzBuzz_Best()
{
	for (int i = 1; i <= 100; i++)
        {
		output = "";
		for (int y = 0; y < numbers.Length; y++)
                {
	                if (i % numbers[y] == 0)
	                {
		                output += words[y];
			}
                }
                if (output == "")
                {
	                output = i.ToString();
                }
                Console.WriteLine(output);
	}
        Console.WriteLine("Press Enter To Exit");
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
	        //keep command prompt open
	}
}
```
***
### Main(string[] args):
The supporting code for this project is pretty basic. I wanted the user to be able to test all methods without having to relaunch the application or modify the code. First thing I did to acieve this is create a variable for storing the users choice, Next I made a while loop that always reads true so the user can keep running the program. For neatness then I clear the output of the console. I then write the options the user has to the console and then read the users choice. I clear the console again to remove the options. Then I use a switch statement to determine which option the user has selected, if any. Finally if the user doesn't chose a valid option the program exits with code 0 meaning it has ran successfully.
```csharp
static void Main(string[] args)
{
	string choice = "";
        while (true)
        {
	        Console.Clear();
                Console.WriteLine("Please enter 1 for FizzBuzz with hardcoded values");
                Console.WriteLine("Please enter 2 for FizzBuzz with variables");
                Console.WriteLine("Please enter 3 for FizzBuzz with arrays");
                Console.WriteLine("Please enter anything else to exit the program");

                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
		        case "1":
	                        FizzBuzz_Worst();
	                        break;
	                case "2":
	                        FizzBuzz_Better();
	                        break;
	                case "3":
	                        FizzBuzz_Best();
	                        break;
		        default:
		                System.Environment.Exit(0);
	                        break;
	        }
	}   
}
```
***
**Output:**

>1
2
fizz
4
buzz
fizz
7
8
fizz
buzz
11
fizz
13
14
fizzbuzz
16
17
fizz
19
buzz
fizz
22
23
fizz
buzz
26
fizz
28
29
fizzbuzz
31
32
fizz
34
buzz
fizz
37
38
fizz
buzz
41
fizz
43
44
fizzbuzz
46
47
fizz
49
buzz
fizz
52
53
fizz
buzz
56
fizz
58
59
fizzbuzz
61
62
fizz
64
buzz
fizz
67
68
fizz
buzz
71
fizz
73
74
fizzbuzz
76
77
fizz
79
buzz
fizz
82
83
fizz
buzz
86
fizz
88
89
fizzbuzz
91
92
fizz
94
buzz
fizz
97
98
fizz
buzz
