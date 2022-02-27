using System;

namespace FirstWeekTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapsiriq nomresin secin");
            Console.Write("Nomre daxil edin:");
            string xx = Console.ReadLine();
            int yy = Convert.ToInt32(xx);
            switch (yy)
            {
                case 1:
                    Console.WriteLine("Tapsiriq nomre 1");
                    Console.Write("Nomre daxil edin:");
                    string y = Console.ReadLine();
                    int c = Convert.ToInt32(y);
                    if (c % 3 == 0)
                    {

                        Console.WriteLine("Yes 3-e bolunur");
                    }
                    else
                    {
                        Console.WriteLine("No 3-e bolunmur");
                    }
                    break;
                case 2:
                    Console.WriteLine("Tapsiriq nomre 2");
                    Console.Write("Nomre daxil edin:");
                    string a = Console.ReadLine();
                    int b = Convert.ToInt32(a);
                    if (b % 3 == 0 && b % 2 == 0)
                    {
                        Console.WriteLine("3-e bolunen cut ededdir");
                    }
                    else if (b % 3 == 0)
                    {
                        Console.WriteLine("3-e bolunen tek ededdir");
                    }
                    else
                    {
                        Console.WriteLine("Bolunmur");
                    }
                    break;
                case 3:
                    Console.WriteLine("Tapsiriq nomre 3");
                    Console.Write("1-ci ededi daxil edin:");
                    string a3 = Console.ReadLine();
                    int b3 = Convert.ToInt32(a3);
                    Console.Write("2-ci ededi daxil edin:");
                    string a2 = Console.ReadLine();
                    int b2 = Convert.ToInt32(a2);
                    if (b3 + b2 >= 100 && b3 + b2 <= 999)
                    {
                        Console.WriteLine("uc reqemli ededdi");
                    }
                    else if (b3 + b2 >= 10 && b3 + b2 <= 99)
                    {
                        Console.WriteLine("iki reqemli ededdi");
                    }
                    else
                    {
                        Console.WriteLine("nezere alinmayib");
                    }
                    break;
                case 4:
                    Console.WriteLine("Tapsiriq nomre 4");
                    string a4 = Console.ReadLine();
                    int b4 = Convert.ToInt32(a4);
                    if (b4 >= 0 && b4 <= 9)
                    {
                        Console.WriteLine("bir reqemli ededdi");
                    }
                    else if (b4 >= 10 && b4 <= 99)
                    {
                        Console.WriteLine("iki reqemli ededdi");
                    }
                    else if (b4 >= 100 && b4 <= 999)
                    {
                        Console.WriteLine("uc reqemli ededdi");
                    }
                    else if (b4 >= 1000 && b4 <= 9999)
                    {
                        Console.WriteLine("dord reqemli ededdi");
                    }
                    else if (b4 >= 10000 && b4 <= 99999)
                    {
                        Console.WriteLine("bes reqemli ededdi");
                    }
                    else
                    {

                    }
                    break;
                case 5:
                    Console.WriteLine("Tapsiriq nomre 5");
                    Console.Write("1-ci ededi daxil edin:");
                    string a5 = Console.ReadLine();
                    int b5 = Convert.ToInt32(a5);
                    Console.Write("2-ci ededi daxil edin:");
                    string a6 = Console.ReadLine();
                    int b6 = Convert.ToInt32(a6);
                    if (b5 % b6 == 0)
                    {
                        Console.WriteLine("Tam bolunur");
                    }
                    else
                    {
                        Console.WriteLine("Bolunmur");
                    }
                    break;
                default:
                    Console.WriteLine("Nomreni duzgun daxil edin");
                    break;
            }

        }
    }
}
