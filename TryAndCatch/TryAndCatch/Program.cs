namespace TryAndCatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(userInput));
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, pleaser enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Occured an overflow!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null exception, pleaser enter the correct type next time.");
            }
            finally
            {
                Console.WriteLine("Press any key to continue...");
            }
        }
    }   
}