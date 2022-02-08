using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 spawn = new Vector2(-7.5f, 3.5f);
    public int maxSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb.position = spawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector2(0f, 5f);
        }

        else if (rb.velocity.y < -maxSpeed) {
            rb.velocity = new Vector2(0f, -maxSpeed);
        }

        if (rb.position.y > 5) {
            rb.position = new Vector2(spawn.x, 5f);
        }
        else if (rb.position.y < -5) {
            rb.position = spawn; 
        }
    }
}
