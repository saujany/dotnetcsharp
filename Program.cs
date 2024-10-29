

using System;

public class HelloWorld
{
    
    public static string rev(string s)
    {
        char[]str=s.ToCharArray();
        Array.Reverse(str);
        foreach(var ob in str)
        {
        Console.WriteLine(ob);
        }
       string b=new string(str);
        return b;
        }
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the string");
        string str1=Console.ReadLine();
        string str2=rev(str1);
        //if(str1.CompareTo(str2)==0
        if(str1.Equals(str2))
        {
            Console.WriteLine ("it is Anagram");
            
        }
         else
                {
            Console.WriteLine ("it is not Anagram");
            
        }
        Console.ReadLine();
        }
    }
