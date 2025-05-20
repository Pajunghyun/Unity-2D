using UnityEngine;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

     public float moveSpeed = 3f;// 유니티 툴에서 인스팩터창에 표시되고 수정도 가능하다.
     //private float moveSpeed;// 이거와 float moveSpeed;앞에 private 안써도된다 같음   이건 유니티 인스팩터창에 표시가 안 되고 수정도 안된다. 


    void Start()
    {
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
        // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //
        //this.GetComponent<Rigidbody>().linearVelocity;


        Debug.Log($" 현재 Z축값 : {this.transform.position.z}");





        if ( Input.GetKey(KeyCode.W)) //   GetKeyDown 누르면 한 번  ,    GetKey 키누르고있으면    , GetKeyUp 키놓으면 1번실행 
        {
            SetDirection(0);
            this.transform.position += (Vector3.forward * (moveSpeed * Time.deltaTime)); //   Vector3 위치값 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);// 뱡향값 바꾸기 // 위치값이 돌아감 
            SetDirection(180f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.back * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            SetDirection(-90f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.left * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            SetDirection(90f); //방향바꾸기 하지만 위치값고정 
            this.transform.position += (Vector3.right * (moveSpeed * Time.deltaTime));
        }



    }



    void SetDirection(float yRotation)
    {
        Vector3 currentEuler = transform.eulerAngles;
        currentEuler.y = yRotation;
        transform.eulerAngles = currentEuler;
    }





}
