using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float move_speed = 0.1f;
    [SerializeField] float steer_speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = 0f; // move forward or backward
        float steer = 0f; // steer (rotate) left or right

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }

        // not having this as else if allows for more fluid movement - 2 keys can be pressed at once, steering while moving
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f; // in unity it shows that rotating left is positive
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        //Time.deltaTime: for frame rate independence
        float steer_amount = steer * steer_speed * Time.deltaTime;
        float move_amount = move * move_speed * Time.deltaTime;

        transform.Rotate(0, 0, steer_amount); // rotate in the local space (z axis is up)
        transform.Translate(0, move_amount, 0); // move in the local space (y axis is forward)
    }
}
