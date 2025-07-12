// using System.Diagnostics;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.Numerics;
// using System.Runtime.ConstrainedExecution;
// using System.Runtime.Intrinsics.X86;
// using System.Security.Cryptography;

// namespace MyAppNamespace;

// internal class Program
// {
//     private static void Main()
//     {

// Console.WriteLine("Enter a number N:");
// int num=Convert.ToInt32(Console.ReadLine());
// Console.Write("Even numbers:");
// for(int i =2;i<=num;i=i+2)
// {
//     if(i % 2 ==0)
//     {
//         Console.Write(i);

//     }
//     if(i<num)
//     {
//         Console.Write(",");
//     }

// }



// Console.WriteLine("Enter a number N:");
// int num=Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=10;i=i+1)
// {
// Console.Write($"{num} * {i} = {num*i}");
// }




//    int sum=0;
//    for(int i=1;i<=num;i=i+1)
//    {
//    sum=sum+i;
//    }
//    Console.Write($"The sum of first {num} natural nConsole.WriteLine("Enter a number N:");
//    int num=Convert.ToInt32(Console.ReadLine()); umber is {sum}");



//     Console.WriteLine("Enter a number:");
//    int num=Convert.ToInt32(Console.ReadLine()); 
//     int factorial = 1;
//     for(int i =1;i<=num;i=i+1)
//     {
//         factorial = factorial*i;
//     }
//    Console.Write($"Factorial of {num} is {factorial}");




//      Console.WriteLine("Enter the number of terms:");
//      int num=Convert.ToInt32(Console.ReadLine()); 
//      Console.WriteLine("Fibonacci series:");
//      int firstNum=0;
//      int secondNum=1;
//      Console.Write(firstNum);
//     for(int i=1;i<num;i=i+1)
//     {

//           Console.Write(", " + secondNum);
//         int next = firstNum+secondNum;
//         firstNum=secondNum;
//         secondNum=next;

//     }
//   Console.WriteLine();






// Console.WriteLine("Enter a number N:");
// int num=Convert.ToInt32(Console.ReadLine());
// for(int i=num;i>=1;i=i-1)
// {
//     Console.Write(i);
//     if(i>1)
//     {
//      Console.Write(",");
//     }
// }




// Console.WriteLine("Enter a number:");
// int num=Convert.ToInt32(Console.ReadLine());
// bool isPrime = true;
// for(int i=2;i<num;i=i+1)
// {
//     if(num%i==0)
//     {
//         isPrime=false;
//         break;
//     }
// }
// if(isPrime && num>1)
// {
//     Console.WriteLine($"{num} is a prime number");
// }
// else{
//     Console.WriteLine($"{num} is not a prime number");
// }




// Console.WriteLine("Enter a number N:");
// int number=Convert.ToInt32(Console.ReadLine());
// Console.Write("Fibonacci series:");
// int first=0;
// int second=1;
// Console.Write(first);
// for(int i=1;i<number;i=i+1)
// {
//     Console.Write("," + second);
//     int next=first+second;

//      first=second;
//      second=next;

// }




// Console.WriteLine("Enter a number N:");
//  int number=Convert.ToInt32(Console.ReadLine());
//  for(int i=number;i>=1;i=i-1)
//  {
//    Console.Write(i);
//    if(i>1)
//    {
//     Console.Write(",");
//    }
//  }




// Console.WriteLine("Enter a number:");
//  int number=Convert.ToInt32(Console.ReadLine());
// bool isPrime=true;
// for(int i=2;i<number;i=i+1)
// {
//     if(number % i==0)
//     {
//         isPrime=false;
//         break;
//     }
// }
// if(isPrime && number >1)
// {
//     Console.WriteLine($"{number} is a prime number.");
// }
// else
// {
//     Console.WriteLine($"{number} is not a prime number.");
// 



// Console.WriteLine("Enter a number:");
//  int num=Convert.ToInt32(Console.ReadLine());
//  int i=1;
//  while(i<=num)
//  {
//     Console.Write(i);
//     if(i<num)
//     {
//         Console.Write(",");
//     }
//     i=i+1;
//  }




