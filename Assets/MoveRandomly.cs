using UnityEngine;

public class MoveRandomly : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 targetPosition;
    public float moveSpeed = 2f;
    public float changeTargetTime = 3f;

    private float timer;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
        CalculateRandomPosition();
        timer = changeTargetTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        // Move toward the target position
        playerTransform.position = Vector3.MoveTowards(playerTransform.position, targetPosition, moveSpeed * Time.deltaTime);

        // If time to change the target
        if (timer <= 0f)
        {
            CalculateRandomPosition();
            timer = changeTargetTime;
        }
    }

    void CalculateRandomPosition()
    {
        // Choose a random position within a range
        float randomX = Random.Range(-5f, 5f);
        float randomZ = Random.Range(-5f, 5f);
        targetPosition = new Vector3(randomX, playerTransform.position.y, randomZ);
    }
}