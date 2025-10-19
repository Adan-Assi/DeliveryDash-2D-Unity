using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool has_package = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Customer") && has_package)
        {
            has_package = false;
            Debug.Log("Delivered!");
            GetComponent<ParticleSystem>().Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !has_package)
        {
            has_package = true;
            Debug.Log("Picked up package!");
            GetComponent<ParticleSystem>().Play();
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
