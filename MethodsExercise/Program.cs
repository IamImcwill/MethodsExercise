namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is the name of your pet if any?");
            string userPetName = Console.ReadLine();
            Console.WriteLine("What is the color of your pet?");
            string userPetColor = Console.ReadLine();

            Console.WriteLine($"I met a  young man yesterday whom seemed cool, his name was {userName}. It shocked me when the man told me he was {age} years old.");
            Console.WriteLine($"He had this beautiful {userPetColor}, Englisg Bulldog named {userPetName}.");
            Console.WriteLine($"{userName} mentioned to me, that he was looking to breed {userPetName} with a lighter verison of {userPetColor}."); 
        }
    }
}
