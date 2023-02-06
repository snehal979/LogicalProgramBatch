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
                    Console.WriteLine("Hint 1 FibonacciSeries 2.Perfect Number 3.Prime Number 4.Revese Number 5.STOPWATCH 6.Day of Week " +
                        "7.Temperature Conversion 8.MonthlyPayment 9.Convert to Binary 10.Vending Machine 11.Cuopon Number 12.Exit");
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
                            Console.WriteLine("TimeLap Calender");
                            Console.WriteLine("Enter the Date of the Month");
                            int day = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("For Month 1.Jan 2.Feb 3.Mar 4.April 5.May 6.Jun 7.July 8.Aug 9.Sept 10.Oct 11.Nov 12.Dec");
                            int month = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the year");
                            int year = Convert.ToInt32(Console.ReadLine());
                            DayOfWeek.WeekDayOfDay(day,month,year);  //Argument
                            break;
                        case 7:
                            TemperaturConversion.ConvertTemperatureConversion();
                            break;
                        case 8:
                            Console.WriteLine("Enter the Principle,Year,Rate resp.");
                            int P = Convert.ToInt32(Console.ReadLine());
                            int Y= Convert.ToInt32(Console.ReadLine());
                            int R = Convert.ToInt32(Console.ReadLine());

                            MonthlyPayment.CalculateMonthlyPayment(P, Y, R);
                            break;
                        case 9:
                            ToBinnary.ConvertBinary();
                            break;
                        case 10:
                            ToBinnary.ConvertInterger();
                            break;
                        case 11:
                            Console.WriteLine("Enter the ammount");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            VendingMachine vendingMachine = new VendingMachine();
                            vendingMachine.NoteVendingMachine(amount);
                            break;
                        case 12:
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