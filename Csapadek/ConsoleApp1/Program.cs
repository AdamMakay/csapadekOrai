namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<byte> EviIdojaras = new List<byte>();
            Random random = new Random();
            do
            {
                if(EviIdojaras.Count>=170 && EviIdojaras.Count<=235)
                {
                    if (random.Next(1, 18) == 17)
                    {
                        EviIdojaras.Add(Convert.ToByte(random.Next(1, 20)));
                    }
                    else EviIdojaras.Add(0);
                }
                else
                {
                    if(random.Next(1, 8) == 7)
                    {
                        EviIdojaras.Add(Convert.ToByte(random.Next(1, 31)));
                    }
                    else EviIdojaras.Add(0);
                }
                
            }
            while (EviIdojaras.Count <365);
            
            
            int vizsgalt = 0;
            int LeghosszabbSzarazsag = 0;
            for (int i = 0; i < EviIdojaras.Count-1; i++)
            {
                if (EviIdojaras[i] == EviIdojaras[i+1])
                {
                    vizsgalt++;
                }
                else
                {
                    if (LeghosszabbSzarazsag < vizsgalt)
                    {
                        LeghosszabbSzarazsag = vizsgalt;
                    }
                    vizsgalt = 0;
                }
            }
            Console.WriteLine(LeghosszabbSzarazsag);


            int MegfeleloCsapadek = 0;
            foreach (byte y in EviIdojaras)
            {
                if (y > 10) MegfeleloCsapadek++; 
            }
            Console.WriteLine(MegfeleloCsapadek);
        

            int osszeg = 0;
            int db = 0;
            for (int b = 0;b< EviIdojaras.Count;b++)
            {
                if (b < 170 || b > 235)
                {
                    if (EviIdojaras[b] != 0)
                    {
                        osszeg += EviIdojaras[b];
                        db++;
                    }
                }
            }
            Console.WriteLine($"Atlag: {Math.Round(Convert.ToDouble(osszeg)  / Convert.ToDouble(db),2)}");
            

            int ciklus = 0;
            do
            {
                if (EviIdojaras[ciklus] + EviIdojaras[ciklus+1] > 35)
                { Console.WriteLine("Van ilyen nap");break;}
                ciklus++;
            }
            while (ciklus < EviIdojaras.Count-1);

            int haviCsap = 0;
            for (int w = 0; w < EviIdojaras.Count; w++)
            {
                haviCsap += EviIdojaras[w];
                switch(w)
                {
                    case 30:Console.WriteLine($"Januar: {haviCsap}") ; haviCsap = 0; ; break;
                    case 60: Console.WriteLine($"Februar: {haviCsap}"); haviCsap = 0; break;
                    case 90: Console.WriteLine($"Marcius: {haviCsap}"); haviCsap = 0; break;
                    case 120: Console.WriteLine($"Aprilis: {haviCsap}"); haviCsap = 0; break;
                    case 150: Console.WriteLine($"Majus: {haviCsap}"); haviCsap = 0; break;
                    case 180: Console.WriteLine($"Junius: {haviCsap}"); haviCsap = 0; break;
                    case 210: Console.WriteLine($"Julius: {haviCsap}"); haviCsap = 0; break;
                    case 240: Console.WriteLine($"Auguszus: {haviCsap}"); haviCsap = 0; break;
                    case 270: Console.WriteLine($"Szeptember: {haviCsap}"); haviCsap = 0; break;
                    case 300: Console.WriteLine($"Oktober: {haviCsap}"); haviCsap = 0; break;
                    case 330: Console.WriteLine($"November: {haviCsap}"); haviCsap = 0; break;
                    case 365: Console.WriteLine($"December: {haviCsap}"); haviCsap = 0; break;

                }
                
            }
        }
    }
}
