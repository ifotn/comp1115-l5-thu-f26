// ex 1 while loop - ask a question until user gets right answer
//Console.WriteLine("What is 2 + 2?");

//// store input as whole #
//int answer = int.Parse(Console.ReadLine());

//// ! means NOT
//while (answer != 4)
//{
//    Console.WriteLine("Sorry, try again. Enter another answer.");
//    answer = int.Parse(Console.ReadLine());
//}

//// this only runs once the user has gotten out of the loop by entering the right answer
//Console.WriteLine("Correct");

// ex 2 do-while loop - ensure loop runs at least once
//string choice;

//do
//{
//    // code to repeat
//    Console.WriteLine("Play again (yes/no)?");
//    choice = Console.ReadLine().ToLower();  // convert response to all lowercase
//} while (choice == "yes"); 

// ex 3 - for loop (finite) from 1 to 10, adding 1 each time ++ means add 1 to the current value

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 5) break; // exit at 5
//    Console.WriteLine(i);
//}

//// ex 4 - for loop incrementing by 2
//for (int j = 0; j <=10; j = j + 2)
//{
//    Console.WriteLine(j);
//}


//// ex 5 - for loop that counts down instead of up
//for (int k = 100; k >= 0; k = k - 10)
//{
//    Console.WriteLine(k);
//}

//// ex 6 - countdown
//for (int countdown = 10; countdown >= 1; countdown--)
//{
//    Console.WriteLine(countdown);
//}

//Console.WriteLine("GO!");

// ex 7 - while practice => refactor to repeat until user gets correct answer
Console.WriteLine("Welcome to Lesson 5 Trivia");
Console.WriteLine("How many Bits are in a Byte?");
int answer = int.Parse(Console.ReadLine());

// check answer
while (answer != 8)
{   Console.WriteLine("Incorrect, try again.");
    answer = int.Parse(Console.ReadLine()); 
}

Console.WriteLine("Correct");