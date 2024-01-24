namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        
           
 
        {

            Console.WriteLine("what is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("how old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("what is the name of your pet if any?");
            string userpetname = Console.ReadLine();
            Console.WriteLine("what is the color of your pet?");
            string userpetcolor = Console.ReadLine();

            Console.WriteLine($"I met a  young man yesterday whom seemed cool, his name was {username}. it shocked me when the man told me he was {age} years old.");
            Console.WriteLine($"He had this beautiful {userpetcolor}, englisg bulldog named {userpetname}.");
            Console.WriteLine($"{username} mentioned to me, that he was looking to breed {userpetname} with a lighter verison of {userpetcolor}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is:{sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The sum is:{product}");
        }

        public static int Sum(int num1, int num2)

        { return num1 + num2; }

        public static int Multiply(int x, int y)

        { return x * y; }
    }

}
