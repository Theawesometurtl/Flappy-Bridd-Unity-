using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotCreator : MonoBehaviour
{

    [SerializeField] GameObject bridd;
    [SerializeField] Vector2 spawn;
    public int maxSpeed = 5;
    public float jumpForce;

    // has an extra row zero just to end the list
    private List<int> amountOfNeurons = new List<int>(4, 5, 1, 0);

    //creates a list of all the robot Brains which are made up of lists of columns of neurons made up of lists of all the neuron weights
    public List<List<List<List<float>>>> listOfRobotBrains = new List<List<List<List<float>>>>();

    private void fillList(List<int> amountOfNeurons, int robotNum, int amountOfColumns) {
        for (int i = 0; i < robotNum; i++)
        {
            //masterlist
            listOfRobotBrains.Add(new List<List<List<float>>>());
            //current list of neurons has 3 rows (excluding the 0)
            for (int column = 0; column < 3; column++)
            {
                //column list
                listOfRobotBrains[i].Add(new List<List<float>>());
                //amount of neurons list has the amount of neurons per row
                for (int neuron = 0; neuron < amountOfNeurons[column]; neuron++)
                {
                    //adds all neurons into the rows
                    listOfRobotBrains[i][column].Add(new List<float>());

                    //loops for every neuron in the next column
                    for (int weight = 0; weight < amountOfNeurons[column + 1 ] +1/*extra one for neuron weight, rest for connection weight*/; weight++)
                    {
                        //adds a weight to the current neuron
                        listOfRobotBrains[i][column][neuron].Add(0f);
                    }
                }
            }
        }
    }


    private void mutateList(List<List<List<List<float>>>> listOfRobotBrains) {
        for (int i = 0; i < robotNum; i++)
        {
            //masterlist

            //current list of neurons has 3 rows (excluding the 0)
            for (int column = 0; column < 3; column++)
            {
                //column list

                //amount of neurons list has the amount of neurons per row
                for (int neuron = 0; neuron < amountOfNeurons[column]; neuron++)
                {
                    //neuron list


                    //loops for every neuron in the next column
                    for (int weight = 0; weight < amountOfNeurons[column + 1] + 1 /*extra one for neuron weight, rest for connection weight*/; weight++)
                    {
                        //mutates weight in current neuron
                        listOfRobotBrains[i][column][neuron].Add(0f); //DO SOMETHING TO IT HERE!!!
                    }
                }
            }
        }
    }


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
