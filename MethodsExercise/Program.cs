namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        
           
 
        {
            
            //console.writeline("what is your name?");
            //string username = console.readline();
            //console.writeline("how old are you?");
            //string age = console.readline();
            //console.writeline("what is the name of your pet if any?");
            //string userpetname = console.readline();
            //console.writeline("what is the color of your pet?");
            //string userpetcolor = console.readline();

            //console.writeline($"i met a  young man yesterday whom seemed cool, his name was {username}. it shocked me when the man told me he was {age} years old.");
            //console.writeline($"he had this beautiful {userpetcolor}, englisg bulldog named {userpetname}.");
            //console.writeline($"{username} mentioned to me, that he was looking to breed {userpetname} with a lighter verison of {userpetcolor}.");

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

        { return x * y;}
    }

}
