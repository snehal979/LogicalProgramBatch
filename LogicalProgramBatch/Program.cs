namespace LogicalProgramBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Hint 1 FibonacciSeries 2.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            FibonacciSeries series = new FibonacciSeries();
                            series.CalculatedFibonacciSeries();
                            break;
                        case 2:
                            flag = false;
                            Console.WriteLine("Exit");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}