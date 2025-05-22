using UnityEngine;
//using static UnityEngine.GraphicsBuffer;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

     public float moveSpeed = 3f;// 유니티 툴에서 인스팩터창에 표시되고 수정도 가능하다.
                                 //private float moveSpeed;// 이거와 float moveSpeed;앞에 private 안써도된다 같음   이건 유니티 인스팩터창에 표시가 안 되고 수정도 안된다. 

    //public Transform target;     // 따라갈 대상 (플레이어)
    //public Vector3 offset = new Vector3(0, 5, -10); // 위치 오프셋 (뒤에서 위로 보기)



    void Start()
    {

        //transform.position = target.position + offset;
        //transform.rotation = Quaternion.Euler(30f, 0f, 0f); // 카메라 각도 고정


        // Debug.Log("스타트함수 Log 실행");
        //Debug.LogWarning("스타트함수 LogWarning 실행");
        // Debug.LogError("스타트함수 LogError 실행");

        ////// 현재위피 /////////////////현재위치         +    (0,0,1)   x,y,z    this는 어몽어스임 
        //this.transform.position = this.transform.position + Vector3.forward;

        Debug.Log( $" 현재 Z축값 : {this.transform.position.z}" );

        //moveSpeed = 0.01f;

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("업데이트함수 실행");
        ////////////어몽오스                 어몽어스            앞쪽->(0,0,1)  속도조절변수          Vector3 위치값 
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
       // this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //Debug.Log($" 현재 Z축값 : {this.transform.position.z}");




        /*

        if ( Input.GetKey(KeyCode.W)) //   GetKeyDown 누르면 한 번  ,    GetKey 키누르고있으면    , GetKeyUp 키놓으면 1번실행 
        {
            //SetDirection(0);
            this.transform.position += (Vector3.forward * (moveSpeed * Time.deltaTime)); //   Vector3 위치값 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);// 뱡향값 바꾸기 // 위치값이 돌아감 
           // SetDirection(180f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.back * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //SetDirection(-90f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.left * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //SetDirection(90f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.right * (moveSpeed * Time.deltaTime));
        }
        */

        

        /////////////////////////////////////////////////////////////////////////////2   위에 움직임을 아래처럼 바꾼다. 
        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        float h = Input.GetAxis("Horizontal");//h = x값  /////////////// 부드럽게 움직일때 
        float v = Input.GetAxis("Vertical"); //v = z 값

       // float h = Input.GetAxisRaw("Horizontal");//h = x값  //////////// 딱 떨어지는값 1,0 딱 떨어지는값 
       // float v = Input.GetAxisRaw("Vertical"); //v = z 값

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
        ///////////////////////////////////////////////////////////////////////////////
        



    }



    void SetDirection(float yRotation)
    {
        Vector3 currentEuler = transform.eulerAngles;
        currentEuler.y = yRotation;
        transform.eulerAngles = currentEuler;
    }





}
