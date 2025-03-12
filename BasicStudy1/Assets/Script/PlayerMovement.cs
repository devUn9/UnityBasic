using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public bool isFinish = false;
    public float speed = 5.0f;


    

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.Translate(move * speed * Time.deltaTime);


    }


    //private void ResetPlayerPosition()
    //{
    //    transform.position = new Vector3(0, 0, 0);
    //}


}
