using UnityEngine;

public class isFinish : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {


        // �浹�� ������Ʈ�� Ư�� ������Ʈ�� ��� ó��
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("�浹����");
            transform.position = new Vector3(0, 0, 0);
        }

       
    }
}
