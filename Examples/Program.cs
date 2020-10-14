using System;
using System.Collections.Generic;
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
                      select n;

        // Kik laknak "CO" állmaban?


        // számok értéke növelve 2-vel


        // A Customer-ből csak név és telefonszám kell --> anonim objektum típus felhasználása


        // számokból --> szöveg


        // csoportosítás 



        Console.ReadLine();
    }

}

