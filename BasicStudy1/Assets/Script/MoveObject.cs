using UnityEngine;

public class MoveObject : MonoBehaviour
{
   
    public float speed = 5.0f; // 이동속도

    void Update()
    {
        ////키 입력에 따라 이동
        //float move = Input.GetAxis("Horizontal");
        //// 방향 *  스피드 * 타임델타타임(부드럽게)
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime);


        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        //transform.position += move * speed * Time.deltaTime;

        transform.Translate(move * speed * Time.deltaTime);

    }
}
