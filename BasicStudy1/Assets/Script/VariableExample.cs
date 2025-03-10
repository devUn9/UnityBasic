using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;


    void Start()
    {
        Debug.Log("Player Name : " + playerName);
        Debug.Log("Player Score : " + playerScore);
        Debug.Log("Spped : " + speed);
        Debug.Log("is Game Over? : " + isGameOver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
