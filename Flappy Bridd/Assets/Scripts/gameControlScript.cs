using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameControlScript : MonoBehaviour
{
    public int fitnessScore = 0;
    [SerializeField] GameObject pipe;
    private float timer = 0;
    [SerializeField] float maxTime;
    [SerializeField] float screenTime;
    [SerializeField] TextMeshProUGUI fitnessText;


    private void createPipe() {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-4, 4) + 1, 0);
        Destroy(newpipe, screenTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime) {
            fitnessScore += 1;
            createPipe();
            timer = 0;
            fitnessText.text = string.Format("Fitness Score: " + fitnessScore);
        }
    }
}
