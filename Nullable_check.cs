using System;

/*class MainClass
{
    public static void Main(string[] args)
    {
        int? var1 = 10;// 자료형 뒤에 ? 기호를 붙이면 기본 자료형에도 null값을 허용하도록 할 수 있음
        int? var2 = null;
        //산술연산에서 피연산자 중 하나가 null이면 결과는 null
        //비교연산 시 null==null을 제외하고는 모두 false
        //cw로 null값 출력 시 아무 값도 출력되지 않으므로, 줄바꿈만 함

        Console.WriteLine(var1+var2);// null
        Console.WriteLine(var1 * var2);//null
        Console.WriteLine(var1 == var2);//false
        Console.WriteLine(var1 >var2);//false
        Console.WriteLine(var2 == var2);//true
       
    }
}*/
class MainClass
{
    //디버깅 목적으로 객체가 null값을 허용하는지를 확인해야 할 때-->GetUnderlyingType()메서드로 Nullable형식 판단(system네임스페이스 내 존재)
    public static void Main(string[] args)
    {
        int? var1 = 10;
        int var2 = 15;
        Console.WriteLine(IsOfNullableType(var1));
        Console.WriteLine(IsOfNullableType(var2));
    }

    static bool IsOfNullableType<T>(T o)
    {
        var type = typeof(T);
        return Nullable.GetUnderlyingType(type) != null;
         
    }
}
