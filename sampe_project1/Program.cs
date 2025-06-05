namespace sampe_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {

                Console.WriteLine("its Positive number!");
            }
            else
            {
                Console.WriteLine("its Negative number!");
            }

            Console.Read();
        }

    }
}
