using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


//외부접근자// 클래스명 ////유니티의 유용한 기능이 들어있는 곳  
public class Study_Component : MonoBehaviour
{

    /// <summary>
    /// 접근제한자   타입    변수이름 
    /// </summary>
    public       GameObject    obj;// = GameObject.Find("Main Camera"); ///1  , 2  , 3  , 4 , 5 , 8
    //private      GameObject    obj;// = GameObject.Find("Main Camera"); /// 2  내부적으로 설정하는경우 public 필요 없음 private으로 하면 인스팩터에서 안나옴 

    //public Transform objTf; ///7



    public Mesh msh;///8
    public Material mat; ///8


    //접근제한자  타입    변수이름 
    //public      string   changName; ///1



    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //타입  함수명 
    void   Start()
    {


        //obj = GameObject.Find("Main Camera");//1    실행하면 Main Camera 오브젝트를 찾아서 할당하는 기능 
        //obj.name = changName;//1                    

        /*
        ////////////////태그를 활용해서 찾겠다  Tag의 이름 
        obj = GameObject.FindGameObjectWithTag("Player"); //2  //인스팩터에서 테그선택에 플레이를 선택한다.  애드로 태그를 추가할 수 있음 

        obj.GetComponent<MeshRenderer>().enabled = false;  /// obj의 MeshRenderer에 접근해서 활성상태로 false로 변경하겠다.(체크박스 없어짐)   5     
        /////GetComponent<데이터타입>()

        obj.SetActive(false);//obj의 GameObject을 활성상태를 false (끄는 기능 )  6   인스팩터에서 큐브왼쪽 체크박스 꺼버린다. 큐브 자체가 거짐 

       // objTf = GameObject.FindGameObjectWithTag("Player").transform;//////////////////////////////////////////////////////////////7
        //objTf.gameObject.SetActive(false);   //////////////////GameObject 대문자는 테이더타입 , gameObject  소문자는 변수          7




        Debug.Log($"<color=#FF0000>이름: {obj.name}");// 게임 오즈젝트 이름   3      <color=#0000FF>색지정 <color=#FF0000>  <color=#00FF00>   <color=#FFFF00> 
        Debug.Log(obj.tag);// 게임오브젝트 태그    3
        Debug.Log(obj.transform.position);// 게임오브젝트transform 컴포넌트 위치   3
        Debug.Log(obj.transform.rotation);//  게임오브젝트transform 컴포넌트 회전  3
        Debug.Log(obj.transform.localScale);// 게임오브젝트transform 컴포넌트 크기  3

        Debug.Log($"메시데이터: {obj.GetComponent<MeshFilter>().mesh}");// MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력 하는기능   4
        Debug.Log($"메시데이터: {obj.GetComponent<MeshRenderer>().material}");// MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력 하는기능  4
        Debug.Log($"메시데이터: {obj.GetComponent<MeshRenderer>().material}");// MeshRenderer 컴포넌트에 접근해서 체크박스 끄기   4
        */



        //////////////////////////////////////////////////////////  8 
        CreatxCube("Cube");
        ////////////////////////////////////////////////////////////8
        



    }

    /// <summary>
    ///  함수는 void형, Type형이 있다 
    ///  void형 :  결과가 없는 타입 
    ///  Type형 :  int정수형,float실수형,bool논리형,string문자열형,여기부터유니티에서만 Inspector에 들어있는 컴포넌트들,GameObject ,Transform,MeshFilter,MeshRenderer     결과값을반환타입이 있는함수 
    ///  GameObject 타입의 함수 예제식으로만들어봄 
    /// public GameObject Find(string pph )
    ///  {
    ///  
    ///     return 결과값;
    ///  }
    ///  
    /// </summary>


    public void CreatxCube(string name ) /////////////8
    {
        //////////////////////////////////////////////////////////  8 
        /// obj = new GameObject();
        ///  obj.name = "Cube";   
        obj = new GameObject(name);//위에를 간단히 줄여서 작업함 

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;//모양 

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;// 면 색 

        obj.AddComponent<BoxCollider>();

        ////////////////////////////////////////////////////////////8
    }





    // Update is called once per frame
    void Update()
    {
        
    }




}