// Random rand = new Random();
// int correctNum =rand.Next(1,11);
// int guessNum=0;
// Console.WriteLine("Guess the number (between 1-10):");
// while(guessNum!=correctNum)
// {
//     guessNum =Convert.ToInt32(Console.ReadLine());
//     if(guessNum>correctNum)
//     {
//         Console.WriteLine("Too high, try again.");
//     }
//     else if(guessNum<correctNum)
//     {
//         Console.WriteLine("Too low, try again.");
//     }
// }
// Console.WriteLine($"Correct! The number is {correctNum}.");




// int sum =0;
// int num =0;
// while(num!=-1)
// {
//    Console.WriteLine(" Enter a number (-1 to stop):");
//    num=Convert.ToInt32(Console.ReadLine());
//    if(num!=-1)
//    {
//     sum=sum+num;
//    }
// }
// Console.WriteLine($"The total sum is {sum}");



// Random rand = new Random();
// int position=0;
// Console.WriteLine($"Current position:{position}");
// while(position!=10 && position!=-10)
// {
//     if(rand.Next(2)==0)
//     {
//         position++;
//          Console.WriteLine($"Move up! Current position:{position}");
//     }
//     else
//     {
//         position--;
//         Console.WriteLine($"Move down! Current position:{position}");
//     }
// }
// if(position==10)
// {
//     Console.WriteLine("Reached position 10! Stopping");
// }
// else
// {
//     Console.WriteLine("Reached position -10! Stopping");

// }



// Console.WriteLine("Enter a number");
// int num=Convert.ToInt32(Console.ReadLine());
// int orginalnum=num;
// int reversenum=0;
// while(num>0)
// {
//     int digit=num%10;
//     reversenum=reversenum*10+digit;
//     num=num/10;
// }
// if(reversenum==orginalnum)
// {
//     Console.WriteLine($"{reversenum} is a palindrome");
// }
// else{
//      Console.WriteLine($"{reversenum} is not a palindrome");
// }



// string correctpin="1234";
// int attempt=0;
// Console.WriteLine("Enter pin:");
// while(attempt<3)
// {
//     string input=Console.ReadLine();
//     if(input==correctpin)
//     {
//          Console.WriteLine("Correct pin.Access granted");
//          break;
//     }
//     else
//     {
//         attempt=attempt+1;
//          Console.WriteLine("Incorrect PIN. Try again");
//     }
// }
// if(attempt==3)
// {
//     Console.WriteLine("Account locked after 3 failed attempts");
// }





// int balance=0;
// string commands="";
// Console.WriteLine("Enter Commands:[ADD, WITHDRAW, CHECK, STOP]");


// while(commands!="STOP")


// {

//          commands=Console.ReadLine();

//     if(commands=="ADD")
//     {

//         int amount = Convert.ToInt32(Console.ReadLine());
//         balance=balance + amount;
//         Console.WriteLine($"Current balance is {balance}");
//     }
//     else if(commands=="WITHDRAW")
//     {
//         int amount = Convert.ToInt32(Console.ReadLine());
//         balance=balance-amount;
//         Console.WriteLine($"Current balance is {balance}");

//     }
//     else if(commands=="CHECK")
//     {
//          Console.WriteLine($"Current balance is {balance}");
//     }
//     else if(commands=="STOP")
//     {
//          Console.WriteLine($"Good Bye");
//     }
//     else
//     {
//          Console.WriteLine("Invalid commend");
//     }
// }




//arrays

// Console.WriteLine("Enter the number of elements: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[] num=new int[size];
// int sum=0;
// for(int i=0;i<size;i=i+1)
// {
//     Console.WriteLine($"Enter element{i}");
//     num[i]=Convert.ToInt32(Console.ReadLine());
//     sum=sum+num[i];
// }
// Console.WriteLine($"Sum of all elements:{sum}");




