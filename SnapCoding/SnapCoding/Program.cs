using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapCoding
{
    class Program
    {


        static void Main(string[] args)
        {
            var list = new List<int> { 10, 20, 30, 40, 60, 80, 99, 121, 134, 189 };
            var queue = new Queue<int>();
            var stack = new Stack<int>();   

            foreach (var item in list)
            {
                queue.Enqueue(item * item);

                while (queue.Count > 0)
                {
                    var number = queue.Dequeue();
                    stack.Push(number * number * number);
                    // var power = Math.Pow(3, number);

                }

                int total = 0;
                while (stack.Count > 0)
                {
                    total += stack.Pop();
                }

                Console.WriteLine($"total is {0}", total);
            }


           
           
            
            Console.ReadLine();
        }

        



    }

    public class coding
    {
        public List<int> listdigits = new List<int>();
        public Queue<int> qt = new Queue<int>();
        public Stack<int> stk = new Stack<int>();
        int[] arrayDigits = { 10, 20, 30, 40, 60, 80, 99, 121, 134, 189 };

        public List<int> ListingDigits() 
        {
            //listdigits.Add(arrayDigits[0]);
            //listdigits.Add(arrayDigits[1]);
            //listdigits.Add(arrayDigits[2]);
            //listdigits.Add(arrayDigits[3]);
            //listdigits.Add(arrayDigits[4]);
            //listdigits.Add(arrayDigits[5]);
            //listdigits.Add(arrayDigits[6]);
            //listdigits.Add(arrayDigits[7]);
            //listdigits.Add(arrayDigits[8]);
            //listdigits.Add(arrayDigits[9]);

            for (int i = 0; i < arrayDigits.Length; i++)
            {
                listdigits.Add(arrayDigits[i * i]);

            }

            return listdigits;
        }

        public Queue<int> QueueCubeDigits() 
        {
           

            return qt;
        }


           
       
    } 
}
