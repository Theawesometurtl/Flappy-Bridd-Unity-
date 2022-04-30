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



    public class robotBrain
    {
        public List<column> columnList = new List<column>();
    }

    public class column 
    {
        public List<neuron> neuronList = new List<neuron>();
    }
        
    public class neuron 
    {
        public float neuronWeight = 0f;
        public List<float> connectionWeights = new List<float>();
    }





    public robotBrain fillBrain(int[] neuronsPerColumn) {
        robotBrain robot = new robotBrain();
<<<<<<< HEAD
        Debug.Log("start");
        
=======
>>>>>>> parent of 923f4ed (finished creating the robot brains, side error, the game doesn't run)
        //columns
        for (int columns = 0; columns < neuronsPerColumn.Length; columns++)
        {
<<<<<<< HEAD
            Debug.Log("column");
            //for the columns in column list add column
=======
>>>>>>> parent of 923f4ed (finished creating the robot brains, side error, the game doesn't run)
            column c = new column();
            robot.columnList.Add(c);
            //neurons
            for (int neurons = 0; neurons < neuronsPerColumn[columns]; neurons++)
            {
<<<<<<< HEAD
                Debug.Log("neuron");
                //for the neurons in the current column specified in the column list add a neuron
                neuron n = new neuron();
                //connections (but none for last row) 
                robot.columnList[columns].neuronList.Add(n);
                
                if (columns != 0) {
                    columnsMinusOne = columns -= 1;
                    //for the neurons in the previous row, add a connection to the current neuron, except for the first row
                    for (int connections = 0; connections < neuronsPerColumn[columnsMinusOne]; connections++)
                    {
                        Debug.Log("connection");
                        break;
                        /*
                        robot.columnList[columns].neuronList[neurons].connectionWeights.Add(0f);
                        */
                    }
                }
=======
                neuron n = new neuron();
                //connections (but none for last row)
                if (neuronsPerColumn.Length != columns) {
                for (int connections = 0; connections < neuronsPerColumn[columns++]; connections++)
                    {
                        n.connectionWeights.Add(0f);
                    } 
                }
                
                robot.columnList[columns].neuronList.Add(n);
>>>>>>> parent of 923f4ed (finished creating the robot brains, side error, the game doesn't run)
            }
        }
        return robot;
    }
    




/*

public List<robotBrain> fillList(int amount, int[] neuronsPerRow) {
    List<robotBrain> listOfRobotBrains = new List<robotBrain>();
            for (int i = 0; i < amount; i++)
            {
                //masterlist
                listOfRobotBrains.Add(new robotBrain(neuronsPerRow));
                
                for (int column = 0; column < neuronsPerRow.Length; column++)
                {
                    //column list
                    listOfRobotBrains[i].neuronList = neuronsPerRow;
                    //amount of neurons list has the amount of neurons per row
                    for (int neuron = 0; neuron < amountOfNeurons[column]; neuron++)
                    {
                        //adds all neurons into the rows
                        listOfRobotBrains[i][column].Add(new List<float>());

                        //loops for every neuron in the next column
                        for (int weight = 0; weight < amountOfNeurons[column + 1 ] +1; weight++)
                        {
                            //adds a weight to the current neuron
                            listOfRobotBrains[i][column][neuron].Add(0f);
                        }
                    }
                }
            }
        }
*/

/*
//duplicating more robots
private void createBridd() {
        GameObject newBridd = Instantiate(bridd);
        newbridd.position = spawn; 
        //Destroy(newpipe, screenTime);
    }
*/
    void Start()
    {
        Time.timeScale = 1;
        robotBrain robot = fillBrain(neuronsPerColumn);
        Debug.Log(robot);
        
    }

    // Update is called once per frame
    void Update()
    {




    }
}
