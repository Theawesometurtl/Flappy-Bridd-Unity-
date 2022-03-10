using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class buttonHandler : MonoBehaviour
{
    public void playGame() {  
        SceneManager.LoadScene("MainPlayableLevel");  
    }  

    public void titleScreen() {  
        SceneManager.LoadScene("TitleScreen");  
    }  

    public void quitGame() {  
        Debug.Log("quitgame");  
        Application.Quit();  
    }
}
