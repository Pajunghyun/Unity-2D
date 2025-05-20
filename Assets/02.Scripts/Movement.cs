using UnityEngine;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

     public float moveSpeed = 3f;// ����Ƽ ������ �ν�����â�� ǥ�õǰ� ������ �����ϴ�.
     //private float moveSpeed;// �̰ſ� float moveSpeed;�տ� private �Ƚᵵ�ȴ� ����   �̰� ����Ƽ �ν�����â�� ǥ�ð� �� �ǰ� ������ �ȵȴ�. 


    void Start()
    {
        // Debug.Log("��ŸƮ�Լ� Log ����");
        //Debug.LogWarning("��ŸƮ�Լ� LogWarning ����");
        // Debug.LogError("��ŸƮ�Լ� LogError ����");

        ////// �������� /////////////////������ġ         +    (0,0,1)   x,y,z    this�� ������ 
        //this.transform.position = this.transform.position + Vector3.forward;

        Debug.Log( $" ���� Z�ప : {this.transform.position.z}" );

        //moveSpeed = 0.01f;

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("������Ʈ�Լ� ����");
        //////////�������                 ����            ����->(0,0,1)  �ӵ���������
       // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //
        //this.GetComponent<Rigidbody>().linearVelocity;


        Debug.Log($" ���� Z�ప : {this.transform.position.z}");





        if ( Input.GetKey(KeyCode.W)) //   GetKeyDown ������ �� ��  ,    GetKey Ű������������    , GetKeyUp Ű������ 1������ 
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            this.transform.position += (Vector3.forward * (moveSpeed * Time.deltaTime)); // 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            this.transform.position += (Vector3.back * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            this.transform.position += (Vector3.left * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            this.transform.position += (Vector3.right * (moveSpeed * Time.deltaTime));
        }



    }





}
