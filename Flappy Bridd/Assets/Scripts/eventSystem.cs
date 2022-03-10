using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;

public class eventSystem : MonoBehaviour
{
    public int fitnessScore = 0;
    [SerializeField] Text fitnessText;
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] GameObject gameOverCanvas;

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

    private void gameOver() {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }

    public void scorePlus1() {
        fitnessScore++;
    }

    void Start() {
        gameOverCanvas.SetActive(false);
    }

    void Update() {
        fitnessText.text = "Fitness Score: " + fitnessScore.toString();
        
        if (playerRb.position.x < -10.5) {
            gameOver();
        }

    }
}
