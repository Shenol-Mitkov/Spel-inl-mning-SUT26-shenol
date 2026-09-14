namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            var rnd = new Random();
            int secret = rnd.Next(1, 21); 

            const int maxAttempts = 5;
            int attempts = 0;

           
    }
}
