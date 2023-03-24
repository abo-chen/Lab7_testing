namespace BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath basicMath = new BasicMath();
            Console.WriteLine( basicMath.Divide(5, 0) );
        }
    }
}