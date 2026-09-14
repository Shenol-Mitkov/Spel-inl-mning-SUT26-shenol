namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Välkomnar spelaren
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");


            var rnd = new Random();
            int secret = rnd.Next(0, 21); // skapar ett slump nummer mellan 0 - 20

            const int maxAttempts = 5; // ger spelaren ett max antal av 5 försök
            int attempts = 0; // antal försök sätts till 0

            while (attempts < maxAttempts) // loopen pågår medans antal försök är mindre än maxAttempts
            {
                Console.WriteLine("Skriv en gissning: ");
                string? input = Console.ReadLine(); // läser av spelarens försök

                if (!int.TryParse(input, out int guess)) // felmeddelande om spelaren skriver något annat än ett heltal
                {
                    Console.WriteLine("Ogiltig inmatning, ange ett heltal");
                    continue; // avslutar inte programmet
                }
                attempts++; 
                int result = CheckGuess(secret, guess); // anrop av metod
                if (result == 0)
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                    break;
                }

                if (result < 0)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt");
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt");
                }
                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på 5 försök");
                }
            }


            static int CheckGuess(int secret, int guess) // metod för att kolla om gissningen är korrekt
            {
                if (guess == secret) return 0;
                return guess < secret ? -1 : 1;
            }



















        }
    }
}
