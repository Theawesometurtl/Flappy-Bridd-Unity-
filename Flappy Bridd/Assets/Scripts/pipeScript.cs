using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    [SerializeField] Transform pipe;
    public float velocity;

    

    void Update()
    {
        pipe.position = new Vector2(pipe.position.x - (velocity * Time.deltaTime), pipe.position.y);

    }
}
