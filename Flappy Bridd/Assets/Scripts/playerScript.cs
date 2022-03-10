using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 spawn;
    public int maxSpeed = 5;
    public float jumpForce;


    void Start()
    {
        rb.position = spawn;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector2(0f, jumpForce);
        }

        else if (rb.velocity.y < -maxSpeed) {
            rb.velocity = new Vector2(0f, -maxSpeed);
        }

        if (rb.position.y > 5) {
            rb.position = new Vector2(rb.position.x, 5f);
        }
    }
}
