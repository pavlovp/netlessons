using System;
using System.Collections.Generic;

namespace Lab8_b
{

    public class MyClass
    {

    }
    public static class Extenders
    {
        public static void AddPopulationIfPowerOfTwo<T>(this GeneralCollection<T> collection) where T : MyClass
        {

        }

        public static void Reverse<T>(this MyStack<T> collection)
        {

        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            var gc = new MyStack<MyClass>();
            gc.AddPopulationIfPowerOfTwo();

            int liczba = 3;
            int res = liczba >> 1;
            List<int> tabl = null;

            Console.WriteLine("---------------ETAP I----------------------------\n");

            int[] tab = new int[] { 1, 2, 4, 8, 16, 32, 9, 3, 7, 34, 75, 12, 876, 123, 5 };
            for (int i = 0; i < tab.Length; i++)
            {
                bool isPowerOfTwo = tab[i].CheckIfPowerOfTwo();
                Console.WriteLine("Is: " + tab[i] + " power of two? \t" + isPowerOfTwo.ToString());
            }

            Console.WriteLine("\n---------------ETAP III----------------------------\n");

            MyStack<int> stack = new MyStack<int>();
            Random rnd = new Random(555);
            for (int i = 0; i < tab.Length; i++)
            {
                stack.Add(tab[i]);
                Console.WriteLine(stack.ToString());
            }

            stack.Remove();
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Size is: " + stack.Size);

            stack.Remove();
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Size is: " + stack.Size);

            stack.Remove();
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Size is: " + stack.Size);

            var top = stack.Get();
            Console.WriteLine("top: {0}, Size is: {1} ", top, stack.Size);
            stack.Add(99);
            top = stack.Get();
            Console.WriteLine("top: {0}, Size is: {1} ", top, stack.Size);

            MyStack<int> stack2 = new MyStack<int>();
            for (int i = 0; i < 10; i++)
                stack2.Add(rnd.Next(100));
            Console.WriteLine(stack2.ToString());
            // no exception expected
            while (stack2.Size != 0)
            {
                stack2.Remove();
                Console.WriteLine(stack2.ToString());
            }
            try
            {
                stack2.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception! : " + e.Message);
            }

            try
            {
                top = stack2.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception! : " + e.Message);
            }

            stack2.Add(3);
            stack2.Add(4);
            stack2.Add(5);
            Console.WriteLine(stack2.ToString());

            Console.WriteLine("\n---------------ETAP IV----------------------------\n");

            MyQueue<int> queue = new MyQueue<int>();
            for (int i = 0; i < tab.Length; i++)
            {
                queue.Add(tab[i]);
                Console.WriteLine(queue.ToString());
            }

            Console.WriteLine("\nGetMaxElement");

            MyQueue<int> maxTest = new MyQueue<int>();
            for (int i = 10; i >= 0; i--)
                maxTest.Add(i);

            while (maxTest.Size != 0)
            {
                Console.WriteLine(maxTest.GetMaxElement());
                maxTest.Remove();
            }

            Console.WriteLine();

            var max = queue.GetMaxElement();
            Console.WriteLine(max + "\n");

            Console.WriteLine("Get & Remove");

            queue.Remove();
            Console.WriteLine(queue.ToString());
            Console.WriteLine("Size is: " + queue.Size);

            queue.Remove();
            Console.WriteLine(queue.ToString());
            Console.WriteLine("Size is: " + queue.Size);

            queue.Remove();
            Console.WriteLine(queue.ToString());
            Console.WriteLine("Size is: " + queue.Size);

            top = queue.Get();
            Console.WriteLine("top: {0}, Size is: {1} ", top, queue.Size);
            queue.Add(99);
            top = queue.Get();
            Console.WriteLine("top: {0}, Size is: {1} ", top, queue.Size);

            MyQueue<int> queue2 = new MyQueue<int>();
            for (int i = 0; i < 10; i++)
                queue2.Add(rnd.Next(100));
            Console.WriteLine(queue2.ToString());
            // no exception expected
            while (queue2.Size != 0)
            {
                queue2.Remove();
                Console.WriteLine(queue2.ToString());
            }
            try
            {
                queue2.Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception! : " + e.Message);
            }

            try
            {
                top = queue2.Get();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception! : " + e.Message);
            }

            Console.WriteLine("\n---------------ETAP V----------------------------\n");

            //MyQueue<Species> species = new MyQueue<Species>();
            //species.Add(new Species { Population = 1024, SpeciesName = "Dog" });
            //species.Add(new Species { Population = 256, SpeciesName = "Cat" });
            //species.Add(new Species { Population = 300, SpeciesName = "Cow" });
            //species.Add(new Species { Population = 128, SpeciesName = "Camel" });
            //species.Add(new Species { Population = 1024, SpeciesName = "Dolphin" });
            //species.Add(new Species { Population = 1100, SpeciesName = "Elephant" });

            //Console.WriteLine("Before increasing population:");
            //Console.WriteLine(species.ToString());
            //Console.WriteLine("Max:" + species.GetMaxElement());
            //Console.WriteLine("After increasing population:");
            //species.AddPopulationIfPowerOfTwo(100);
            //Console.WriteLine(species.ToString());
            //Console.WriteLine("Max:" + species.GetMaxElement());
            //species.Remove();
            //Console.WriteLine("Max:" + species.GetMaxElement() + "\n");


            //Console.WriteLine("Before reversing stack:");
            //Console.WriteLine(stack.ToString());
            //stack = stack.ReverseStack();
            //Console.WriteLine("After reversing stack:");
            //Console.WriteLine(stack.ToString());
            //Console.WriteLine("Remove from new stack:");
            //stack.Remove();
            //Console.WriteLine(stack.ToString());
        }


    }
}