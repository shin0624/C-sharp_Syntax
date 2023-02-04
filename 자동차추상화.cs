using System;

class Car
{
    public string Name = null;
    public int Vel = 0;
    public string Gear = null;

    public Car(string name, string gear) {

        Name = name;
        Gear = gear;
       

        Console.WriteLine("자동차의 이름은 " + Name + "입니다.\n");
        Console.WriteLine("자동차가 " + Gear + "합니다.\n");
        
        
    }

    public  Car(int vel, string gear)
    {
        Vel = vel;
        Gear = gear;
        Console.WriteLine("자동차의 속도는 시속" + Vel + "입니다.\n");
        Console.WriteLine("자동차가 " + Gear + "합니다.\n");

    }
    
    }

class MainClass
{
    public static void Main(string[] args)
    {
        Car sonata = new Car("소나타","전진");
        Car velgear = new Car(80, "후진");

        Console.WriteLine("자동차가 멈춥니다.\n");
    }
}

