//
// /*namespace CSharpBasics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Hey!");
//             Console.WriteLine("Hello!");
//
//             //This is a comment
//             /*
//              * this
//              * is
//              * a
//              * multiline
//              * comment
//              */
//
//             Console.WriteLine("\tBro\nCode");
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             int x; // declaration
//             x = 123; // initialization
//
//             int y = 321; // declaration + initialization
//
//             int z = x + y;
//
//             int age = 21; // whole integer
//             double height = 300.5; // decimal number
//             bool alive = false; // true or false
//             char symbol = '@'; // single character
//             string name = "Bro"; // a series of characters
//
//             Console.WriteLine("Hello " + name);
//             Console.WriteLine("Your age is " + age);
//             Console.WriteLine("Your height is " + height + "cm");
//             Console.WriteLine("Are you alive? " + alive);
//             Console.WriteLine("Your symbol is: " + symbol);
//
//             string userName = symbol + name;
//
//             Console.WriteLine("Your username is: " + userName);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // constants  = immutable values which are known at compile time
//             //                        and do not change for the life of the program
//
//             const double pi = 3.14;
//
//             //pi = 420; //can't change this constant
//
//             Console.WriteLine(pi);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//             // type casting = Converting a value to a different data type
//             //                Useful when we accept user input (string)
//             //                Different data types can do different things
//
//             double a = 3.14;
//             int b = Convert.ToInt32(a);
//
//             int c = 123;
//             double d = Convert.ToDouble(c);
//
//             int e = 321;
//             string f = Convert.ToString(e);
//
//             string g = "$";
//             char h = Convert.ToChar(g);
//
//             string i = "true";
//             bool j = Convert.ToBoolean(i);
//
//             Console.WriteLine(b.GetType());
//             Console.WriteLine(d.GetType());
//             Console.WriteLine(f.GetType());
//             Console.WriteLine(h.GetType());
//             Console.WriteLine(j.GetType());
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             Console.WriteLine("What's your age?");
//             string name = Console.ReadLine();
//
//             Console.WriteLine("What's your age?");
//             int age = Convert.ToInt32(Console.ReadLine());
//
//             Console.WriteLine("Hello " + name);
//             Console.WriteLine("You are " + age + " years old");
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             int friends = 5;
//
//             friends = friends + 1;
//             //friends += 1;
//             //friends++;
//
//             //friends = friends - 1;
//             //friends -= 1;
//             //friends--;
//
//             //friends = friends * 2;
//             //friends *= 2;
//
//             //friends = friends / 2;
//             //friends /= 2;
//
//             //int remainder = friends % 2;
//             //Console.WriteLine(remainder);
//
//             Console.WriteLine(friends);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             double x = 3;
//             double y = 5;
//
//             double a = Math.Pow(x, 2);
//             double b = Math.Sqrt(x);
//             double c = Math.Abs(x);
//             double d = Math.Round(x);
//             double e = Math.Ceiling(x);
//             double f = Math.Floor(x);
//             double g = Math.Max(x, y);
//             double h = Math.Min(x, y);
//
//             Console.WriteLine(a);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             Random random = new Random();
//
//             int num1 = random.Next(1, 7);
//             int num2 = random.Next(1, 7);
//             int num3 = random.Next(1, 7);
//
//             //double num = random.NextDouble();
//
//             Console.WriteLine(num1);
//             Console.WriteLine(num2);
//             Console.WriteLine(num3);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             Console.WriteLine("Enter side A: ");
//             double a = Convert.ToDouble(Console.ReadLine());
//
//             Console.WriteLine("Enter side B: ");
//             double b = Convert.ToDouble(Console.ReadLine());
//
//             double c = Math.Sqrt((a * a) + (b * b));
//
//             Console.WriteLine("The hypotenuse is: " + c);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             string fullName = "Bro Code";
//             string phoneNumber = "123-456-7890";
//
//             //fullName = fullName.ToUpper();
//             //fullName = fullName.ToLower();
//             //Console.WriteLine(fullName);
//
//             //phoneNumber = phoneNumber.Replace("-","");
//             //Console.WriteLine(phoneNumber);
//
//             //String userName = fullName.Insert(0,"Mr.");
//             //Console.WriteLine(userName);
//
//             //Console.WriteLine(fullName.Length);
//
//             string firstName = fullName.Substring(0, 3);
//             string lastName = fullName.Substring(4, 4);
//
//             Console.WriteLine(firstName);
//             Console.WriteLine(lastName);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             //if statement = a basic form of decision making
//             // -------------------- Example 1 -------------------- 
//
//             Console.WriteLine("Please enter your age: ");
//             int age = Convert.ToInt32(Console.ReadLine());
//
//             if (age >= 18)
//             {
//                 Console.WriteLine("You are now signed up!");
//             }
//             else if (age < 0)
//             {
//                 Console.WriteLine("You haven't been born yet!");
//             }
//             else
//             {
//                 Console.WriteLine("You must be 18+ to sign up!");
//             }
//             // -------------------- Example 2 -------------------- 
//
//             Console.WriteLine("Please enter your name: ");
//             string name = Console.ReadLine();
//
//             if (name == "")
//             {
//                 Console.WriteLine("You did not enter your name!");
//             }
//             else
//             {
//                 Console.WriteLine("Hello " + name);
//             }
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // switch = an efficient alternative to many else if statements
//
//             Console.WriteLine("What day is it today?");
//             String day = Console.ReadLine();
//
//             switch (day)
//             {
//                 case "Monday":
//                     Console.WriteLine("It's Monday!");
//                     break;
//                 case "Tuesday":
//                     Console.WriteLine("It's Tuesday!");
//                     break;
//                 case "Wednesday":
//                     Console.WriteLine("It's Wednesday!");
//                     break;
//                 case "Thursday":
//                     Console.WriteLine("It's Thursday!");
//                     break;
//                 case "Friday":
//                     Console.WriteLine("It's Friday!");
//                     break;
//                 case "Saturday":
//                     Console.WriteLine("It's Saturday!");
//                     break;
//                 case "Sunday":
//                     Console.WriteLine("It's Sunday!");
//                     break;
//                 default:
//                     Console.WriteLine(day + " is not a day!");
//                     break;
//             }
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // logical operators = Can be used to check if more than 1 condition is true/false
//
//             // && (AND)
//             // || (OR)
//
//             Console.WriteLine("What's the temperature outside: (C)");
//             double temp = Convert.ToDouble(Console.ReadLine());
//
//             if (temp >= 10 && temp <= 25)
//             {
//                 Console.WriteLine("It's warm outside!");
//             }
//             else if (temp <= -50 || temp >= 50)
//             {
//                 Console.WriteLine("DO NOT GO OUTSIDE!");
//             }
//
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // while loop = repeats some code while some condition remains true
//
//             string name = "";
//
//             while (name == "")
//             {
//                 Console.Write("Enter your name: ");
//                 name = Console.ReadLine();
//             }
//
//             Console.WriteLine("Hello " + name);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // for loop = repeats some code a FINITE amount of times
//
//             // Count up to 10
//             for (int i = 1; i <= 10; i++)
//             {
//                 Console.WriteLine(i);
//             }
//
//             // Count down from 10
//             for (int i = 10; i > 0; i--)
//             {
//                 Console.WriteLine(i);
//             }
//             Console.WriteLine("HAPPY NEW YEAR!");
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // nested loops = loops inside of other loops
//             //                Uses vary. Used a lot in sorting algorithms
//
//             Console.Write("How many rows?: ");
//             int rows = Convert.ToInt32(Console.ReadLine());
//
//             Console.Write("How many columns?: ");
//             int columns = Convert.ToInt32(Console.ReadLine());
//
//             Console.Write("What symbol: ");
//             String symbol = Console.ReadLine();
//
//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < columns; j++)
//                 {
//                     Console.Write(symbol);
//                 }
//                 Console.WriteLine();
//             }
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             Random random = new Random();
//             bool playAgain = true;
//             int min = 1;
//             int max = 100;
//             int guess;
//             int number;
//             int guesses;
//             string response;
//
//             while (playAgain)
//             {
//                 guess = 0;
//                 guesses = 0;
//                 response = "";
//                 number = random.Next(min, max + 1);
//
//                 while (guess != number)
//                 {
//                     Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
//                     guess = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Guess: " + guess);
//
//                     if (guess > number)
//                     {
//                         Console.WriteLine(guess + " is to high!");
//                     }
//                     else if (guess < number)
//                     {
//                         Console.WriteLine(guess + " is to low!");
//                     }
//                     guesses++;
//                 }
//                 Console.WriteLine("Number: " + number);
//                 Console.WriteLine("YOU WIN!");
//                 Console.WriteLine("Guesses: " + guesses);
//
//                 Console.WriteLine("Would you like to play again (Y/N): ");
//                 response = Console.ReadLine();
//                 response = response.ToUpper();
//
//                 if (response == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }
//             }
//
//             Console.WriteLine("Thanks for playing! ... I guess");
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             Random random = new Random();
//             bool playAgain = true;
//             string player;
//             string computer;
//             string answer;
//
//             while (playAgain)
//             {
//                 player = "";
//                 computer = "";
//                 answer = "";
//
//                 while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
//                 {
//                     Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
//                     player = Console.ReadLine();
//                     player = player.ToUpper();
//                 }
//
//
//                 switch (random.Next(1, 4))
//                 {
//                     case 1:
//                         computer = "ROCK";
//                         break;
//                     case 2:
//                         computer = "PAPER";
//                         break;
//                     case 3:
//                         computer = "SCISSORS";
//                         break;
//                 }
//
//                 Console.WriteLine("Player: " + player);
//                 Console.WriteLine("Computer: " + computer);
//
//                 switch (player)
//                 {
//                     case "ROCK":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         break;
//                     case "PAPER":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         break;
//                     case "SCISSORS":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         break;
//                 }
//
//                 Console.Write("Would you like to play again (Y/N): ");
//                 answer = Console.ReadLine();
//                 answer = answer.ToUpper();
//
//                 if (answer == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }
//
//             }
//
//             Console.WriteLine("Thanks for playing!");
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             do
//             {
//                 double num1 = 0;
//                 double num2 = 0;
//                 double result = 0;
//
//                 Console.WriteLine("------------------");
//                 Console.WriteLine("Calculator Program");
//                 Console.WriteLine("------------------");
//
//                 Console.Write("Enter number 1: ");
//                 num1 = Convert.ToDouble(Console.ReadLine());
//
//                 Console.Write("Enter number 2: ");
//                 num2 = Convert.ToDouble(Console.ReadLine());
//
//                 Console.WriteLine("Enter an option: ");
//                 Console.WriteLine("\t+ : Add");
//                 Console.WriteLine("\t- : Subtract");
//                 Console.WriteLine("\t* : Multiply");
//                 Console.WriteLine("\t/ : Divide");
//                 Console.Write("Enter an option: ");
//
//
//                 switch (Console.ReadLine())
//                 {
//                     case "+":
//                         result = num1 + num2;
//                         Console.WriteLine($"Your result: {num1} + {num2} = " + result);
//                         break;
//                     case "-":
//                         result = num1 - num2;
//                         Console.WriteLine($"Your result: {num1} - {num2} = " + result);
//                         break;
//                     case "*":
//                         result = num1 * num2;
//                         Console.WriteLine($"Your result: {num1} * {num2} = " + result);
//                         break;
//                     case "/":
//                         result = num1 / num2;
//                         Console.WriteLine($"Your result: {num1} / {num2} = " + result);
//                         break;
//                     default:
//                         Console.WriteLine("That was not a valid option");
//                         break;
//                 }
//                 Console.Write("Would you like to continue? (Y = yes, N = No): ");
//             } while (Console.ReadLine().ToUpper() == "Y");
//
//             Console.WriteLine("Bye!");
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // array = a variable that can store multiple values. fixed size
//
//             //String[] cars = {"BMW", "Mustang", "Corvette"};
//
//             string[] cars = new string[3];
//
//             cars[0] = "Tesla";
//             cars[1] = "Mustang";
//             cars[2] = "Corvette";
//
//             for (int i = 0; i < cars.Length; i++)
//             {
//                 Console.WriteLine(cars[i]);
//             }
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // foreach loop = a simpler way to iterate over an array, but it's less flexible
//
//             string[] cars = { "BMW", "Mustang", "Corvette" };
//
//             foreach (string car in cars)
//             {
//                 Console.WriteLine(car);
//             }
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // method  = performs a section of code, whenever it's called "invoked".
//             //           benefit = Let's us reuse code w/o writing it multiple times
//             //           Good practice is to capitalize method names (I forgot in this video)
//
//             string name = "Bro";
//             int age = 21;
//
//             SingHappyBirthday(name, age);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // return  = returns data back to the place where a method is invoked
//
//             double x;
//             double y;
//             double result;
//
//             Console.WriteLine("Enter in number 1: ");
//             x = Convert.ToDouble(Console.ReadLine());
//
//             Console.WriteLine("Enter in number 2: ");
//             y = Convert.ToDouble(Console.ReadLine());
//
//             result = Multiply(x, y);
//
//             Console.WriteLine(result);
//
//             Console.ReadKey();
//
//             //*******************************************************************************************
//
//
//             // method overloading  = methods share same name, but different parameters
//             //                       name + parameters = signature
//             //                       methods must have a unique signature
//
//             double total;
//             
//             total = Multiply(2, 3, 4);
//
//             Console.WriteLine(total);
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             // exception = errors that occur during execution
//
//             //        try     = try some code that is considered "dangerous"
//             //        catch   = catches and handles exceptions when they occur
//             //        finally = always executes regardless if exception is caught or not
//
//             int x;
//             int y;
//             double result;
//
//             try
//             {
//                 Console.Write("Enter number 1: ");
//                 x = Convert.ToInt32(Console.ReadLine());
//
//                 Console.Write("Enter number 2: ");
//                 y = Convert.ToInt32(Console.ReadLine());
//
//                 result = x / y;
//
//                 Console.WriteLine("result: " + result);
//             }
//             catch (FormatException e)
//             {
//                 Console.WriteLine("Enter ONLY numbers PLEASE!");
//             }
//             catch (DivideByZeroException e)
//             {
//                 Console.WriteLine("You can't divide by zero! IDIOT!");
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("Something went wrong!");
//             }
//             finally
//             {
//                 Console.WriteLine("Thanks for visiting!");
//             }
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             // conditional operator = used in conditional assignment if a condition is true/false
//
//             //(condition) ? x : y
//
//             double temperature = 20;
//             string message;
//
//             message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
//
//             Console.WriteLine(message);
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             // string interpolation = allows us to insert variables into a string literal
//             //                        precede a string literal with $
//             //                        {} are placeholders
//
//             string firstName = "Bro";
//             string lastName = "Code";
//             int age = 21;
//
//             Console.WriteLine($"Hello {firstName} {lastName}.");
//             Console.WriteLine($"You are {age,-10} old.");
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             string[,] parkingLot =    { { "Mustang", "F-150", "Explorer" }, 
//                                         { "Corvette", "Camaro", "Silverado" }, 
//                                         { "Corolla", "Camry", "Rav4" } 
//                                       };
//
//             parkingLot[0, 2] = "Fusion";
//             parkingLot[2, 0] = "Tacoma";
//             /*
//             foreach(String car in parkingLot)
//             {
//                 Console.WriteLine(car);
//             }
//             */
//             for(int i = 0; i < parkingLot.GetLength(0); i++)
//             {
//                 for (int j = 0; j < parkingLot.GetLength(1); j++)
//                 {
//                     Console.Write(parkingLot[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             // class = A bundle of releted code.
//             //          can be used as a blueprint to create objects (OOP)
//             
//             Messages.Hello();   
//             Messages.Waiting();
//             Messages.Bye();
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             // object = An instance of a class
//             //          A class can be used as a blueprint to create objects (OOP)
//             //          objects can have fields & methods (characteristics & actions)
//             
//             // constructor = A special method in a class
//             //               Same name as the class name
//             //               Can be used to assign arguments to fields when creating an object
//             
//             Human human1 = new Human("Rick", 65);
//
//             human1.name = "Rick";
//             human1.age = 65;
//
//             human1.Eat();
//             human1.Sleep();
//
//
//             Car car1 = new Car("Ferrari", "F40", 2000, "red");
//             Car car2 = new Car("McLaren", "P1", 2024, "orange");
//
//             Console.ReadKey();
//             
//             //*******************************************************************************************
//             
//             
//             
//             // static = modifier to declare a static member, which belongs to the class itself
//             //          rather than to any specific object
//
//             Car1 car1 = new Car("Mustang");
//             Car1 car2 = new Car("Corvette");
//             Car1 car3 = new Car("Lambo");
//
//             Console.WriteLine(Car1.numberOfCars);
//             Car1.StartRace();
//
//             Console.ReadKey();
//         }
//
//         //*******************************************************************************************
//         //*******************************************************************************************
//         //*******************************************************************************************
//
//
//         static void SingHappyBirthday(string birthdayBoy, int yearsOld)
//         {
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine("Happy birthday dear " + birthdayBoy);
//             Console.WriteLine("You are " + yearsOld + " years old!");
//             Console.WriteLine("Happy birthday to you!");
//             Console.WriteLine();
//
//         }
//
//         //*******************************************************************************************
//
//         static double Multiply(double x, double y)
//         {
//             return x * y;
//         }
//
//         //*******************************************************************************************
//         
//         
//         static double Multiply(double a, double b)
//         {      
//             return a * b;
//         }
//         static double Multiply(double a, double b, double c)
//         {
//             return a * b * c;
//         }
//     }
//     
//     //*******************************************************************************************
//     //*******************************************************************************************
//     //*******************************************************************************************
//
//     static class Messages
//     {
//         public static void Hello()
//         {
//             Console.WriteLine("Welcome to the program!");
//         }
//
//         public static void Waiting()
//         {
//             Console.WriteLine("I'am waiting for you");
//         }
//
//         public static void Bye()
//         {
//             Console.WriteLine("Goodbye!, see you later!");
//         }
//     }
//     
//     //*******************************************************************************************
//
//
//     class Human
//     {
//         public string name;
//         public int age;
//
//         public Human(string name, int age)
//         {
//             
//         }
//
//         public void Eat()
//         {
//             Console.WriteLine(name + " is eating");
//         }
//
//         public void Sleep()
//         {
//             Console.WriteLine(name + " is sleeping");
//         }
//     }
//     
//     //*******************************************************************************************
//
//
//     class  Car
//     {
//         public string make;
//         public string model;
//         public int year;
//         public string color;
//
//         public Car(string make, string model, int year, string color)
//         {
//             this.make = make;
//             this.model = model;
//             this.year = year;
//             this.color = color;
//         }
//
//         public void Drive()
//         {
//             Console.WriteLine("You drive the " + make + " " + model + " " + year + " " + color);
//         }
//     }
//     
//     //*******************************************************************************************
//     
//     
//     class Car1
//     {
//         string model;
//         public static int numberOfCars;
//
//         public Car1(string model)
//         {
//             this.model = model;
//             numberOfCars++;
//         }
//
//         public static void StartRace()
//         {
//             Console.WriteLine("The race has begun!");
//         }
//     }
// }
//
//
