using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 50.0f;
    private Rigidbody playerRb;
    private float zBound = 6;
    // Start is called before the first frame update
    void Start()
    {

        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoviePlayer();
        MoviePlayer(zBound);

    }

    //Move the player and arrow key input
    //POLIMORFISMO
    void MoviePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
    //POLIMORFISMO
    void MoviePlayer(float zbound)
    {

        if (transform.position.z < -zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zbound);

        }
        if (transform.position.z > zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("player has collided with enemy");
        }
 
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Debug.Log("player has collided with Powerup");
            Destroy(other.gameObject);
            
        }
    }


}
