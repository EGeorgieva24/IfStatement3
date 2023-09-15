namespace IfStatement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >=21)
            {
                Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            }
            else
                Console.WriteLine("Sorry,you can't vote :(");
        }
    }
}