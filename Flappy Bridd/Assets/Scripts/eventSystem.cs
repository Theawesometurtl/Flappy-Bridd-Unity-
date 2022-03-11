using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;

public class eventSystem : MonoBehaviour
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
