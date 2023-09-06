using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyClass
{
    private int myValue;

    public MyClass(int initialValue)
    {
        myValue = initialValue;
    }

    public void SetValue(int newValue)
    {
        myValue = newValue;
    }
    public int GetValue()
    {
        return myValue;
    }
}

class Program
{
    static void Main()
    {
       
        MyClass myObject = new MyClass(10);

       
        Console.WriteLine("Initial Value: " + myObject.GetValue());

      
        myObject.SetValue(20);

      
        Console.WriteLine("Modified Value: " + myObject.GetValue());
    }
}

