using UnityEngine;

public class ArounTheWorld : MonoBehaviour
{
    public float orbit;
    Vector3 offset;
    public float orbitSpeed;
    Vector3 distance;
    GameObject player;
    public bool reverse;
    void Start()
    {

        orbit = Random.Range(1f, 7f);
        player = GameObject.Find("Player");
        offset = new Vector3(orbit, 0, 0);
        transform.position = player.transform.position + offset;
        
        
        
    }

    void Update()
    {

        if (player != null)
        {
           
            OrbitAround();
            LookRotation();

        }
            distance = transform.position - player.transform.position;
        if (!reverse)
        {
            orbitSpeed = 50 + (distance.magnitude * 10) ;

        }else
        {
            orbitSpeed = -50 - (distance.magnitude * 10);  // go the oposite way 

        }

    }
    public void OrbitAround() 
    {
     
        Quaternion rotation = Quaternion.Euler(0, 0,  orbitSpeed * Time.deltaTime); // Rotate around Z-axis
      
        offset = rotation * offset; 
        gameObject.transform.position = player.transform.position + offset ;
    }
    void LookRotation()
    {
        Vector3 playerDirection = player.transform.position - transform.position;
        float angle = Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;

        gameObject.transform.rotation = Quaternion.Euler(0,0,angle - 90);
    }

}
