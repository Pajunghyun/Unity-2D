



using UnityEngine;
//using static UnityEngine.RuleTile.TilingRuleOutput;

public class StudyGameObject : MonoBehaviour
{


    public GameObject prefab;// ����             1,
    public Vector3 pos;//     0,0,0  ��ġ        1,  
    public Quaternion rot;// 0,0,0,1   ȸ��      1,

    public GameObject destroyObj; //�����Ѱ� �ı��ϱ�  2  , 3

   
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("�����Ǿ����ϴ�.");// 
        CreateAmongus(); // ���� ����� �߰��ؼ� �ְ� �����̱� 1

        //Destroy(destroyObj , 3f ); //3�ʵڿ� �ٴ� �ı��Ѵ�.   ���ӿ�����Ʈ(Spawner) �ν����Ϳ� destroyObj ���� ĭ�� �ٴڸ����(Plane) �巡���ؼ� �־��ش�.   2
        ////////////�ı����   �����ð�



    }





    public void CreateAmongus()
    {
        // 3������ ��ġ�� Vector3 x,t,z    2���� x,y      1����  x 
        //Instantiate(prefab);// GameObject�� �����ϴ±�� 0,0,0                               1.    �۾� ����: ���ӿ�����Ʈ����� �ν����Ϳ��� ��ũ��Ʈ �ְ� Prefab�� ����� �巡�׷� �ְ� �����ϸ� ������ ������� 
        //GameObject obj = Instantiate(prefab, pos, rot);// GameObject�� ���� ��ġ,ȸ���߰�    1.    �۾� ����: ���ӿ�����Ʈ����� �ν����Ϳ��� ��ũ��Ʈ �ְ� Prefab�� ����� �巡�׷� �ְ� �����ϸ� ������ ������� 



        ///////////////////////////////////////////////////////////////////////////////////////3 , ���� ���鶧 ���� ������Ʈ�� �ڽı������� ÷�� �� ���Ѵ�. 
        /*
         GameObject obj = Instantiate(prefab);// GameObject�� ����                              
         obj.name = "����ĳ����"; ////        
         Debug.Log($"ĳ������ �ڽ� ������Ʈ�� ��:{obj.transform.childCount}");// 
         Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸�:{obj.transform.GetChild(0).name}");// 
         Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸�:{obj.transform.GetChild(obj.transform.childCount -1).name}");// 
        */
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 3
        /// ���� 3���� �Ʒ� ó�� �ٲܼ� �ִ�. 
        GameObject obj = Instantiate(prefab);// GameObject�� ����                              
        obj.name = "����ĳ����"; ////        
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� ��:{count}");// 
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸�:{objTf.GetChild(0).name}");// 
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸�:{objTf.GetChild(count - 1).name}");// 
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

       
    }

 




    private void OnDestroy()//����Ƽ���� �����ϴ� �Լ� ����Ƽ���� �����ϰ� �����ϸ� �����Ѵ�. 
    {
        Debug.Log("�ı��Ǿ����ϴ�.");// 
    }




    // Update is called once per frame
    void Update()
    {
        
    }





}
