using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotBrain
{
    public List<column> columnList = new List<column>();

    public class column 
    {
        public List<neuron> neuronList = new List<neuron>();
    }
    
    public class neuron 
    {
        public float neuronWeight = 0f;
        public List<float> connectionWeights = new List<float>();
    }
}
