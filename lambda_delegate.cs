using System;

/*람다식 기본형
// 매개변수 => 식
//매개변수A, 매개변수 B =>{코드블록}
delegate int Add(int a, int b);

class MainClass { 
public static void Main(string[] args)
    {
        Add add = (a, b) => a + b;
        Console.WriteLine(add(1,2));
    }
}
*/
class MainClass { 
    //Func대리자 : 반환값이 있을 떄 사용
    // Func 대리자 + 람다식 --> Func <매개변수 자료형, 반환형> 호출식 이름 = 매개변수 => 식
public static void Main(string[] args)
{
    Func<int, int> square = x => x * x;
    Console.WriteLine(square(5));

        
        //Action 대리자 : 반환값이 없을 때 사용
        //Action 대리자 + 람다식--> Action <매개변수 자료형> 호출식 이름 = 매개변수 =>{코드 블록}
    Action<string> greet = name =>
        {
            string greeting = "hello" + name;
            Console.WriteLine(greeting);
        };
        greet("world");






}




}

