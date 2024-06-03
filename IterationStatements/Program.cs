namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE

        //Write a method to check whether a given number is even or odd - DONE

        //Write a method to check whether a given number is positive or negative - DONE

        //Write a method to read the age of a candidate and determine whether they can vote. - DONE
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE

        //Write a method to display the multiplication table(from 1 to 12) of a given integer - DONE


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            PrintThrees();
            Console.WriteLine(CheckEqual(7, 9));
            EvenOrOdd();
            PositiveOrNegative();
            CheckUserAge();
            CheckIntInRange();
            IntMultiplicationTable();
        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintThrees()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool CheckEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void EvenOrOdd()
        {

            int userNumber;
            bool isParsable;

            do
            {
                Console.WriteLine("Please enter a number that is an intiger.");
                var userResponse = Console.ReadLine();
                isParsable = int.TryParse(userResponse, out userNumber);
            } while (isParsable == false);

            int checkUserNumber = userNumber % 2;
            if (checkUserNumber == 0)
            {
                Console.WriteLine($"Your number {userNumber} is even.");
            }
            else
            {
                Console.WriteLine($"Your number {userNumber} is odd.");
            }

        }

        public static void PositiveOrNegative()
        {

            int userIntiger;
            bool intParsable;

            do
            {
                Console.WriteLine("Please enter a positive or negative intiger.");
                var userIntigerResponse = Console.ReadLine();
                intParsable = int.TryParse(userIntigerResponse, out userIntiger);
            } while (intParsable == false);

            if (userIntiger > 0)
            {
                Console.WriteLine($"Your number {userIntiger} is positive.");
            }
            else if (userIntiger < 0)
            {
                Console.WriteLine($"Your number {userIntiger} is negative");
            }
            else
            {
                Console.WriteLine($"Your number is {userIntiger}. Not posotive or negative");
            }

        }

        public static void CheckUserAge()
        {

            int userAge;
            bool isAgeParsable;

            do
            {
                Console.WriteLine("Please enter your age");
                var userAgeInput = Console.ReadLine();
                isAgeParsable = int.TryParse(userAgeInput, out userAge);
            } while (isAgeParsable == false);

            if (userAge >= 18)
            {
                Console.WriteLine($"Your age is {userAge} and you can vote.");
            }
            else
            {
                Console.WriteLine($"Sorry you are {userAge} and under the voting age and cant't vote.");
            }
        }

        public static void CheckIntInRange()
        {

            int usersIntigerNumber;
            bool isIntInRangeParsable;

            do
            {
                Console.WriteLine("Please enter an intiger.");
                var usersIntigerNumberInput = Console.ReadLine();
                isIntInRangeParsable = int.TryParse(usersIntigerNumberInput, out usersIntigerNumber);
            } while (isIntInRangeParsable == false);

            if (usersIntigerNumber >= -10 && usersIntigerNumber <= 10)
            {
                Console.WriteLine($"Your number {usersIntigerNumber} is in the range of -10 and 10"); 
            }
            else
            {
                Console.WriteLine($"Your number {usersIntigerNumber} is out of the range of -10 and 10");
            }

        }

        public static void IntMultiplicationTable()
        {

            int intToBeMultiplied;
            bool isMultiplicationTableParsable;

            do
            {
                Console.WriteLine("Please enter an intiger to see its multiplication table.");
                var intToBeMultipliedInput = Console.ReadLine();
                isMultiplicationTableParsable = int.TryParse(intToBeMultipliedInput, out intToBeMultiplied);
            } while (isMultiplicationTableParsable == false);

            for (int m = 1; m <= 12; m++)
            {
                Console.WriteLine(m * intToBeMultiplied);
            }

        }
    }

}
