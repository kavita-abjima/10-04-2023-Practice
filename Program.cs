using System;

using Generics_method.Generic_Methods;
using Interface_vs_AbsractClass;
using System.Collections;

namespace Interface_vs_AbsractClass
{
    class Program
   {
    static void Main(string[] args)
      {
            MyClass_1 obj = new MyClass_1();
            
            obj.Show();
            obj.Show1();

            int[] Numbers = new int[4];
            Numbers[0] = 11;
            Numbers[1] = 22;
            Numbers[2] = 33;
            Numbers[3] = 44;
            Person.ShowArray(Numbers);

            Console.WriteLine(Person.Check(10, 10));
            Console.WriteLine(Person.Check(10.7, 10.5));

            Example<string> obj2 = new Example<string>("Kavita");

            Console.WriteLine(obj2.GetBox());

            Example1<int> obj1 = new Example1<int>();
            obj1.BigBox = 20;
            Console.WriteLine(obj1.BigBox);


            //Collections
            ArrayList MyList = new ArrayList();
            MyList.Add(10);
            MyList.Add("Kavita");
            MyList.Add(34.34);
            MyList.Add('k');
            Console.WriteLine(MyList.Capacity);

            foreach (object i in MyList)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            MyList.Insert(3, 67.5);   //Value insert

            foreach (object i in MyList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //MyList.Remove(67.5);

            MyList.RemoveAt(2);
            foreach (object i in MyList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //HashTable
            Hashtable ht = new Hashtable() {
                { "id", 123},
                { "name", "Kavita" },
                { "Salary", 100000 }

            };

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key+ ":"+ht[key]);
            }
            
            
            //ht.Add("id", 123);
            //ht.Add("name", "Kavita");
            //ht.Add("Salary", 100000);
            Console.WriteLine(ht["id"]);
            Console.ReadLine();
        }

    }

    //Interfaces vs abstraction

    class Example
    {

    }
    interface i1
    {

    }
    interface i2
    {

    }
    interface MyInterface : i1, i2
    {
        void Show1();
    }
    abstract class MyClass : Example, i1, i2
    {
        public MyClass()
        {
            Console.WriteLine("Abstract class Consturctor !!");
        }
        ~MyClass()
        {
            Console.WriteLine("Abstract class Desturctor !!");
        }
        public abstract void Show();

    }
    class MyClass_1 : MyClass, MyInterface
    {
        public override void Show()
        {
            Console.WriteLine("this is the abstract class method !!");
        }
        public void Show1()
        {
            Console.WriteLine("This is the Interface Method !!");
        }
    }

}

//Generics
namespace Generics_method
{
    namespace Generic_Methods
    {
        class Example<T>
        {

            T box;
            public Example(T b)
            {
                this.box = b;

            }
            public T GetBox()
            {
                return this.box;
            }
        }
        class Example1<T>
        {
            T bigbox;

            public T BigBox
            {
                set { this.bigbox = value; }
                get { return this.bigbox; }
            }

        }

        class Person
        {
            public static bool Check<T>(T a, T b)
            {
                bool c = a.Equals(b);
                return c;
            }
            public static void ShowArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }
    }
   
}
