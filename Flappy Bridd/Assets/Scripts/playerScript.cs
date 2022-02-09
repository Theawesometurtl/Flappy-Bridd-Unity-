using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 spawn;
    public int maxSpeed = 5;
    public float jumpForce;
    private int score = 0;



    private void gameOver(int score) {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }

    public void scorePlus1() {
        score++;
    }


    void Start()
    {
        rb.position = spawn;
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
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
        if (rb.position.x < -10.5) {
            gameOver(score);
        }
    }
}
