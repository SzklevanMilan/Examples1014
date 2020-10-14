using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Customer
{
    public string Name;
    public string State;
    public string Phone;

    public Customer(string n, string s, string p)
    {
        Name = n;
        State = s;
        Phone = p;
    }
}
class Program
{

    static void Main(string[] args)
    {
        var customers = new List<Customer>();
        customers.Add(new Customer("Chandler", "OR", "555-555-5555"));
        customers.Add(new Customer("Monica", "CO", "555-666-6666"));
        customers.Add(new Customer("Joey", "CO", "555-777-7777"));
        customers.Add(new Customer("Ross", "NY", "555-000-0000"));
        customers.Add(new Customer("Phoebe", "NY", "555-111-1111"));
        customers.Add(new Customer("Rachel", "NJ", "555-222-2222"));

        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        string[] numNames = { "nulla", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc" };

        //5 alatti számok kiíratása
        var otAlatt = from n in numbers
                      where n < 5 
                      orderby n descending
                      select n;
        // azonnali kiértékelés --> átalakítással
        //var ujTomb = otAlatt.ToList();
        //var ujTomb = otAlatt.ToArray();

        foreach (var o in otAlatt)
        {
            Console.Write($"{o}, ");
        }
        // Kik laknak "CO" állmaban?
        var coState = from c in customers
                      where c.State == "CO"
                      orderby c.Name
                      select c;
        Console.WriteLine("\n'CO' államban élők");
        foreach (var c in coState)
        {
            Console.WriteLine($"{c.Name,6}--{c.State}");
        }

        // számok értéke növelve 2-vel
        var kettovel = from n in numbers
                       select n + 2;
        
        //var kettoTomb = kettovel.ToArray();
        //for (int i = 0; i < kettoTomb.Length; i++)
        //{
        //    Console.WriteLine($"{numbers[i]}-->{kettoTomb[i]}");
        //}

        int i = 0;
        Console.WriteLine();
        foreach (var k in kettovel)
        {
            Console.WriteLine($"{numbers[i++]} --> {k}");
        }

        // A Customer-ből csak név és telefonszám kell --> anonim objektum típus felhasználása
        var namePhone = from c in customers
                        orderby c.Name
                        select new { nev = c.Name, tel = c.Phone };
        //anonim objektum a "new" kulcs szóval adjuk meg

        Console.WriteLine();
        foreach (var n in namePhone)
        {
            Console.WriteLine($"{n.nev,8} {n.tel}");
        }

        // számokból --> szöveg
        Console.WriteLine();
        int[] ujtomb = { 2, 4, 0, 1, 9, 6 };

        var szoveges = from u in ujtomb
                       select numNames[u];
        foreach (var s in szoveges)
        {
            Console.Write(s+" ");
        }

        // csoportosítás 
        Console.WriteLine();
        var nevek = from c in customers
                    select c.Name;
        var nevLista = nevek.ToList();
        var kezdoBetu = from n in nevLista
                        orderby n
                        where n[0] != 'R'
                        group n by n[0] into tempNevek
                        select tempNevek;


        Console.WriteLine("\nCsoportosítás kezdőbetű szerint");
        foreach (var csoport in kezdoBetu)
        {
            Console.WriteLine("Kezdőbetű: {0}", csoport.Key);
            foreach (var csoportTag in csoport)
            {
                Console.WriteLine($"\t{csoportTag}");
            }
        }


        Console.ReadLine();
    }

}