// Console.WriteLine("Enter the number of elements: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[]num=new int[size];
// int evennum=0;
// int oddnum=0;
// for(int i=0;i<size;i=i+1)
// {
//     Console.WriteLine($"Enter element {i}");
//     num[i]=Convert.ToInt32(Console.ReadLine());
//     if(num[i] % 2==0)
//     {
//         evennum=evennum+1;
//     }
//     else
//     {
//         oddnum=oddnum+1;
//     }
// }
// Console.WriteLine($"Even number :{evennum}");
// Console.WriteLine($"Odd number :{oddnum}");




// Console.WriteLine("Enter the number of elements: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[]num=new int[size];
// for(int i=0;i<size;i=i+1)
// {
//     Console.WriteLine($"Enter element {i}");
//     num[i]=Convert.ToInt32(Console.ReadLine());

// }
// Console.Write("Reversed array:");
// for(int i=size-1;i>=0;i=i-1)
// {

//     Console.Write(num[i]);
//      if(i!=0)
//     {
//         Console.Write(",");
//     }

// }



// Console.WriteLine("Enter a string:");
// string input=Console.ReadLine();
// char[] array=input.ToCharArray();
// Array.Reverse(array);
// string reversed=new string(array);
// Console.WriteLine($"Reversed string:{reversed}");





// Console.WriteLine("Enter a sentence: ");
// string input=Console.ReadLine();
// string[] words=input.Split(' ');
// string longestword="";
// foreach(string word in words)
// {
//     if(word.Length>=longestword.Length)
//     {
//         longestword=word;
//     }
// }
// Console.WriteLine($"Longest word :{longestword}");


// Console.WriteLine("Enter number of rows:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of clms:");
// int clms=Convert.ToInt32(Console.ReadLine());
// char[,]grid=new char[rows,clms];
// for(int i=0;i<rows;i=i+1)
// {
//     for(int j=0;j<clms;j=j+1)
//     {
//       Console.WriteLine($"Enter character at [{i},{j}]:");
//       grid[i,j]=Convert.ToChar(Console.ReadLine());
//     }
// }
// Console.WriteLine("Character Grid :");
// for(int i=0;i<rows;i=i+1)
// {
//  for(int j=0;j<clms;j=j+1)
//  {
//     Console.Write(grid[i,j]+" ");
//  }
//  Console.WriteLine();
// }


// Console.WriteLine("Enter number of students: ");
// int students=Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Enter number of subjects: ");
// int subjects=Convert.ToInt16(Console.ReadLine());
// int[,]grade=new int[students,subjects];
// for(int i=0;i<students;i=i+1)
// {
//     for(int j=0;j<subjects;j=j+1)
//     {
//      Console.WriteLine($"Enter grade for Student {i}, Subject {j}: ");
//      grade[i,j]=Convert.ToInt32(Console.ReadLine());

//     }
// }
// Console.WriteLine("Gradebook:");
// for(int i=0;i<students;i=i+1)
// {
//     int sum=0;
//     for(int j=0;j<subjects;j=j+1)
// {
// sum=sum+grade[i,j];
// }
// double average=(double)sum/subjects;
// Console.WriteLine($"Student{i},average:{average}");
// }


// int[][] temperatures = {
//     new int[] {3, 5, 7},      // January
//     new int[] {1, 4},      // February
//     new int[] {6, 10, 12},    // March
//     new int[] {9, 14, 15},    // April
//     new int[] {12, 18, 20},   // May
//     new int[] {15, 22, 25},   // June
//     new int[] {18, 25, 30},   // July
//     new int[] {17, 23, 28},   // August
//     new int[] {13, 19, 24, 40},   // September
//     new int[] {9, 14, 18},    // October
//     new int[] {5, 10, 12},    // November
//     new int[] {2, 6, 9}       // December
// }; 
// string[]months={"January","February","March","April","May","June","July","August","September","October","November","December"};
// Console.WriteLine("Average Temperatures:");
// for(int i=0;i<temperatures.Length;i=i+1)
// {
//     int sum=0;
//     for(int j=0;j<temperatures[i].Length;j=j+1)
//     {
//         sum=sum+temperatures[i][j];
//     }
//     double average=(double)sum/temperatures[i].Length;
// Console.WriteLine($"{months[i]}:{average:F1}");
// }



