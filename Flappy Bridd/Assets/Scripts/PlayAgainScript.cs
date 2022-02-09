using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{
    public void playAgain() {
        SceneManager.LoadScene(0);
    }
}
