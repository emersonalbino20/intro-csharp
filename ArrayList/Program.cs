using System.Collections;

namespace ArrayListExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);
            myArrayList2.Add(1);
            myArrayList2.Add(2);
            myArrayList2.Add("Hello World");
            myArrayList2.Add(12.3);
            myArrayList2.Add(12);
            myArrayList2.Add(42);
            
            // delete  element with specific value from the arrayList
            myArrayList2.Remove(1);
            
            // delete element at specific position
            myArrayList2.RemoveAt(4);

            double sum = 0;
            Console.WriteLine(myArrayList2.Count);
            foreach(object obj in myArrayList2)
            {
                if (obj is int)
                    sum += Convert.ToDouble(obj);
                else if (obj is double)
                    sum += (double)obj;
                else
                    Console.WriteLine(obj);
            }
            Console.WriteLine(sum);
        }
    }
}