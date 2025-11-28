List<byte> csapadek = new List<byte>(365);
Random randSzam = new Random();
int valoszinuseg;

for(int i = 0; i <365;i++)
{

    if (i > 169 && i < 236)
    {
        valoszinuseg = randSzam.Next(1, 18);
        if (valoszinuseg == 17)
        {
            csapadek.Add(Convert.ToByte(randSzam.Next(1, 20)));
        }
        else csapadek.Add(0);
    }
    else
    {
        valoszinuseg = randSzam.Next(1, 8);
        if (valoszinuseg == 7)
        {
            
            csapadek.Add(Convert.ToByte(randSzam.Next(1, 31)));
        }
        else csapadek.Add(0);
    }
}
Console.WriteLine(csapadek.Count);
Console.Write(string.Join(", ", csapadek));

File.WriteAllLines("C:\\Users\\makay.adam\\Desktop\\adatok\\csapadek.txt", csapadek.Select(szam => szam + ""));
int ciklus = 0;
int legHosszabbSzarassag = 0;
do
{
  
}
while (ciklus < csapadek.Count);
Console.WriteLine(legHosszabbSzarassag);