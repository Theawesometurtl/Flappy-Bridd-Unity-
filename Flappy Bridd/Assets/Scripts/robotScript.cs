using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotScript : MonoBehaviour
{
    private int amountOfInputNodes = 5;
    private double nodeValue;
    private double robotBrainColumn1();
    private double robotBrainColumn2();
    private double robotBrainColumn3();
    [SerializeField] Rigidbody2D rb;




//calculating a column of nodes with their respective weights
private calculatingWeights() {
    //does this to every node in the column
    foreach (y in nodesList) {
        //resetting weightnum
        weightNum = 0;
        //repeats until it has gone through and calculated with every weight
        while (true)
        {
            weightNum ++;
            weight = robotBrain[weightNum];
            connectionsList.append(nodesList[y] * weight);
            
        }
        

    }
    //I should wipe the previous nodes list clean
    nodesList.clear();

    //this will give us the amount of nodes we will need
    private int amountOfNodes = weightNum;

    //this variable is to remember what section of the list we're on
    private int connectionNum = 0;

    //this will loop and calculate every node's value
    for (int i = 0; i < amountOfNodes; i++)
    {
        nodeValue = 0
       

        //this loops for the amount of connections per node
        for (int i = 0; i < length(connectionsList) / amountOfNodes; i++)
        {
            //adding all the connections together for the node
            nodeValue += connectionsList[connectionNum]

            //getting next connection
            connectionNum++;
            
        }
        //adding the node to the nodesList. I SHOULD ALSO CALCULATE THE NODE'S WEIGHT HERE IF I DECIDDE TO DO THAT
        nodesList.append(nodeValue)
        
    }

    //FINISHED!!!
    return(nodesList());
    
}

    void Start()
    {
        
    }


    void Update()
    {

    }
}
