namespace HW._17._6._6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calc1 = new Calculator(new SalaryAccount(1500));
            calc1.Calculate();
            Console.WriteLine();

            Calculator calc2 = new Calculator(new OrdinaryAccount(950));
            calc2.Calculate();
            Console.WriteLine();

            Calculator calc3 = new Calculator(new OrdinaryAccount(1100));
            calc3.Calculate();
            Console.WriteLine();

        }
    }
}