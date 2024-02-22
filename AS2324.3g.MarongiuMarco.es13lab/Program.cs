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
            CaricaVettori(ref pesi, ref eta);

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
    }
}