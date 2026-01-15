namespace HappyTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solver solver = new Solver();
            Test test = new Test(solver.Run);
            test.Run();
            Console.ReadKey();
        }
    }
}
