using System;
using System.Collections;

class MainClass { 


    //암시적 형식 지역 변수 var
    //여러 자료형이 포함된 ArrayList클래스 등에 유용
    //반드시 지역변수로 선언, 초깃값 지정 필요. 반복문으로 출력할 item의 자료형을 var을 사용해 컴파일러에 위임하면 해당 자료형으로 자동 변환
    public static void Main(string[] args)
    { 
    ArrayList al = new ArrayList();
        al.Add(1);
        al.Add("hi");
        al.Add(true);

        foreach(var item in al)
        {
            Console.WriteLine(item);
        }
    
    }

              }