// Console.WriteLine(" Enter the number of elements: ");
// int size=Convert.ToInt32(Console.ReadLine());
// int[]num=new int[size];
// int evennum=0;
// int oddnum=0;
// for(int i=0;i<size;i=i+1)
// {
//    Console.WriteLine($" Enter element {i}: ");
//    num[i]=Convert.ToInt32(Console.ReadLine());
//    if(num[i]%2==0)
//    {
//     evennum=evennum+1;
//    }
//    else
//    {
//     oddnum=oddnum+1;
//    }
// }
// Console.WriteLine($" Even numbers: {evennum}");
// Console.WriteLine($" Odd numbers: {oddnum}");


//  Console.WriteLine("Enter a sentence:");
//  string input=Console.ReadLine();
//  string[] word =input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"Number of words:{word.Length}");


// Console.WriteLine("Enter number of students:");
// int students=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of subjects:");
// int subjects=Convert.ToInt32(Console.ReadLine());
// int[,] grade=new int[students,subjects];
// for(int i=0;i<students;i=i+1)
// {
//     for(int j=0;j<subjects;j=j+1)
//     {
//         Console.WriteLine($" Enter grade for Student{i},subject{j}");
//         grade[i,j]=Convert.ToInt32(Console.ReadLine());
//     }
// }
//         Console.WriteLine("Gradebook:");
//         for(int i=0;i<students;i=i+1)
// {
//     int sum=0;
//     for(int j=0;j<subjects;j=j+1)
//     {
//         sum=sum+grade[i,j];


//     }
//     double average=(double)sum/subjects;
//         Console.WriteLine($" Student{i} average:{average}");
// }




// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             string[] lines = File.ReadAllLines(fileName);
//             int lineCount = lines.Length;

//             Console.WriteLine($"Total lines: {lineCount}");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }

// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             string[] lines = File.ReadAllLines(fileName);
//             int lineCount = lines.Length;

//             Console.WriteLine($"Total lines: {lineCount}");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }






// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             string content = File.ReadAllText(fileName);
//             int charCount = content.Length;
//             Console.WriteLine($"Total characters: {charCount}");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }



// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             Console.WriteLine("Enter word to search:");
//             string searchWord = Console.ReadLine().ToLower();

//             string text = File.ReadAllText(fileName).ToLower();
//            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?', ';', ':', '-', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
//             int count = 0;
//             foreach (string word in words)
//             {
//                 if (word == searchWord)
//                 {
//                     count++;
//                 }
//             }

//             Console.WriteLine($"Word found {count} times");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }



// using System;
// using System.IO;
// using System.Linq.Expressions;
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();
//             Console.WriteLine("Enter word to search:");
//             string searchWord = Console.ReadLine().ToLower();
//             string text = File.ReadAllText(fileName).ToLower();
//             string[] words = text.Split(new char[] { ' ', '\n', '\t', '\r', '-', '.', ',', '?', '!', ';', ':', '\'', '\"', }, StringSplitOptions.RemoveEmptyEntries
//     );
//             int count = 0;
//             foreach (String word in words)
//             {
//                 if (word == searchWord)
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine($"Word found {count} times");
//         }
//         catch (FileNotFoundException)



//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }



// using System;
// using System.IO;
// class Programm
// {
//     static void Main()
//     {
//         try

//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();
//             string content = File.ReadAllText(fileName);
//             int count = content.Length;
//             Console.WriteLine($"Total characters: {count}");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//              Console.WriteLine("crazy input");
//         }
//     }
// }


// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             Console.WriteLine("Enter text to append:");
//             string textToAdd = Console.ReadLine();

//             File.AppendAllText(fileName, textToAdd + Environment.NewLine);

//             Console.WriteLine("Text added successfully.");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("crazy input");
//         }
//     }
// }


// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();
//             Console.WriteLine("Enter text to append:");
//             string text = Console.ReadLine();
//             File.AppendAllText(fileName, text + Environment.NewLine);
//             Console.WriteLine("Text added successfully.");
//         }
//         catch (FileNotFoundException)
//         {
//            Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Crazy Input");
//         }
//     }
// }



// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         try

//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();
//             Console.WriteLine("Enter word to replace:");
//             string oldWord = Console.ReadLine();
//             Console.WriteLine("Enter new word:");
//             string newWord = Console.ReadLine();
//             string content = File.ReadAllText(fileName);
//             string newContent = content.Replace(oldWord, newWord);
//             string newfileName = Path.GetFileNameWithoutExtension(fileName) + "_edited" + Path.GetExtension(fileName);
//             File.WriteAllText(newfileName, newContent);
//             System.Console.WriteLine($"File saved as {newfileName}");
//         }
//         catch (FileNotFoundException)
//         {
//             System.Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             System.Console.WriteLine("crazy output");
//         }
//     }
// }


// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter filename:");
//             string fileName = Console.ReadLine();

//             string content = File.ReadAllText(fileName);

//             // Split by basic whitespace
//             string[] tokens = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

//             int wordCount = 0;

//             foreach (string token in tokens)
//             {
//                 // Trim common punctuation from start/end of each word
//                 string word = token.Trim(',', '.', ';', ':', '!', '?', '"', '\'', '(', ')');

//                 // Only count if it's still a valid word
//                 if (!string.IsNullOrWhiteSpace(word))
//                 {
//                     wordCount++;
//                 }
//             }

//             Console.WriteLine("Total words: " + wordCount);
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("file not found");
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Crazy Input");
//         }
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("What is your favorite color? ");
//         string colorName = Console.ReadLine();
//         Console.WriteLine($"Wow! Blue is a great color.");
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the first word:");
//         string firstV = Console.ReadLine();
//         Console.WriteLine("Enter the second word: ");
//         string secondV = Console.ReadLine();

//         firstV = firstV.ToUpper();
//         secondV = secondV.ToUpper();
//         Console.WriteLine($"{firstV} {secondV}");
//     }
// }()

// using System;
// class Program
// {
//     static void Main()/
//     {
//         Console.WriteLine("Enter your name:");
//         string name = Console.ReadLine();
//         Console.WriteLine("Enter your age: ");
//         int age = Convert.ToInt32(Console.ReadLine());
//         int ageSum = age + 10;
//         Console.WriteLine($"Hello {name},in 10 years you will be {ageSum} years old");
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the first number:");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter the second number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         int sum = num1 + num2;
//         Console.WriteLine($"The sum is:{sum}");
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter temperature in Celsius:");
//         double celsius = Convert.ToDouble(Console.ReadLine());
//         double farenhite = (celsius * 9 / 5) + 32;
//         Console.WriteLine($"{celsius}°C is equal to {farenhite}°F.");

//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a character:");
//         string input = Console.ReadLine();
//         char character = input[0];
//         int asciValue = (int)character;
//         Console.WriteLine($"The ASCII value of {input} is {asciValue}");
//     }
// } 

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter your weight (kg):");
//         double weight = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter your height (m): ");
//         double height = Convert.ToDouble(Console.ReadLine());
//         double bmi = weight / (height * height);
//         bmi = Math.Round(bmi, 2);
//         Console.WriteLine($"Your BMI is {bmi}");
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the base number: ");
//         double baseNum = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Enter the exponent: ");
//         double exponentNum = Convert.ToDouble(Console.ReadLine());
//         double result = Math.Pow(baseNum, exponentNum);
//         Console.WriteLine($"The result is {result}");
//     }
// }


// using System;
// class Program
// {
//     static void Main()
//     {

//         Console.WriteLine("Enter a number:");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num % 2 == 0)
//         {
//             Console.WriteLine($"{num} is an even number");
//         }
//         else
//         {
//             Console.WriteLine($"{num} is an odd number");
//         }
//     }
// }



// using System;
// class Program
// {
//     static void Main()
//     {
        
//     }
// }

using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base number:");
        int baseNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the exponent: ");
        int exponentNum = Convert.ToInt32(Console.ReadLine());
        double result = Math.Pow(baseNum, exponentNum);
        Console.WriteLine($"The result is {result}");
    }
}





















































































































































































 
    




     
     


