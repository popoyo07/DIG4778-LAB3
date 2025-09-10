using UnityEngine;

public class ArounTheWorld : MonoBehaviour
{
    public int orbit;
     Vector3 offset;
    public float rotationSpeed;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        offset = new Vector3(orbit, 0, 0);
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
           
            Rotation();
                }
    }
    public void Rotation() {
       
       // offset = new Vector3(orbit, 0, 0);
       TheLookAtRotation();
        Quaternion rotation = Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime); // Rotate around Z-axis
        offset = rotation * offset; 
        gameObject.transform.position = player.transform.position + offset ;
    }
    void TheLookAtRotation()
    {
        Vector3 playerDirection = player.transform.position - transform.position;
        float angle = Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;
    
        Quaternion rotation = Quaternion.Euler(0,0, -angle);
        gameObject.transform.rotation = rotation;
    }

}
