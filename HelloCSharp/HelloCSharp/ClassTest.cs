using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    public class ClassTest
    {

        static void Main(string[] args)
        {
            Studnet s1 = new Studnet();
            Studnet s2 = new Studnet("하하");
            Studnet s3 = new Studnet("멋쟁이", "경기도 성남 분당구");

            s1.printAllProperty();
            s2.printAllProperty();
            s3.printAllProperty();
        }

    }

}


public class Studnet
{
    string name;
    string address;

    public Studnet(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public Studnet(string name) : this(name, null)
    {
    }
    public Student() : this(null)
    {
    }

    public void printName()
    {
        Console.WriteLine(name);
    }

    public void printAddress()
    {
        Console.WriteLine(address);
    }

    public void printAllProperty()
    {
        Console.WriteLine(name + " " + address);
    }
}

