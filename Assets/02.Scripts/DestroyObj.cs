using UnityEngine;

public class DestroyObj : MonoBehaviour
{

    public float destroyTime = 3f; //

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Destroy(this.gameObject, destroyTime); // ���θ��� ť��, ĸ��,Sphere 3���� DestroyObj�̽�ũ��Ʈ�� ť��, ĸ��,Sphere ���� ���� �����Ѵ�. �����ϸ� 3���� �� ����� 

    }

    private void OnDestroy()//����Ƽ���� �����ϴ� �Լ� ����Ƽ���� �����ϰ� �����ϸ� �����Ѵ�. 
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");// 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
