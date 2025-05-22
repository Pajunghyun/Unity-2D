



using UnityEngine;
//using static UnityEngine.RuleTile.TilingRuleOutput;

public class StudyGameObject : MonoBehaviour
{


    public GameObject prefab;// 생성             1,
    public Vector3 pos;//     0,0,0  위치        1,  
    public Quaternion rot;// 0,0,0,1   회전      1,

    public GameObject destroyObj; //생성한거 파괴하기  2  , 3

   
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("생성되었습니다.");// 
        CreateAmongus(); // 어몽어스 만든거 추가해서 넣고 움직이기 1

        //Destroy(destroyObj , 3f ); //3초뒤에 바닥 파괴한다.   게임오브젝트(Spawner) 인스팩터에 destroyObj 오른 칸에 바닥만든거(Plane) 드래그해서 넣어준다.   2
        ////////////파괴대상   지연시간



    }





    public void CreateAmongus()
    {
        // 3차원은 위치가 Vector3 x,t,z    2차원 x,y      1차원  x 
        //Instantiate(prefab);// GameObject를 생성하는기능 0,0,0                               1.    작업 설명: 게임오브젝트만들고 인스팩터에서 스크립트 넣고 Prefab에 오몽어스 드래그로 넣고 실행하면 어몽어스가 만들어짐 
        //GameObject obj = Instantiate(prefab, pos, rot);// GameObject를 생성 위치,회전추가    1.    작업 설명: 게임오브젝트만들고 인스팩터에서 스크립트 넣고 Prefab에 오몽어스 드래그로 넣고 실행하면 어몽어스가 만들어짐 



        ///////////////////////////////////////////////////////////////////////////////////////3 , 어몽어스 만들때 각각 오브젝트들 자식구조에서 첨과 끝 구한다. 
        /*
         GameObject obj = Instantiate(prefab);// GameObject를 생성                              
         obj.name = "어몽어스캐릭터"; ////        
         Debug.Log($"캐릭터의 자식 오브젝트의 수:{obj.transform.childCount}");// 
         Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름:{obj.transform.GetChild(0).name}");// 
         Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름:{obj.transform.GetChild(obj.transform.childCount -1).name}");// 
        */
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 3
        /// 위에 3번을 아래 처럼 바꿀수 있다. 
        GameObject obj = Instantiate(prefab);// GameObject를 생성                              
        obj.name = "어몽어스캐릭터"; ////        
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        Debug.Log($"캐릭터의 자식 오브젝트의 수:{count}");// 
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름:{objTf.GetChild(0).name}");// 
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름:{objTf.GetChild(count - 1).name}");// 
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

       
    }

 




    private void OnDestroy()//유니티에서 제공하는 함수 유니티에서 실행하고 종료하면 실행한다. 
    {
        Debug.Log("파괴되었습니다.");// 
    }




    // Update is called once per frame
    void Update()
    {
        
    }





}
