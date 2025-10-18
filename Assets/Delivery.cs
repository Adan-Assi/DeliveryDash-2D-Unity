using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Customer"))
        {
            Debug.Log("Delivered!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("Picked up package!");
            Destroy(collision.gameObject);
        }
    }

    /* the next 2 methods are not necessary here: */

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
