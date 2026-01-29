namespace ExceptionCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a number");       
            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);
                Console.WriteLine(i);
            }
            catch(Exception e)
            {

                Console.WriteLine("occour wrong!");
            }
            finally {
                Console.WriteLine("Done !!!");
            }
            
        }
    }
}
