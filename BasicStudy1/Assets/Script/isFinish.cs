using UnityEngine;

public class isFinish : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {


        // 충돌한 오브젝트가 특정 오브젝트일 경우 처리
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("충돌감지");
            transform.position = new Vector3(0, 0, 0);
        }

       
    }
}
