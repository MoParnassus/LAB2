using System;

namespace ConsoleApp10
{
    class Program
    {

        static int[] liczniki=new int[3];
        static void Etykieta(int index)
        {
            Console.WriteLine("Etykieta "+liczniki[index-1]);
            liczniki[index - 1]++;
        }
        static int Suma()
        {
            int suma = 0;
            for (int i = 0; i <liczniki.Length; i++)
            {
                suma += liczniki[i];
            }
            return suma;
        }
        static(int, string) Funkcja()
        {
            return (0, "text");
        }
        static int cel = 100;
       static void Main(string[] args)
        {
            /*
           int a;

          
            
            string tekst= Console.ReadLine();
            a = Convert.ToInt32(tekst);

            if (a % 2==0)
                Console.WriteLine("liczba jest parzysta");
           else
                Console.WriteLine("liczba jest nieparzysta");

            Console.WriteLine((a%2==0)?"parzysta":"nieparzysta");
            */

            /*
            int odleglosc = -1,suma=0,licznik=0;
            float srednia;

            while(odleglosc!=0)
            {
                string odpowiedz = Console.ReadLine();
                odleglosc = Convert.ToInt32(odpowiedz);
                suma += odleglosc;
                licznik++;
            }

            srednia = (float)suma / (licznik-1);
            Console.WriteLine("srednia odleglosc: "+srednia);
            */
            
            // _ oznacza wyrzuć zmienna 
           // (int numer, string tekst) = Funkcja();

            while (Suma()!=cel+1)
            {
                string tekst=Console.ReadLine();
                switch (tekst)
                {
                    case "1":
                        Etykieta(1);
                        break;
                    case "2":
                        Etykieta(2);
                        break;
                    case "3":
                        Etykieta(3);
                        break;
                    default:
                        break;


                }
                

            }



            Console.Read();
        }
    }
}
