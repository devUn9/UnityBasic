using UnityEngine;

public class LoopExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ////for�� : 1���� 10���� ���
        //for (int i =1; i<=10; i++)
        //{
        //    Debug.Log("Count : " + i);
        //}


        //while�� : ������ ���ϋ� ����
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log("While COunt :" + counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
