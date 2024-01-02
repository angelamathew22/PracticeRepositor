namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Numbers");
            List<int> ints = new List<int>();
            for (int i = 0; i <= 10; i++)
            {

                i = int.Parse(Console.ReadLine());
                ints.Add(i);
            }
            ints.Sort();
            Console.WriteLine("\n");

            foreach (int i in ints)
            {
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

       
