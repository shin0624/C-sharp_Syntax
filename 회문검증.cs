using System;
using System.Collections;

class MainClass
{
    public static void Main(string[] args)
    {
        bool result = true;
        Console.WriteLine("단어를 영문으로 입력하세요 : ");
        string word = Console.ReadLine();
         
        Queue qu = new Queue();
        Stack st = new Stack();

        foreach (char item in word)
        {
            st.Push(item);
            qu.Enqueue(item);
        }



        while (qu.Count > 0)
        {
            char A = (char)qu.Dequeue();
            char B = (char)st.Pop();

            if (A != B)
            {
                result = false;
                break;
            }

        }
        if (result)
            Console.WriteLine("참(True)");
        else
            Console.WriteLine("거짓(False)");
       
    }
    
}