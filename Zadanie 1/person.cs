using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class zadanie1
{
    public static void Main(string[] args){
        Person person = new Person("Grzegorz Brzeczyszczykiewicz");
        person.DateOfBorn = new DateTime(1936, 1, 11);
        person.DateOfDead = new DateTime(2016, 3, 17);
        Person person2 = new Person("Michal Bak");
        person2.DateOfBorn = new DateTime(2000, 7, 15);
        Console.WriteLine(person.ToString());
        Console.WriteLine(person2.ToString());
    }
}
