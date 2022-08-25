namespace Chapter7p53
{
    class Helper
    {
        public static void Swap(ref int a,ref int b)
        {
            int t;
            t=a;
            a = b;
            b = t;   
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            
        }
    }
}