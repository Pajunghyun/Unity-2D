using UnityEngine;
//using static UnityEngine.GraphicsBuffer;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

     public float moveSpeed = 3f;// ����Ƽ ������ �ν�����â�� ǥ�õǰ� ������ �����ϴ�.
                                 //private float moveSpeed;// �̰ſ� float moveSpeed;�տ� private �Ƚᵵ�ȴ� ����   �̰� ����Ƽ �ν�����â�� ǥ�ð� �� �ǰ� ������ �ȵȴ�. 

    //public Transform target;     // ���� ��� (�÷��̾�)
    //public Vector3 offset = new Vector3(0, 5, -10); // ��ġ ������ (�ڿ��� ���� ����)



    void Start()
    {

        //transform.position = target.position + offset;
        //transform.rotation = Quaternion.Euler(30f, 0f, 0f); // ī�޶� ���� ����


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
        ////////////�������                 ����            ����->(0,0,1)  �ӵ���������          Vector3 ��ġ�� 
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
       // this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //Debug.Log($" ���� Z�ప : {this.transform.position.z}");




        /*

        if ( Input.GetKey(KeyCode.W)) //   GetKeyDown ������ �� ��  ,    GetKey Ű������������    , GetKeyUp Ű������ 1������ 
        {
            //SetDirection(0);
            this.transform.position += (Vector3.forward * (moveSpeed * Time.deltaTime)); //   Vector3 ��ġ�� 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);// ���Ⱚ �ٲٱ� // ��ġ���� ���ư� 
           // SetDirection(180f); //����ٲٱ� ������ ��ġ������ 
            this.transform.position += (Vector3.back * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //SetDirection(-90f); //����ٲٱ� ������ ��ġ������ 
            this.transform.position += (Vector3.left * (moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //SetDirection(90f); //����ٲٱ� ������ ��ġ������ 
            this.transform.position += (Vector3.right * (moveSpeed * Time.deltaTime));
        }
        */

        

        /////////////////////////////////////////////////////////////////////////////2   ���� �������� �Ʒ�ó�� �ٲ۴�. 
        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����

        float h = Input.GetAxis("Horizontal");//h = x��  /////////////// �ε巴�� �����϶� 
        float v = Input.GetAxis("Vertical"); //v = z ��

       // float h = Input.GetAxisRaw("Horizontal");//h = x��  //////////// �� �������°� 1,0 �� �������°� 
       // float v = Input.GetAxisRaw("Vertical"); //v = z ��

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"���� �Է� : {dir}");

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
