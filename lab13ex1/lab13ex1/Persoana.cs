using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13ex1
{
    internal class X
    {
        public static void print (List<global::Persoana> a)
        {
            foreach (object o in a )
            
                Console.WriteLine(o);
            
        }
        public static void Main()
        {
            List<global::Persoana> pers = new List<global::Persoana>();
            pers.Add(new global::Persoana("Ion", 50));
            pers.Add(new global::Persoana("Ana", 30));
            pers.Add(new global::Persoana("Vasile", 20));
            pers.Add(new global::Persoana("Gheorghe", 20));
            pers.Add(new global::Persoana("Adrian", 25));
            pers.Add(new global::Persoana("Adriana", 30));

            pers.Sort(new SortByName());
            Console.WriteLine("\n\nSortarea dupa nume:\n");
            print(pers);

            pers.Sort(new SortByAge());
            Console.WriteLine("\n\nSortarea dupa varsta(crescator):\n");
            print(pers);

            pers.Reverse();
            Console.WriteLine("\n\nSortarea dupa varsta(descrescator):\n");
            print(pers);
        }
    }
}
//se considera un fisier text de intrare avand liniile de forma "nume prenume n" apoi nota 1,nota2,...nota n
//pe prima linie avem numarul de inregistrari din fisier
//datele din fisier se adauga intr o colectie generica prin intermediul unei clase denumite elev avand ca membri data: numele si prenumele si media aritmetica a notelor
//sa se afiseze intr un fiser de iesire lista inregistrarilor sortate descrecator in functie de medie
//iar pentru medii egale ordine in functie de nume si prenume precum si media generala

//sortam date predefinite (decimal) 
//se considera o lista de valori in virgula mobila cu precizie 20-30 zecimale 
//se cere sortarea valorilor descescator in functie de partea fractionara 