using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCreator : MonoBehaviour
{

    [SerializeField] GameObject bridd;
    [SerializeField] Vector2 spawn;
    public int maxSpeed = 5;
    public float jumpForce;
    private int[] neuronsPerColumn = {4, 5, 1};


    void Start()
    {
        Time.timeScale = 1;

        
    }

    // Update is called once per frame
    void Update()
    {




    }
}
