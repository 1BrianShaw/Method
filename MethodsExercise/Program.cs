namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name} What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"I like the color {color} too! What is your favorite Animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("I think they are overrated but that is okay, no one is perfect. What band do you listen to?");
            string band = Console.ReadLine();

            Console.WriteLine($"Great, now let me tell you a story about a hero named {name}");
            Console.WriteLine($"They had a magic {animal}, that was the color {color}");
            Console.WriteLine($"Evil would run and hide when they heard songs from {band} playing for they knew {name} and their magic {animal} was on the way");
            Console.WriteLine($"The villagers lived in peace as they blasted {band} music day and night rocking out and keeping evil away");

            Console.WriteLine("For how many years did the hero fight for peace?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("How many years did the hero keep peace over the kingdom?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"Congratulations on a long reign of {sum} years");

            Console.WriteLine($"How many generations will there be for peace?");
            int num3 = int.Parse(Console.ReadLine());

            int product = Multiply(sum, num3);
            Console.WriteLine($"If your family line is strong that ensures peace for {product} years. That is amazing!");

            Console.WriteLine($"Is {sum} Enough years for you?  How many more years than that would you like to reign?");
            int num4 = int.Parse(Console.ReadLine());

            int total = Add(sum, num4);
            int total2 = Add(num4, product);
            Console.WriteLine($"That is not too much to ask, so you will reign for {total} years and Peace will hold for atleast {total2}!");

        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Add(params int[] list)
        {
            int add = 0;

            for (int i = 0; i < list.Length; i++)
            {
                add = add + list[i];
            }

            return add;
        }
    }
}


