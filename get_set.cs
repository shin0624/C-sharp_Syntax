using System;

class Human
{
    public string name { get; set; }//게터 세터 자동구현
    public int age { get; set; }   
}

class MainClass
{
    public static void Main(string[] args)
    {
        Human h1 = new Human();
        h1.name = "ab";
        h1.age = 8;
        Console.WriteLine(h1.name);
        Console.WriteLine(h1.age);
    }
}