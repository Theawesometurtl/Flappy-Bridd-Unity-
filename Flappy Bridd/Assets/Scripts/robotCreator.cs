using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCreator : MonoBehaviour
{

    [SerializeField] GameObject bridd;
    [SerializeField] Vector2 spawn;
    public int maxSpeed = 5;
    public float jumpForce;

/*
//duplicating more robots
private void createBridd() {
        GameObject newBridd = Instantiate(bridd);
        newbridd.position = spawn; 
        //Destroy(newpipe, screenTime);
    }

    void Start()
    {
        //creating all robots
        foreach (robot in listOfRobots) {
            createBridd(robot)
        }


        Time.timeScale = 1;
    }
*/
    // Update is called once per frame
    void Update()
    {




    }
}
