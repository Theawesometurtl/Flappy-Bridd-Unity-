using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawningScript : MonoBehaviour
{
    public PlayerScript playerScript;
    [SerializeField] GameObject pipe;
    private float timer = 0;
    [SerializeField] float maxTime;
    [SerializeField] float screenTime;

    private void createPipe() {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-4, 4) + 1, 0);
        Destroy(newpipe, screenTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime) {
            createPipe();
            timer = 0;
            playerScript.scorePlus1();
        }
    }
}
