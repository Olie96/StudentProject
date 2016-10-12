using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breznjak_Student_project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool valjanostOperacije;  // sluzi za provjeru ispravnosti unesenog stringa
            bool valjanostPoruke;     // sluzi za provjeru ispravnosti unesene operacije
            int vracenaOperacija;     // vracena vrijednost izabrane operacije, koristimo kod switch grananja
            string operations;        // poruka za odabir operacije, Display/Enlist
            do
            {
                Console.Write("Operation: ");
                operations = Console.ReadLine();                   // unos operaije "enlist" ili "display"
                valjanostOperacije = ValidationClass.provjeraUnosaOperacije(operations);   // provjera valjanosti unesenog stringa
                if (valjanostOperacije == false)
                    Console.WriteLine("KRIVI UNOS OPERACIJE!!");           
            vracenaOperacija = ValidationClass.izabranaOperacija(operations);
            Console.WriteLine(vracenaOperacija.ToString());
            switch (vracenaOperacija)
             {
                case 1:{
                            // napraviti listu u klasi student container koju cemo ispisati
                            valjanostPoruke = true;
                            break;
                       }   // u slucaju poruke DISPLAY zovemo primjerenu funkciju
                case 2:{
                            // napraviti funkciju u klasi student container  koja ce ucitati podatke pojedinog studenta
                            valjanostPoruke = true;
                            break;
                       }   // u slucaju poruke ENLIST zovemo primjerenu funkciju
                default:
                    {
                        Console.WriteLine("Invalid operation!!!\nPlease insert your message again");
                            valjanostPoruke = false;
                        break;
                    }  // u slucaju pogresne poruke ispisujemo poruku te trazimo ponovan unost poruke 
             }
            } while (valjanostOperacije == false || valjanostPoruke == false);






 //---------------
        }
    }
}
