using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotScript : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;


/*

//calculating a column of nodes with their respective weights
private int[] calculatingWeights() {
    //does this to every node in the column
    foreach (int y in nodesList()) {
        //resetting weightnum
        weightNum = 0;
        //repeats until it has gone through and calculated with every weight
        while (true)
        {
            weightNum ++;
            weight = robotBrain[weightNum];
            connectionsList.Add(nodesList[y] * weight);
            
        }
        

    }
    //I should wipe the previous nodes list clean
    int[] nodesList = new int[];

    //this will give us the amount of nodes we will need
    private int amountOfNodes = weightNum;

    //this variable is to remember what section of the list we're on
    private int connectionNum = 0;
    int nodeValue;
    int connectionNum;

    //this will loop and calculate every node's value
    for (int i = 0; i < amountOfNodes; i++)
    {
        nodeValue = 0;
       

        //this loops for the amount of connections per node
        for (int i = 0; i < connectionsList.Length / amountOfNodes; i++)
        {
            //adding all the connections together for the node
            nodeValue += connectionsList[connectionNum];

            //getting next connection
            connectionNum++;
            
        }
        //adding the node to the nodesList. I SHOULD ALSO CALCULATE THE NODE'S WEIGHT HERE IF I DECIDDE TO DO THAT
        nodesList.Add(nodeValue);
        
    }

    //FINISHED!!!
    return(nodesList);
    
}
*/

    void Update()
    {
        /*
        nodesList.Add(rb.position.y);
        nodesList.Add(pipeRb.position.x);
        nodesList.Add(pipeRb.position.y);
        nodesList.Add(rb.velocity.y);


        //if the jump node is above 0, then it jumps
        if (nodesList[0] > 0) {
            rb.velocity = new Vector2(rb.velocity.x, 1f);
        }

        */

    }
}
