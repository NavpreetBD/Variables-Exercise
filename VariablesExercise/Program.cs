namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string myString = "C#";
            int myInt = 42;
            char myChar = 'A';
            bool myBool = true;
            double myDouble = 3.14;
            decimal myDecimal = 123.45M;

            // Interpolate variables in a Console.WriteLine();
            Console.WriteLine($"My string is: {myString}. My integer is {myInt}. My nickename is {myChar}. I am {myBool} to myself. Math fact is - the pie value is {myDouble} and decimal value can be written as {myDecimal}");
            
            
        }
    }
}
