using System.Collections;

namespace RealArrayListDemo;

class Program
{
    static void Main(string[] args)
    {
        ArrayList myArrayList = new ArrayList();
        
        myArrayList.Add(1);
        myArrayList.Add(2.54);
        myArrayList.Add("Hello world");
        
        //myArrayList.Remove(1);   --> Remove
        //myArrayList.RemoveAt(1); --> Remove in terms of index
        //Console.WriteLine(myArrayList[2]);
        
        // Know about how many elements are there.
        // Console.WriteLine(myArrayList.Count);
        
        
        for (int i = 0; i < myArrayList.Count; i++)
        {
            Console.WriteLine(myArrayList[i]);
        }
        
        
        // We can't use it.
        //foreach (int num in myArrayList)
        //{
        //   Console.WriteLine(num);
        //}
        
        Console.ReadKey();
    }
}