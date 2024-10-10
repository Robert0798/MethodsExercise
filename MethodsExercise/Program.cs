namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
          GetUserNameAndGreet();
          Console.WriteLine(Add(2,4));
          Console.WriteLine(Subtract(2,4));
          Console.WriteLine(Multiply(2,4));
          Console.WriteLine(Divide(2,4));
        }
        public static void GetUserNameAndGreet()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite boba flavor?");
            string boba = Console.ReadLine();
            Console.WriteLine($"Hi, {name}! I love the band {band} as well! And my favorite color is  {favoriteColor} too! We need to get {boba} soon!");
            
            
            
            
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
   
}
