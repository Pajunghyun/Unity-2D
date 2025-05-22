using UnityEngine;

public class DestroyObj : MonoBehaviour
{

    public float destroyTime = 3f; //

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Destroy(this.gameObject, destroyTime); // 새로만드 큐브, 캡슐,Sphere 3개를 DestroyObj이스크립트를 큐브, 캡슐,Sphere 여기 각각 연결한다. 실행하면 3초후 다 사라짐 

    }

    private void OnDestroy()//유니티에서 제공하는 함수 유니티에서 실행하고 종료하면 실행한다. 
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");// 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
