using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{

    static class Polymorphism
    {
        public static void main()
        {

            //class example 
            Person objPerson = new Person();
            objPerson.Print();

            Person objPersonFather = new Father();
            objPersonFather.Print();

            Person objPersonSon = new Son();
            objPersonSon.Print();

            //interface example
            IPerson objIPersonDoctor = new Doctor();
            objIPersonDoctor.Print();
        }

    }

    class Person
    {
        public virtual void Print()
        {
            Console.WriteLine("Person");
        }
    }

    class Father : Person
    {
        public override void Print()
        {
            Console.WriteLine("Father");
        }
    }

    class Son : Person
    {
        public override void Print()
        {
            Console.WriteLine("Son");
        }
    }


    //-------------------------------------------------------------

    interface IPerson {
        void Print();
    
    }

    class Doctor : IPerson
    {
        public void Print()
        {
            Console.WriteLine("Doctor");
        }
    }

}
