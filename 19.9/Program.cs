namespace _19._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();
            int n;
            Console.WriteLine("inserisci i numeri, per uscire premere invio");
            while (int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                numeri.Add(n);
            }
            int numero;
            Console.WriteLine("inserisci il numero da cercare nella lista");
            while (!int.TryParse(Console.ReadLine(), out numero) || n < 0)
            {
                Console.WriteLine("riprova");
            }
            int trovato = -1;
            for (int i = 0; i < numeri.Count; i++)
            {
                if (numeri[i] == numero)
                {
                    trovato = i;
                    break;
                }
            }
            if (trovato == -1)
            {
                Console.WriteLine("numero non trovato");
            }
            else
            {
                Console.WriteLine($"numero trovato in posizione {trovato+1}");
            }
        }
    }
}
