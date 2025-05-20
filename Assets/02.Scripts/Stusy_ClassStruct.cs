using UnityEngine;






public class Study_Class
{
    public int number;
    public Study_Class(int number) // 클래스 참조형  object, string 이둘도 참조타입  ,   생성자 : 생성될 때 실행되는 함수  , number : 매개변수 
    {
        this.number = number;
    }
}
public struct Study_Struct // 구조체 각자가 변수이다.
{
        public int number;
        public Study_Struct(int number)
        {
            this.number = number;
        }
 }



public class Stusy_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int number1, number2;


    void Start()
    {
        

        Debug.Log(" 클래스 ------------------------------"); // 클래스로만들면 값을 갖고있음 c1,c2는 클래스 변수를 참조하여 보여주는거임 c1.number = 100; 이렇게 하면 c2도 바뀜
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($" c1.number : {c1.number} / c2 : {c2.number}");
        c1.number = 100;
        Debug.Log($" c1.number : {c1.number} / c2 : {c2.number}");

        Debug.Log(" 구조체 ------------------------------"); // 각각 변수이다.
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($" s1 : {s1.number} / s2 : {s2.number}");
        s1.number = 100;
        Debug.Log($" s1 : {s1.number} / s2 : {s2.number}");


        Study_Struct[] sArray = new Study_Struct[100];//배열로 구조체 100개 만들기 

        number1 = AddMinus(0, 100, 37);
        number2 = AddMinus(1, 100, 37);
        Debug.Log($" number1 : {number1} ,  number2 : {number2}");
    }




    // Update is called once per frame
    void Update()
    {


    }


    int AddMinus( int type , int num1 , int num2 ) //함수 만들기  더하기, 빼기 
    {
        int number;

        if  (type == 0 ) // 더하다
        {
            number = num1 + num2;
        } else         /// 빼다 
        {
            number = num1 - num2;
        }

        return number;
    }
        


}
