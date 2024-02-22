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
            Statistiche (ref pesi, ref media, ref min, ref max ); //calcolo della media,min e max
            Console.WriteLine("la media è "+media);
            Console.WriteLine("il minimo è "+min);
            Console.WriteLine("il massimo è "+max);
            ordina(ref pesi, ref eta); //ordinamento
            Console.WriteLine("stampa delle età e dei pesi");
            foreach (int i in pesi)
            {
                Console.Write(pesi[i]);
                Console.WriteLine(eta[i]);
            }
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
                if (pesi[i] >= max)
                {
                    max = pesi[i];
                }
                if (pesi[i] <= min)
                {
                    min = pesi[i];
                }
                somma += pesi[i];
                cont++;
            }
            media = somma / cont;
        }
        static void ordina (ref int [] pesi,ref int[] eta)
        {
            int temp1,temp2;
            for(int i = 0; i < eta.Length-1; i++)
            {
                for(int j = 0; j < eta.Length-i-1; j++)
                {
                    if (eta[j] > eta[j+1])
                    {
                        temp1= eta[j];
                        eta[j]= eta[j+1];
                        eta[j+1]= temp1;
                        temp2 = pesi[j];
                        pesi[j] = pesi[j+1];
                        pesi[j+1]=temp2;
                    }
                }
            }
        }
    }
}