using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch we collided!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What did I just pass through?");
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
