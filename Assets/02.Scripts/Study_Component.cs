using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


//�ܺ�������// Ŭ������ ////����Ƽ�� ������ ����� ����ִ� ��  
public class Study_Component : MonoBehaviour
{

    /// <summary>
    /// ����������   Ÿ��    �����̸� 
    /// </summary>
    public       GameObject    obj;// = GameObject.Find("Main Camera"); ///1  , 2  , 3  , 4 , 5 , 8
    //private      GameObject    obj;// = GameObject.Find("Main Camera"); /// 2  ���������� �����ϴ°�� public �ʿ� ���� private���� �ϸ� �ν����Ϳ��� �ȳ��� 

    //public Transform objTf; ///7



    public Mesh msh;///8
    public Material mat; ///8


    //����������  Ÿ��    �����̸� 
    //public      string   changName; ///1



    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Ÿ��  �Լ��� 
    void   Start()
    {


        //obj = GameObject.Find("Main Camera");//1    �����ϸ� Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ��� 
        //obj.name = changName;//1                    

        /*
        ////////////////�±׸� Ȱ���ؼ� ã�ڴ�  Tag�� �̸� 
        obj = GameObject.FindGameObjectWithTag("Player"); //2  //�ν����Ϳ��� �ױ׼��ÿ� �÷��̸� �����Ѵ�.  �ֵ�� �±׸� �߰��� �� ���� 

        obj.GetComponent<MeshRenderer>().enabled = false;  /// obj�� MeshRenderer�� �����ؼ� Ȱ�����·� false�� �����ϰڴ�.(üũ�ڽ� ������)   5     
        /////GetComponent<������Ÿ��>()

        obj.SetActive(false);//obj�� GameObject�� Ȱ�����¸� false (���� ��� )  6   �ν����Ϳ��� ť����� üũ�ڽ� ��������. ť�� ��ü�� ���� 

       // objTf = GameObject.FindGameObjectWithTag("Player").transform;//////////////////////////////////////////////////////////////7
        //objTf.gameObject.SetActive(false);   //////////////////GameObject �빮�ڴ� ���̴�Ÿ�� , gameObject  �ҹ��ڴ� ����          7




        Debug.Log($"<color=#FF0000>�̸�: {obj.name}");// ���� ������Ʈ �̸�   3      <color=#0000FF>������ <color=#FF0000>  <color=#00FF00>   <color=#FFFF00> 
        Debug.Log(obj.tag);// ���ӿ�����Ʈ �±�    3
        Debug.Log(obj.transform.position);// ���ӿ�����Ʈtransform ������Ʈ ��ġ   3
        Debug.Log(obj.transform.rotation);//  ���ӿ�����Ʈtransform ������Ʈ ȸ��  3
        Debug.Log(obj.transform.localScale);// ���ӿ�����Ʈtransform ������Ʈ ũ��  3

        Debug.Log($"�޽õ�����: {obj.GetComponent<MeshFilter>().mesh}");// MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� ��� �ϴ±��   4
        Debug.Log($"�޽õ�����: {obj.GetComponent<MeshRenderer>().material}");// MeshRenderer ������Ʈ�� �����ؼ� material�� Log �޼����� ��� �ϴ±��  4
        Debug.Log($"�޽õ�����: {obj.GetComponent<MeshRenderer>().material}");// MeshRenderer ������Ʈ�� �����ؼ� üũ�ڽ� ����   4
        */



        //////////////////////////////////////////////////////////  8 
        CreatxCube("Cube");
        ////////////////////////////////////////////////////////////8
        



    }

    /// <summary>
    ///  �Լ��� void��, Type���� �ִ� 
    ///  void�� :  ����� ���� Ÿ�� 
    ///  Type�� :  int������,float�Ǽ���,bool����,string���ڿ���,�����������Ƽ������ Inspector�� ����ִ� ������Ʈ��,GameObject ,Transform,MeshFilter,MeshRenderer     ���������ȯŸ���� �ִ��Լ� 
    ///  GameObject Ÿ���� �Լ� ���������θ��� 
    /// public GameObject Find(string pph )
    ///  {
    ///  
    ///     return �����;
    ///  }
    ///  
    /// </summary>


    public void CreatxCube(string name ) /////////////8
    {
        //////////////////////////////////////////////////////////  8 
        /// obj = new GameObject();
        ///  obj.name = "Cube";   
        obj = new GameObject(name);//������ ������ �ٿ��� �۾��� 

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;//��� 

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;// �� �� 

        obj.AddComponent<BoxCollider>();

        ////////////////////////////////////////////////////////////8
    }





    // Update is called once per frame
    void Update()
    {
        
    }




}
