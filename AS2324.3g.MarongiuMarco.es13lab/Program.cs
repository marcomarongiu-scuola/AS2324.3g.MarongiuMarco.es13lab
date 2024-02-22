namespace AS2324._3g.MarongiuMarco.es13lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quante persone?");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] pesi=new int[n];
            int[] eta=new int[n];
            CaricaVettori(ref pesi, ref eta); //carica dei vettori
            int min = pesi[0], max=pesi[0];
            double media=0;
            Statistiche (ref pesi, ref media, ref min, ref max );

        }
        static void CaricaVettori(ref int[] pesi,ref int[] eta)
        {
            Random random = new Random();
            foreach(int i in pesi)
            {
                eta[i] = random.Next(50, 101);
                pesi[i] = random.Next(18, 100);
            }
        }
        static void Statistiche(ref int[] pesi, ref double media,ref int min,ref int max)
        {
            int somma = 0;
            int cont = 0;
            foreach (int i in pesi)
            {
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
                somma += pesi[i];
                cont++;
            }
            media = somma / cont;
        }
    }
}