using UnityEngine;






public class Study_Class
{
    public int number;
    public Study_Class(int number) // Ŭ���� ������  object, string �̵ѵ� ����Ÿ��  ,   ������ : ������ �� ����Ǵ� �Լ�  , number : �Ű����� 
    {
        this.number = number;
    }
}
public struct Study_Struct // ����ü ���ڰ� �����̴�.
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
        

        Debug.Log(" Ŭ���� ------------------------------"); // Ŭ�����θ���� ���� �������� c1,c2�� Ŭ���� ������ �����Ͽ� �����ִ°��� c1.number = 100; �̷��� �ϸ� c2�� �ٲ�
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($" c1.number : {c1.number} / c2 : {c2.number}");
        c1.number = 100;
        Debug.Log($" c1.number : {c1.number} / c2 : {c2.number}");

        Debug.Log(" ����ü ------------------------------"); // ���� �����̴�.
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($" s1 : {s1.number} / s2 : {s2.number}");
        s1.number = 100;
        Debug.Log($" s1 : {s1.number} / s2 : {s2.number}");


        Study_Struct[] sArray = new Study_Struct[100];//�迭�� ����ü 100�� ����� 

        number1 = AddMinus(0, 100, 37);
        number2 = AddMinus(1, 100, 37);
        Debug.Log($" number1 : {number1} ,  number2 : {number2}");
    }




    // Update is called once per frame
    void Update()
    {


    }


    int AddMinus( int type , int num1 , int num2 ) //�Լ� �����  ���ϱ�, ���� 
    {
        int number;

        if  (type == 0 ) // ���ϴ�
        {
            number = num1 + num2;
        } else         /// ���� 
        {
            number = num1 - num2;
        }

        return number;
    }
        


}
