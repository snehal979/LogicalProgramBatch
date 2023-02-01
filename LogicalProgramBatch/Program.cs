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
                    Console.WriteLine("Hint 1 FibonacciSeries 2.Perfect Number 3.Prime Number 4.Revese Number 5.STOPWATCH 6.Day of Week 7.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            FibonacciSeries series = new FibonacciSeries();
                            series.CalculatedFibonacciSeries();
                            break;
                            case 2:
                            PerfectNumber perfectNumber = new PerfectNumber();
                            perfectNumber.CheckNumberIsPerfect();
                            break;
                        case 3:
                            PrimeNumber primeNumber = new PrimeNumber();
                            primeNumber.CheckPrimeNumber(); 
                            break;
                        case 4:
                            ReverseNumber reverseNumber = new ReverseNumber();
                            reverseNumber.CalculateReverseNumber();
                            break;
                        case 5:
                            StopWatch stopWatch = new StopWatch();
                            //stopWatch.CalculateTime();
                            stopWatch.OtherMethodElapsedIime();
                            break;
                        case 6:
                            DayOfWeek dayOfWeek = new DayOfWeek();
                            dayOfWeek.WeekDayOfDay();
                            break;
                        case 7:
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