using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;

public class eventSystem : MonoBehaviour
{


    public void playGame() {  
        Time.timeScale = 1;
        SceneManager.LoadScene("MainPlayableLevel");  
    }  

    public void titleScreen() { 
        Time.timeScale = 1; 
        SceneManager.LoadScene("TitleScreen");  
    }  

    public void quitGame() {  
        Debug.Log("quitgame");  
        Application.Quit();  
    }
}
