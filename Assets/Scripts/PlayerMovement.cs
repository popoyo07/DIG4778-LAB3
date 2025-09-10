using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {
        moveSpeed = 10f; 
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Move right");
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Move left");
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Move right");
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Move left");
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }
}
