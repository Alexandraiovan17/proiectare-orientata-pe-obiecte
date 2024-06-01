// sa se creeze un tip de date numit "Persoana" care sa contina numele de tip string si varsta de tip int, 
// reprezentate ca autopropreteti de tip read-only
// clasa va contine un constructor pentru initilizare avand 2 parametrii corespunzatori celor 2 campuri
// in metoda main se vor adauga mai multe metode de tipul persoana, intrao colenctie generica listDT[],
// //se cere afisarea persoanelor din colectie sortate lexicografic dupa nume,
// si  respectiv in ordine crescatoare dupa varsta apoi si descrescator in functie de varsta


    public class Persoana
    {
        public string Nume { get; }
        public int Varsta { get; }
        public Persoana(string n, int v)
        {
            Nume = n;
            Varsta = v;
        }
        public override string ToString()
        {
            return Nume + " " + Varsta.ToString() + "ani";

        }

    }

