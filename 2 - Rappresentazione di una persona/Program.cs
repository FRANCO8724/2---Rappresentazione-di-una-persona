using System;

class Program
{
    class Persona
    {
        //Attributi
        public int codice1;
        public string cognome1;
        public string nome1;
        public bool registrato1;

        //Costruttore con parametri
        public Persona(int codice, string cognome, string nome, bool registrato)
        {
            codice1 = codice;
            cognome1 = cognome;
            nome1 = nome;
            registrato1 = registrato;
        }

        //Metodo
        public string Registra()
        {
            return "Codice: " + codice1 + ", cognome: " + cognome1 + ", nome: " + nome1 + ", registrato: " + registrato1;
        }

        public string Mostra()
        {
            return "Codice: 287908, Cognome: Rossi, Nome: Mario, Registrato: sì";
        }

    }

    static void Main()
    {
        Console.WriteLine("Inserire codice:");
        int codice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Inserire cognome:");
        string cognome = Console.ReadLine();

        Console.WriteLine("Inserire nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Inserire registrato:");
        string controllo = Console.ReadLine();

        bool registrato;

        if (controllo == "true")
        {
            registrato = true;
        }
        else
        {
            registrato = false;
        }

        Persona persona1 = new Persona(codice, cognome, nome, registrato);

        if (registrato == false)
        {
            Console.WriteLine(persona1.Registra());
        }
        else
        {
            Console.WriteLine(persona1.Mostra());
        }
    }



}